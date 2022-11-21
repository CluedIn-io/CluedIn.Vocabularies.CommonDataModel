using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemUserGroupEntityVocabulary : SimpleVocabulary
    {
        public SystemUserGroupEntityVocabulary()
        {
            VocabularyName = "System User Group Entity";
            KeyPrefix = "commonDataModel.systemusergroupentity";
            KeySeparator = ".";
            Grouping = "/SystemUserGroupEntity";

            AddGroup("SystemUserGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}