using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderLineCDSEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderLineCDSEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderlinecdsentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderLineCDSEntity";

            AddGroup("Common Data Model PurchPurchaseOrderLineCDSEntity Details", group =>
            {
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderLineStatus = group.Add(new VocabularyKey(nameof(PurchaseOrderLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDelveryAddress = group.Add(new VocabularyKey(nameof(FormattedDelveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedPurchaseQuantity = group.Add(new VocabularyKey(nameof(OrderedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Barcode = group.Add(new VocabularyKey(nameof(Barcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPartialDeliveryPrevented = group.Add(new VocabularyKey(nameof(IsPartialDeliveryPrevented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(OrderedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierachyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierachyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterPersonnelNumber = group.Add(new VocabularyKey(nameof(RequesterPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey PurchaseOrderLineStatus { get; private set; }
        public VocabularyKey ConfirmedDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey FormattedDelveryAddress { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey OrderedPurchaseQuantity { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey Barcode { get; private set; }
        public VocabularyKey CatchWeightUnitSymbol { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey IsPartialDeliveryPrevented { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey OrderedCatchWeightQuantity { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierachyName { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ReceivingSiteId { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey RequesterPersonnelNumber { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }


    }
}