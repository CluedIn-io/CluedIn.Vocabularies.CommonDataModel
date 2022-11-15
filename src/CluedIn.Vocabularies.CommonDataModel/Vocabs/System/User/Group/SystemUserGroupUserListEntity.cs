using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemUserGroupUserListEntityVocabulary : SimpleVocabulary
    {
        public SystemUserGroupUserListEntityVocabulary()
        {
            VocabularyName = "System User Group User List Entity";
            KeyPrefix = "commonDataModel.systemusergroupuserlistentity";
            KeySeparator = ".";
            Grouping = "/SystemUserGroupUserListEntity";

            AddGroup("SystemUserGroupUserListEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey UserId { get; private set; }
    }
}