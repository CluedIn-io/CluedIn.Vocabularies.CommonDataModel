using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankParametersEntityVocabulary : SimpleVocabulary
    {
        public BankParametersEntityVocabulary()
        {
            VocabularyName = "BankParametersEntity";
            KeyPrefix = "commonDataModel.bankparametersentity";
            KeySeparator = ".";
            Grouping = "/BankParametersEntity";

            AddGroup("BankParametersEntity Details", group =>
            {
                AllowChecksForLedgerAccounts = group.Add(new VocabularyKey(nameof(AllowChecksForLedgerAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowCheckReuse = group.Add(new VocabularyKey(nameof(AllowCheckReuse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDateDifferenceForReconciliationMatching = group.Add(new VocabularyKey(nameof(MaxDateDifferenceForReconciliationMatching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowInactiveBankPrenote = group.Add(new VocabularyKey(nameof(AllowInactiveBankPrenote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowPaymentCopies = group.Add(new VocabularyKey(nameof(AllowPaymentCopies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableLetterOfCreditExport = group.Add(new VocabularyKey(nameof(EnableLetterOfCreditExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableLetterOfCreditImport = group.Add(new VocabularyKey(nameof(EnableLetterOfCreditImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableLetterOfGuarantee = group.Add(new VocabularyKey(nameof(EnableLetterOfGuarantee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LetterOfGuaranteeJournalName = group.Add(new VocabularyKey(nameof(LetterOfGuaranteeJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowAmountsInDebitCreditOnBankStatement = group.Add(new VocabularyKey(nameof(ShowAmountsInDebitCreditOnBankStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateReconciliationMatchingDateDifference = group.Add(new VocabularyKey(nameof(ValidateReconciliationMatchingDateDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateReconciliationMatchingTransactionType = group.Add(new VocabularyKey(nameof(ValidateReconciliationMatchingTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimitTolerance = group.Add(new VocabularyKey(nameof(CreditLimitTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnablePostdatedChecks = group.Add(new VocabularyKey(nameof(EnablePostdatedChecks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedChecksJournalName = group.Add(new VocabularyKey(nameof(PostdatedChecksJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingMainAccountIdForIssuedPostdatedChecks = group.Add(new VocabularyKey(nameof(ClearingMainAccountIdForIssuedPostdatedChecks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonsufficientFundsTransactionType = group.Add(new VocabularyKey(nameof(NonsufficientFundsTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostJournalEntriesForPostdatedChecks = group.Add(new VocabularyKey(nameof(PostJournalEntriesForPostdatedChecks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingMainAccountIdForRecievedPostdatedChecks = group.Add(new VocabularyKey(nameof(ClearingMainAccountIdForRecievedPostdatedChecks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireCheckReversalJournal = group.Add(new VocabularyKey(nameof(RequireCheckReversalJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireCheckReversalReason = group.Add(new VocabularyKey(nameof(RequireCheckReversalReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireDepositCancellationJournal = group.Add(new VocabularyKey(nameof(RequireDepositCancellationJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireDepositCancellationReason = group.Add(new VocabularyKey(nameof(RequireDepositCancellationReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostdatedChecksPaymentJournalName = group.Add(new VocabularyKey(nameof(PostdatedChecksPaymentJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxMainAccountIdForPostdatedChecks = group.Add(new VocabularyKey(nameof(WithholdingTaxMainAccountIdForPostdatedChecks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingMainAccountIdForIssuedPostdatedChecksDisplayValue = group.Add(new VocabularyKey(nameof(ClearingMainAccountIdForIssuedPostdatedChecksDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingMainAccountIdForRecievedPostdatedChecksDisplayValue = group.Add(new VocabularyKey(nameof(ClearingMainAccountIdForRecievedPostdatedChecksDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxMainAccountIdForPostdatedChecksDisplayValue = group.Add(new VocabularyKey(nameof(WithholdingTaxMainAccountIdForPostdatedChecksDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JBAFileKanaNameValidationMethod = group.Add(new VocabularyKey(nameof(JBAFileKanaNameValidationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowCommaInBankAccountKanaName = group.Add(new VocabularyKey(nameof(AllowCommaInBankAccountKanaName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLetterofCreditChargesPostingEnabled = group.Add(new VocabularyKey(nameof(IsLetterofCreditChargesPostingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationMethod = group.Add(new VocabularyKey(nameof(ValidationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckForVoucherUsed = group.Add(new VocabularyKey(nameof(CheckForVoucherUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseConfirmStatus = group.Add(new VocabularyKey(nameof(UseConfirmStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cash = group.Add(new VocabularyKey(nameof(Cash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingOnEarlierDate = group.Add(new VocabularyKey(nameof(PostingOnEarlierDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeDifferencesType = group.Add(new VocabularyKey(nameof(ExchangeDifferencesType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateOnDisbursements = group.Add(new VocabularyKey(nameof(ExchangeRateOnDisbursements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckOperationsLimit = group.Add(new VocabularyKey(nameof(CheckOperationsLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsLimit = group.Add(new VocabularyKey(nameof(OperationsLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityOfDays = group.Add(new VocabularyKey(nameof(QuantityOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisallowPostingEarlierThanCashReportClosingDate = group.Add(new VocabularyKey(nameof(DisallowPostingEarlierThanCashReportClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashPosting = group.Add(new VocabularyKey(nameof(CashPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnalysisCode = group.Add(new VocabularyKey(nameof(AnalysisCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentCode = group.Add(new VocabularyKey(nameof(DepartmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurposeCode = group.Add(new VocabularyKey(nameof(PurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowBankCurrencyReval = group.Add(new VocabularyKey(nameof(AllowBankCurrencyReval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowBankAccountStatementEdit = group.Add(new VocabularyKey(nameof(AllowBankAccountStatementEdit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNEnableEscheatment = group.Add(new VocabularyKey(nameof(PSNEnableEscheatment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowChecksForLedgerAccounts { get; private set; }
        public VocabularyKey AllowCheckReuse { get; private set; }
        public VocabularyKey MaxDateDifferenceForReconciliationMatching { get; private set; }
        public VocabularyKey AllowInactiveBankPrenote { get; private set; }
        public VocabularyKey AllowPaymentCopies { get; private set; }
        public VocabularyKey EnableLetterOfCreditExport { get; private set; }
        public VocabularyKey EnableLetterOfCreditImport { get; private set; }
        public VocabularyKey EnableLetterOfGuarantee { get; private set; }
        public VocabularyKey LetterOfGuaranteeJournalName { get; private set; }
        public VocabularyKey ShowAmountsInDebitCreditOnBankStatement { get; private set; }
        public VocabularyKey ValidateReconciliationMatchingDateDifference { get; private set; }
        public VocabularyKey ValidateReconciliationMatchingTransactionType { get; private set; }
        public VocabularyKey CreditLimitTolerance { get; private set; }
        public VocabularyKey EnablePostdatedChecks { get; private set; }
        public VocabularyKey PostdatedChecksJournalName { get; private set; }
        public VocabularyKey ClearingMainAccountIdForIssuedPostdatedChecks { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey NonsufficientFundsTransactionType { get; private set; }
        public VocabularyKey PostJournalEntriesForPostdatedChecks { get; private set; }
        public VocabularyKey ClearingMainAccountIdForRecievedPostdatedChecks { get; private set; }
        public VocabularyKey RequireCheckReversalJournal { get; private set; }
        public VocabularyKey RequireCheckReversalReason { get; private set; }
        public VocabularyKey RequireDepositCancellationJournal { get; private set; }
        public VocabularyKey RequireDepositCancellationReason { get; private set; }
        public VocabularyKey PostdatedChecksPaymentJournalName { get; private set; }
        public VocabularyKey WithholdingTaxMainAccountIdForPostdatedChecks { get; private set; }
        public VocabularyKey ClearingMainAccountIdForIssuedPostdatedChecksDisplayValue { get; private set; }
        public VocabularyKey ClearingMainAccountIdForRecievedPostdatedChecksDisplayValue { get; private set; }
        public VocabularyKey WithholdingTaxMainAccountIdForPostdatedChecksDisplayValue { get; private set; }
        public VocabularyKey JBAFileKanaNameValidationMethod { get; private set; }
        public VocabularyKey AllowCommaInBankAccountKanaName { get; private set; }
        public VocabularyKey IsLetterofCreditChargesPostingEnabled { get; private set; }
        public VocabularyKey ValidationMethod { get; private set; }
        public VocabularyKey CheckForVoucherUsed { get; private set; }
        public VocabularyKey UseConfirmStatus { get; private set; }
        public VocabularyKey Cash { get; private set; }
        public VocabularyKey PostingOnEarlierDate { get; private set; }
        public VocabularyKey ExchangeDifferencesType { get; private set; }
        public VocabularyKey ExchangeRateOnDisbursements { get; private set; }
        public VocabularyKey CheckOperationsLimit { get; private set; }
        public VocabularyKey OperationsLimit { get; private set; }
        public VocabularyKey QuantityOfDays { get; private set; }
        public VocabularyKey DisallowPostingEarlierThanCashReportClosingDate { get; private set; }
        public VocabularyKey CashPosting { get; private set; }
        public VocabularyKey AnalysisCode { get; private set; }
        public VocabularyKey DepartmentCode { get; private set; }
        public VocabularyKey PurposeCode { get; private set; }
        public VocabularyKey AllowBankCurrencyReval { get; private set; }
        public VocabularyKey AllowBankAccountStatementEdit { get; private set; }
        public VocabularyKey PSNEnableEscheatment { get; private set; }


    }
}