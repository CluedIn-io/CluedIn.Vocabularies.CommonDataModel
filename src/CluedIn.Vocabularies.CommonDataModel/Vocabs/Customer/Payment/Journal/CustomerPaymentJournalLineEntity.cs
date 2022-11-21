using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPaymentJournalLineEntityVocabulary : SimpleVocabulary
    {
        public CustomerPaymentJournalLineEntityVocabulary()
        {
            VocabularyName = "Customer Payment Journal Line Entity";
            KeyPrefix = "commonDataModel.customerpaymentjournallineentity";
            KeySeparator = ".";
            Grouping = "/CustomerPaymentJournalLineEntity";

            AddGroup("CustomerPaymentJournalLineEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeText = group.Add(new VocabularyKey(nameof(CentralBankPurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepositNumber = group.Add(new VocabularyKey(nameof(DepositNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyBankAccountId = group.Add(new VocabularyKey(nameof(ThirdPartyBankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionsForAccount = group.Add(new VocabularyKey(nameof(DefaultDimensionsForAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankImportDate = group.Add(new VocabularyKey(nameof(CentralBankImportDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetCompany = group.Add(new VocabularyKey(nameof(OffsetCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionsForOffsetAccount = group.Add(new VocabularyKey(nameof(DefaultDimensionsForOffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetTransactionText = group.Add(new VocabularyKey(nameof(OffsetTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethodName = group.Add(new VocabularyKey(nameof(PaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentReference = group.Add(new VocabularyKey(nameof(PaymentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrepayment = group.Add(new VocabularyKey(nameof(IsPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSalesTaxDirectionFromMainAccount = group.Add(new VocabularyKey(nameof(UseSalesTaxDirectionFromMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateWithholdingTax = group.Add(new VocabularyKey(nameof(CalculateWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionText = group.Add(new VocabularyKey(nameof(TransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryExchangeRate = group.Add(new VocabularyKey(nameof(SecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionsForAccountDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionsForAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionsForOffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionsForOffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerName = group.Add(new VocabularyKey(nameof(CustomerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATForeignExchangeIndicator = group.Add(new VocabularyKey(nameof(NACHAIATForeignExchangeIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATForeignExchangeReferenceIndicator = group.Add(new VocabularyKey(nameof(NACHAIATForeignExchangeReferenceIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATForeignExchangeReference = group.Add(new VocabularyKey(nameof(NACHAIATForeignExchangeReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATOFACScreeningIndicator = group.Add(new VocabularyKey(nameof(NACHAIATOFACScreeningIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATOFACSecondaryScreeningIndicator = group.Add(new VocabularyKey(nameof(NACHAIATOFACSecondaryScreeningIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATOriginatingDFIQualifier = group.Add(new VocabularyKey(nameof(NACHAIATOriginatingDFIQualifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NACHAIATReceivingDFIQualifier = group.Add(new VocabularyKey(nameof(NACHAIATReceivingDFIQualifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckMaturityDate = group.Add(new VocabularyKey(nameof(PostdatedCheckMaturityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckReceivedDate = group.Add(new VocabularyKey(nameof(PostdatedCheckReceivedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckNumber = group.Add(new VocabularyKey(nameof(PostdatedCheckNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckStopPayment = group.Add(new VocabularyKey(nameof(PostdatedCheckStopPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckReasonForStop = group.Add(new VocabularyKey(nameof(PostdatedCheckReasonForStop), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckBankName = group.Add(new VocabularyKey(nameof(PostdatedCheckBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckBankBranch = group.Add(new VocabularyKey(nameof(PostdatedCheckBankBranch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckIsReplacementCheck = group.Add(new VocabularyKey(nameof(PostdatedCheckIsReplacementCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckReplacementComments = group.Add(new VocabularyKey(nameof(PostdatedCheckReplacementComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckOriginalCheckNumber = group.Add(new VocabularyKey(nameof(PostdatedCheckOriginalCheckNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckCashier = group.Add(new VocabularyKey(nameof(PostdatedCheckCashier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckCashierDisplayValue = group.Add(new VocabularyKey(nameof(PostdatedCheckCashierDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckSalesperson = group.Add(new VocabularyKey(nameof(PostdatedCheckSalesperson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedCheckSalespersonDisplayValue = group.Add(new VocabularyKey(nameof(PostdatedCheckSalespersonDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxGroup = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Due = group.Add(new VocabularyKey(nameof(Due), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfImport = group.Add(new VocabularyKey(nameof(DateOfImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleVoucher = group.Add(new VocabularyKey(nameof(SettleVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkedInvoice = group.Add(new VocabularyKey(nameof(MarkedInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkedInvoiceCompany = group.Add(new VocabularyKey(nameof(MarkedInvoiceCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentNotes = group.Add(new VocabularyKey(nameof(PaymentNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRateSecondary = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseABankDepositSlip = group.Add(new VocabularyKey(nameof(UseABankDepositSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CentralBankPurposeText { get; private set; }
        public VocabularyKey DepositNumber { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ThirdPartyBankAccountId { get; private set; }
        public VocabularyKey DefaultDimensionsForAccount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CentralBankImportDate { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetCompany { get; private set; }
        public VocabularyKey DefaultDimensionsForOffsetAccount { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetTransactionText { get; private set; }
        public VocabularyKey PaymentId { get; private set; }
        public VocabularyKey PaymentMethodName { get; private set; }
        public VocabularyKey PaymentReference { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey IsPrepayment { get; private set; }
        public VocabularyKey UseSalesTaxDirectionFromMainAccount { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey CalculateWithholdingTax { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey TransactionText { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey SecondaryExchangeRate { get; private set; }
        public VocabularyKey DefaultDimensionsForAccountDisplayValue { get; private set; }
        public VocabularyKey DefaultDimensionsForOffsetAccountDisplayValue { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey CustomerName { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey NACHAIATForeignExchangeIndicator { get; private set; }
        public VocabularyKey NACHAIATForeignExchangeReferenceIndicator { get; private set; }
        public VocabularyKey NACHAIATForeignExchangeReference { get; private set; }
        public VocabularyKey NACHAIATOFACScreeningIndicator { get; private set; }
        public VocabularyKey NACHAIATOFACSecondaryScreeningIndicator { get; private set; }
        public VocabularyKey NACHAIATOriginatingDFIQualifier { get; private set; }
        public VocabularyKey NACHAIATReceivingDFIQualifier { get; private set; }
        public VocabularyKey PostdatedCheckMaturityDate { get; private set; }
        public VocabularyKey PostdatedCheckReceivedDate { get; private set; }
        public VocabularyKey PostdatedCheckNumber { get; private set; }
        public VocabularyKey PostdatedCheckStopPayment { get; private set; }
        public VocabularyKey PostdatedCheckReasonForStop { get; private set; }
        public VocabularyKey PostdatedCheckBankName { get; private set; }
        public VocabularyKey PostdatedCheckBankBranch { get; private set; }
        public VocabularyKey PostdatedCheckIsReplacementCheck { get; private set; }
        public VocabularyKey PostdatedCheckReplacementComments { get; private set; }
        public VocabularyKey PostdatedCheckOriginalCheckNumber { get; private set; }
        public VocabularyKey PostdatedCheckCashier { get; private set; }
        public VocabularyKey PostdatedCheckCashierDisplayValue { get; private set; }
        public VocabularyKey PostdatedCheckSalesperson { get; private set; }
        public VocabularyKey PostdatedCheckSalespersonDisplayValue { get; private set; }
        public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
        public VocabularyKey ChineseVoucherType { get; private set; }
        public VocabularyKey ChineseVoucher { get; private set; }
        public VocabularyKey ItemWithholdingTaxGroup { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey Due { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey DateOfImport { get; private set; }
        public VocabularyKey SettleVoucher { get; private set; }
        public VocabularyKey MarkedInvoice { get; private set; }
        public VocabularyKey MarkedInvoiceCompany { get; private set; }
        public VocabularyKey PaymentNotes { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey ReportingCurrencyExchRateSecondary { get; private set; }
        public VocabularyKey UseABankDepositSlip { get; private set; }
    }
}