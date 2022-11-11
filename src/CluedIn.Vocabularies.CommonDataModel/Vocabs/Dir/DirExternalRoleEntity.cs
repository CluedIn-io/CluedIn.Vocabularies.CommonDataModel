using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirExternalRoleEntityVocabulary : SimpleVocabulary
    {
        public DirExternalRoleEntityVocabulary()
        {
            VocabularyName = "Common Data Model DirExternalRoleEntity";
            KeyPrefix = "commonDataModel.direxternalroleentity";
            KeySeparator = ".";
            Grouping = "/DirExternalRoleEntity";

            AddGroup("Common Data Model DirExternalRoleEntity Details", group =>
            {
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Role { get; private set; }
        public VocabularyKey Type { get; private set; }


    }
}