using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocumentRoutingJobEntityVocabulary : SimpleVocabulary
    {
        public DocumentRoutingJobEntityVocabulary()
        {
            VocabularyName = "Common Data Model DocumentRoutingJobEntity";
            KeyPrefix = "commonDataModel.documentroutingjobentity";
            KeySeparator = ".";
            Grouping = "/DocumentRoutingJobEntity";

            AddGroup("Common Data Model DocumentRoutingJobEntity Details", group =>
            {
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterName = group.Add(new VocabularyKey(nameof(PrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterPath = group.Add(new VocabularyKey(nameof(PrinterPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportName = group.Add(new VocabularyKey(nameof(ReportName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobStatus = group.Add(new VocabularyKey(nameof(JobStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Message = group.Add(new VocabularyKey(nameof(Message), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNumberOfPages = group.Add(new VocabularyKey(nameof(TotalNumberOfPages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartProcessTime = group.Add(new VocabularyKey(nameof(StartProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndProcessTime = group.Add(new VocabularyKey(nameof(EndProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterId = group.Add(new VocabularyKey(nameof(PrinterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JobId { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey PrinterName { get; private set; }
        public VocabularyKey PrinterPath { get; private set; }
        public VocabularyKey ReportName { get; private set; }
        public VocabularyKey JobStatus { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey TotalNumberOfPages { get; private set; }
        public VocabularyKey StartProcessTime { get; private set; }
        public VocabularyKey EndProcessTime { get; private set; }
        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey PrinterId { get; private set; }


    }
}