using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailXZReportEntityVocabulary : SimpleVocabulary
    {
        public RetailXZReportEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailXZReportEntity";
            KeyPrefix = "commonDataModel.retailxzreportentity";
            KeySeparator = ".";
            Grouping = "/RetailXZReportEntity";

            AddGroup("Common Data Model RetailXZReportEntity Details", group =>
            {
                StoreId = group.Add(new VocabularyKey(nameof(StoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminalId = group.Add(new VocabularyKey(nameof(TerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchId = group.Add(new VocabularyKey(nameof(BatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportId = group.Add(new VocabularyKey(nameof(ReportId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportDateTime = group.Add(new VocabularyKey(nameof(ReportDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportValue = group.Add(new VocabularyKey(nameof(ReportValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey StoreId { get; private set; }
        public VocabularyKey TerminalId { get; private set; }
        public VocabularyKey BatchId { get; private set; }
        public VocabularyKey ReportType { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey ReportId { get; private set; }
        public VocabularyKey ReportDateTime { get; private set; }
        public VocabularyKey ReportValue { get; private set; }


    }
}