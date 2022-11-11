using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaParameterEntityVocabulary : SimpleVocabulary
    {
        public BankCodaParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCodaParameterEntity";
            KeyPrefix = "commonDataModel.bankcodaparameterentity";
            KeySeparator = ".";
            Grouping = "/BankCodaParameterEntity";

            AddGroup("Common Data Model BankCodaParameterEntity Details", group =>
            {
                PrefixNewBankAccounts = group.Add(new VocabularyKey(nameof(PrefixNewBankAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoCreateNewBankAccounts = group.Add(new VocabularyKey(nameof(IsAutoCreateNewBankAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccount = group.Add(new VocabularyKey(nameof(CostAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOverrideStatementInCaseOfNoMatching = group.Add(new VocabularyKey(nameof(IsOverrideStatementInCaseOfNoMatching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueAccount = group.Add(new VocabularyKey(nameof(RevenueAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumberDisplayValue = group.Add(new VocabularyKey(nameof(AccountNumberDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccountDisplayValue = group.Add(new VocabularyKey(nameof(CostAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueAccountDisplayValue = group.Add(new VocabularyKey(nameof(RevenueAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodaDeviation = group.Add(new VocabularyKey(nameof(CodaDeviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PrefixNewBankAccounts { get; private set; }
        public VocabularyKey IsAutoCreateNewBankAccounts { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey CostAccount { get; private set; }
        public VocabularyKey IsOverrideStatementInCaseOfNoMatching { get; private set; }
        public VocabularyKey RevenueAccount { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey AccountNumberDisplayValue { get; private set; }
        public VocabularyKey CostAccountDisplayValue { get; private set; }
        public VocabularyKey RevenueAccountDisplayValue { get; private set; }
        public VocabularyKey CodaDeviation { get; private set; }


    }
}