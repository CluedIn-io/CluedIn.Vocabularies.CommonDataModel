using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class EventRegistrationVocabulary : SimpleVocabulary
    {
        public EventRegistrationVocabulary()
        {
            VocabularyName = "Event Registration";
            KeyPrefix = "commonDataModel.eventregistration.eventmanagement";
            KeySeparator = ".";
            Grouping = "/EventRegistration";

            AddGroup("EventRegistration Details for EventManagement", group =>
            {
			    EventRegistrationId = group.Add(new VocabularyKey(nameof(EventRegistrationId), "Event Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Area = group.Add(new VocabularyKey(nameof(Area), "Area", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), "Company Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), "Is Canceled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Memo = group.Add(new VocabularyKey(nameof(Memo), "Memo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryRole = group.Add(new VocabularyKey(nameof(PrimaryRole), "Primary Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegisteredBy = group.Add(new VocabularyKey(nameof(RegisteredBy), "Registered By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), "Registration Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), "Registration Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), "Synced with Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), "Times Checked-in", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), "Webinar Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YearsInIndustry = group.Add(new VocabularyKey(nameof(YearsInIndustry), "Years in Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EventRegistrationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Area { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey Memo { get; private set; }
        public VocabularyKey PrimaryRole { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey RegisteredBy { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
        public VocabularyKey YearsInIndustry { get; private set; }
    }
}