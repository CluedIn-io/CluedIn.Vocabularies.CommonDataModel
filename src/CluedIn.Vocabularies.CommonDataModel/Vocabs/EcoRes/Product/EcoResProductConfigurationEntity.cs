using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductConfigurationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductConfigurationEntityVocabulary()
        {
            VocabularyName = "EcoResProductConfigurationEntity";
            KeyPrefix = "commonDataModel.ecoresproductconfigurationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductConfigurationEntity";

            AddGroup("EcoResProductConfigurationEntity Details", group =>
            {
                ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConfigurationId { get; private set; }


    }
}