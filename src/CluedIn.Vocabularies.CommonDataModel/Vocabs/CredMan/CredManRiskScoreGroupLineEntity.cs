using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManRiskScoreGroupLineEntityVocabulary : SimpleVocabulary
    {
        public CredManRiskScoreGroupLineEntityVocabulary()
        {
            VocabularyName = "CredManRiskScoreGroupLineEntity";
            KeyPrefix = "commonDataModel.credmanriskscoregrouplineentity";
            KeySeparator = ".";
            Grouping = "/CredManRiskScoreGroupLineEntity";

            AddGroup("CredManRiskScoreGroupLineEntity Details", group =>
            {
                RangeFrom = group.Add(new VocabularyKey(nameof(RangeFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RangeTo = group.Add(new VocabularyKey(nameof(RangeTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Score = group.Add(new VocabularyKey(nameof(Score), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RangeFrom { get; private set; }
        public VocabularyKey RangeTo { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Score { get; private set; }
        public VocabularyKey Value { get; private set; }


    }
}