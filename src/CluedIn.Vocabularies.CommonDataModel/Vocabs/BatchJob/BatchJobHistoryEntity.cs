using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BatchJobHistoryEntityVocabulary : SimpleVocabulary
    {
        public BatchJobHistoryEntityVocabulary()
        {
            VocabularyName = "Batch Job History Entity";
            KeyPrefix = "commonDataModel.batchjobhistoryentity";
            KeySeparator = ".";
            Grouping = "/BatchJobHistoryEntity";

            AddGroup("BatchJobHistoryEntity Details", group =>
            {
                AlertsProcessed = group.Add(new VocabularyKey(nameof(AlertsProcessed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDescription = group.Add(new VocabularyKey(nameof(JobDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Finishing = group.Add(new VocabularyKey(nameof(Finishing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrigStartDateTime = group.Add(new VocabularyKey(nameof(OrigStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchJobID = group.Add(new VocabularyKey(nameof(BatchJobID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchCreatedBy = group.Add(new VocabularyKey(nameof(BatchCreatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanceledBy = group.Add(new VocabularyKey(nameof(CanceledBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataPartition = group.Add(new VocabularyKey(nameof(DataPartition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AlertsProcessed { get; private set; }
        public VocabularyKey JobDescription { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey Finishing { get; private set; }
        public VocabularyKey OrigStartDateTime { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey BatchJobID { get; private set; }
        public VocabularyKey BatchCreatedBy { get; private set; }
        public VocabularyKey CanceledBy { get; private set; }
        public VocabularyKey DataPartition { get; private set; }
    }
}