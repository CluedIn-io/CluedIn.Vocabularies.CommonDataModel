using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class SpeakerEngagementVocabulary : SimpleVocabulary
    {
        public SpeakerEngagementVocabulary()
        {
            VocabularyName = "Speaker Engagement";
            KeyPrefix = "commonDataModel.speakerengagement.eventmanagement";
            KeySeparator = ".";
            Grouping = "/SpeakerEngagement";

            AddGroup("SpeakerEngagement Details for EventManagement", group =>
            {
			    SpeakerEngagementId = group.Add(new VocabularyKey(nameof(SpeakerEngagementId), "Speaker Engagement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Speakercost = group.Add(new VocabularyKey(nameof(Speakercost), "Speaker cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SpeakercostBase = group.Add(new VocabularyKey(nameof(SpeakercostBase), "Speaker cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SpeakerEngagementId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey Speakercost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SpeakercostBase { get; private set; }
    }
}