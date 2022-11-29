using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class SessionRegistrationVocabulary : SimpleVocabulary
    {
        public SessionRegistrationVocabulary()
        {
            VocabularyName = "Session Registration";
            KeyPrefix = "commonDataModel.sessionregistration.eventmanagement";
            KeySeparator = ".";
            Grouping = "/SessionRegistration";

            AddGroup("SessionRegistration Details for EventManagement", group =>
            {
			    SessionRegistrationId = group.Add(new VocabularyKey(nameof(SessionRegistrationId), "Session Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), "Is Canceled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), "Registration Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), "Registration Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), "Synced with Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), "Times Checked-in", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), "Webinar Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SessionRegistrationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
    }
}