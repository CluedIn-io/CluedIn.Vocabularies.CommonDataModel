using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalLineCDSEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerJournalLineCDSEntity";
            KeyPrefix = "commonDataModel.ledgerjournallinecdsentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalLineCDSEntity";

            AddGroup("Common Data Model LedgerJournalLineCDSEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetText = group.Add(new VocabularyKey(nameof(OffsetText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelayTaxCalculation = group.Add(new VocabularyKey(nameof(DelayTaxCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetCompany = group.Add(new VocabularyKey(nameof(OffsetCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseDate = group.Add(new VocabularyKey(nameof(ReverseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseEntry = group.Add(new VocabularyKey(nameof(ReverseEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRate = group.Add(new VocabularyKey(nameof(ExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateSecond = group.Add(new VocabularyKey(nameof(ExchRateSecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRateSecondary = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationComputedKey = group.Add(new VocabularyKey(nameof(IntegrationComputedKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey OffsetText { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey DelayTaxCalculation { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey OffsetCompany { get; private set; }
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
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey ReverseDate { get; private set; }
        public VocabularyKey ReverseEntry { get; private set; }
        public VocabularyKey ExchRate { get; private set; }
        public VocabularyKey ExchRateSecond { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey ReportingCurrencyExchRateSecondary { get; private set; }
        public VocabularyKey IntegrationComputedKey { get; private set; }


    }
}