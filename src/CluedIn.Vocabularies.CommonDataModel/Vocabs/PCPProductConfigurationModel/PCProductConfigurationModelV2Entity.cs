using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PCProductConfigurationModelV2EntityVocabulary : SimpleVocabulary
    {
        public PCProductConfigurationModelV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PCProductConfigurationModelV2Entity";
            KeyPrefix = "commonDataModel.pcproductconfigurationmodelv2entity";
            KeySeparator = ".";
            Grouping = "/PCProductConfigurationModelV2Entity";

            AddGroup("Common Data Model PCProductConfigurationModelV2Entity Details", group =>
            {
                ModelName = group.Add(new VocabularyKey(nameof(ModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModelXml = group.Add(new VocabularyKey(nameof(ModelXml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ModelName { get; private set; }
public VocabularyKey ModelXml { get; private set; }


    }
}