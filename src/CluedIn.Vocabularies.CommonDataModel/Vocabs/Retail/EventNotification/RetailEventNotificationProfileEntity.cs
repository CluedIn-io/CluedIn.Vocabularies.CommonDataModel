using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEventNotificationProfileEntityVocabulary : SimpleVocabulary
    {
        public RetailEventNotificationProfileEntityVocabulary()
        {
            VocabularyName = "RetailEventNotificationProfileEntity";
            KeyPrefix = "commonDataModel.retaileventnotificationprofileentity";
            KeySeparator = ".";
            Grouping = "/RetailEventNotificationProfileEntity";

            AddGroup("RetailEventNotificationProfileEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ProfileId { get; private set; }


    }
}