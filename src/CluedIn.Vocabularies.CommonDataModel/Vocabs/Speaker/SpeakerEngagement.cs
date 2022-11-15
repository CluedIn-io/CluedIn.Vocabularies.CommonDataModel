using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SpeakerEngagementVocabulary : SimpleVocabulary
    {
        public SpeakerEngagementVocabulary()
        {
            VocabularyName = "Speaker Engagement";
            KeyPrefix = "commonDataModel.speakerengagement";
            KeySeparator = ".";
            Grouping = "/SpeakerEngagement";

            AddGroup("SpeakerEngagement Details", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerCost = group.Add(new VocabularyKey(nameof(SpeakerCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerCostBase = group.Add(new VocabularyKey(nameof(SpeakerCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerEngagementId = group.Add(new VocabularyKey(nameof(SpeakerEngagementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SpeakerCost { get; private set; }
        public VocabularyKey SpeakerCostBase { get; private set; }
        public VocabularyKey SpeakerEngagementId { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}