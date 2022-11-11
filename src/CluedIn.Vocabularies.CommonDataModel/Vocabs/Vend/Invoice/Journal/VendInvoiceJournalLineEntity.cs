using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendInvoiceJournalLineEntityVocabulary : SimpleVocabulary
    {
        public VendInvoiceJournalLineEntityVocabulary()
        {
            VocabularyName = "VendInvoiceJournalLineEntity";
            KeyPrefix = "commonDataModel.vendinvoicejournallineentity";
            KeySeparator = ".";
            Grouping = "/VendInvoiceJournalLineEntity";

            AddGroup("VendInvoiceJournalLineEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Credit = group.Add(new VocabularyKey(nameof(Credit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Debit = group.Add(new VocabularyKey(nameof(Debit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approved = group.Add(new VocabularyKey(nameof(Approved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedBy = group.Add(new VocabularyKey(nameof(ApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountAmount = group.Add(new VocabularyKey(nameof(CashDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscount = group.Add(new VocabularyKey(nameof(CashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Document = group.Add(new VocabularyKey(nameof(Document), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTHSTTaxType = group.Add(new VocabularyKey(nameof(GSTHSTTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Listcode = group.Add(new VocabularyKey(nameof(Listcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetCompany = group.Add(new VocabularyKey(nameof(OffsetCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetTransactionText = group.Add(new VocabularyKey(nameof(OffsetTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfOperation = group.Add(new VocabularyKey(nameof(TypeOfOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDeclaration = group.Add(new VocabularyKey(nameof(InvoiceDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UUID = group.Add(new VocabularyKey(nameof(UUID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverNumber = group.Add(new VocabularyKey(nameof(ApproverNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDeclarationId = group.Add(new VocabularyKey(nameof(InvoiceDeclarationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressTimeZone = group.Add(new VocabularyKey(nameof(RemittanceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressDescription = group.Add(new VocabularyKey(nameof(RemittanceAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressCountry = group.Add(new VocabularyKey(nameof(RemittanceAddressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressCountryISOCode = group.Add(new VocabularyKey(nameof(RemittanceAddressCountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressState = group.Add(new VocabularyKey(nameof(RemittanceAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressCounty = group.Add(new VocabularyKey(nameof(RemittanceAddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressCity = group.Add(new VocabularyKey(nameof(RemittanceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressStreet = group.Add(new VocabularyKey(nameof(RemittanceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressZipCode = group.Add(new VocabularyKey(nameof(RemittanceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressDistrictName = group.Add(new VocabularyKey(nameof(RemittanceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressLatitude = group.Add(new VocabularyKey(nameof(RemittanceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressLongitude = group.Add(new VocabularyKey(nameof(RemittanceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressValidTo = group.Add(new VocabularyKey(nameof(RemittanceAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressValidFrom = group.Add(new VocabularyKey(nameof(RemittanceAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryRemittanceAddress = group.Add(new VocabularyKey(nameof(FullPrimaryRemittanceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceAddressLocationId = group.Add(new VocabularyKey(nameof(RemittanceAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWithholdingTaxCalculate = group.Add(new VocabularyKey(nameof(IsWithholdingTaxCalculate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendBankAccountId = group.Add(new VocabularyKey(nameof(CustVendBankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Fields = group.Add(new VocabularyKey(nameof(Tax1099Fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymId = group.Add(new VocabularyKey(nameof(PaymId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetTransType = group.Add(new VocabularyKey(nameof(AssetTransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRate = group.Add(new VocabularyKey(nameof(ExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateSecond = group.Add(new VocabularyKey(nameof(ExchRateSecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Company { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Credit { get; private set; }
        public VocabularyKey Debit { get; private set; }
        public VocabularyKey Approved { get; private set; }
        public VocabularyKey ApprovedBy { get; private set; }
        public VocabularyKey CashDiscountAmount { get; private set; }
        public VocabularyKey CashDiscount { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CashDiscountDate { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey Document { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey GSTHSTTaxType { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey DeliveryDate { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Listcode { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetCompany { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetTransactionText { get; private set; }
        public VocabularyKey TypeOfOperation { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey InvoiceDeclaration { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey UUID { get; private set; }
        public VocabularyKey ApproverNumber { get; private set; }
        public VocabularyKey InvoiceDeclarationId { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey RemittanceAddressTimeZone { get; private set; }
        public VocabularyKey RemittanceAddressDescription { get; private set; }
        public VocabularyKey RemittanceAddressCountry { get; private set; }
        public VocabularyKey RemittanceAddressCountryISOCode { get; private set; }
        public VocabularyKey RemittanceAddressState { get; private set; }
        public VocabularyKey RemittanceAddressCounty { get; private set; }
        public VocabularyKey RemittanceAddressCity { get; private set; }
        public VocabularyKey RemittanceAddressStreet { get; private set; }
        public VocabularyKey RemittanceAddressZipCode { get; private set; }
        public VocabularyKey RemittanceAddressDistrictName { get; private set; }
        public VocabularyKey RemittanceAddressLatitude { get; private set; }
        public VocabularyKey RemittanceAddressLongitude { get; private set; }
        public VocabularyKey RemittanceAddressValidTo { get; private set; }
        public VocabularyKey RemittanceAddressValidFrom { get; private set; }
        public VocabularyKey FullPrimaryRemittanceAddress { get; private set; }
        public VocabularyKey RemittanceAddressLocationId { get; private set; }
        public VocabularyKey ItemWithholdingTaxGroupCode { get; private set; }
        public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
        public VocabularyKey ChineseVoucherType { get; private set; }
        public VocabularyKey ChineseVoucher { get; private set; }
        public VocabularyKey IsWithholdingTaxCalculate { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey CustVendBankAccountId { get; private set; }
        public VocabularyKey Tax1099Fields { get; private set; }
        public VocabularyKey PaymId { get; private set; }
        public VocabularyKey BookId { get; private set; }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey AssetTransType { get; private set; }
        public VocabularyKey ExchRate { get; private set; }
        public VocabularyKey ExchRateSecond { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }


    }
}