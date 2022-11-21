using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPersonUserEntityVocabulary : SimpleVocabulary
    {
        public DirPersonUserEntityVocabulary()
        {
            VocabularyName = "Dir Person User Entity";
            KeyPrefix = "commonDataModel.dirpersonuserentity";
            KeySeparator = ".";
            Grouping = "/DirPersonUserEntity";

            AddGroup("DirPersonUserEntity Details", group =>
            {
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonName = group.Add(new VocabularyKey(nameof(PersonName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonNameAlias = group.Add(new VocabularyKey(nameof(PersonNameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserEmail = group.Add(new VocabularyKey(nameof(UserEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPrimaryEmail = group.Add(new VocabularyKey(nameof(PersonPrimaryEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonParty = group.Add(new VocabularyKey(nameof(PersonParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey PersonName { get; private set; }
        public VocabularyKey PersonNameAlias { get; private set; }
        public VocabularyKey UserEmail { get; private set; }
        public VocabularyKey PersonPrimaryEmail { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey User { get; private set; }
        public VocabularyKey PersonParty { get; private set; }
    }
}