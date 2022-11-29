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
    }

    public class ReadManifest : ManifestBase
    {
        private static List<string> CdmDataTypes { get; set; }
        private static ReadManifestOption opts { get; set; }
        private static string pathFromExeToVocabForlder;
        private static int VocabGeneratedCount = 0;

        public static async Task<int> Run(ReadManifestOption _opts)
        {
            opts = _opts;
            pathFromExeToVocabForlder = "../../../../" + "CluedIn.Vocabularies.CommonDataModel/Vocabs" + 
                opts.FullPath[(opts.FullPath.IndexOf("schemaDocuments") + "schemaDocuments".Length)..].Replace(Path.GetFileName(_opts.FullPath), "");

            Console.WriteLine($"\nReading manifest files from directory {_opts.FullPath} ...");

            CdmCorpus.Storage.Mount("local", new LocalAdapter(Path.GetDirectoryName(_opts.FullPath)));
            
            VocabGeneratedCount = 0;
            await ExploreManifest(Path.GetFileName(_opts.FullPath));

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
                ExportToCluedInVocab(entitySelected);
            }

            //loop through manifest.SubManifest
            foreach (var subManifest in manifest.SubManifests)
            {
                await ExploreManifest(CdmCorpus.Storage.CreateAbsoluteCorpusPath(subManifest.Definition, manifest));
            }
        }

        private static void ExportToCluedInVocab(CdmEntityDefinition entity)
        {

            try
            {
                if (entity == null) return;

                Console.Write($"Generating Vocab for : {entity.EntityName}");

                var properties = new StringBuilder();
                var keys = new StringBuilder();
                var propList = new List<string>();

                if (entity.EntityName == "Contact")
                {
                }

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
                                foreach (var trait in member.AppliedTraits)
                                {
                                    if (trait.NamedReference == "is.linkedEntity.identifier")
                                    {

                                    }
                                    //if (trait is CdmTraitReference)
                                    //{
                                    //    foreach (var argDef in (trait as CdmTraitReference).Arguments)
                                    //    {
                                    //        if (argDef.Value is CdmEntityReference)
                                    //        {
                                    //            var contEntDef = argDef.Value.FetchObjectDefinition<CdmConstantEntityDefinition>();
                                    //            foreach (List<string> constantValueList in contEntDef.ConstantValues)
                                    //            {

                                    //            }
                                    //        }
                                    //        else if (argDef.Value is string)
                                    //        {

                                    //        }
                                    //        else
                                    //        {

                                    //        }
                                    //    }
                                    //}
                                    //else
                                    //{

                                    //}
                                }

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

                //var path = Path.Combine(pathFromExeToVocabForlder, entity.AtCorpusPath.Substring(0, entity.AtCorpusPath.IndexOf(entity.EntityName)).Replace("local:/", ""));
                //var @namespace = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));

                //if (@namespace == "schemaDocuments")
                //    @namespace = "";
                //else
                //    @namespace = "." + @namespace.CamelCase();

                //var template = File.ReadAllText("VocabularyTemplate.txt");
                //template = template.Replace("{{EntityType}}", entity.EntityName.CamelCase());
                //template = template.Replace("{{EntityTypeName}}", entity.EntityName.SplitCamelCase());
                //template = template.Replace("{{entitytype}}", entity.EntityName.ToLowerInvariant() + @namespace.ToLowerInvariant());
                //template = template.Replace("{{namespace}}", @namespace);
                //template = template.Replace("{{Properties}}", properties.ToString().Trim());
                //template = template.Replace("{{Keys}}", keys.ToString().Trim());
                //template = template.Replace("{{Details}}", @namespace.Replace(".", " for "));

                //if (!Directory.Exists(path))
                //    Directory.CreateDirectory(path);

                //var file = path + "\\" + entity.EntityName.CamelCase() + ".cs";
                //if (File.Exists(file))
                //    File.Delete(file);

                //File.WriteAllText(file, template.ToString());

                //path = path.Replace("Vocabs", "Sample Data");
                //if (!Directory.Exists(path))
                //    Directory.CreateDirectory(path);

                //file = path + "\\" + entity.EntityName.CamelCase() + ".csv";
                //if (File.Exists(file))
                //    File.Delete(file);

                //File.WriteAllText(file, string.Join(",", propList));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" => File has been generated - {entity.EntityName.CamelCase()}.cs");
                Console.ForegroundColor = ConsoleColor.White;

                VocabGeneratedCount++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        //public static async Task<int> Run(ReadManifestOption _opts)
        //{
        //    opts = _opts;

        //    Console.WriteLine($"\nReading manifest files from directory {_opts.FullPath} ...");

        //    CdmCorpus.Storage.Mount("local", new LocalAdapter(_opts.FullPath)); //this is the root path

        //    CdmDataTypes = new List<string>();
        //    var manifestFiles = await GetAppManifestFile(_opts.FullPath);

        //    int total = 0;
        //    foreach (var manifestFile in manifestFiles)
        //    {
        //        Console.WriteLine(manifestFile.Key);
        //        total += manifestFile.Value.Count;
        //    }

        //    Console.WriteLine($"Total Manifest Count: {manifestFiles.Count}");
        //    Console.WriteLine($"Total Entities Count: {total}");

        //    foreach (var dataType in CdmDataTypes.OrderBy(o => o))
        //        Console.WriteLine($"DataTypes: {dataType}");

        //    Console.WriteLine($"Total DataType: {CdmDataTypes.Count}");

        //    return 0;
        //}

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
    }
}
