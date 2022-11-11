using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobTaskAssignmentEntityVocabulary : SimpleVocabulary
    {
        public HcmJobTaskAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobTaskAssignmentEntity";
            KeyPrefix = "commonDataModel.hcmjobtaskassignmententity";
            KeySeparator = ".";
            Grouping = "/HcmJobTaskAssignmentEntity";

            AddGroup("Common Data Model HcmJobTaskAssignmentEntity Details", group =>
            {
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTask = group.Add(new VocabularyKey(nameof(JobTask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTaskId = group.Add(new VocabularyKey(nameof(JobTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Job { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey JobTask { get; private set; }
        public VocabularyKey JobTaskId { get; private set; }
        public VocabularyKey Note { get; private set; }


    }
}