using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInUserProfileVocabulary : SimpleVocabulary
    {
        public LinkedInUserProfileVocabulary()
        {
            VocabularyName = "Linked In User Profile";
            KeyPrefix = "commonDataModel.linkedinuserprofile";
            KeySeparator = ".";
            Grouping = "/LinkedInUserProfile";

            AddGroup("LinkedInUserProfile Details", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Authorized = group.Add(new VocabularyKey(nameof(Authorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiresIn = group.Add(new VocabularyKey(nameof(ExpiresIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSyncDate = group.Add(new VocabularyKey(nameof(LastSyncDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinauthorizedName = group.Add(new VocabularyKey(nameof(LinkedinauthorizedName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInUserProfileId = group.Add(new VocabularyKey(nameof(LinkedInUserProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusDetails = group.Add(new VocabularyKey(nameof(StatusDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SyncStatus = group.Add(new VocabularyKey(nameof(SyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Authorized { get; private set; }
        public VocabularyKey ExpiresIn { get; private set; }
        public VocabularyKey LastSyncDate { get; private set; }
        public VocabularyKey LinkedinauthorizedName { get; private set; }
        public VocabularyKey LinkedInUserProfileId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StatusDetails { get; private set; }
        public VocabularyKey SyncStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}