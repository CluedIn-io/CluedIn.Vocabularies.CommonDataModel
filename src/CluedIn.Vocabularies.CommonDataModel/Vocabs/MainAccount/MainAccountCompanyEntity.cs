using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountCompanyEntityVocabulary : SimpleVocabulary
    {
        public MainAccountCompanyEntityVocabulary()
        {
            VocabularyName = "Common Data Model MainAccountCompanyEntity";
            KeyPrefix = "commonDataModel.mainaccountcompanyentity";
            KeySeparator = ".";
            Grouping = "/MainAccountCompanyEntity";

            AddGroup("Common Data Model MainAccountCompanyEntity Details", group =>
            {
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}