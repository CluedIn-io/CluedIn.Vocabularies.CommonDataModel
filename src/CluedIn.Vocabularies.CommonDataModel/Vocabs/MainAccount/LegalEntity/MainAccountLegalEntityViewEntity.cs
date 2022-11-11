using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountLegalEntityViewEntityVocabulary : SimpleVocabulary
    {
        public MainAccountLegalEntityViewEntityVocabulary()
        {
            VocabularyName = "MainAccountLegalEntityViewEntity";
            KeyPrefix = "commonDataModel.mainaccountlegalentityviewentity";
            KeySeparator = ".";
            Grouping = "/MainAccountLegalEntityViewEntity";

            AddGroup("MainAccountLegalEntityViewEntity Details", group =>
            {
                MainAccountCategory = group.Add(new VocabularyKey(nameof(MainAccountCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryReference = group.Add(new VocabularyKey(nameof(AccountCategoryReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountType = group.Add(new VocabularyKey(nameof(MainAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryDescription = group.Add(new VocabularyKey(nameof(AccountCategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryRef = group.Add(new VocabularyKey(nameof(AccountCategoryRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityRecId = group.Add(new VocabularyKey(nameof(LegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountLegalEntityId = group.Add(new VocabularyKey(nameof(MainAccountLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountCategory { get; private set; }
        public VocabularyKey AccountCategoryReference { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey MainAccountType { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey AccountCategoryDescription { get; private set; }
        public VocabularyKey AccountCategoryRef { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey LegalEntityRecId { get; private set; }
        public VocabularyKey MainAccountLegalEntityId { get; private set; }


    }
}