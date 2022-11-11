using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BatchServerScheduleEntityVocabulary : SimpleVocabulary
    {
        public BatchServerScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model BatchServerScheduleEntity";
            KeyPrefix = "commonDataModel.batchserverscheduleentity";
            KeySeparator = ".";
            Grouping = "/BatchServerScheduleEntity";

            AddGroup("Common Data Model BatchServerScheduleEntity Details", group =>
            {
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumBatchThreads = group.Add(new VocabularyKey(nameof(MaximumBatchThreads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AOSInstanceName = group.Add(new VocabularyKey(nameof(AOSInstanceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey MaximumBatchThreads { get; private set; }
        public VocabularyKey AOSInstanceName { get; private set; }
        public VocabularyKey StartTime { get; private set; }


    }
}