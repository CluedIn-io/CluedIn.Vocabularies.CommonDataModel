using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupMemberVocabulary : SimpleVocabulary
    {
        public GroupMemberVocabulary()
        {
            VocabularyName = "GroupMember";
            KeyPrefix = "commonDataModel.groupmember";
            KeySeparator = ".";
            Grouping = "/GroupMember";

            AddGroup("GroupMember Details", group =>
            {
                groupMemberId = group.Add(new VocabularyKey(nameof(groupMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey groupMemberId { get; private set; }


    }
}