using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BatchJobEntityVocabulary : SimpleVocabulary
    {
        public BatchJobEntityVocabulary()
        {
            VocabularyName = "BatchJobEntity";
            KeyPrefix = "commonDataModel.batchjobentity";
            KeySeparator = ".";
            Grouping = "/BatchJobEntity";

            AddGroup("BatchJobEntity Details", group =>
            {
                CanceledBy = group.Add(new VocabularyKey(nameof(CanceledBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDescription = group.Add(new VocabularyKey(nameof(JobDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyAccounts = group.Add(new VocabularyKey(nameof(CompanyAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartitionKey = group.Add(new VocabularyKey(nameof(PartitionKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Finishing = group.Add(new VocabularyKey(nameof(Finishing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaveJobToHistory = group.Add(new VocabularyKey(nameof(SaveJobToHistory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrigStartDateTime = group.Add(new VocabularyKey(nameof(OrigStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recurrence = group.Add(new VocabularyKey(nameof(Recurrence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuntimeJob = group.Add(new VocabularyKey(nameof(RuntimeJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchJobRecId = group.Add(new VocabularyKey(nameof(BatchJobRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutingBy = group.Add(new VocabularyKey(nameof(ExecutingBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CanceledBy { get; private set; }
        public VocabularyKey JobDescription { get; private set; }
        public VocabularyKey CompanyAccounts { get; private set; }
        public VocabularyKey PartitionKey { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey Finishing { get; private set; }
        public VocabularyKey SaveJobToHistory { get; private set; }
        public VocabularyKey OrigStartDateTime { get; private set; }
        public VocabularyKey Recurrence { get; private set; }
        public VocabularyKey RuntimeJob { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey BatchJobRecId { get; private set; }
        public VocabularyKey ExecutingBy { get; private set; }


    }
}