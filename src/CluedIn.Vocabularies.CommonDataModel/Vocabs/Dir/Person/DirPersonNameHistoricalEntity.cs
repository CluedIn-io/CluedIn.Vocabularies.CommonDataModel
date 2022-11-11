using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPersonNameHistoricalEntityVocabulary : SimpleVocabulary
    {
        public DirPersonNameHistoricalEntityVocabulary()
        {
            VocabularyName = "DirPersonNameHistoricalEntity";
            KeyPrefix = "commonDataModel.dirpersonnamehistoricalentity";
            KeySeparator = ".";
            Grouping = "/DirPersonNameHistoricalEntity";

            AddGroup("DirPersonNameHistoricalEntity Details", group =>
            {
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastNamePrefix = group.Add(new VocabularyKey(nameof(LastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Person = group.Add(new VocabularyKey(nameof(Person), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastNamePrefix { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Person { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}