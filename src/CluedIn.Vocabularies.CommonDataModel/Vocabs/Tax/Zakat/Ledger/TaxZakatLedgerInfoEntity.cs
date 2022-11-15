using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxZakatLedgerInfoEntityVocabulary : SimpleVocabulary
    {
        public TaxZakatLedgerInfoEntityVocabulary()
        {
            VocabularyName = "Tax Zakat Ledger Info Entity";
            KeyPrefix = "commonDataModel.taxzakatledgerinfoentity";
            KeySeparator = ".";
            Grouping = "/TaxZakatLedgerInfoEntity";

            AddGroup("TaxZakatLedgerInfoEntity Details", group =>
            {
                DimensionAttributeValue = group.Add(new VocabularyKey(nameof(DimensionAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitLossDebitItemCode = group.Add(new VocabularyKey(nameof(ProfitLossDebitItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProfitLossDebitRepair = group.Add(new VocabularyKey(nameof(IsProfitLossDebitRepair), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitLossCreditItemCode = group.Add(new VocabularyKey(nameof(ProfitLossCreditItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProfitLossCreditRepair = group.Add(new VocabularyKey(nameof(IsProfitLossCreditRepair), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpeningBalanceItemCode = group.Add(new VocabularyKey(nameof(OpeningBalanceItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosingBalanceItemCode = group.Add(new VocabularyKey(nameof(ClosingBalanceItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitItemCode = group.Add(new VocabularyKey(nameof(DebitItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditItemCode = group.Add(new VocabularyKey(nameof(CreditItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DimensionAttributeValue { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ProfitLossDebitItemCode { get; private set; }
        public VocabularyKey IsProfitLossDebitRepair { get; private set; }
        public VocabularyKey ProfitLossCreditItemCode { get; private set; }
        public VocabularyKey IsProfitLossCreditRepair { get; private set; }
        public VocabularyKey OpeningBalanceItemCode { get; private set; }
        public VocabularyKey ClosingBalanceItemCode { get; private set; }
        public VocabularyKey DebitItemCode { get; private set; }
        public VocabularyKey CreditItemCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}