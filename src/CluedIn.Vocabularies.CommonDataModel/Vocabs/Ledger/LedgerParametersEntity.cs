using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerParametersEntityVocabulary : SimpleVocabulary
    {
        public LedgerParametersEntityVocabulary()
        {
            VocabularyName = "LedgerParametersEntity";
            KeyPrefix = "commonDataModel.ledgerparametersentity";
            KeySeparator = ".";
            Grouping = "/LedgerParametersEntity";

            AddGroup("LedgerParametersEntity Details", group =>
            {
                DoNotUseErrorAccount = group.Add(new VocabularyKey(nameof(DoNotUseErrorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireContinuousNumberSequences = group.Add(new VocabularyKey(nameof(RequireContinuousNumberSequences), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireJournalizingOnFiscalPeriodClose = group.Add(new VocabularyKey(nameof(RequireJournalizingOnFiscalPeriodClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DuplicateVoucherOption = group.Add(new VocabularyKey(nameof(DuplicateVoucherOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeletePreviousClosingTransactionsDuringFiscalYearClose = group.Add(new VocabularyKey(nameof(DeletePreviousClosingTransactionsDuringFiscalYearClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValuesUsedForSummaryAccountOption = group.Add(new VocabularyKey(nameof(DimensionValuesUsedForSummaryAccountOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBudgetAppropriation = group.Add(new VocabularyKey(nameof(UseBudgetAppropriation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBudgetReservationProcess = group.Add(new VocabularyKey(nameof(UseBudgetReservationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseEncumbranceProcess = group.Add(new VocabularyKey(nameof(UseEncumbranceProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsePreencumbranceProcess = group.Add(new VocabularyKey(nameof(UsePreencumbranceProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartJournalizeReportOnPageOne = group.Add(new VocabularyKey(nameof(StartJournalizeReportOnPageOne), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderJournalizingReportByCreatedDateAndTime = group.Add(new VocabularyKey(nameof(OrderJournalizingReportByCreatedDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsePostingDefinitions = group.Add(new VocabularyKey(nameof(UsePostingDefinitions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumNumberOfOpenFiscalYears = group.Add(new VocabularyKey(nameof(MaximumNumberOfOpenFiscalYears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPennyDifferenceInAccountingCurrency = group.Add(new VocabularyKey(nameof(MaximumPennyDifferenceInAccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPennyDifferenceInReportingCurrency = group.Add(new VocabularyKey(nameof(MaximumPennyDifferenceInReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UploadJournalName = group.Add(new VocabularyKey(nameof(UploadJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberRequiredForFiscalYearClose = group.Add(new VocabularyKey(nameof(VoucherNumberRequiredForFiscalYearClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipBudgetTransactionsForFiscalYearClose = group.Add(new VocabularyKey(nameof(SkipBudgetTransactionsForFiscalYearClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateClosingTransactionsDuringFiscalYearClose = group.Add(new VocabularyKey(nameof(CreateClosingTransactionsDuringFiscalYearClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseFundDimensionToCarryForwardPurchaseOrders = group.Add(new VocabularyKey(nameof(UseFundDimensionToCarryForwardPurchaseOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseOppositeSignAmounts = group.Add(new VocabularyKey(nameof(ReverseOppositeSignAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateReversalsAsCorrections = group.Add(new VocabularyKey(nameof(CreateReversalsAsCorrections), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetFiscalYearToClosedDuringFiscalYearClose = group.Add(new VocabularyKey(nameof(SetFiscalYearToClosedDuringFiscalYearClose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflationCorrectionAccountDisplayValue = group.Add(new VocabularyKey(nameof(InflationCorrectionAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflationCorrectionAccount = group.Add(new VocabularyKey(nameof(InflationCorrectionAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TAccount = group.Add(new VocabularyKey(nameof(TAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflationOffsetAccount = group.Add(new VocabularyKey(nameof(InflationOffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflationOffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(InflationOffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxMinimumInvoiceAmount = group.Add(new VocabularyKey(nameof(WithholdingTaxMinimumInvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMappingMexicanBalanceSheet = group.Add(new VocabularyKey(nameof(ERFormatMappingMexicanBalanceSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMexicanBalanceSheet = group.Add(new VocabularyKey(nameof(ERFormatMexicanBalanceSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERSolutionMexicanBalanceSheet = group.Add(new VocabularyKey(nameof(ERSolutionMexicanBalanceSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERProviderMexicanBalanceSheet = group.Add(new VocabularyKey(nameof(ERProviderMexicanBalanceSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMappingMexicanChartOfAccount = group.Add(new VocabularyKey(nameof(ERFormatMappingMexicanChartOfAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMexicanChartOfAccount = group.Add(new VocabularyKey(nameof(ERFormatMexicanChartOfAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERSolutionMexicanChartOfAccount = group.Add(new VocabularyKey(nameof(ERSolutionMexicanChartOfAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERProviderMexicanChartOfAccount = group.Add(new VocabularyKey(nameof(ERProviderMexicanChartOfAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMappingMexicanLedgerEntries = group.Add(new VocabularyKey(nameof(ERFormatMappingMexicanLedgerEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMexicanLedgerEntries = group.Add(new VocabularyKey(nameof(ERFormatMexicanLedgerEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERSolutionMexicanLedgerEntries = group.Add(new VocabularyKey(nameof(ERSolutionMexicanLedgerEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERProviderMexicanLedgerEntries = group.Add(new VocabularyKey(nameof(ERProviderMexicanLedgerEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMappingMexicanAuxiliaryLedger = group.Add(new VocabularyKey(nameof(ERFormatMappingMexicanAuxiliaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMexicanAuxiliaryLedger = group.Add(new VocabularyKey(nameof(ERFormatMexicanAuxiliaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERSolutionMexicanAuxiliaryLedger = group.Add(new VocabularyKey(nameof(ERSolutionMexicanAuxiliaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERProviderMexicanAuxiliaryLedger = group.Add(new VocabularyKey(nameof(ERProviderMexicanAuxiliaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitedOpenFiscalPeriods = group.Add(new VocabularyKey(nameof(LimitedOpenFiscalPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowAmountDebitCredit = group.Add(new VocabularyKey(nameof(ShowAmountDebitCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISFormatMapping = group.Add(new VocabularyKey(nameof(CISFormatMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Financialstatements = group.Add(new VocabularyKey(nameof(Financialstatements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Charges = group.Add(new VocabularyKey(nameof(Charges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatExpenseAccount = group.Add(new VocabularyKey(nameof(ZakatExpenseAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsZakatEnabled = group.Add(new VocabularyKey(nameof(IsZakatEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatProvisionAccount = group.Add(new VocabularyKey(nameof(ZakatProvisionAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableSelfApproval = group.Add(new VocabularyKey(nameof(EnableSelfApproval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableExtendedCustVendBalanceInquiry = group.Add(new VocabularyKey(nameof(EnableExtendedCustVendBalanceInquiry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableShowAmountInDebitCreditColumn = group.Add(new VocabularyKey(nameof(EnableShowAmountInDebitCreditColumn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableJournalApprovalStatus = group.Add(new VocabularyKey(nameof(EnableJournalApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableCommonAccountType = group.Add(new VocabularyKey(nameof(EnableCommonAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableChineseVoucherSystem = group.Add(new VocabularyKey(nameof(EnableChineseVoucherSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableExcludeUnusedAccounts = group.Add(new VocabularyKey(nameof(EnableExcludeUnusedAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableExtendedLedgerInquiry = group.Add(new VocabularyKey(nameof(EnableExtendedLedgerInquiry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableAlandTaxRequirements = group.Add(new VocabularyKey(nameof(EnableAlandTaxRequirements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableReverseCharge = group.Add(new VocabularyKey(nameof(EnableReverseCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseChargePurchTaxGroup = group.Add(new VocabularyKey(nameof(ReverseChargePurchTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseChargeSalesTaxGroup = group.Add(new VocabularyKey(nameof(ReverseChargeSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseChargeContactName = group.Add(new VocabularyKey(nameof(ReverseChargeContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseChargeContactPhone = group.Add(new VocabularyKey(nameof(ReverseChargeContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMappingSalesListExport_UK = group.Add(new VocabularyKey(nameof(ERFormatMappingSalesListExport_UK), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseCorrespondingMechanism = group.Add(new VocabularyKey(nameof(UseCorrespondingMechanism), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPurchaseBookDateNumberDelimiter = group.Add(new VocabularyKey(nameof(SalesPurchaseBookDateNumberDelimiter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactureOperationCodeDelimiter = group.Add(new VocabularyKey(nameof(FactureOperationCodeDelimiter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsePrecalculatedData = group.Add(new VocabularyKey(nameof(UsePrecalculatedData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceRevaluationCancelation = group.Add(new VocabularyKey(nameof(AdvanceRevaluationCancelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMultipleTransactionsWithinOneVoucher = group.Add(new VocabularyKey(nameof(AllowMultipleTransactionsWithinOneVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessSourceDocumentLinesInParallel = group.Add(new VocabularyKey(nameof(ProcessSourceDocumentLinesInParallel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedLedgerSettlement = group.Add(new VocabularyKey(nameof(AdvancedLedgerSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RDeferralsPostingProfile = group.Add(new VocabularyKey(nameof(RDeferralsPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RDeferralsRoundOffOperation = group.Add(new VocabularyKey(nameof(RDeferralsRoundOffOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RDeferralsBaseValueModel = group.Add(new VocabularyKey(nameof(RDeferralsBaseValueModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATRefundingMethod = group.Add(new VocabularyKey(nameof(VATRefundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateCalculationMethod = group.Add(new VocabularyKey(nameof(ExchRateCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNLedgerInterestDistributionEnable = group.Add(new VocabularyKey(nameof(PSNLedgerInterestDistributionEnable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNLedgerInterestDistributionFundingSourceRules = group.Add(new VocabularyKey(nameof(PSNLedgerInterestDistributionFundingSourceRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNLedgerInterestDistributionPostALE = group.Add(new VocabularyKey(nameof(PSNLedgerInterestDistributionPostALE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPriorYearCorrection = group.Add(new VocabularyKey(nameof(PSNPriorYearCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCashControlDimensionHierarchy = group.Add(new VocabularyKey(nameof(PSNCashControlDimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCashControlOverrideGroup = group.Add(new VocabularyKey(nameof(PSNCashControlOverrideGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCashControlDimensionHierarchyName = group.Add(new VocabularyKey(nameof(PSNCashControlDimensionHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCashControlOverrideGroupId = group.Add(new VocabularyKey(nameof(PSNCashControlOverrideGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecDisableContractTerms = group.Add(new VocabularyKey(nameof(RevRecDisableContractTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecEnableReallocation = group.Add(new VocabularyKey(nameof(RevRecEnableReallocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecHeaderDiscounts = group.Add(new VocabularyKey(nameof(RevRecHeaderDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecJournalNameId = group.Add(new VocabularyKey(nameof(RevRecJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecPostToAccountsReceivable = group.Add(new VocabularyKey(nameof(RevRecPostToAccountsReceivable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DoNotUseErrorAccount { get; private set; }
        public VocabularyKey RequireContinuousNumberSequences { get; private set; }
        public VocabularyKey RequireJournalizingOnFiscalPeriodClose { get; private set; }
        public VocabularyKey DuplicateVoucherOption { get; private set; }
        public VocabularyKey DeletePreviousClosingTransactionsDuringFiscalYearClose { get; private set; }
        public VocabularyKey DimensionValuesUsedForSummaryAccountOption { get; private set; }
        public VocabularyKey UseBudgetAppropriation { get; private set; }
        public VocabularyKey UseBudgetReservationProcess { get; private set; }
        public VocabularyKey UseEncumbranceProcess { get; private set; }
        public VocabularyKey UsePreencumbranceProcess { get; private set; }
        public VocabularyKey StartJournalizeReportOnPageOne { get; private set; }
        public VocabularyKey OrderJournalizingReportByCreatedDateAndTime { get; private set; }
        public VocabularyKey UsePostingDefinitions { get; private set; }
        public VocabularyKey MaximumNumberOfOpenFiscalYears { get; private set; }
        public VocabularyKey MaximumPennyDifferenceInAccountingCurrency { get; private set; }
        public VocabularyKey MaximumPennyDifferenceInReportingCurrency { get; private set; }
        public VocabularyKey UploadJournalName { get; private set; }
        public VocabularyKey VoucherNumberRequiredForFiscalYearClose { get; private set; }
        public VocabularyKey SkipBudgetTransactionsForFiscalYearClose { get; private set; }
        public VocabularyKey CreateClosingTransactionsDuringFiscalYearClose { get; private set; }
        public VocabularyKey UseFundDimensionToCarryForwardPurchaseOrders { get; private set; }
        public VocabularyKey ReverseOppositeSignAmounts { get; private set; }
        public VocabularyKey CreateReversalsAsCorrections { get; private set; }
        public VocabularyKey SetFiscalYearToClosedDuringFiscalYearClose { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey InflationCorrectionAccountDisplayValue { get; private set; }
        public VocabularyKey InflationCorrectionAccount { get; private set; }
        public VocabularyKey TAccount { get; private set; }
        public VocabularyKey InflationOffsetAccount { get; private set; }
        public VocabularyKey InflationOffsetAccountDisplayValue { get; private set; }
        public VocabularyKey WithholdingTaxMinimumInvoiceAmount { get; private set; }
        public VocabularyKey ERFormatMappingMexicanBalanceSheet { get; private set; }
        public VocabularyKey ERFormatMexicanBalanceSheet { get; private set; }
        public VocabularyKey ERSolutionMexicanBalanceSheet { get; private set; }
        public VocabularyKey ERProviderMexicanBalanceSheet { get; private set; }
        public VocabularyKey ERFormatMappingMexicanChartOfAccount { get; private set; }
        public VocabularyKey ERFormatMexicanChartOfAccount { get; private set; }
        public VocabularyKey ERSolutionMexicanChartOfAccount { get; private set; }
        public VocabularyKey ERProviderMexicanChartOfAccount { get; private set; }
        public VocabularyKey ERFormatMappingMexicanLedgerEntries { get; private set; }
        public VocabularyKey ERFormatMexicanLedgerEntries { get; private set; }
        public VocabularyKey ERSolutionMexicanLedgerEntries { get; private set; }
        public VocabularyKey ERProviderMexicanLedgerEntries { get; private set; }
        public VocabularyKey ERFormatMappingMexicanAuxiliaryLedger { get; private set; }
        public VocabularyKey ERFormatMexicanAuxiliaryLedger { get; private set; }
        public VocabularyKey ERSolutionMexicanAuxiliaryLedger { get; private set; }
        public VocabularyKey ERProviderMexicanAuxiliaryLedger { get; private set; }
        public VocabularyKey LimitedOpenFiscalPeriods { get; private set; }
        public VocabularyKey ShowAmountDebitCredit { get; private set; }
        public VocabularyKey CISFormatMapping { get; private set; }
        public VocabularyKey Financialstatements { get; private set; }
        public VocabularyKey Charges { get; private set; }
        public VocabularyKey ZakatExpenseAccount { get; private set; }
        public VocabularyKey IsZakatEnabled { get; private set; }
        public VocabularyKey ZakatProvisionAccount { get; private set; }
        public VocabularyKey EnableSelfApproval { get; private set; }
        public VocabularyKey EnableExtendedCustVendBalanceInquiry { get; private set; }
        public VocabularyKey EnableShowAmountInDebitCreditColumn { get; private set; }
        public VocabularyKey EnableJournalApprovalStatus { get; private set; }
        public VocabularyKey EnableCommonAccountType { get; private set; }
        public VocabularyKey EnableChineseVoucherSystem { get; private set; }
        public VocabularyKey EnableExcludeUnusedAccounts { get; private set; }
        public VocabularyKey EnableExtendedLedgerInquiry { get; private set; }
        public VocabularyKey EnableAlandTaxRequirements { get; private set; }
        public VocabularyKey EnableReverseCharge { get; private set; }
        public VocabularyKey ReverseChargePurchTaxGroup { get; private set; }
        public VocabularyKey ReverseChargeSalesTaxGroup { get; private set; }
        public VocabularyKey ReverseChargeContactName { get; private set; }
        public VocabularyKey ReverseChargeContactPhone { get; private set; }
        public VocabularyKey ERFormatMappingSalesListExport_UK { get; private set; }
        public VocabularyKey UseCorrespondingMechanism { get; private set; }
        public VocabularyKey SalesPurchaseBookDateNumberDelimiter { get; private set; }
        public VocabularyKey FactureOperationCodeDelimiter { get; private set; }
        public VocabularyKey UsePrecalculatedData { get; private set; }
        public VocabularyKey AdvanceRevaluationCancelation { get; private set; }
        public VocabularyKey AllowMultipleTransactionsWithinOneVoucher { get; private set; }
        public VocabularyKey ProcessSourceDocumentLinesInParallel { get; private set; }
        public VocabularyKey AdvancedLedgerSettlement { get; private set; }
        public VocabularyKey RDeferralsPostingProfile { get; private set; }
        public VocabularyKey RDeferralsRoundOffOperation { get; private set; }
        public VocabularyKey RDeferralsBaseValueModel { get; private set; }
        public VocabularyKey VATRefundingMethod { get; private set; }
        public VocabularyKey ExchRateCalculationMethod { get; private set; }
        public VocabularyKey PSNLedgerInterestDistributionEnable { get; private set; }
        public VocabularyKey PSNLedgerInterestDistributionFundingSourceRules { get; private set; }
        public VocabularyKey PSNLedgerInterestDistributionPostALE { get; private set; }
        public VocabularyKey PSNPriorYearCorrection { get; private set; }
        public VocabularyKey PSNCashControlDimensionHierarchy { get; private set; }
        public VocabularyKey PSNCashControlOverrideGroup { get; private set; }
        public VocabularyKey PSNCashControlDimensionHierarchyName { get; private set; }
        public VocabularyKey PSNCashControlOverrideGroupId { get; private set; }
        public VocabularyKey RevRecDisableContractTerms { get; private set; }
        public VocabularyKey RevRecEnableReallocation { get; private set; }
        public VocabularyKey RevRecHeaderDiscounts { get; private set; }
        public VocabularyKey RevRecJournalNameId { get; private set; }
        public VocabularyKey RevRecPostToAccountsReceivable { get; private set; }


    }
}