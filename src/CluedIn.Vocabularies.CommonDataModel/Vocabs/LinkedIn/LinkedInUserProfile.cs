using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInUserProfileVocabulary : SimpleVocabulary
    {
        public LinkedInUserProfileVocabulary()
        {
            VocabularyName = "LinkedInUserProfile";
            KeyPrefix = "commonDataModel.linkedinuserprofile";
            KeySeparator = ".";
            Grouping = "/LinkedInUserProfile";

            AddGroup("LinkedInUserProfile Details", group =>
            {
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                authorized = group.Add(new VocabularyKey(nameof(authorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                expiresIn = group.Add(new VocabularyKey(nameof(expiresIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastSyncDate = group.Add(new VocabularyKey(nameof(lastSyncDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinauthorizedName = group.Add(new VocabularyKey(nameof(linkedinauthorizedName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInUserProfileId = group.Add(new VocabularyKey(nameof(linkedInUserProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusDetails = group.Add(new VocabularyKey(nameof(statusDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                syncStatus = group.Add(new VocabularyKey(nameof(syncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey entityImage { get; private set; }
        public VocabularyKey authorized { get; private set; }
        public VocabularyKey expiresIn { get; private set; }
        public VocabularyKey lastSyncDate { get; private set; }
        public VocabularyKey linkedinauthorizedName { get; private set; }
        public VocabularyKey linkedInUserProfileId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey statusDetails { get; private set; }
        public VocabularyKey syncStatus { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}