using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventRegistrationVocabulary : SimpleVocabulary
    {
        public EventRegistrationVocabulary()
        {
            VocabularyName = "Event Registration";
            KeyPrefix = "commonDataModel.eventregistration";
            KeySeparator = ".";
            Grouping = "/EventRegistration";

            AddGroup("EventRegistration Details", group =>
            {
                Area = group.Add(new VocabularyKey(nameof(Area), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrelationID = group.Add(new VocabularyKey(nameof(CorrelationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedFromApi = group.Add(new VocabularyKey(nameof(CreatedFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventRegistrationId = group.Add(new VocabularyKey(nameof(EventRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Industry = group.Add(new VocabularyKey(nameof(Industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalRegistrationStatus = group.Add(new VocabularyKey(nameof(InternalRegistrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Memo = group.Add(new VocabularyKey(nameof(Memo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryRole = group.Add(new VocabularyKey(nameof(PrimaryRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCode = group.Add(new VocabularyKey(nameof(QRCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationOperation = group.Add(new VocabularyKey(nameof(RegistrationOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsInIndustry = group.Add(new VocabularyKey(nameof(YearsInIndustry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Area { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey CorrelationID { get; private set; }
        public VocabularyKey CreatedFromApi { get; private set; }
        public VocabularyKey EventRegistrationId { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey InternalRegistrationStatus { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey Memo { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrimaryRole { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey QRCode { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationOperation { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
        public VocabularyKey YearsInIndustry { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}