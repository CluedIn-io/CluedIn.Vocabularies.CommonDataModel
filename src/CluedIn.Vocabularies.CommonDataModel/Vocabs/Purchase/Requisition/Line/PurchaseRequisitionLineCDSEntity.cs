using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRequisitionLineCDSEntityVocabulary : SimpleVocabulary
    {
        public PurchaseRequisitionLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchaseRequisitionLineCDSEntity";
            KeyPrefix = "commonDataModel.purchaserequisitionlinecdsentity";
            KeySeparator = ".";
            Grouping = "/PurchaseRequisitionLineCDSEntity";

            AddGroup("Common Data Model PurchaseRequisitionLineCDSEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateName = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationDocumentNumber = group.Add(new VocabularyKey(nameof(BudgetReservationDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineNumber = group.Add(new VocabularyKey(nameof(BudgetReservationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessJustificationCode = group.Add(new VocabularyKey(nameof(BusinessJustificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessJustificationDetails = group.Add(new VocabularyKey(nameof(BusinessJustificationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyingLegalEntityId = group.Add(new VocabularyKey(nameof(BuyingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAttentionInformation = group.Add(new VocabularyKey(nameof(DeliveryAttentionInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCityInKana = group.Add(new VocabularyKey(nameof(DeliveryCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetReasonCode = group.Add(new VocabularyKey(nameof(FixedAssetReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetRuleQualifierOptionName = group.Add(new VocabularyKey(nameof(FixedAssetRuleQualifierOptionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPartialDeliveryPrevented = group.Add(new VocabularyKey(nameof(IsPartialDeliveryPrevented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrepaymentRequired = group.Add(new VocabularyKey(nameof(IsPrepaymentRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrePaymentDetails = group.Add(new VocabularyKey(nameof(PrePaymentDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesUnitSymbol = group.Add(new VocabularyKey(nameof(ProjectSalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDate = group.Add(new VocabularyKey(nameof(RequestedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPurchaseQuantity = group.Add(new VocabularyKey(nameof(RequestedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequisitionerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionLineNumber = group.Add(new VocabularyKey(nameof(RequisitionLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionNumber = group.Add(new VocabularyKey(nameof(RequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQRequirementLevel = group.Add(new VocabularyKey(nameof(RFQRequirementLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingOperatingUnitPartyNumber = group.Add(new VocabularyKey(nameof(ReceivingOperatingUnitPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey AccountingDistributionTemplateName { get; private set; }
        public VocabularyKey BudgetReservationDocumentNumber { get; private set; }
        public VocabularyKey BudgetReservationLineNumber { get; private set; }
        public VocabularyKey BusinessJustificationCode { get; private set; }
        public VocabularyKey BusinessJustificationDetails { get; private set; }
        public VocabularyKey BuyingLegalEntityId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAttentionInformation { get; private set; }
        public VocabularyKey DeliveryCityInKana { get; private set; }
        public VocabularyKey DeliveryStreetInKana { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey FixedAssetReasonCode { get; private set; }
        public VocabularyKey FixedAssetRuleQualifierOptionName { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey IsPartialDeliveryPrevented { get; private set; }
        public VocabularyKey IsPrepaymentRequired { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey LineStatus { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey PrePaymentDetails { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
        public VocabularyKey ProjectSalesPrice { get; private set; }
        public VocabularyKey ProjectSalesUnitSymbol { get; private set; }
        public VocabularyKey ProjectTaxGroupCode { get; private set; }
        public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey ReceivingSiteId { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey RequestedDate { get; private set; }
        public VocabularyKey RequestedPurchaseQuantity { get; private set; }
        public VocabularyKey RequisitionerPersonnelNumber { get; private set; }
        public VocabularyKey RequisitionLineNumber { get; private set; }
        public VocabularyKey RequisitionNumber { get; private set; }
        public VocabularyKey RFQRequirementLevel { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ReceivingOperatingUnitPartyNumber { get; private set; }


    }
}