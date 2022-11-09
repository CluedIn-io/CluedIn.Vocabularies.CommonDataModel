using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerParametersEntityVocabulary : SimpleVocabulary
    {
        public CustomerParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerParametersEntity";
            KeyPrefix = "commonDataModel.customerparametersentity";
            KeySeparator = ".";
            Grouping = "/CustomerParametersEntity";

            AddGroup("Common Data Model CustomerParametersEntity Details", group =>
            {
                CustomerDefaultOneTimeAccount = group.Add(new VocabularyKey(nameof(CustomerDefaultOneTimeAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerIsTaxGroupMandatory = group.Add(new VocabularyKey(nameof(CustomerIsTaxGroupMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerMinimumRefund = group.Add(new VocabularyKey(nameof(CustomerMinimumRefund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerTaxExemptNumberRequirement = group.Add(new VocabularyKey(nameof(CustomerTaxExemptNumberRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerIsConsolidatedInvoiceUsed = group.Add(new VocabularyKey(nameof(CustomerIsConsolidatedInvoiceUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerIsBillingClassificationUsed = group.Add(new VocabularyKey(nameof(CustomerIsBillingClassificationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerPostingProfile = group.Add(new VocabularyKey(nameof(GeneralLedgerPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerPostingAccountForConsumption = group.Add(new VocabularyKey(nameof(GeneralLedgerPostingAccountForConsumption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerPostingAccountForDiscount = group.Add(new VocabularyKey(nameof(GeneralLedgerPostingAccountForDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerPostingAccountForRevenue = group.Add(new VocabularyKey(nameof(GeneralLedgerPostingAccountForRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerDefaultDimensionHierarchy = group.Add(new VocabularyKey(nameof(GeneralLedgerDefaultDimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerIsAmountDebitCreditShown = group.Add(new VocabularyKey(nameof(GeneralLedgerIsAmountDebitCreditShown), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GiroAccountPositions = group.Add(new VocabularyKey(nameof(GiroAccountPositions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsValidationOnBillOfExchangeJournalsEnabled = group.Add(new VocabularyKey(nameof(IsValidationOnBillOfExchangeJournalsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDateTreatmentOfBillOfExchangeJournalsEnabled = group.Add(new VocabularyKey(nameof(IsDateTreatmentOfBillOfExchangeJournalsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementAutoSettleEnabled = group.Add(new VocabularyKey(nameof(SettlementAutoSettleEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementMaximumPennyDifference = group.Add(new VocabularyKey(nameof(SettlementMaximumPennyDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementMaximumOverUnderPayment = group.Add(new VocabularyKey(nameof(SettlementMaximumOverUnderPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementIsPriorityUsed = group.Add(new VocabularyKey(nameof(SettlementIsPriorityUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementIsPriorityUsedOnAutoSettlement = group.Add(new VocabularyKey(nameof(SettlementIsPriorityUsedOnAutoSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementMarkOpenInvoiceLine = group.Add(new VocabularyKey(nameof(SettlementMarkOpenInvoiceLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementInvoiceLinePrioritizationMethod = group.Add(new VocabularyKey(nameof(SettlementInvoiceLinePrioritizationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementSpanBillingCodeAcrossInvoices = group.Add(new VocabularyKey(nameof(SettlementSpanBillingCodeAcrossInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementProrationTypeForInvoices = group.Add(new VocabularyKey(nameof(SettlementProrationTypeForInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountAdministration = group.Add(new VocabularyKey(nameof(CashDiscountAdministration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountReasonCode = group.Add(new VocabularyKey(nameof(CashDiscountReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountIsCreditNotePosted = group.Add(new VocabularyKey(nameof(CashDiscountIsCreditNotePosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountIsCalculatedForCreditNotes = group.Add(new VocabularyKey(nameof(CashDiscountIsCalculatedForCreditNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountIsCalculatedForPartialPayments = group.Add(new VocabularyKey(nameof(CashDiscountIsCalculatedForPartialPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountIsCalculatedOnAmountInclSalesTax = group.Add(new VocabularyKey(nameof(CashDiscountIsCalculatedOnAmountInclSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountIsCalculatedOnPosting = group.Add(new VocabularyKey(nameof(TotalDiscountIsCalculatedOnPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterCodeUpdate = group.Add(new VocabularyKey(nameof(CollectionLetterCodeUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterDisputedTransactionsExcluded = group.Add(new VocabularyKey(nameof(CollectionLetterDisputedTransactionsExcluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterIgnoreCreditTransactionCodes = group.Add(new VocabularyKey(nameof(CollectionLetterIgnoreCreditTransactionCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterGenerationLevel = group.Add(new VocabularyKey(nameof(CollectionLetterGenerationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsAgencyTaxRate = group.Add(new VocabularyKey(nameof(CollectionsAgencyTaxRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsGracePeriodForDuesTransfer = group.Add(new VocabularyKey(nameof(CollectionsGracePeriodForDuesTransfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsIsReferToCollectionAgencyEnabled = group.Add(new VocabularyKey(nameof(CollectionsIsReferToCollectionAgencyEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsTransactionsToContactEmailTemplateId = group.Add(new VocabularyKey(nameof(CollectionsTransactionsToContactEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsTeamRecId = group.Add(new VocabularyKey(nameof(CollectionsTeamRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsTeamPartyNumber = group.Add(new VocabularyKey(nameof(CollectionsTeamPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsTransactionsToSalespersonEmailTemplateId = group.Add(new VocabularyKey(nameof(CollectionsTransactionsToSalespersonEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsStatementToContactEmailTemplateId = group.Add(new VocabularyKey(nameof(CollectionsStatementToContactEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsAgingPeriodDefinition = group.Add(new VocabularyKey(nameof(CollectionsAgingPeriodDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsWriteOffLedgerJournalName = group.Add(new VocabularyKey(nameof(CollectionsWriteOffLedgerJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsWriteOffIsSalesTaxSeparated = group.Add(new VocabularyKey(nameof(CollectionsWriteOffIsSalesTaxSeparated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitDefaultDaysForFirstPrenotification = group.Add(new VocabularyKey(nameof(DirectDebitDefaultDaysForFirstPrenotification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitDefaultDaysForRecurringPrenotification = group.Add(new VocabularyKey(nameof(DirectDebitDefaultDaysForRecurringPrenotification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitB2BSchemeDefaultDaysForRecurringBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitB2BSchemeDefaultDaysForRecurringBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitB2BSchemeDefaultDaysForFirstBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitB2BSchemeDefaultDaysForFirstBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitCor1SchemeDefaultDaysForFirstBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitCor1SchemeDefaultDaysForFirstBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitCor1SchemeDefaultDaysForRecurringBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitCor1SchemeDefaultDaysForRecurringBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitCoreSchemeDefaultDaysForFirstBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitCoreSchemeDefaultDaysForFirstBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitCoreSchemeDefaultDaysForRecurringBankSubmission = group.Add(new VocabularyKey(nameof(DirectDebitCoreSchemeDefaultDaysForRecurringBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebitMandateDefaultExpirationInMonths = group.Add(new VocabularyKey(nameof(DirectDebitMandateDefaultExpirationInMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardCostCenterDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(CreditCardCostCenterDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardCostCenterDimensionAttribute = group.Add(new VocabularyKey(nameof(CreditCardCostCenterDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardEstimatedShippingChargeMaximum = group.Add(new VocabularyKey(nameof(CreditCardEstimatedShippingChargeMaximum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardEstimatedShippingChargeType = group.Add(new VocabularyKey(nameof(CreditCardEstimatedShippingChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardEstimatedShippingChargeValue = group.Add(new VocabularyKey(nameof(CreditCardEstimatedShippingChargeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardNotes = group.Add(new VocabularyKey(nameof(CreditCardNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardPostingBankTransactionType = group.Add(new VocabularyKey(nameof(CreditCardPostingBankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardAuthorization = group.Add(new VocabularyKey(nameof(CreditCardAuthorization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardAuthorizationLastNumberOfDays = group.Add(new VocabularyKey(nameof(CreditCardAuthorizationLastNumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardPostingAccountType = group.Add(new VocabularyKey(nameof(CreditCardPostingAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardPostingLedgerDimension = group.Add(new VocabularyKey(nameof(CreditCardPostingLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardPostingLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CreditCardPostingLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceIsCreditNotePostedAsCorrection = group.Add(new VocabularyKey(nameof(InvoiceIsCreditNotePostedAsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceTaxExemptNumberRequirement = group.Add(new VocabularyKey(nameof(InvoiceTaxExemptNumberRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreeTextInvoiceIsItemTaxGroupMandatory = group.Add(new VocabularyKey(nameof(FreeTextInvoiceIsItemTaxGroupMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreeTextInvoiceIsProjectEnabled = group.Add(new VocabularyKey(nameof(FreeTextInvoiceIsProjectEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreeTextInvoiceCanEditLedgerAccountForProject = group.Add(new VocabularyKey(nameof(FreeTextInvoiceCanEditLedgerAccountForProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimitCheckType = group.Add(new VocabularyKey(nameof(CreditLimitCheckType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimitIsCheckedOnSalesOrder = group.Add(new VocabularyKey(nameof(CreditLimitIsCheckedOnSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimitIsCheckedOnFreeTextInvoice = group.Add(new VocabularyKey(nameof(CreditLimitIsCheckedOnFreeTextInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimitMessageTypeShownWhenExceeding = group.Add(new VocabularyKey(nameof(CreditLimitMessageTypeShownWhenExceeding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestAdjustmentDateToUse = group.Add(new VocabularyKey(nameof(InterestAdjustmentDateToUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestTransactionsToCalculateFor = group.Add(new VocabularyKey(nameof(InterestTransactionsToCalculateFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestMinimumDaysToAllowWaiving = group.Add(new VocabularyKey(nameof(InterestMinimumDaysToAllowWaiving), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestMaximumDaysAllowedToWaive = group.Add(new VocabularyKey(nameof(InterestMaximumDaysAllowedToWaive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryCertificateIsIssuingEnabled = group.Add(new VocabularyKey(nameof(EntryCertificateIsIssuingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryCertificateIsManagementEnabled = group.Add(new VocabularyKey(nameof(EntryCertificateIsManagementEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicePrintCreditInvoicingLayout = group.Add(new VocabularyKey(nameof(InvoicePrintCreditInvoicingLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicePrintPackagingWeight = group.Add(new VocabularyKey(nameof(InvoicePrintPackagingWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfExchangePostingProfile = group.Add(new VocabularyKey(nameof(BillOfExchangePostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfExchangePostingProfileForEndorsed = group.Add(new VocabularyKey(nameof(BillOfExchangePostingProfileForEndorsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfExchangePostingProfileForProtested = group.Add(new VocabularyKey(nameof(BillOfExchangePostingProfileForProtested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfExchangePostingProfileForRemitCollection = group.Add(new VocabularyKey(nameof(BillOfExchangePostingProfileForRemitCollection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfExchangePostingProfileForRemitDiscount = group.Add(new VocabularyKey(nameof(BillOfExchangePostingProfileForRemitDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentProposalWarnWhenMultipleMethodsOfPayment = group.Add(new VocabularyKey(nameof(PaymentProposalWarnWhenMultipleMethodsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrepaymentPostingProfile = group.Add(new VocabularyKey(nameof(PrepaymentPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrepaymentCalculateTax = group.Add(new VocabularyKey(nameof(PrepaymentCalculateTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TAMDeductionRequireFullSettle = group.Add(new VocabularyKey(nameof(TAMDeductionRequireFullSettle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TAMDeductionType = group.Add(new VocabularyKey(nameof(TAMDeductionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TAMRebatePosting = group.Add(new VocabularyKey(nameof(TAMRebatePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceDetailsEnabledForSalesDocuments = group.Add(new VocabularyKey(nameof(PriceDetailsEnabledForSalesDocuments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonRequirementForCreditNotes = group.Add(new VocabularyKey(nameof(ReasonRequirementForCreditNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonRequirementForPaymentCancellation = group.Add(new VocabularyKey(nameof(ReasonRequirementForPaymentCancellation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonRequirementForReturnOrders = group.Add(new VocabularyKey(nameof(ReasonRequirementForReturnOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonRequirementForTransactionReversals = group.Add(new VocabularyKey(nameof(ReasonRequirementForTransactionReversals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntegrationWithTaxSystemEnabled = group.Add(new VocabularyKey(nameof(IsIntegrationWithTaxSystemEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerEnableCancelPostingProfiles = group.Add(new VocabularyKey(nameof(GeneralLedgerEnableCancelPostingProfiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLedgerEnableReturnPostingProfiles = group.Add(new VocabularyKey(nameof(GeneralLedgerEnableReturnPostingProfiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionsWriteOffReasonCode = group.Add(new VocabularyKey(nameof(CollectionsWriteOffReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableDateOfVATRegisterChanging = group.Add(new VocabularyKey(nameof(EnableDateOfVATRegisterChanging), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseFiscalDataFromInvoiceAccount = group.Add(new VocabularyKey(nameof(UseFiscalDataFromInvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryRelation = group.Add(new VocabularyKey(nameof(PrimaryRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowTimeBetweenDeliveryDateAndInvoiceDate = group.Add(new VocabularyKey(nameof(CashFlowTimeBetweenDeliveryDateAndInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowTermsOfPayment = group.Add(new VocabularyKey(nameof(CashFlowTermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowTimeBetweenInvoiceDueDateAndPaymentDate = group.Add(new VocabularyKey(nameof(CashFlowTimeBetweenInvoiceDueDateAndPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowLiquidityAccountForPayments = group.Add(new VocabularyKey(nameof(CashFlowLiquidityAccountForPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowLiquidityAccountForPaymentsDisplayValue = group.Add(new VocabularyKey(nameof(CashFlowLiquidityAccountForPaymentsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowPercentageOfAmountToAllocateToCashFlowForecast = group.Add(new VocabularyKey(nameof(CashFlowPercentageOfAmountToAllocateToCashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EditCashDiscountsWhenDueDateChanged = group.Add(new VocabularyKey(nameof(EditCashDiscountsWhenDueDateChanged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultFilterForCustomerTransactions = group.Add(new VocabularyKey(nameof(DefaultFilterForCustomerTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementWriteOffEnabled = group.Add(new VocabularyKey(nameof(SettlementWriteOffEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementWriteOffReasonCode = group.Add(new VocabularyKey(nameof(SettlementWriteOffReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementWriteOffJournalName = group.Add(new VocabularyKey(nameof(SettlementWriteOffJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChangeProposalIsEnabled = group.Add(new VocabularyKey(nameof(ChangeProposalIsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChangeProposalDataEntityBehavior = group.Add(new VocabularyKey(nameof(ChangeProposalDataEntityBehavior), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BypassValidationOfAccountingDistributions = group.Add(new VocabularyKey(nameof(BypassValidationOfAccountingDistributions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLanguage = group.Add(new VocabularyKey(nameof(DefaultLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SuppressDepreciationOfPaymentSection = group.Add(new VocabularyKey(nameof(SuppressDepreciationOfPaymentSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversePrepayment = group.Add(new VocabularyKey(nameof(ReversePrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrepaymentFactureAutoCreate = group.Add(new VocabularyKey(nameof(PrepaymentFactureAutoCreate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlePrepaymentVATType = group.Add(new VocabularyKey(nameof(SettlePrepaymentVATType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerDefaultOneTimeAccount { get; private set; }
public VocabularyKey CustomerIsTaxGroupMandatory { get; private set; }
public VocabularyKey CustomerMinimumRefund { get; private set; }
public VocabularyKey CustomerTaxExemptNumberRequirement { get; private set; }
public VocabularyKey CustomerIsConsolidatedInvoiceUsed { get; private set; }
public VocabularyKey CustomerIsBillingClassificationUsed { get; private set; }
public VocabularyKey GeneralLedgerPostingProfile { get; private set; }
public VocabularyKey GeneralLedgerPostingAccountForConsumption { get; private set; }
public VocabularyKey GeneralLedgerPostingAccountForDiscount { get; private set; }
public VocabularyKey GeneralLedgerPostingAccountForRevenue { get; private set; }
public VocabularyKey GeneralLedgerDefaultDimensionHierarchy { get; private set; }
public VocabularyKey GeneralLedgerIsAmountDebitCreditShown { get; private set; }
public VocabularyKey GiroAccountPositions { get; private set; }
public VocabularyKey IsValidationOnBillOfExchangeJournalsEnabled { get; private set; }
public VocabularyKey IsDateTreatmentOfBillOfExchangeJournalsEnabled { get; private set; }
public VocabularyKey SettlementAutoSettleEnabled { get; private set; }
public VocabularyKey SettlementMaximumPennyDifference { get; private set; }
public VocabularyKey SettlementMaximumOverUnderPayment { get; private set; }
public VocabularyKey SettlementIsPriorityUsed { get; private set; }
public VocabularyKey SettlementIsPriorityUsedOnAutoSettlement { get; private set; }
public VocabularyKey SettlementMarkOpenInvoiceLine { get; private set; }
public VocabularyKey SettlementInvoiceLinePrioritizationMethod { get; private set; }
public VocabularyKey SettlementSpanBillingCodeAcrossInvoices { get; private set; }
public VocabularyKey SettlementProrationTypeForInvoices { get; private set; }
public VocabularyKey CashDiscountAdministration { get; private set; }
public VocabularyKey CashDiscountReasonCode { get; private set; }
public VocabularyKey CashDiscountIsCreditNotePosted { get; private set; }
public VocabularyKey CashDiscountIsCalculatedForCreditNotes { get; private set; }
public VocabularyKey CashDiscountIsCalculatedForPartialPayments { get; private set; }
public VocabularyKey CashDiscountIsCalculatedOnAmountInclSalesTax { get; private set; }
public VocabularyKey TotalDiscountIsCalculatedOnPosting { get; private set; }
public VocabularyKey CollectionLetterCodeUpdate { get; private set; }
public VocabularyKey CollectionLetterDisputedTransactionsExcluded { get; private set; }
public VocabularyKey CollectionLetterIgnoreCreditTransactionCodes { get; private set; }
public VocabularyKey CollectionLetterGenerationLevel { get; private set; }
public VocabularyKey CollectionsAgencyTaxRate { get; private set; }
public VocabularyKey CollectionsGracePeriodForDuesTransfer { get; private set; }
public VocabularyKey CollectionsIsReferToCollectionAgencyEnabled { get; private set; }
public VocabularyKey CollectionsTransactionsToContactEmailTemplateId { get; private set; }
public VocabularyKey CollectionsTeamRecId { get; private set; }
public VocabularyKey CollectionsTeamPartyNumber { get; private set; }
public VocabularyKey CollectionsTransactionsToSalespersonEmailTemplateId { get; private set; }
public VocabularyKey CollectionsStatementToContactEmailTemplateId { get; private set; }
public VocabularyKey CollectionsAgingPeriodDefinition { get; private set; }
public VocabularyKey CollectionsWriteOffLedgerJournalName { get; private set; }
public VocabularyKey CollectionsWriteOffIsSalesTaxSeparated { get; private set; }
public VocabularyKey DirectDebitDefaultDaysForFirstPrenotification { get; private set; }
public VocabularyKey DirectDebitDefaultDaysForRecurringPrenotification { get; private set; }
public VocabularyKey DirectDebitB2BSchemeDefaultDaysForRecurringBankSubmission { get; private set; }
public VocabularyKey DirectDebitB2BSchemeDefaultDaysForFirstBankSubmission { get; private set; }
public VocabularyKey DirectDebitCor1SchemeDefaultDaysForFirstBankSubmission { get; private set; }
public VocabularyKey DirectDebitCor1SchemeDefaultDaysForRecurringBankSubmission { get; private set; }
public VocabularyKey DirectDebitCoreSchemeDefaultDaysForFirstBankSubmission { get; private set; }
public VocabularyKey DirectDebitCoreSchemeDefaultDaysForRecurringBankSubmission { get; private set; }
public VocabularyKey DirectDebitMandateDefaultExpirationInMonths { get; private set; }
public VocabularyKey CreditCardCostCenterDimensionAttributeRecId { get; private set; }
public VocabularyKey CreditCardCostCenterDimensionAttribute { get; private set; }
public VocabularyKey CreditCardEstimatedShippingChargeMaximum { get; private set; }
public VocabularyKey CreditCardEstimatedShippingChargeType { get; private set; }
public VocabularyKey CreditCardEstimatedShippingChargeValue { get; private set; }
public VocabularyKey CreditCardNotes { get; private set; }
public VocabularyKey CreditCardPostingBankTransactionType { get; private set; }
public VocabularyKey CreditCardAuthorization { get; private set; }
public VocabularyKey CreditCardAuthorizationLastNumberOfDays { get; private set; }
public VocabularyKey CreditCardPostingAccountType { get; private set; }
public VocabularyKey CreditCardPostingLedgerDimension { get; private set; }
public VocabularyKey CreditCardPostingLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey InvoiceIsCreditNotePostedAsCorrection { get; private set; }
public VocabularyKey InvoiceTaxExemptNumberRequirement { get; private set; }
public VocabularyKey FreeTextInvoiceIsItemTaxGroupMandatory { get; private set; }
public VocabularyKey FreeTextInvoiceIsProjectEnabled { get; private set; }
public VocabularyKey FreeTextInvoiceCanEditLedgerAccountForProject { get; private set; }
public VocabularyKey CreditLimitCheckType { get; private set; }
public VocabularyKey CreditLimitIsCheckedOnSalesOrder { get; private set; }
public VocabularyKey CreditLimitIsCheckedOnFreeTextInvoice { get; private set; }
public VocabularyKey CreditLimitMessageTypeShownWhenExceeding { get; private set; }
public VocabularyKey InterestAdjustmentDateToUse { get; private set; }
public VocabularyKey InterestTransactionsToCalculateFor { get; private set; }
public VocabularyKey InterestMinimumDaysToAllowWaiving { get; private set; }
public VocabularyKey InterestMaximumDaysAllowedToWaive { get; private set; }
public VocabularyKey EntryCertificateIsIssuingEnabled { get; private set; }
public VocabularyKey EntryCertificateIsManagementEnabled { get; private set; }
public VocabularyKey InvoicePrintCreditInvoicingLayout { get; private set; }
public VocabularyKey InvoicePrintPackagingWeight { get; private set; }
public VocabularyKey BillOfExchangePostingProfile { get; private set; }
public VocabularyKey BillOfExchangePostingProfileForEndorsed { get; private set; }
public VocabularyKey BillOfExchangePostingProfileForProtested { get; private set; }
public VocabularyKey BillOfExchangePostingProfileForRemitCollection { get; private set; }
public VocabularyKey BillOfExchangePostingProfileForRemitDiscount { get; private set; }
public VocabularyKey PaymentProposalWarnWhenMultipleMethodsOfPayment { get; private set; }
public VocabularyKey PrepaymentPostingProfile { get; private set; }
public VocabularyKey PrepaymentCalculateTax { get; private set; }
public VocabularyKey TAMDeductionRequireFullSettle { get; private set; }
public VocabularyKey TAMDeductionType { get; private set; }
public VocabularyKey TAMRebatePosting { get; private set; }
public VocabularyKey PriceDetailsEnabledForSalesDocuments { get; private set; }
public VocabularyKey ReasonRequirementForCreditNotes { get; private set; }
public VocabularyKey ReasonRequirementForPaymentCancellation { get; private set; }
public VocabularyKey ReasonRequirementForReturnOrders { get; private set; }
public VocabularyKey ReasonRequirementForTransactionReversals { get; private set; }
public VocabularyKey IsIntegrationWithTaxSystemEnabled { get; private set; }
public VocabularyKey GeneralLedgerEnableCancelPostingProfiles { get; private set; }
public VocabularyKey GeneralLedgerEnableReturnPostingProfiles { get; private set; }
public VocabularyKey CollectionsWriteOffReasonCode { get; private set; }
public VocabularyKey EnableDateOfVATRegisterChanging { get; private set; }
public VocabularyKey UseFiscalDataFromInvoiceAccount { get; private set; }
public VocabularyKey PrimaryRelation { get; private set; }
public VocabularyKey CashFlowTimeBetweenDeliveryDateAndInvoiceDate { get; private set; }
public VocabularyKey CashFlowTermsOfPayment { get; private set; }
public VocabularyKey CashFlowTimeBetweenInvoiceDueDateAndPaymentDate { get; private set; }
public VocabularyKey CashFlowLiquidityAccountForPayments { get; private set; }
public VocabularyKey CashFlowLiquidityAccountForPaymentsDisplayValue { get; private set; }
public VocabularyKey CashFlowPercentageOfAmountToAllocateToCashFlowForecast { get; private set; }
public VocabularyKey EditCashDiscountsWhenDueDateChanged { get; private set; }
public VocabularyKey DefaultFilterForCustomerTransactions { get; private set; }
public VocabularyKey SettlementWriteOffEnabled { get; private set; }
public VocabularyKey SettlementWriteOffReasonCode { get; private set; }
public VocabularyKey SettlementWriteOffJournalName { get; private set; }
public VocabularyKey ChangeProposalIsEnabled { get; private set; }
public VocabularyKey ChangeProposalDataEntityBehavior { get; private set; }
public VocabularyKey BypassValidationOfAccountingDistributions { get; private set; }
public VocabularyKey DefaultLanguage { get; private set; }
public VocabularyKey SuppressDepreciationOfPaymentSection { get; private set; }
public VocabularyKey ReversePrepayment { get; private set; }
public VocabularyKey TaxGroup { get; private set; }
public VocabularyKey TaxItemGroup { get; private set; }
public VocabularyKey PrepaymentFactureAutoCreate { get; private set; }
public VocabularyKey SettlePrepaymentVATType { get; private set; }


    }
}