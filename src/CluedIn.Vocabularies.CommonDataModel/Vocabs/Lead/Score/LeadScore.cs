using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreVocabulary : SimpleVocabulary
    {
        public LeadScoreVocabulary()
        {
            VocabularyName = "LeadScore";
            KeyPrefix = "commonDataModel.leadscore";
            KeySeparator = ".";
            Grouping = "/LeadScore";

            AddGroup("LeadScore Details", group =>
            {
                grade = group.Add(new VocabularyKey(nameof(grade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                leadscoreV2Id = group.Add(new VocabularyKey(nameof(leadscoreV2Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modelVersion = group.Add(new VocabularyKey(nameof(modelVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                score = group.Add(new VocabularyKey(nameof(score), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                scoreStatus = group.Add(new VocabularyKey(nameof(scoreStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastScoreTimestamp = group.Add(new VocabularyKey(nameof(lastScoreTimestamp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey grade { get; private set; }
        public VocabularyKey leadscoreV2Id { get; private set; }
        public VocabularyKey modelVersion { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey score { get; private set; }
        public VocabularyKey scoreStatus { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey lastScoreTimestamp { get; private set; }


    }
}