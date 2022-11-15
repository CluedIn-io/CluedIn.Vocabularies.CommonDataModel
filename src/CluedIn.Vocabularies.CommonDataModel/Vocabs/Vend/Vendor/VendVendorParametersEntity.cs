using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorParametersEntityVocabulary : SimpleVocabulary
    {
        public VendVendorParametersEntityVocabulary()
        {
            VocabularyName = "Vend Vendor Parameters Entity";
            KeyPrefix = "commonDataModel.vendvendorparametersentity";
            KeySeparator = ".";
            Grouping = "/VendVendorParametersEntity";

            AddGroup("VendVendorParametersEntity Details", group =>
            {
                RoyaltyAccrualJournalName = group.Add(new VocabularyKey(nameof(RoyaltyAccrualJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicingPeriod = group.Add(new VocabularyKey(nameof(InvoicingPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryDiscountPosting = group.Add(new VocabularyKey(nameof(PrimaryDiscountPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryReceiptPosting = group.Add(new VocabularyKey(nameof(PrimaryReceiptPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentInvoicePostingProfile = group.Add(new VocabularyKey(nameof(PrepaymentInvoicePostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticSettlement = group.Add(new VocabularyKey(nameof(IsAutomaticSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationKey = group.Add(new VocabularyKey(nameof(AllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountAdministration = group.Add(new VocabularyKey(nameof(CashDiscountAdministration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashDiscountCalculatedForCreditNotes = group.Add(new VocabularyKey(nameof(IsCashDiscountCalculatedForCreditNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashDiscountCalculatedForPartialPayments = group.Add(new VocabularyKey(nameof(IsCashDiscountCalculatedForPartialPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashDiscountCalculatedOnAmountIncludingSalesTax = group.Add(new VocabularyKey(nameof(IsCashDiscountCalculatedOnAmountIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCheckInvoiceNumberUsed = group.Add(new VocabularyKey(nameof(IsCheckInvoiceNumberUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckTheTaxInvoiceNumberUsed = group.Add(new VocabularyKey(nameof(CheckTheTaxInvoiceNumberUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteAsCorrection = group.Add(new VocabularyKey(nameof(CreditNoteAsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditMaxCheck = group.Add(new VocabularyKey(nameof(CreditMaxCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSettlementTypeForCreditNotes = group.Add(new VocabularyKey(nameof(DefaultSettlementTypeForCreditNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVend = group.Add(new VocabularyKey(nameof(DefaultVend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayPriceTotalMatchIcon = group.Add(new VocabularyKey(nameof(DisplayPriceTotalMatchIcon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayMiscChargeToleranceIcon = group.Add(new VocabularyKey(nameof(DisplayMiscChargeToleranceIcon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayPriceMatchIcon = group.Add(new VocabularyKey(nameof(DisplayPriceMatchIcon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayInvoiceTotalsMatchIcon = group.Add(new VocabularyKey(nameof(DisplayInvoiceTotalsMatchIcon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrintTransportationDetails = group.Add(new VocabularyKey(nameof(IsPrintTransportationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlePeriod = group.Add(new VocabularyKey(nameof(SettlePeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceTotalTolerance = group.Add(new VocabularyKey(nameof(PurchasePriceTotalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceTotalTolerancePercent = group.Add(new VocabularyKey(nameof(PurchasePriceTotalTolerancePercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactureIssuePeriod = group.Add(new VocabularyKey(nameof(FactureIssuePeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeepSalesTaxAdjustmentsForPOInvoices = group.Add(new VocabularyKey(nameof(KeepSalesTaxAdjustmentsForPOInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumberRequirement = group.Add(new VocabularyKey(nameof(TaxExemptNumberRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MandatoryTaxGroup = group.Add(new VocabularyKey(nameof(MandatoryTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MandatoryVATNum = group.Add(new VocabularyKey(nameof(MandatoryVATNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineMatchingPolicy = group.Add(new VocabularyKey(nameof(LineMatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMatchingPolicyOverride = group.Add(new VocabularyKey(nameof(AllowMatchingPolicyOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPennyDifference = group.Add(new VocabularyKey(nameof(MaximumPennyDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumOverpaymentOrUnderpayment = group.Add(new VocabularyKey(nameof(MaximumOverpaymentOrUnderpayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DifferentialJournalName = group.Add(new VocabularyKey(nameof(DifferentialJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseJournalName = group.Add(new VocabularyKey(nameof(ExpenseJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualPosting = group.Add(new VocabularyKey(nameof(ManualPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualAccount = group.Add(new VocabularyKey(nameof(AccrualAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyExpenseAccount = group.Add(new VocabularyKey(nameof(RoyaltyExpenseAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartingDayOfWeek = group.Add(new VocabularyKey(nameof(StartingDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesTolerancePercentage = group.Add(new VocabularyKey(nameof(ChargesTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarnIfPaymentProposalUsesMultipleMethodsOfPayment = group.Add(new VocabularyKey(nameof(WarnIfPaymentProposalUsesMultipleMethodsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationsOnPromissoryNotesJournals = group.Add(new VocabularyKey(nameof(ValidationsOnPromissoryNotesJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponseToInvoicesThatFailValidation = group.Add(new VocabularyKey(nameof(ResponseToInvoicesThatFailValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostToChargeAccountInLedger = group.Add(new VocabularyKey(nameof(PostToChargeAccountInLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceRemit = group.Add(new VocabularyKey(nameof(InvoiceRemit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromissoryNotes = group.Add(new VocabularyKey(nameof(PromissoryNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemitPromissoryNote = group.Add(new VocabularyKey(nameof(RemitPromissoryNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostInvoiceMatchDiscrepancies = group.Add(new VocabularyKey(nameof(PostInvoiceMatchDiscrepancies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostProductReceiptInLedger = group.Add(new VocabularyKey(nameof(PostProductReceiptInLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileForPaymentJournalWithPrepayment = group.Add(new VocabularyKey(nameof(PostingProfileForPaymentJournalWithPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryRelationTaxMatrix = group.Add(new VocabularyKey(nameof(PrimaryRelationTaxMatrix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShowAmountDebitCredit = group.Add(new VocabularyKey(nameof(IsShowAmountDebitCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxOnPrepaymentInPaymentJournal = group.Add(new VocabularyKey(nameof(SalesTaxOnPrepaymentInPaymentJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceTotalsTolerancePercentage = group.Add(new VocabularyKey(nameof(InvoiceTotalsTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDocumentDate = group.Add(new VocabularyKey(nameof(UseDocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchPriceTotals = group.Add(new VocabularyKey(nameof(MatchPriceTotals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableInvoiceMatchingValidation = group.Add(new VocabularyKey(nameof(EnableInvoiceMatchingValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMatchCharges = group.Add(new VocabularyKey(nameof(IsMatchCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMatchInvoiceTotals = group.Add(new VocabularyKey(nameof(IsMatchInvoiceTotals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountOffsetAccounts = group.Add(new VocabularyKey(nameof(DiscountOffsetAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCodeForInvoiceGroups = group.Add(new VocabularyKey(nameof(DefaultCodeForInvoiceGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireDocumentDateOnVendorInvoice = group.Add(new VocabularyKey(nameof(RequireDocumentDateOnVendorInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInvoiceGroupsForThisCompany = group.Add(new VocabularyKey(nameof(UseInvoiceGroupsForThisCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomCodeForInvoiceGroups = group.Add(new VocabularyKey(nameof(CustomCodeForInvoiceGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateInvoicesInTheJournal = group.Add(new VocabularyKey(nameof(ValidateInvoicesInTheJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomCodeForWebServiceInvoices = group.Add(new VocabularyKey(nameof(CustomCodeForWebServiceInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivateInvoicePaymentGroups = group.Add(new VocabularyKey(nameof(ActivateInvoicePaymentGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeOfSalesTaxPosting = group.Add(new VocabularyKey(nameof(TimeOfSalesTaxPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsW9Validation = group.Add(new VocabularyKey(nameof(IsW9Validation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerProcurementCategory = group.Add(new VocabularyKey(nameof(BrokerProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticHeaderMatching = group.Add(new VocabularyKey(nameof(AutomaticHeaderMatching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Draft = group.Add(new VocabularyKey(nameof(Draft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchyIsSystemGenerated = group.Add(new VocabularyKey(nameof(DimensionHierarchyIsSystemGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionTreeName = group.Add(new VocabularyKey(nameof(DimensionTreeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchyType = group.Add(new VocabularyKey(nameof(DimensionHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchAgreementDimensionName = group.Add(new VocabularyKey(nameof(PurchAgreementDimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerCategoryHierarchy = group.Add(new VocabularyKey(nameof(BrokerCategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerCategoryName = group.Add(new VocabularyKey(nameof(BrokerCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerCategoryHierarchyName = group.Add(new VocabularyKey(nameof(BrokerCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualAccountDisplayValue = group.Add(new VocabularyKey(nameof(AccrualAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyExpenseAccountDisplayValue = group.Add(new VocabularyKey(nameof(RoyaltyExpenseAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseConsolidatedInvoice = group.Add(new VocabularyKey(nameof(UseConsolidatedInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdCalculateCrossCompany = group.Add(new VocabularyKey(nameof(TaxWithholdCalculateCrossCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdCompany = group.Add(new VocabularyKey(nameof(TaxWithholdCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Include3wayMatching = group.Add(new VocabularyKey(nameof(Include3wayMatching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SplitDeliveryInvoice = group.Add(new VocabularyKey(nameof(SplitDeliveryInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SplitDeliveryPackingSlip = group.Add(new VocabularyKey(nameof(SplitDeliveryPackingSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceJoiningPreventionOnPromissoryNoteJournals = group.Add(new VocabularyKey(nameof(InvoiceJoiningPreventionOnPromissoryNoteJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTreatmentOnPromissoryNoteJournals = group.Add(new VocabularyKey(nameof(DateTreatmentOnPromissoryNoteJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseFiscalDataFromInvoiceAccount = group.Add(new VocabularyKey(nameof(UseFiscalDataFromInvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchPrepayApplicationPolicy = group.Add(new VocabularyKey(nameof(PurchPrepayApplicationPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowTimeBetweenDeliveryDateAndInvoiceDate = group.Add(new VocabularyKey(nameof(CashFlowTimeBetweenDeliveryDateAndInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowTermsOfPayment = group.Add(new VocabularyKey(nameof(CashFlowTermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowTimeBetweenInvoiceDueDateAndPaymentDate = group.Add(new VocabularyKey(nameof(CashFlowTimeBetweenInvoiceDueDateAndPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowLiquidityAccountForPayments = group.Add(new VocabularyKey(nameof(CashFlowLiquidityAccountForPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowLiquidityAccountForPaymentsDisplayValue = group.Add(new VocabularyKey(nameof(CashFlowLiquidityAccountForPaymentsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowPercentageOfAmountToAllocateToCashFlowForecast = group.Add(new VocabularyKey(nameof(CashFlowPercentageOfAmountToAllocateToCashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EditCashDiscountsWhenDueDateChanged = group.Add(new VocabularyKey(nameof(EditCashDiscountsWhenDueDateChanged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFilterForVendorTransactions = group.Add(new VocabularyKey(nameof(DefaultFilterForVendorTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementWriteOffEnabled = group.Add(new VocabularyKey(nameof(SettlementWriteOffEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementWriteOffJournalName = group.Add(new VocabularyKey(nameof(SettlementWriteOffJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementWriteOffReasonCode = group.Add(new VocabularyKey(nameof(SettlementWriteOffReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeProposalIsEnabled = group.Add(new VocabularyKey(nameof(ChangeProposalIsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeProposalDataEntityBehavior = group.Add(new VocabularyKey(nameof(ChangeProposalDataEntityBehavior), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendInvoiceInUseRecoverEnable = group.Add(new VocabularyKey(nameof(VendInvoiceInUseRecoverEnable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BypassValidationOfAccountingDistributions = group.Add(new VocabularyKey(nameof(BypassValidationOfAccountingDistributions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxInvoicesPerBatch = group.Add(new VocabularyKey(nameof(MaxInvoicesPerBatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxWaitTimeForInvoiceScheduledStatus_Hours = group.Add(new VocabularyKey(nameof(MaxWaitTimeForInvoiceScheduledStatus_Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PollingInterval_Minutes = group.Add(new VocabularyKey(nameof(PollingInterval_Minutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversePrepayment = group.Add(new VocabularyKey(nameof(ReversePrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlePrepaymentVATType = group.Add(new VocabularyKey(nameof(SettlePrepaymentVATType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceHoldersPostingProfile = group.Add(new VocabularyKey(nameof(AdvanceHoldersPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceHoldersAutoSettle = group.Add(new VocabularyKey(nameof(AdvanceHoldersAutoSettle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceHoldersSettlementByDimension = group.Add(new VocabularyKey(nameof(AdvanceHoldersSettlementByDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisablePaymentIDValidation = group.Add(new VocabularyKey(nameof(DisablePaymentIDValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportFormatMappingNameQRBill = group.Add(new VocabularyKey(nameof(ImportFormatMappingNameQRBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNActivatePurchasingCard = group.Add(new VocabularyKey(nameof(PSNActivatePurchasingCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPostingDefinitionRecId = group.Add(new VocabularyKey(nameof(PSNPostingDefinitionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPostingDefinitionCode = group.Add(new VocabularyKey(nameof(PSNPostingDefinitionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RoyaltyAccrualJournalName { get; private set; }
        public VocabularyKey InvoicingPeriod { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey PrimaryDiscountPosting { get; private set; }
        public VocabularyKey PrimaryReceiptPosting { get; private set; }
        public VocabularyKey PrepaymentInvoicePostingProfile { get; private set; }
        public VocabularyKey IsAutomaticSettlement { get; private set; }
        public VocabularyKey AllocationKey { get; private set; }
        public VocabularyKey CashDiscountAdministration { get; private set; }
        public VocabularyKey IsCashDiscountCalculatedForCreditNotes { get; private set; }
        public VocabularyKey IsCashDiscountCalculatedForPartialPayments { get; private set; }
        public VocabularyKey IsCashDiscountCalculatedOnAmountIncludingSalesTax { get; private set; }
        public VocabularyKey IsCheckInvoiceNumberUsed { get; private set; }
        public VocabularyKey CheckTheTaxInvoiceNumberUsed { get; private set; }
        public VocabularyKey CreditNoteAsCorrection { get; private set; }
        public VocabularyKey CreditMaxCheck { get; private set; }
        public VocabularyKey DefaultSettlementTypeForCreditNotes { get; private set; }
        public VocabularyKey DefaultVend { get; private set; }
        public VocabularyKey DisplayPriceTotalMatchIcon { get; private set; }
        public VocabularyKey DisplayMiscChargeToleranceIcon { get; private set; }
        public VocabularyKey DisplayPriceMatchIcon { get; private set; }
        public VocabularyKey DisplayInvoiceTotalsMatchIcon { get; private set; }
        public VocabularyKey IsPrintTransportationDetails { get; private set; }
        public VocabularyKey SettlePeriod { get; private set; }
        public VocabularyKey PurchasePriceTotalTolerance { get; private set; }
        public VocabularyKey PurchasePriceTotalTolerancePercent { get; private set; }
        public VocabularyKey FactureIssuePeriod { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey KeepSalesTaxAdjustmentsForPOInvoices { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey TaxExemptNumberRequirement { get; private set; }
        public VocabularyKey MandatoryTaxGroup { get; private set; }
        public VocabularyKey MandatoryVATNum { get; private set; }
        public VocabularyKey LineMatchingPolicy { get; private set; }
        public VocabularyKey AllowMatchingPolicyOverride { get; private set; }
        public VocabularyKey MaximumPennyDifference { get; private set; }
        public VocabularyKey MaximumOverpaymentOrUnderpayment { get; private set; }
        public VocabularyKey DifferentialJournalName { get; private set; }
        public VocabularyKey ExpenseJournalName { get; private set; }
        public VocabularyKey ManualPosting { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
        public VocabularyKey AccrualAccount { get; private set; }
        public VocabularyKey RoyaltyExpenseAccount { get; private set; }
        public VocabularyKey StartingDayOfWeek { get; private set; }
        public VocabularyKey ChargesTolerancePercentage { get; private set; }
        public VocabularyKey WarnIfPaymentProposalUsesMultipleMethodsOfPayment { get; private set; }
        public VocabularyKey ValidationsOnPromissoryNotesJournals { get; private set; }
        public VocabularyKey ResponseToInvoicesThatFailValidation { get; private set; }
        public VocabularyKey PostToChargeAccountInLedger { get; private set; }
        public VocabularyKey InvoiceRemit { get; private set; }
        public VocabularyKey PromissoryNotes { get; private set; }
        public VocabularyKey RemitPromissoryNote { get; private set; }
        public VocabularyKey PostInvoiceMatchDiscrepancies { get; private set; }
        public VocabularyKey PostProductReceiptInLedger { get; private set; }
        public VocabularyKey PostingProfileForPaymentJournalWithPrepayment { get; private set; }
        public VocabularyKey PrimaryRelationTaxMatrix { get; private set; }
        public VocabularyKey AccountStructure { get; private set; }
        public VocabularyKey FinancialDimension { get; private set; }
        public VocabularyKey IsShowAmountDebitCredit { get; private set; }
        public VocabularyKey SalesTaxOnPrepaymentInPaymentJournal { get; private set; }
        public VocabularyKey InvoiceTotalsTolerancePercentage { get; private set; }
        public VocabularyKey UseDocumentDate { get; private set; }
        public VocabularyKey MatchPriceTotals { get; private set; }
        public VocabularyKey EnableInvoiceMatchingValidation { get; private set; }
        public VocabularyKey IsMatchCharges { get; private set; }
        public VocabularyKey IsMatchInvoiceTotals { get; private set; }
        public VocabularyKey DiscountOffsetAccounts { get; private set; }
        public VocabularyKey DefaultCodeForInvoiceGroups { get; private set; }
        public VocabularyKey RequireDocumentDateOnVendorInvoice { get; private set; }
        public VocabularyKey UseInvoiceGroupsForThisCompany { get; private set; }
        public VocabularyKey CustomCodeForInvoiceGroups { get; private set; }
        public VocabularyKey ValidateInvoicesInTheJournal { get; private set; }
        public VocabularyKey CustomCodeForWebServiceInvoices { get; private set; }
        public VocabularyKey ActivateInvoicePaymentGroups { get; private set; }
        public VocabularyKey TimeOfSalesTaxPosting { get; private set; }
        public VocabularyKey IsW9Validation { get; private set; }
        public VocabularyKey BrokerProcurementCategory { get; private set; }
        public VocabularyKey AutomaticHeaderMatching { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey Draft { get; private set; }
        public VocabularyKey DimensionHierarchyIsSystemGenerated { get; private set; }
        public VocabularyKey DimensionTreeName { get; private set; }
        public VocabularyKey DimensionHierarchyType { get; private set; }
        public VocabularyKey PurchAgreementDimensionName { get; private set; }
        public VocabularyKey BrokerCategoryHierarchy { get; private set; }
        public VocabularyKey BrokerCategoryName { get; private set; }
        public VocabularyKey BrokerCategoryHierarchyName { get; private set; }
        public VocabularyKey AccrualAccountDisplayValue { get; private set; }
        public VocabularyKey RoyaltyExpenseAccountDisplayValue { get; private set; }
        public VocabularyKey UseConsolidatedInvoice { get; private set; }
        public VocabularyKey TaxWithholdCalculateCrossCompany { get; private set; }
        public VocabularyKey TaxWithholdCompany { get; private set; }
        public VocabularyKey Include3wayMatching { get; private set; }
        public VocabularyKey SplitDeliveryInvoice { get; private set; }
        public VocabularyKey SplitDeliveryPackingSlip { get; private set; }
        public VocabularyKey InvoiceJoiningPreventionOnPromissoryNoteJournals { get; private set; }
        public VocabularyKey DateTreatmentOnPromissoryNoteJournals { get; private set; }
        public VocabularyKey UseFiscalDataFromInvoiceAccount { get; private set; }
        public VocabularyKey PurchPrepayApplicationPolicy { get; private set; }
        public VocabularyKey CashFlowTimeBetweenDeliveryDateAndInvoiceDate { get; private set; }
        public VocabularyKey CashFlowTermsOfPayment { get; private set; }
        public VocabularyKey CashFlowTimeBetweenInvoiceDueDateAndPaymentDate { get; private set; }
        public VocabularyKey CashFlowLiquidityAccountForPayments { get; private set; }
        public VocabularyKey CashFlowLiquidityAccountForPaymentsDisplayValue { get; private set; }
        public VocabularyKey CashFlowPercentageOfAmountToAllocateToCashFlowForecast { get; private set; }
        public VocabularyKey EditCashDiscountsWhenDueDateChanged { get; private set; }
        public VocabularyKey DefaultFilterForVendorTransactions { get; private set; }
        public VocabularyKey SettlementWriteOffEnabled { get; private set; }
        public VocabularyKey SettlementWriteOffJournalName { get; private set; }
        public VocabularyKey SettlementWriteOffReasonCode { get; private set; }
        public VocabularyKey ChangeProposalIsEnabled { get; private set; }
        public VocabularyKey ChangeProposalDataEntityBehavior { get; private set; }
        public VocabularyKey VendInvoiceInUseRecoverEnable { get; private set; }
        public VocabularyKey BypassValidationOfAccountingDistributions { get; private set; }
        public VocabularyKey MaxInvoicesPerBatch { get; private set; }
        public VocabularyKey MaxWaitTimeForInvoiceScheduledStatus_Hours { get; private set; }
        public VocabularyKey PollingInterval_Minutes { get; private set; }
        public VocabularyKey ReversePrepayment { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey SettlePrepaymentVATType { get; private set; }
        public VocabularyKey AdvanceHoldersPostingProfile { get; private set; }
        public VocabularyKey AdvanceHoldersAutoSettle { get; private set; }
        public VocabularyKey AdvanceHoldersSettlementByDimension { get; private set; }
        public VocabularyKey DisablePaymentIDValidation { get; private set; }
        public VocabularyKey ImportFormatMappingNameQRBill { get; private set; }
        public VocabularyKey PSNActivatePurchasingCard { get; private set; }
        public VocabularyKey PSNPostingDefinitionRecId { get; private set; }
        public VocabularyKey PSNPostingDefinitionCode { get; private set; }
    }
}