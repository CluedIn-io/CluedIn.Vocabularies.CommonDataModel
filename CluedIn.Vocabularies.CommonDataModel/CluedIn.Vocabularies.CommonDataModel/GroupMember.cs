using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupMemberVocabulary : SimpleVocabulary
    {
        public GroupMemberVocabulary()
        {
            VocabularyName = "Common Data Model GroupMember";
            KeyPrefix = "commonDataModel.groupmember";
            KeySeparator = ".";
            Grouping = "/GroupMember";

            AddGroup("Common Data Model GroupMember Details", group =>
            {
                groupMemberId = group.Add(new VocabularyKey(nameof(groupMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey groupMemberId { get; private set; }


    }
}