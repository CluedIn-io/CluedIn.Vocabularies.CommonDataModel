using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupVocabulary : SimpleVocabulary
    {
        public GroupVocabulary()
        {
            VocabularyName = "Group";
            KeyPrefix = "commonDataModel.group";
            KeySeparator = ".";
            Grouping = "/Group";

            AddGroup("Group Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
    }
}