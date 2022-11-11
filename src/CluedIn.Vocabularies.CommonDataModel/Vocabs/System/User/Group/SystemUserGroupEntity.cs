using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemUserGroupEntityVocabulary : SimpleVocabulary
    {
        public SystemUserGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemUserGroupEntity";
            KeyPrefix = "commonDataModel.systemusergroupentity";
            KeySeparator = ".";
            Grouping = "/SystemUserGroupEntity";

            AddGroup("Common Data Model SystemUserGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey name { get; private set; }


    }
}