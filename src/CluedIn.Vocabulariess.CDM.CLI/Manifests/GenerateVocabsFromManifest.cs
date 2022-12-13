using CluedIn.Vocabulariess.CDM.CLI.Model;
using CommandLine;
using Microsoft.CommonDataModel.ObjectModel.Cdm;
using Microsoft.CommonDataModel.ObjectModel.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CluedIn.Vocabulariess.CDM.CLI
{
    [Verb("read-manifest", HelpText = "Read Manifest file from MS CDM")]
    public class ReadManifestOption
    {
        [Option("path", Default = @"C:\CluedIn\Repository\Microsoft\CDM\schemaDocuments\core\applicationCommon\applicationCommon.manifest.cdm.json", HelpText = "Full Path of manifest file")]
        public string FullPath { get; set; }

        [Option("CICdmProjPath", Default = @"C:\CluedIn\Repository\cluedin-io\CluedIn.Vocabularies.CommonDataModel\src\CluedIn.Vocabularies.CommonDataModel\", HelpText = "Full Path of CluedIn CDM Project")]
        public string CICdmProjPath { get; set; }
    }

    public class GenerateVocabsFromManifest : ManifestBase
    {
        private static List<string> CdmDataTypes { get; set; }
        private static ReadManifestOption opts { get; set; }
        private static List<VocabInfo> VocabInfos;


        public static async Task<int> Run(ReadManifestOption _opts)
        {
            opts = _opts;

            Console.WriteLine($"\nReading manifest files from directory {_opts.FullPath} ...");

            CdmCorpus.Storage.Mount("local", new LocalAdapter(Path.GetDirectoryName(_opts.FullPath)));

            VocabInfos = new List<VocabInfo>();

            await ExploreManifest(Path.GetFileName(_opts.FullPath));

            GenerateVocabFiles();
            GenerateEntityTypesFile();

            return 0;
        }

        public static async Task ExploreManifest(string manifestFile)
        {
            CdmManifestDefinition manifest = await CdmCorpus.FetchObjectAsync<CdmManifestDefinition>(manifestFile);

            if (manifest == null)
            {
                Console.WriteLine($"Unable to load manifest {manifestFile}. Please inspect error log for additional details.");
                return;
            }

            if (manifest.Entities.Count == 0 && manifest.SubManifests.Count == 0)
            {
                Console.Write("No Entities or Sub-manifest found. Press [enter] to exit.");
                Console.ReadLine();
                return;
            }

            //convert manifest.Entities into Vocab
            foreach (var entity in manifest.Entities)
            {
                var entitySelected = await CdmCorpus.FetchObjectAsync<CdmEntityDefinition>(entity.EntityPath, manifest);
                GenerateVocabInformation(manifest, entitySelected);
            }

            //loop through manifest.SubManifest
            foreach (var subManifest in manifest.SubManifests)
            {
                await ExploreManifest(CdmCorpus.Storage.CreateAbsoluteCorpusPath(subManifest.Definition, manifest));
            }
        }

        private static void GenerateVocabInformation(CdmManifestDefinition manifest, CdmEntityDefinition entity)
        {
            try
            {
                if (entity == null) return;

                var entityName = entity.EntityName.CamelCase();

                Console.Write($"Generating Vocab Info for : ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{entity.AtCorpusPath}");

                var properties = new List<string>();
                var keys = new List<string>();

                foreach (var attribute in entity.Attributes)
                {
                    string attribName = null;
                    string attribDesc = null;
                    string attribType = null;
                    if (attribute.GetType() == typeof(CdmAttributeGroupReference))
                    {
                        var attrb = attribute as CdmAttributeGroupReference;
                        if (attrb.ExplicitReference != null)
                        {
                            foreach (var member in (attrb.ExplicitReference as CdmAttributeGroupDefinition).Members)
                            {
                                if (member.GetType() == typeof(CdmTypeAttributeDefinition))
                                {
                                    var attrbDef = member as CdmTypeAttributeDefinition;
                                    attribName = attrbDef.Name;
                                    attribDesc = attrbDef.DisplayName ?? attrbDef.Description;
                                    if (attrbDef.DataFormat.ToString() != "Unknown")
                                    {
                                        attribType = attrbDef.DataFormat.ToString();
                                    }
                                    else
                                    {
                                        attribType = attrbDef.DataType.NamedReference;
                                    }

                                    attribName = attribName.Replace("@", "").CamelCase();
                                    attribDesc = string.IsNullOrEmpty(attribDesc) ? "" : $", \"{attribDesc}\"";
                                    keys.Add("        public VocabularyKey " + attribName + " { get; private set; }");
                                    properties.Add($"			    {attribName} = group.Add(new VocabularyKey(nameof({attribName}){attribDesc}, VocabularyKeyDataType.{MapCDMTypeToCluedInType(attribType)}, VocabularyKeyVisibility.Visible)); ");
                                }
                                else if (member.GetType() == typeof(CdmAttributeGroupReference))
                                {
                                    //TODO
                                    //var attrbDef = member as CdmAttributeGroupReference;
                                    //var attrbGroupDef = new CdmAttributeGroupDefinition(entity.Ctx, attrbDef.NamedReference);
                                }
                                else
                                {
                                    //TODO: Identify more types
                                }
                            }
                        }
                        else if (attribute.GetType() == typeof(CdmTypeAttributeDefinition))
                        {
                            foreach (var trait in attribute.AppliedTraits)
                            {
                                if (trait.NamedReference == "is.linkedEntity.identifier")
                                {

                                }
                            }

                            var attrbDef = attribute as CdmTypeAttributeDefinition;
                            attribName = attrbDef.Name;
                            attribDesc = attrbDef.DisplayName ?? attrbDef.Description;
                            if (attrbDef.DataFormat.ToString() != "Unknown")
                            {
                                attribType = attrbDef.DataFormat.ToString();
                            }
                            else
                            {
                                attribType = attrbDef.DataType.NamedReference;
                            }

                            attribName = attribName.Replace("@", "").CamelCase();
                            attribDesc = string.IsNullOrEmpty(attribDesc) ? "" : $", \"{attribDesc}\"";
                            keys.Add("        public VocabularyKey " + attribName + " { get; private set; }");
                            properties.Add($"			    {attribName} = group.Add(new VocabularyKey(nameof({attribName}){attribDesc}, VocabularyKeyDataType.{MapCDMTypeToCluedInType(attribType)}, VocabularyKeyVisibility.Visible)); ");
                        }
                        else if (attribute.GetType() == typeof(CdmEntityAttributeDefinition))
                        {

                        }
                        else
                        {

                        }
                    }
                    else if (attribute.GetType() == typeof(CdmTypeAttributeDefinition))
                    {

                    }
                    else
                    {

                    }
                }

                GetAllRelationships(manifest, entity, out List<CdmE2ERelationship> relationshipFromList, out List<CdmE2ERelationship> relationshipToList);

                VocabInfo vocabInfo = new VocabInfo();
                if (VocabInfos.Any(a => a.EntityType == entityName))
                    vocabInfo = VocabInfos.SingleOrDefault(s => s.EntityType == entityName);
                else
                {
                    vocabInfo.AtCorpusPath = entity.AtCorpusPath;
                    vocabInfo.EntityType = entityName;
                    vocabInfo.EntityTypeName = entity.EntityName.SplitCamelCase();

                    if (vocabInfo.IncomingRelationships == null)
                    {
                        var relStr = new StringBuilder();
                        relationshipFromList.ForEach(relationship => relStr.AppendLine($"            ///Property <see cref=\"{relationship.FromEntityAttribute.CamelCase()}\"/> to Vocab '{relationship.ToEntity}' with Property '{relationship.ToEntityAttribute.CamelCase()}'"));
                        vocabInfo.IncomingRelationships = relStr;
                    }
                    if (vocabInfo.OutgoingRelationships == null)
                    {
                        var relStr = new StringBuilder();
                        relationshipToList.ForEach(relationship => relStr.AppendLine($"            ///Property <see cref=\"{relationship.ToEntityAttribute.CamelCase()}\"/> from Vocab '{relationship.FromEntity}' with Property '{relationship.FromEntityAttribute.CamelCase()}'"));
                        vocabInfo.OutgoingRelationships = relStr;
                    }

                    VocabInfos.Add(vocabInfo);
                }

                var newProperties = properties
                    .Where(prop =>
                      !vocabInfo.GroupProperties.Any(a =>
                        a.Properties.Any(p => p == prop || p.StartsWith(prop[..prop.IndexOf("nameof")]))))
                    .ToList();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" - Generated ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{newProperties.Count()}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" new Vocab Property/ies");

                vocabInfo.GroupProperties.Add(new GroupProperties
                {
                    AtCorpusPath = entity.AtCorpusPath,
                    Properties = newProperties
                });

                vocabInfo.Keys.AddRange(keys);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private static void GenerateVocabFiles()
        {
            var cdmSubFolder = opts.FullPath[(opts.FullPath.IndexOf("schemaDocuments") + "schemaDocuments".Length)..].Replace(Path.GetFileName(opts.FullPath), "");
            var path = opts.CICdmProjPath.TrimTrailingPath() +
                    @"\Vocabs\" +
                    cdmSubFolder.TrimTrailingPath() + "\\";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Generating Vocabs to ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{path}");

            foreach (var vocabInfo in VocabInfos)
            {
                var vocabCorpusPath = vocabInfo.AtCorpusPath[..vocabInfo.AtCorpusPath.IndexOf(vocabInfo.EntityType)]
                    .Replace("local:/", "")
                    .TrimTrailingPath();
                var vocabPath = path + (string.IsNullOrEmpty(vocabCorpusPath.TrimTrailingPath()) ? "" : vocabCorpusPath.TrimTrailingPath() + "\\");
                var vocabKeyGroup = new StringBuilder();
                foreach (var groupProperty in vocabInfo.GroupProperties)
                {
                    var corpusPath = groupProperty.AtCorpusPath[..groupProperty.AtCorpusPath.IndexOf(vocabInfo.EntityType)]
                        .Replace("local:/", "")
                        .TrimTrailingPath();
                    var groupPath = opts.CICdmProjPath.TrimTrailingPath() +
                        @"\Vocabs\" +
                        cdmSubFolder.TrimTrailingPath() + "\\" +
                        (string.IsNullOrEmpty(corpusPath.TrimTrailingPath()) ? "" : corpusPath.TrimTrailingPath() + "\\");

                    var @namespace = Path.GetFileName(groupPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));

                    if (@namespace == "schemaDocuments")
                        @namespace = "";
                    else
                        @namespace = " for " + @namespace.CamelCase();

                    vocabKeyGroup.AppendLine($"            AddGroup(\"{vocabInfo.EntityType} Details{@namespace}\", group =>");
                    vocabKeyGroup.AppendLine("            {");
                    vocabKeyGroup.AppendLine(string.Join(Environment.NewLine, groupProperty.Properties));
                    vocabKeyGroup.AppendLine("            });");
                }

                string template = File.ReadAllText("Templates/VocabularyTemplate.txt");

                template = template.Replace("{{EntityType}}", vocabInfo.EntityType);
                template = template.Replace("{{EntityTypeName}}", vocabInfo.EntityTypeName);
                template = template.Replace("{{entitytype}}", vocabInfo.EntityType.ToLowerInvariant());
                template = template.Replace("{{VocabKeyGroup}}", vocabKeyGroup.ToString().Trim());
                template = template.Replace("{{Keys}}", string.Join(Environment.NewLine, vocabInfo.Keys.Distinct().OrderBy(s => s)).Trim());
                template = template.Replace("{{IncomingRelationships}}", vocabInfo.IncomingRelationships.ToString().Trim());
                template = template.Replace("{{OutgoingRelationships}}", vocabInfo.OutgoingRelationships.ToString().Trim());

                if (!Directory.Exists(vocabPath))
                    Directory.CreateDirectory(vocabPath);

                var file = vocabPath + "\\" + vocabInfo.EntityType + ".cs";

                if (File.Exists(file))
                    File.Delete(file);

                File.WriteAllText(file, template.ToString());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\tFile has been generated - ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{vocabInfo.EntityType}.cs");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total Vocabs generated: {VocabInfos.Count}");
        }

        private static async Task<Dictionary<string, List<string>>> GetAppManifestFile(string directory)
        {
            CdmCorpus.Storage.Mount("local", new LocalAdapter(directory));

            var manifestFiles = new Dictionary<string, List<string>>();

            var folderName = Path.GetFileName(directory.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Split('/').Last().Split('\\').Last());

            var manifestFile = folderName + ".manifest.cdm.json";
            if (File.Exists(Path.Combine(directory, manifestFile)))
            {
                CdmManifestDefinition manifest = await CdmCorpus.FetchObjectAsync<CdmManifestDefinition>(manifestFile);

                if (manifest != null)
                {
                    manifestFiles.Add(Path.Combine(directory, manifestFile), manifest.Entities.Select(s => s.EntityName).ToList());

                    foreach (var entity in manifest.Entities)
                    {
                        var entitySelected = await CdmCorpus.FetchObjectAsync<CdmEntityDefinition>(entity.EntityPath, manifest);
                        try
                        {
                            if (entitySelected == null) continue;

                            foreach (var attribute in entitySelected.Attributes)
                            {
                                if (attribute.GetType() == typeof(CdmAttributeGroupReference))
                                {
                                    var attrb = attribute as CdmAttributeGroupReference;

                                    if (attrb.ExplicitReference != null)
                                    {
                                        foreach (var member in (attrb.ExplicitReference as CdmAttributeGroupDefinition).Members)
                                        {
                                            if (member.GetType() == typeof(CdmTypeAttributeDefinition))
                                            {
                                                var attrbDef = member as CdmTypeAttributeDefinition;
                                                if (attrbDef.DataFormat.ToString() != "Unknown")
                                                {
                                                    //if (!CdmDataTypes.Contains(member.DataFormat.ToString()))
                                                    //    CdmDataTypes.Add(attribute.DataFormat.ToString());
                                                }
                                                else
                                                {
                                                    if (!CdmDataTypes.Contains(attrbDef.DataType.NamedReference))
                                                        CdmDataTypes.Add(attrbDef.DataType.NamedReference);
                                                }
                                            }
                                            else
                                            {

                                            }
                                        }
                                    }
                                }
                                else if (attribute.GetType() == typeof(CdmTypeAttributeDefinition))
                                {
                                    var attrbDef = attribute as CdmTypeAttributeDefinition;
                                    if (attrbDef.DataFormat.ToString() != "Unknown")
                                    {
                                        if (!CdmDataTypes.Contains(attrbDef.DataFormat.ToString()))
                                            CdmDataTypes.Add(attrbDef.DataFormat.ToString());
                                    }
                                    else
                                    {
                                        if (!CdmDataTypes.Contains(attrbDef.DataType.NamedReference))
                                            CdmDataTypes.Add(attrbDef.DataType.NamedReference);
                                    }
                                }
                                else if (attribute.GetType() == typeof(CdmEntityAttributeDefinition))
                                {

                                }
                                else
                                {

                                }
                            }

                            //foreach (CdmTypeAttributeDefinition attribute in entitySelected.Attributes.Where(w => w.GetType() == typeof(CdmTypeAttributeDefinition)))
                            //{
                            //    Console.WriteLine("{0} : {1}", attribute.Name, attribute.DataFormat.ToString());

                            //    if (!CdmDataTypes.Contains(attribute.DataFormat.ToString()))
                            //        CdmDataTypes.Add(attribute.DataFormat.ToString());
                            //}
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                }
            }

            foreach (var dir in Directory.GetDirectories(directory))
            {
                var manifests = await GetAppManifestFile(dir);

                if (manifests.Count > 0)
                {
                    foreach (var manifest in manifests)
                        manifestFiles.Add(manifest.Key, manifest.Value);
                }
            }

            return manifestFiles;
        }

        private static void GetAllRelationships(CdmManifestDefinition manifest, CdmEntityDefinition entity, out List<CdmE2ERelationship> relationshipFromList, out List<CdmE2ERelationship> relationshipToList)
        {
            relationshipFromList = new List<CdmE2ERelationship>();
            relationshipToList = new List<CdmE2ERelationship>();
            if (manifest.Relationships != null && manifest.Relationships.Count > 0)
            {
                foreach (CdmE2ERelationship relationship in manifest.Relationships)
                {
                    if (relationship.FromEntity.Contains(entity.EntityName))
                        relationshipFromList.Add(relationship);

                    if (relationship.ToEntity.Contains(entity.EntityName))
                        relationshipToList.Add(relationship);
                }
            }
            else
            {
                CdmCorpus.CalculateEntityGraphAsync(manifest).Wait();

                foreach (CdmE2ERelationship relationship in CdmCorpus.FetchIncomingRelationships(entity))
                    relationshipFromList.Add(relationship);

                foreach (CdmE2ERelationship relationship in CdmCorpus.FetchOutgoingRelationships(entity))
                    relationshipToList.Add(relationship);
            }
        }

        private static void GenerateEntityTypesFile()
        {
            try
            {
                var entityTypes = new StringBuilder();

                VocabInfos.OrderBy(s => s.EntityType).ToList().
                    ForEach(vocabInfo => entityTypes.AppendLine($"        public const string {vocabInfo.EntityType} = \"/{vocabInfo.EntityType}\";"));

                var template = File.ReadAllText("Templates/EntityTypesTemplate.txt");
                template = template.Replace("{{EntityTypes}}", entityTypes.ToString().Trim());

                if (!Directory.Exists(opts.CICdmProjPath))
                    Directory.CreateDirectory(opts.CICdmProjPath);

                var file = opts.CICdmProjPath + "\\CommonDataModelEntityTypes.cs";
                if (File.Exists(file))
                    File.Delete(file);

                File.WriteAllText(file, template.ToString());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}