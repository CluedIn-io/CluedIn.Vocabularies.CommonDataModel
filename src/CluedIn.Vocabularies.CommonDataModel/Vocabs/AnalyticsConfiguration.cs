using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AnalyticsConfigurationVocabulary : SimpleVocabulary
    {
        public AnalyticsConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model AnalyticsConfiguration";
            KeyPrefix = "commonDataModel.analyticsconfiguration";
            KeySeparator = ".";
            Grouping = "/AnalyticsConfiguration";

            AddGroup("Common Data Model AnalyticsConfiguration Details", group =>
            {
                cdsaconnectorconfigurationId = group.Add(new VocabularyKey(nameof(cdsaconnectorconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exporttoblobstoragesastoken = group.Add(new VocabularyKey(nameof(exporttoblobstoragesastoken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exporttoblobstorageurl = group.Add(new VocabularyKey(nameof(exporttoblobstorageurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exportFromDate = group.Add(new VocabularyKey(nameof(exportFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastExport = group.Add(new VocabularyKey(nameof(lastExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sastokenexpirationdatetime = group.Add(new VocabularyKey(nameof(sastokenexpirationdatetime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isDefault = group.Add(new VocabularyKey(nameof(isDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                serviceStatus = group.Add(new VocabularyKey(nameof(serviceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey cdsaconnectorconfigurationId { get; private set; }
        public VocabularyKey exporttoblobstoragesastoken { get; private set; }
        public VocabularyKey exporttoblobstorageurl { get; private set; }
        public VocabularyKey exportFromDate { get; private set; }
        public VocabularyKey lastExport { get; private set; }
        public VocabularyKey sastokenexpirationdatetime { get; private set; }
        public VocabularyKey isDefault { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey serviceStatus { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}