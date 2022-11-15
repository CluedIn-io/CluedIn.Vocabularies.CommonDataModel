using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMVendorRebateAgreementHeaderEntityVocabulary : SimpleVocabulary
    {
        public TAMVendorRebateAgreementHeaderEntityVocabulary()
        {
            VocabularyName = "TAM Vendor Rebate Agreement Header Entity";
            KeyPrefix = "commonDataModel.tamvendorrebateagreementheaderentity";
            KeySeparator = ".";
            Grouping = "/TAMVendorRebateAgreementHeaderEntity";

            AddGroup("TAMVendorRebateAgreementHeaderEntity Details", group =>
            {
                IsApprovalRequired = group.Add(new VocabularyKey(nameof(IsApprovalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseCumulationMethod = group.Add(new VocabularyKey(nameof(PurchaseCumulationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualMainAccountId = group.Add(new VocabularyKey(nameof(AccrualMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementNote = group.Add(new VocabularyKey(nameof(AgreementNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseMainAccountId = group.Add(new VocabularyKey(nameof(ExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseCumulationMethodCustomizedPeriodType = group.Add(new VocabularyKey(nameof(PurchaseCumulationMethodCustomizedPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateBreakBasis = group.Add(new VocabularyKey(nameof(RebateBreakBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPurchaseAmountQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumPurchaseAmountQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPurchaseQuantityQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumPurchaseQuantityQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateProgramId = group.Add(new VocabularyKey(nameof(RebateProgramId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmountBasis = group.Add(new VocabularyKey(nameof(LineAmountBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbolOption = group.Add(new VocabularyKey(nameof(ProductUnitSymbolOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbolType = group.Add(new VocabularyKey(nameof(ProductUnitSymbolType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAgreementValidated = group.Add(new VocabularyKey(nameof(IsAgreementValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationSearchDateType = group.Add(new VocabularyKey(nameof(CalculationSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRebateCode = group.Add(new VocabularyKey(nameof(VendRebateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRebateRelation = group.Add(new VocabularyKey(nameof(VendRebateRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ValidatingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowApprovalStatus = group.Add(new VocabularyKey(nameof(WorkflowApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxable = group.Add(new VocabularyKey(nameof(IsTaxable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AccrualMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingWarehouseId = group.Add(new VocabularyKey(nameof(QualifyingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingSiteId = group.Add(new VocabularyKey(nameof(QualifyingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRebateProductGroupId = group.Add(new VocabularyKey(nameof(VendorRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRebateVendorGroupId = group.Add(new VocabularyKey(nameof(VendorRebateVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementId = group.Add(new VocabularyKey(nameof(RebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSelectionUsed = group.Add(new VocabularyKey(nameof(IsProductSelectionUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductUnitSymbolExact = group.Add(new VocabularyKey(nameof(IsProductUnitSymbolExact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsApprovalRequired { get; private set; }
        public VocabularyKey PurchaseCumulationMethod { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey AccrualMainAccountId { get; private set; }
        public VocabularyKey AgreementNote { get; private set; }
        public VocabularyKey ExpenseMainAccountId { get; private set; }
        public VocabularyKey PurchaseCumulationMethodCustomizedPeriodType { get; private set; }
        public VocabularyKey RebateBreakBasis { get; private set; }
        public VocabularyKey MinimumPurchaseAmountQualifyingRebate { get; private set; }
        public VocabularyKey MinimumPurchaseQuantityQualifyingRebate { get; private set; }
        public VocabularyKey RebateProgramId { get; private set; }
        public VocabularyKey LineAmountBasis { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey ProductUnitSymbolOption { get; private set; }
        public VocabularyKey ProductUnitSymbolType { get; private set; }
        public VocabularyKey IsAgreementValidated { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey CalculationSearchDateType { get; private set; }
        public VocabularyKey VendRebateCode { get; private set; }
        public VocabularyKey VendRebateRelation { get; private set; }
        public VocabularyKey ValidatingWorkerPersonnelNumber { get; private set; }
        public VocabularyKey WorkflowApprovalStatus { get; private set; }
        public VocabularyKey IsTaxable { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey AccrualMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ExpenseMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey QualifyingWarehouseId { get; private set; }
        public VocabularyKey QualifyingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey VendorRebateProductGroupId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorRebateVendorGroupId { get; private set; }
        public VocabularyKey RebateAgreementId { get; private set; }
        public VocabularyKey IsProductSelectionUsed { get; private set; }
        public VocabularyKey IsProductUnitSymbolExact { get; private set; }
    }
}