using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupVocabulary : SimpleVocabulary
    {
        public GroupVocabulary()
        {
            VocabularyName = "Common Data Model Group";
            KeyPrefix = "commonDataModel.group";
            KeySeparator = ".";
            Grouping = "/Group";

            AddGroup("Common Data Model Group Details", group =>
            {
                groupId = group.Add(new VocabularyKey(nameof(groupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey groupId { get; private set; }


    }
}