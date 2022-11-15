using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AnalyticsConfigurationVocabulary : SimpleVocabulary
    {
        public AnalyticsConfigurationVocabulary()
        {
            VocabularyName = "Analytics Configuration";
            KeyPrefix = "commonDataModel.analyticsconfiguration";
            KeySeparator = ".";
            Grouping = "/AnalyticsConfiguration";

            AddGroup("AnalyticsConfiguration Details", group =>
            {
                CdsaconnectorconfigurationId = group.Add(new VocabularyKey(nameof(CdsaconnectorconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Exporttoblobstoragesastoken = group.Add(new VocabularyKey(nameof(Exporttoblobstoragesastoken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Exporttoblobstorageurl = group.Add(new VocabularyKey(nameof(Exporttoblobstorageurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportFromDate = group.Add(new VocabularyKey(nameof(ExportFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastExport = group.Add(new VocabularyKey(nameof(LastExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sastokenexpirationdatetime = group.Add(new VocabularyKey(nameof(Sastokenexpirationdatetime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceStatus = group.Add(new VocabularyKey(nameof(ServiceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CdsaconnectorconfigurationId { get; private set; }
        public VocabularyKey Exporttoblobstoragesastoken { get; private set; }
        public VocabularyKey Exporttoblobstorageurl { get; private set; }
        public VocabularyKey ExportFromDate { get; private set; }
        public VocabularyKey LastExport { get; private set; }
        public VocabularyKey Sastokenexpirationdatetime { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ServiceStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}