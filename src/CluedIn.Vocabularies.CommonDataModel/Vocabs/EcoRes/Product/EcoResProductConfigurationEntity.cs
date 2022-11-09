using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductConfigurationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductConfigurationEntity";
            KeyPrefix = "commonDataModel.ecoresproductconfigurationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductConfigurationEntity";

            AddGroup("Common Data Model EcoResProductConfigurationEntity Details", group =>
            {
                ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ConfigurationId { get; private set; }


    }
}