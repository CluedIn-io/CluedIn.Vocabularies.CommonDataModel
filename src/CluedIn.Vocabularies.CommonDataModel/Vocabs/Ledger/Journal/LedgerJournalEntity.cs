using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalEntityVocabulary()
        {
            VocabularyName = "Ledger Journal Entity";
            KeyPrefix = "commonDataModel.ledgerjournalentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalEntity";

            AddGroup("LedgerJournalEntity Details", group =>
            {
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelayTaxCalculation = group.Add(new VocabularyKey(nameof(DelayTaxCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetText = group.Add(new VocabularyKey(nameof(OffsetText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateSecondary = group.Add(new VocabularyKey(nameof(ExchangeRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWithholdingCalculationEnabled = group.Add(new VocabularyKey(nameof(IsWithholdingCalculationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountAmount = group.Add(new VocabularyKey(nameof(CashDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscount = group.Add(new VocabularyKey(nameof(CashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Document = group.Add(new VocabularyKey(nameof(Document), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentReference = group.Add(new VocabularyKey(nameof(PaymentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetDefaultDimension = group.Add(new VocabularyKey(nameof(OffsetDefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetDefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OffsetDefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseDate = group.Add(new VocabularyKey(nameof(ReverseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseEntry = group.Add(new VocabularyKey(nameof(ReverseEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceIdentification = group.Add(new VocabularyKey(nameof(InvoiceIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProvisionalAssessment = group.Add(new VocabularyKey(nameof(ProvisionalAssessment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessableValueTransactionCurrency = group.Add(new VocabularyKey(nameof(AssessableValueTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumRetailPrice = group.Add(new VocabularyKey(nameof(MaximumRetailPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdCode = group.Add(new VocabularyKey(nameof(TaxWithholdCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSGroup = group.Add(new VocabularyKey(nameof(TCSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSGroup = group.Add(new VocabularyKey(nameof(TDSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRateSecondary = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceReceiptDate = group.Add(new VocabularyKey(nameof(InvoiceReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxInvoiceReceiptDate = group.Add(new VocabularyKey(nameof(TaxInvoiceReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey DelayTaxCalculation { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OffsetText { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExchangeRateSecondary { get; private set; }
        public VocabularyKey IsWithholdingCalculationEnabled { get; private set; }
        public VocabularyKey ItemWithholdingTaxGroupCode { get; private set; }
        public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
        public VocabularyKey ChineseVoucherType { get; private set; }
        public VocabularyKey ChineseVoucher { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey CashDiscountAmount { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey PaymentId { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey CashDiscount { get; private set; }
        public VocabularyKey CashDiscountDate { get; private set; }
        public VocabularyKey Document { get; private set; }
        public VocabularyKey PaymentMethod { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey PaymentReference { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey OffsetDefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey OffsetDefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ReverseDate { get; private set; }
        public VocabularyKey ReverseEntry { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey InvoiceIdentification { get; private set; }
        public VocabularyKey ProvisionalAssessment { get; private set; }
        public VocabularyKey AssessableValueTransactionCurrency { get; private set; }
        public VocabularyKey MaximumRetailPrice { get; private set; }
        public VocabularyKey TaxWithholdCode { get; private set; }
        public VocabularyKey TCSGroup { get; private set; }
        public VocabularyKey TDSGroup { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey ReportingCurrencyExchRateSecondary { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey InvoiceReceiptDate { get; private set; }
        public VocabularyKey TaxInvoiceReceiptDate { get; private set; }
    }
}