using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLicensePlateLabelBuildConfigurationEntityVocabulary : SimpleVocabulary
    {
        public WHSLicensePlateLabelBuildConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLicensePlateLabelBuildConfigurationEntity";
            KeyPrefix = "commonDataModel.whslicenseplatelabelbuildconfigurationentity";
            KeySeparator = ".";
            Grouping = "/WHSLicensePlateLabelBuildConfigurationEntity";

            AddGroup("Common Data Model WHSLicensePlateLabelBuildConfigurationEntity Details", group =>
            {
                LicensePlateLabelBuildConfigurationId = group.Add(new VocabularyKey(nameof(LicensePlateLabelBuildConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfigurationDescription = group.Add(new VocabularyKey(nameof(ConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LicensePlateLabelBuildConfigurationId { get; private set; }
public VocabularyKey ConfigurationDescription { get; private set; }


    }
}