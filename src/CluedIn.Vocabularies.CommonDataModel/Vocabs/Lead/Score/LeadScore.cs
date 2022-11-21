using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreVocabulary : SimpleVocabulary
    {
        public LeadScoreVocabulary()
        {
            VocabularyName = "Lead Score";
            KeyPrefix = "commonDataModel.leadscore";
            KeySeparator = ".";
            Grouping = "/LeadScore";

            AddGroup("LeadScore Details", group =>
            {
                Grade = group.Add(new VocabularyKey(nameof(Grade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadscoreV2Id = group.Add(new VocabularyKey(nameof(LeadscoreV2Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelVersion = group.Add(new VocabularyKey(nameof(ModelVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Score = group.Add(new VocabularyKey(nameof(Score), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScoreStatus = group.Add(new VocabularyKey(nameof(ScoreStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastScoreTimestamp = group.Add(new VocabularyKey(nameof(LastScoreTimestamp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Grade { get; private set; }
        public VocabularyKey LeadscoreV2Id { get; private set; }
        public VocabularyKey ModelVersion { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Score { get; private set; }
        public VocabularyKey ScoreStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey LastScoreTimestamp { get; private set; }
    }
}