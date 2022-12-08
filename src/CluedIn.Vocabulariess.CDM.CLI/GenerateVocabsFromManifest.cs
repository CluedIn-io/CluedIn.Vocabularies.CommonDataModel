using CommandLine;
using Microsoft.CommonDataModel.ObjectModel.Cdm;
using Microsoft.CommonDataModel.ObjectModel.Storage;
using Microsoft.CommonDataModel.ObjectModel.Utilities;
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
        //private static string pathFromExeToVocabForlder;
        private static int VocabGeneratedCount;
        private static List<string> EntityCodes;

        public static async Task<int> Run(ReadManifestOption _opts)
        {
            opts = _opts;

            Console.WriteLine($"\nReading manifest files from directory {_opts.FullPath} ...");

            CdmCorpus.Storage.Mount("local", new LocalAdapter(Path.GetDirectoryName(_opts.FullPath)));

            VocabGeneratedCount = 0;
            EntityCodes = new List<string>();

            await ExploreManifest(Path.GetFileName(_opts.FullPath));

            GenerateEntityTypesFile();

            Console.WriteLine($"Total Vocabs generated: {VocabGeneratedCount}");

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
                ExportToCluedInVocab(manifest, entitySelected);
            }

            //loop through manifest.SubManifest
            foreach (var subManifest in manifest.SubManifests)
            {
                await ExploreManifest(CdmCorpus.Storage.CreateAbsoluteCorpusPath(subManifest.Definition, manifest));
            }
        }

        private static void ExportToCluedInVocab(CdmManifestDefinition manifest, CdmEntityDefinition entity)
        {
            try
            {
                if (entity == null) return;

                var entityName = entity.EntityName.CamelCase();

                if (entityName.Equals("Account"))
                {

                }

                Console.Write($"Generating Vocab for : {entity.EntityName}");

                var properties = new StringBuilder();
                var keys = new StringBuilder();
                var propList = new List<string>();

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
                                    keys.AppendLine("        public VocabularyKey " + attribName + " { get; private set; }");
                                    properties.AppendLine($"			    {attribName} = group.Add(new VocabularyKey(nameof({attribName}){attribDesc}, VocabularyKeyDataType.{MapCDMTypeToCluedInType(attribType)}, VocabularyKeyVisibility.Visible)); ");

                                    propList.Add(attribName);
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
                            keys.AppendLine("        public VocabularyKey " + attribName + " { get; private set; }");
                            properties.AppendLine($"			    {attribName} = group.Add(new VocabularyKey(nameof({attribName}){attribDesc}, VocabularyKeyDataType.{MapCDMTypeToCluedInType(attribType)}, VocabularyKeyVisibility.Visible)); ");

                            propList.Add(attribName);
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

                var corpusPath = entity.AtCorpusPath.Substring(0, entity.AtCorpusPath.IndexOf(entity.EntityName)).Replace("local:/", "").TrimTrailingPath();
                var cdmSubFolder = opts.FullPath[(opts.FullPath.IndexOf("schemaDocuments") + "schemaDocuments".Length)..].Replace(Path.GetFileName(opts.FullPath), "");
                var path = opts.CICdmProjPath.TrimTrailingPath() + 
                    @"\Vocabs\" +
                    cdmSubFolder.TrimTrailingPath() + "\\" +
                    (string.IsNullOrEmpty(corpusPath.TrimTrailingPath()) ? "": corpusPath.TrimTrailingPath() + "\\");

                var @namespace = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));

                if (@namespace == "schemaDocuments")
                    @namespace = "";
                else
                    @namespace = "." + @namespace.CamelCase();

                var template = File.ReadAllText("Templates/VocabularyTemplate.txt");
                template = template.Replace("{{EntityType}}", entityName);
                template = template.Replace("{{EntityTypeName}}", entity.EntityName.SplitCamelCase());
                template = template.Replace("{{entitytype}}", entity.EntityName.ToLowerInvariant() + @namespace.ToLowerInvariant());
                template = template.Replace("{{namespace}}", @namespace);
                template = template.Replace("{{Properties}}", properties.ToString().Trim());
                template = template.Replace("{{Keys}}", keys.ToString().Trim());
                template = template.Replace("{{Details}}", @namespace.Replace(".", " for "));

                var relStr = new StringBuilder();
                relationshipFromList.ForEach(relationship => relStr.AppendLine($"            ///Property <see cref=\"{relationship.FromEntityAttribute.CamelCase()}\"/> to Vocab '{relationship.ToEntity}' with Property '{relationship.ToEntityAttribute.CamelCase()}'"));
                template = template.Replace("{{IncomingRelationships}}", relStr.ToString().Trim());
                relStr = new StringBuilder();
                relationshipToList.ForEach(relationship => relStr.AppendLine($"            ///Property <see cref=\"{relationship.ToEntityAttribute.CamelCase()}\"/> from Vocab '{relationship.FromEntity}' with Property '{relationship.FromEntityAttribute.CamelCase()}'"));
                template = template.Replace("{{OutgoingRelationships}}", relStr.ToString().Trim());

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var file = path + "\\" + entityName + ".cs";
                if (File.Exists(file))
                    File.Delete(file);

                File.WriteAllText(file, template.ToString());

                //path = path.Replace("Vocabs", "Sample Data");
                //if (!Directory.Exists(path))
                //    Directory.CreateDirectory(path);

                //file = path + "\\" + entityName + ".csv";
                //if (File.Exists(file))
                //    File.Delete(file);

                //File.WriteAllText(file, string.Join(",", propList));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" => File has been generated - {entityName}.cs");
                Console.ForegroundColor = ConsoleColor.White;

                VocabGeneratedCount++;

                if (!EntityCodes.Contains(entityName))
                    EntityCodes.Add(entityName);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
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

                EntityCodes.OrderBy(s => s).ToList().
                    ForEach(entityCode => entityTypes.AppendLine($"        public const string {entityCode} = \"/{entityCode}\";"));

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