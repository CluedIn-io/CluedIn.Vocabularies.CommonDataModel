using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class AttendeePassVocabulary : SimpleVocabulary
    {
        public AttendeePassVocabulary()
        {
            VocabularyName = "Attendee Pass";
            KeyPrefix = "commonDataModel.attendeepass.eventmanagement";
            KeySeparator = ".";
            Grouping = "/AttendeePass";

            AddGroup("AttendeePass Details for EventManagement", group =>
            {
			    AttendeePassId = group.Add(new VocabularyKey(nameof(AttendeePassId), "Atendee Pass", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), "Pass Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), "Pass Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AttendeePassId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
    }
}