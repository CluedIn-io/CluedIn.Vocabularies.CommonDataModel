using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SessionRegistrationVocabulary : SimpleVocabulary
    {
        public SessionRegistrationVocabulary()
        {
            VocabularyName = "Session Registration";
            KeyPrefix = "commonDataModel.sessionregistration";
            KeySeparator = ".";
            Grouping = "/SessionRegistration";

            AddGroup("SessionRegistration Details", group =>
            {
                CreatedFromApi = group.Add(new VocabularyKey(nameof(CreatedFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationOperation = group.Add(new VocabularyKey(nameof(RegistrationOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionRegistrationId = group.Add(new VocabularyKey(nameof(SessionRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedFromApi { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationOperation { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SessionRegistrationId { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}