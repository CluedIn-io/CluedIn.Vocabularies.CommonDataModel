using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxDocumentEntityVocabulary : SimpleVocabulary
    {
        public TaxDocumentEntityVocabulary()
        {
            VocabularyName = "Tax Document Entity";
            KeyPrefix = "commonDataModel.taxdocumententity";
            KeySeparator = ".";
            Grouping = "/TaxDocumentEntity";

            AddGroup("TaxDocumentEntity Details", group =>
            {
                TaxDocumentNumber = group.Add(new VocabularyKey(nameof(TaxDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentDate = group.Add(new VocabularyKey(nameof(TaxDocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountInCurrency = group.Add(new VocabularyKey(nameof(TaxAmountInCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionTypeOfTax = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionTypeOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionTaxValue = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionTaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionAmount = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionTaxAmount = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionAmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionAmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxDocumentTransactionTaxAmountInCurrency = group.Add(new VocabularyKey(nameof(TaxDocumentTransactionTaxAmountInCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoNumber = group.Add(new VocabularyKey(nameof(TaxCreditMemoNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoDate = group.Add(new VocabularyKey(nameof(TaxCreditMemoDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionTypeOfTax = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionTypeOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionTaxValue = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionTaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionAmount = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionTaxAmount = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionAmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionAmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditMemoTransactionTaxAmountInCurrency = group.Add(new VocabularyKey(nameof(TaxCreditMemoTransactionTaxAmountInCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendTransTableId = group.Add(new VocabularyKey(nameof(CustVendTransTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaxDocumentNumber { get; private set; }
        public VocabularyKey TaxDocumentDate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey TaxAmount { get; private set; }
        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey TaxAmountInCurrency { get; private set; }
        public VocabularyKey TaxDocumentTransactionTypeOfTax { get; private set; }
        public VocabularyKey TaxDocumentTransactionTaxValue { get; private set; }
        public VocabularyKey TaxDocumentTransactionAmount { get; private set; }
        public VocabularyKey TaxDocumentTransactionTaxAmount { get; private set; }
        public VocabularyKey TaxDocumentTransactionAmountInTransactionCurrency { get; private set; }
        public VocabularyKey TaxDocumentTransactionTaxAmountInCurrency { get; private set; }
        public VocabularyKey TaxCreditMemoNumber { get; private set; }
        public VocabularyKey TaxCreditMemoDate { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionTypeOfTax { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionTaxValue { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionAmount { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionTaxAmount { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionAmountInTransactionCurrency { get; private set; }
        public VocabularyKey TaxCreditMemoTransactionTaxAmountInCurrency { get; private set; }
        public VocabularyKey CustVendTransTableId { get; private set; }
    }
}