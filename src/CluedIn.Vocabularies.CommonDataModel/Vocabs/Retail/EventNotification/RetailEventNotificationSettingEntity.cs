using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEventNotificationSettingEntityVocabulary : SimpleVocabulary
    {
        public RetailEventNotificationSettingEntityVocabulary()
        {
            VocabularyName = "Retail Event Notification Setting Entity";
            KeyPrefix = "commonDataModel.retaileventnotificationsettingentity";
            KeySeparator = ".";
            Grouping = "/RetailEventNotificationSettingEntity";

            AddGroup("RetailEventNotificationSettingEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailId = group.Add(new VocabularyKey(nameof(EmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventNotificationProfile = group.Add(new VocabularyKey(nameof(EventNotificationProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventNotificationType = group.Add(new VocabularyKey(nameof(EventNotificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotificationType = group.Add(new VocabularyKey(nameof(NotificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Active { get; private set; }
        public VocabularyKey EmailId { get; private set; }
        public VocabularyKey EventNotificationProfile { get; private set; }
        public VocabularyKey EventNotificationType { get; private set; }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey NotificationType { get; private set; }
    }
}