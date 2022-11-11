using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemUserGroupUserListEntityVocabulary : SimpleVocabulary
    {
        public SystemUserGroupUserListEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemUserGroupUserListEntity";
            KeyPrefix = "commonDataModel.systemusergroupuserlistentity";
            KeySeparator = ".";
            Grouping = "/SystemUserGroupUserListEntity";

            AddGroup("Common Data Model SystemUserGroupUserListEntity Details", group =>
            {
                groupId = group.Add(new VocabularyKey(nameof(groupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                userId = group.Add(new VocabularyKey(nameof(userId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey groupId { get; private set; }
        public VocabularyKey userId { get; private set; }


    }
}