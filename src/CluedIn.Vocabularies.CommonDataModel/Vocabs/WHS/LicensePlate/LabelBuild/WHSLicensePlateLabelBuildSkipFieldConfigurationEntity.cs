using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLicensePlateLabelBuildSkipFieldConfigurationEntityVocabulary : SimpleVocabulary
    {
        public WHSLicensePlateLabelBuildSkipFieldConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLicensePlateLabelBuildSkipFieldConfigurationEntity";
            KeyPrefix = "commonDataModel.whslicenseplatelabelbuildskipfieldconfigurationentity";
            KeySeparator = ".";
            Grouping = "/WHSLicensePlateLabelBuildSkipFieldConfigurationEntity";

            AddGroup("Common Data Model WHSLicensePlateLabelBuildSkipFieldConfigurationEntity Details", group =>
            {
                LicensePlateLabelBuildConfigurationId = group.Add(new VocabularyKey(nameof(LicensePlateLabelBuildConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipFieldName = group.Add(new VocabularyKey(nameof(SkipFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateLabelBuildConfigurationRecId = group.Add(new VocabularyKey(nameof(LicensePlateLabelBuildConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LicensePlateLabelBuildConfigurationId { get; private set; }
        public VocabularyKey SkipFieldName { get; private set; }
        public VocabularyKey LicensePlateLabelBuildConfigurationRecId { get; private set; }


    }
}