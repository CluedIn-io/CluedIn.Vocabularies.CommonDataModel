using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManReasonTableEntityVocabulary : SimpleVocabulary
    {
        public CredManReasonTableEntityVocabulary()
        {
            VocabularyName = "CredManReasonTableEntity";
            KeyPrefix = "commonDataModel.credmanreasontableentity";
            KeySeparator = ".";
            Grouping = "/CredManReasonTableEntity";

            AddGroup("CredManReasonTableEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonId = group.Add(new VocabularyKey(nameof(ReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Type { get; private set; }
        public VocabularyKey ReasonId { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}