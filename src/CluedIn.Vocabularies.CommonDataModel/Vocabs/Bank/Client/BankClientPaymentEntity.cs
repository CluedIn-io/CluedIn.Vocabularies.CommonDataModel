using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankClientPaymentEntityVocabulary : SimpleVocabulary
    {
        public BankClientPaymentEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankClientPaymentEntity";
            KeyPrefix = "commonDataModel.bankclientpaymententity";
            KeySeparator = ".";
            Grouping = "/BankClientPaymentEntity";

            AddGroup("Common Data Model BankClientPaymentEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementNumberLocking = group.Add(new VocabularyKey(nameof(AgreementNumberLocking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankExchangeRate = group.Add(new VocabularyKey(nameof(BankExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Counteragent = group.Add(new VocabularyKey(nameof(Counteragent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentType = group.Add(new VocabularyKey(nameof(DocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Include = group.Add(new VocabularyKey(nameof(Include), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CounteragentType = group.Add(new VocabularyKey(nameof(CounteragentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeAccountNumber = group.Add(new VocabularyKey(nameof(PayeeAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeBankAccountNumber = group.Add(new VocabularyKey(nameof(PayeeBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeBankAddress = group.Add(new VocabularyKey(nameof(PayeeBankAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeBankBIC = group.Add(new VocabularyKey(nameof(PayeeBankBIC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeBankCorrAccount = group.Add(new VocabularyKey(nameof(PayeeBankCorrAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeBankName = group.Add(new VocabularyKey(nameof(PayeeBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeINN = group.Add(new VocabularyKey(nameof(PayeeINN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recipient = group.Add(new VocabularyKey(nameof(Recipient), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeRegistryReasonCode = group.Add(new VocabularyKey(nameof(PayeeRegistryReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerAccountNumber = group.Add(new VocabularyKey(nameof(PayerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerBankAccountNumber = group.Add(new VocabularyKey(nameof(PayerBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerBankAddress = group.Add(new VocabularyKey(nameof(PayerBankAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerBankBIC = group.Add(new VocabularyKey(nameof(PayerBankBIC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerBankCorrAccount = group.Add(new VocabularyKey(nameof(PayerBankCorrAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerBankName = group.Add(new VocabularyKey(nameof(PayerBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerINN = group.Add(new VocabularyKey(nameof(PayerINN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Payer = group.Add(new VocabularyKey(nameof(Payer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayerRegistryReasonCode = group.Add(new VocabularyKey(nameof(PayerRegistryReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDirection = group.Add(new VocabularyKey(nameof(PaymentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurposeText = group.Add(new VocabularyKey(nameof(PurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentJournalVoucher = group.Add(new VocabularyKey(nameof(PrepaymentJournalVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDate = group.Add(new VocabularyKey(nameof(ReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuittanceContent = group.Add(new VocabularyKey(nameof(QuittanceContent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuittanceDate = group.Add(new VocabularyKey(nameof(QuittanceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuittanceTime = group.Add(new VocabularyKey(nameof(QuittanceTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyOfConversion = group.Add(new VocabularyKey(nameof(CurrencyOfConversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmbiguousText = group.Add(new VocabularyKey(nameof(AmbiguousText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Error = group.Add(new VocabularyKey(nameof(Error), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithdrawalDate = group.Add(new VocabularyKey(nameof(WithdrawalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UCI = group.Add(new VocabularyKey(nameof(UCI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementId = group.Add(new VocabularyKey(nameof(AgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey AgreementNumberLocking { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey BankExchangeRate { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Counteragent { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey DocumentType { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey CounteragentType { get; private set; }
        public VocabularyKey PayeeAccountNumber { get; private set; }
        public VocabularyKey PayeeBankAccountNumber { get; private set; }
        public VocabularyKey PayeeBankAddress { get; private set; }
        public VocabularyKey PayeeBankBIC { get; private set; }
        public VocabularyKey PayeeBankCorrAccount { get; private set; }
        public VocabularyKey PayeeBankName { get; private set; }
        public VocabularyKey PayeeINN { get; private set; }
        public VocabularyKey Recipient { get; private set; }
        public VocabularyKey PayeeRegistryReasonCode { get; private set; }
        public VocabularyKey PayerAccountNumber { get; private set; }
        public VocabularyKey PayerBankAccountNumber { get; private set; }
        public VocabularyKey PayerBankAddress { get; private set; }
        public VocabularyKey PayerBankBIC { get; private set; }
        public VocabularyKey PayerBankCorrAccount { get; private set; }
        public VocabularyKey PayerBankName { get; private set; }
        public VocabularyKey PayerINN { get; private set; }
        public VocabularyKey Payer { get; private set; }
        public VocabularyKey PayerRegistryReasonCode { get; private set; }
        public VocabularyKey PaymentDirection { get; private set; }
        public VocabularyKey PurposeText { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey PrepaymentJournalVoucher { get; private set; }
        public VocabularyKey ReceiptDate { get; private set; }
        public VocabularyKey QuittanceContent { get; private set; }
        public VocabularyKey QuittanceDate { get; private set; }
        public VocabularyKey QuittanceTime { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey CurrencyOfConversion { get; private set; }
        public VocabularyKey AmbiguousText { get; private set; }
        public VocabularyKey ErrorCause { get; private set; }
        public VocabularyKey Error { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey WithdrawalDate { get; private set; }
        public VocabularyKey UCI { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey AgreementId { get; private set; }


    }
}