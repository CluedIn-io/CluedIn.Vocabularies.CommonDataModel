using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobTaskEntityVocabulary : SimpleVocabulary
    {
        public HcmJobTaskEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobTaskEntity";
            KeyPrefix = "commonDataModel.hcmjobtaskentity";
            KeySeparator = ".";
            Grouping = "/HcmJobTaskEntity";

            AddGroup("Common Data Model HcmJobTaskEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTaskId = group.Add(new VocabularyKey(nameof(JobTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey JobTaskId { get; private set; }
        public VocabularyKey Note { get; private set; }


    }
}