using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class CheckInVocabulary : SimpleVocabulary
    {
        public CheckInVocabulary()
        {
            VocabularyName = "Check In";
            KeyPrefix = "commonDataModel.checkin.eventmanagement";
            KeySeparator = ".";
            Grouping = "/CheckIn";

            AddGroup("CheckIn Details for EventManagement", group =>
            {
			    CheckInId = group.Add(new VocabularyKey(nameof(CheckInId), "Check-in", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), "Audience Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Checkintime = group.Add(new VocabularyKey(nameof(Checkintime), "Check-in time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckInType = group.Add(new VocabularyKey(nameof(CheckInType), "Check-in Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckOutTime = group.Add(new VocabularyKey(nameof(CheckOutTime), "Check-out time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(NumberOfQuestionsAsked), "Number of interactions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SessionCode = group.Add(new VocabularyKey(nameof(SessionCode), "Session Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionType = group.Add(new VocabularyKey(nameof(SessionType), "Session Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ViewingDurationInMins = group.Add(new VocabularyKey(nameof(ViewingDurationInMins), "Viewing Duration in mins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CheckInId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey Checkintime { get; private set; }
        public VocabularyKey CheckInType { get; private set; }
        public VocabularyKey CheckOutTime { get; private set; }
        public VocabularyKey NumberOfQuestionsAsked { get; private set; }
        public VocabularyKey SessionCode { get; private set; }
        public VocabularyKey SessionType { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ViewingDurationInMins { get; private set; }
    }
}