using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendRequestForQuotationJournalLineEntityVocabulary : SimpleVocabulary
    {
        public VendRequestForQuotationJournalLineEntityVocabulary()
        {
            VocabularyName = "Vend Request For Quotation Journal Line Entity";
            KeyPrefix = "commonDataModel.vendrequestforquotationjournallineentity";
            KeySeparator = ".";
            Grouping = "/VendRequestForQuotationJournalLineEntity";

            AddGroup("VendRequestForQuotationJournalLineEntity Details", group =>
            {
                AssetValueModelId = group.Add(new VocabularyKey(nameof(AssetValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetTransactionType = group.Add(new VocabularyKey(nameof(FixedAssetTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQDeliveryDate = group.Add(new VocabularyKey(nameof(RFQDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQExpirationDateTime = group.Add(new VocabularyKey(nameof(RFQExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalRFQJournalNumber = group.Add(new VocabularyKey(nameof(InternalRFQJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemName = group.Add(new VocabularyKey(nameof(ItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmountTaxAmount = group.Add(new VocabularyKey(nameof(LineAmountTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RequestedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPurchaseQuantity = group.Add(new VocabularyKey(nameof(RequestedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedInventoryQuantity = group.Add(new VocabularyKey(nameof(RequestedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCasePlannedOrderRequirementPlanId = group.Add(new VocabularyKey(nameof(RFQCasePlannedOrderRequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PlannedPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseLineLineNumber = group.Add(new VocabularyKey(nameof(RFQCaseLineLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQJournalDate = group.Add(new VocabularyKey(nameof(RFQJournalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrintCode = group.Add(new VocabularyKey(nameof(SalesTaxPrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLineReasonComment = group.Add(new VocabularyKey(nameof(VendorLineReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLineReasonCode = group.Add(new VocabularyKey(nameof(VendorLineReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AssetValueModelId { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey FixedAssetTransactionType { get; private set; }
        public VocabularyKey RFQDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey RFQExpirationDateTime { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey InternalRFQJournalNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineAmountTaxAmount { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey MultilineDiscountAmount { get; private set; }
        public VocabularyKey MultilineDiscountPercentage { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey RequestedCatchWeightQuantity { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey RequestedPurchaseQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey RequestedInventoryQuantity { get; private set; }
        public VocabularyKey RFQCasePlannedOrderRequirementPlanId { get; private set; }
        public VocabularyKey PlannedPurchaseOrderNumber { get; private set; }
        public VocabularyKey RFQCaseLineLineNumber { get; private set; }
        public VocabularyKey RFQJournalDate { get; private set; }
        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey LineStatus { get; private set; }
        public VocabularyKey TotalTaxAmount { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey SalesTaxPrintCode { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey VendorLineReasonComment { get; private set; }
        public VocabularyKey VendorLineReasonCode { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ReceivingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}