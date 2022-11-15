using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderCreationAndDemandConsolidationPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderCreationAndDemandConsolidationPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Order Creation And Demand Consolidation Policy Rule Entity";
            KeyPrefix = "commonDataModel.purchpurchaseordercreationanddemandconsolidationpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderCreationAndDemandConsolidationPolicyRuleEntity";

            AddGroup("PurchPurchaseOrderCreationAndDemandConsolidationPolicyRuleEntity Details", group =>
            {
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPriceDiscountTransferRuleOverrideAllowed = group.Add(new VocabularyKey(nameof(IsPriceDiscountTransferRuleOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionPriceToleranceErrorProcessingRule = group.Add(new VocabularyKey(nameof(PurchaseRequisitionPriceToleranceErrorProcessingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticPurchaseOrderCreationBatchJobEnabled = group.Add(new VocabularyKey(nameof(IsAutomaticPurchaseOrderCreationBatchJobEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionPriceDiscountTransferRule = group.Add(new VocabularyKey(nameof(PurchaseRequisitionPriceDiscountTransferRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderLineProductDescriptionTransferRule = group.Add(new VocabularyKey(nameof(PurchaseOrderLineProductDescriptionTransferRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseReqInternalCatalogItemMaximumPriceToleranceAmount = group.Add(new VocabularyKey(nameof(PurchaseReqInternalCatalogItemMaximumPriceToleranceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseReqInternalCatalogItemMaximumPriceToleranceAmountCurrencyCode = group.Add(new VocabularyKey(nameof(PurchaseReqInternalCatalogItemMaximumPriceToleranceAmountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseRequisitionInternalCatalogItemMaximumPriceToleranceAmountEnabled = group.Add(new VocabularyKey(nameof(IsPurchaseRequisitionInternalCatalogItemMaximumPriceToleranceAmountEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentageEnabled = group.Add(new VocabularyKey(nameof(IsPurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentageEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnablePriceTolerance = group.Add(new VocabularyKey(nameof(EnablePriceTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentage = group.Add(new VocabularyKey(nameof(PurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchaseOrdersRequisitionLineTypeSpecific = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersRequisitionLineTypeSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchaseOrdersRequisitionProcurementProductCategorySpecific = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersRequisitionProcurementProductCategorySpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchaseOrdersRequisitionRequesterSpecific = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersRequisitionRequesterSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationExternalCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationExternalCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationInternalCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationInternalCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationNonCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationNonCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticPurchaseOrderCreationExcludePrepaidPurchaseRequisitionLines = group.Add(new VocabularyKey(nameof(WillAutomaticPurchaseOrderCreationExcludePrepaidPurchaseRequisitionLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualPurchaseOrderCreationRule = group.Add(new VocabularyKey(nameof(ManualPurchaseOrderCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseRequisitionApprovalMergeVendorFinancialDimensions = group.Add(new VocabularyKey(nameof(WillPurchaseRequisitionApprovalMergeVendorFinancialDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandConsolidationExternalCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(DemandConsolidationExternalCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandConsolidationInternalCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(DemandConsolidationInternalCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandConsolidationNonCatalogItemExceptionRule = group.Add(new VocabularyKey(nameof(DemandConsolidationNonCatalogItemExceptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandConsolidationRule = group.Add(new VocabularyKey(nameof(DemandConsolidationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey IsPriceDiscountTransferRuleOverrideAllowed { get; private set; }
        public VocabularyKey PurchaseRequisitionPriceToleranceErrorProcessingRule { get; private set; }
        public VocabularyKey IsAutomaticPurchaseOrderCreationBatchJobEnabled { get; private set; }
        public VocabularyKey PurchaseRequisitionPriceDiscountTransferRule { get; private set; }
        public VocabularyKey PurchaseOrderLineProductDescriptionTransferRule { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey PurchaseReqInternalCatalogItemMaximumPriceToleranceAmount { get; private set; }
        public VocabularyKey PurchaseReqInternalCatalogItemMaximumPriceToleranceAmountCurrencyCode { get; private set; }
        public VocabularyKey IsPurchaseRequisitionInternalCatalogItemMaximumPriceToleranceAmountEnabled { get; private set; }
        public VocabularyKey IsPurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentageEnabled { get; private set; }
        public VocabularyKey EnablePriceTolerance { get; private set; }
        public VocabularyKey PurchaseRequisitionInternalCatalogItemMaximumPriceTolerancePercentage { get; private set; }
        public VocabularyKey ArePurchaseOrdersRequisitionLineTypeSpecific { get; private set; }
        public VocabularyKey ArePurchaseOrdersRequisitionProcurementProductCategorySpecific { get; private set; }
        public VocabularyKey ArePurchaseOrdersRequisitionRequesterSpecific { get; private set; }
        public VocabularyKey PurchaseOrderCreationExternalCatalogItemExceptionRule { get; private set; }
        public VocabularyKey PurchaseOrderCreationInternalCatalogItemExceptionRule { get; private set; }
        public VocabularyKey PurchaseOrderCreationNonCatalogItemExceptionRule { get; private set; }
        public VocabularyKey WillAutomaticPurchaseOrderCreationExcludePrepaidPurchaseRequisitionLines { get; private set; }
        public VocabularyKey ManualPurchaseOrderCreationRule { get; private set; }
        public VocabularyKey WillPurchaseRequisitionApprovalMergeVendorFinancialDimensions { get; private set; }
        public VocabularyKey DemandConsolidationExternalCatalogItemExceptionRule { get; private set; }
        public VocabularyKey DemandConsolidationInternalCatalogItemExceptionRule { get; private set; }
        public VocabularyKey DemandConsolidationNonCatalogItemExceptionRule { get; private set; }
        public VocabularyKey DemandConsolidationRule { get; private set; }
    }
}