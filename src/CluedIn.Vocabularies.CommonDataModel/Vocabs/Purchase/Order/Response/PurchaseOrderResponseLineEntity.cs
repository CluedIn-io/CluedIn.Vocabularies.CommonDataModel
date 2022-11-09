using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseOrderResponseLineEntityVocabulary : SimpleVocabulary
    {
        public PurchaseOrderResponseLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchaseOrderResponseLineEntity";
            KeyPrefix = "commonDataModel.purchaseorderresponselineentity";
            KeySeparator = ".";
            Grouping = "/PurchaseOrderResponseLineEntity";

            AddGroup("Common Data Model PurchaseOrderResponseLineEntity Details", group =>
            {
                PurchaseOrderResponseLastModificationDateTime = group.Add(new VocabularyKey(nameof(PurchaseOrderResponseLastModificationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedPurchaseQuantity = group.Add(new VocabularyKey(nameof(ConfirmedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResponseLineProcessingState = group.Add(new VocabularyKey(nameof(ResponseLineProcessingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAcceptanceStatus = group.Add(new VocabularyKey(nameof(LineAcceptanceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PurchaseOrderResponseLastModificationDateTime { get; private set; }
public VocabularyKey PurchaseOrderNumber { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey RequestedDeliveryDate { get; private set; }
public VocabularyKey ConfirmedDeliveryDate { get; private set; }
public VocabularyKey ConfirmedPurchaseQuantity { get; private set; }
public VocabularyKey PurchasePrice { get; private set; }
public VocabularyKey PurchasePriceQuantity { get; private set; }
public VocabularyKey PurchaseUnitSymbol { get; private set; }
public VocabularyKey LineDiscountAmount { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey DeliveryAddressLocationId { get; private set; }
public VocabularyKey FormattedDeliveryAddress { get; private set; }
public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
public VocabularyKey DeliveryAddressCity { get; private set; }
public VocabularyKey DeliveryAddressCityInKana { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
public VocabularyKey DeliveryAddressCountyId { get; private set; }
public VocabularyKey DeliveryAddressDescription { get; private set; }
public VocabularyKey DeliveryAddressDistrictName { get; private set; }
public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
public VocabularyKey DeliveryAddressLatitude { get; private set; }
public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
public VocabularyKey DeliveryAddressLongitude { get; private set; }
public VocabularyKey DeliveryAddressPostBox { get; private set; }
public VocabularyKey DeliveryAddressStateId { get; private set; }
public VocabularyKey DeliveryAddressStreet { get; private set; }
public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
public VocabularyKey DeliveryAddressValidFrom { get; private set; }
public VocabularyKey DeliveryAddressValidTo { get; private set; }
public VocabularyKey DeliveryAddressTimeZone { get; private set; }
public VocabularyKey DeliveryAddressZipCode { get; private set; }
public VocabularyKey ReceivingWarehouseId { get; private set; }
public VocabularyKey ReceivingSiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey OrderedInventoryStatusId { get; private set; }
public VocabularyKey CatchWeightUnitSymbol { get; private set; }
public VocabularyKey ProcurementProductCategoryName { get; private set; }
public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
public VocabularyKey OrderVendorAccountNumber { get; private set; }
public VocabularyKey ResponseLineProcessingState { get; private set; }
public VocabularyKey LineAcceptanceStatus { get; private set; }
public VocabularyKey LineCreationSequenceNumber { get; private set; }


    }
}