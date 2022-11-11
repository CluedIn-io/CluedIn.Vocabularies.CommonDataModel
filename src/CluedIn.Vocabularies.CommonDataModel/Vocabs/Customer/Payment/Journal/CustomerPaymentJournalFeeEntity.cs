using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPaymentJournalFeeEntityVocabulary : SimpleVocabulary
    {
        public CustomerPaymentJournalFeeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerPaymentJournalFeeEntity";
            KeyPrefix = "commonDataModel.customerpaymentjournalfeeentity";
            KeySeparator = ".";
            Grouping = "/CustomerPaymentJournalFeeEntity";

            AddGroup("Common Data Model CustomerPaymentJournalFeeEntity Details", group =>
            {
                SourceJournalLineRefRecId = group.Add(new VocabularyKey(nameof(SourceJournalLineRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFeeId = group.Add(new VocabularyKey(nameof(PaymentFeeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxDirection = group.Add(new VocabularyKey(nameof(SalesTaxDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceJournalLineNumber = group.Add(new VocabularyKey(nameof(SourceJournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceJournalBatchNumber = group.Add(new VocabularyKey(nameof(SourceJournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWithholdingCalculationEnabled = group.Add(new VocabularyKey(nameof(IsWithholdingCalculationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SourceJournalLineRefRecId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey PaymentFeeId { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey SalesTaxDirection { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey SourceJournalLineNumber { get; private set; }
        public VocabularyKey SourceJournalBatchNumber { get; private set; }
        public VocabularyKey IsWithholdingCalculationEnabled { get; private set; }
        public VocabularyKey ItemWithholdingTaxGroupCode { get; private set; }


    }
}