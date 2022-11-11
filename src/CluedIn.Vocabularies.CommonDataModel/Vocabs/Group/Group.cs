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
                groupId = group.Add(new VocabularyKey(nameof(groupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey groupId { get; private set; }


    }
}