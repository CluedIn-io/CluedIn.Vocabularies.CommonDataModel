using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateAgreementHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public SalesRebateAgreementHeaderV2EntityVocabulary()
        {
            VocabularyName = "SalesRebateAgreementHeaderV2Entity";
            KeyPrefix = "commonDataModel.salesrebateagreementheaderv2entity";
            KeySeparator = ".";
            Grouping = "/SalesRebateAgreementHeaderV2Entity";

            AddGroup("SalesRebateAgreementHeaderV2Entity Details", group =>
            {
                IsTaxable = group.Add(new VocabularyKey(nameof(IsTaxable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualMainAccountId = group.Add(new VocabularyKey(nameof(AccrualMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseMainAccountId = group.Add(new VocabularyKey(nameof(ExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApprovalRequired = group.Add(new VocabularyKey(nameof(IsApprovalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCumulationMethod = group.Add(new VocabularyKey(nameof(SalesCumulationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PdsCustRebateCode = group.Add(new VocabularyKey(nameof(PdsCustRebateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PdsCustRebateRelation = group.Add(new VocabularyKey(nameof(PdsCustRebateRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateBreakBasis = group.Add(new VocabularyKey(nameof(RebateBreakBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumSalesAmountQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumSalesAmountQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumSalesQuantityQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumSalesQuantityQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmountBasis = group.Add(new VocabularyKey(nameof(LineAmountBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbolType = group.Add(new VocabularyKey(nameof(ProductUnitSymbolType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationSearchDateType = group.Add(new VocabularyKey(nameof(CalculationSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCumulationMethodCustomizedPeriodType = group.Add(new VocabularyKey(nameof(SalesCumulationMethodCustomizedPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsGenericCurrencySearchEnabled = group.Add(new VocabularyKey(nameof(IsGenericCurrencySearchEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbolOption = group.Add(new VocabularyKey(nameof(ProductUnitSymbolOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovalStatus = group.Add(new VocabularyKey(nameof(ApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatedBy = group.Add(new VocabularyKey(nameof(ValidatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ValidatingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AccrualMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateProgramId = group.Add(new VocabularyKey(nameof(RebateProgramId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingSiteId = group.Add(new VocabularyKey(nameof(QualifyingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingWarehouseId = group.Add(new VocabularyKey(nameof(QualifyingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRebateProductGroupId = group.Add(new VocabularyKey(nameof(SalesRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRebateCustomerGroupId = group.Add(new VocabularyKey(nameof(SalesRebateCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductUnitSymbolExact = group.Add(new VocabularyKey(nameof(IsProductUnitSymbolExact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSelectionUsed = group.Add(new VocabularyKey(nameof(IsProductSelectionUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementId = group.Add(new VocabularyKey(nameof(RebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsTaxable { get; private set; }
        public VocabularyKey AccrualMainAccountId { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey ExpenseMainAccountId { get; private set; }
        public VocabularyKey IsApprovalRequired { get; private set; }
        public VocabularyKey SalesCumulationMethod { get; private set; }
        public VocabularyKey PdsCustRebateCode { get; private set; }
        public VocabularyKey PdsCustRebateRelation { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey PaymentType { get; private set; }
        public VocabularyKey RebateBreakBasis { get; private set; }
        public VocabularyKey MinimumSalesAmountQualifyingRebate { get; private set; }
        public VocabularyKey MinimumSalesQuantityQualifyingRebate { get; private set; }
        public VocabularyKey LineAmountBasis { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey ProductUnitSymbolType { get; private set; }
        public VocabularyKey CalculationSearchDateType { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey SalesCumulationMethodCustomizedPeriodType { get; private set; }
        public VocabularyKey IsGenericCurrencySearchEnabled { get; private set; }
        public VocabularyKey ProductUnitSymbolOption { get; private set; }
        public VocabularyKey ApprovalStatus { get; private set; }
        public VocabularyKey IsValidated { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ValidatedBy { get; private set; }
        public VocabularyKey ValidatingWorkerPersonnelNumber { get; private set; }
        public VocabularyKey AccrualMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ExpenseMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RebateProgramId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey QualifyingSiteId { get; private set; }
        public VocabularyKey QualifyingWarehouseId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey SalesRebateProductGroupId { get; private set; }
        public VocabularyKey SalesRebateCustomerGroupId { get; private set; }
        public VocabularyKey IsProductUnitSymbolExact { get; private set; }
        public VocabularyKey IsProductSelectionUsed { get; private set; }
        public VocabularyKey RebateAgreementId { get; private set; }


    }
}