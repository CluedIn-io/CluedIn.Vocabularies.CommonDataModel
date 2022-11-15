using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupMemberVocabulary : SimpleVocabulary
    {
        public GroupMemberVocabulary()
        {
            VocabularyName = "Group Member";
            KeyPrefix = "commonDataModel.groupmember";
            KeySeparator = ".";
            Grouping = "/GroupMember";

            AddGroup("GroupMember Details", group =>
            {
                GroupMemberId = group.Add(new VocabularyKey(nameof(GroupMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupMemberId { get; private set; }
    }
}