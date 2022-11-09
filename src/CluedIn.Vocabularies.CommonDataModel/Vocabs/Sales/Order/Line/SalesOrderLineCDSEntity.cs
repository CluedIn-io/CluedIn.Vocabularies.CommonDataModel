using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderLineCDSEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderLineCDSEntity";
            KeyPrefix = "commonDataModel.salesorderlinecdsentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderLineCDSEntity";

            AddGroup("Common Data Model SalesOrderLineCDSEntity Details", group =>
            {
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderLineStatus = group.Add(new VocabularyKey(nameof(SalesOrderLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLineStopped = group.Add(new VocabularyKey(nameof(IsLineStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedSalesQuantity = group.Add(new VocabularyKey(nameof(OrderedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalChargesAmount = group.Add(new VocabularyKey(nameof(TotalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreTotalsCalculated = group.Add(new VocabularyKey(nameof(AreTotalsCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderProcessingStatus = group.Add(new VocabularyKey(nameof(SalesOrderProcessingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderingCustomerIsExternallyMaintained = group.Add(new VocabularyKey(nameof(OrderingCustomerIsExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCustomerIsExternallyMaintained = group.Add(new VocabularyKey(nameof(InvoiceCustomerIsExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreSalesOrderTotalsUpdated = group.Add(new VocabularyKey(nameof(AreSalesOrderTotalsUpdated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowedOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowedUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedReceiptDate = group.Add(new VocabularyKey(nameof(ConfirmedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderOriginType = group.Add(new VocabularyKey(nameof(SalesOrderOriginType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PickedQuantity = group.Add(new VocabularyKey(nameof(PickedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(SalesProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesOrderNumber { get; private set; }
public VocabularyKey LineCreationSequenceNumber { get; private set; }
public VocabularyKey SalesOrderLineStatus { get; private set; }
public VocabularyKey IsLineStopped { get; private set; }
public VocabularyKey DeliveryAddressName { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineDiscountAmount { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey MultilineDiscountAmount { get; private set; }
public VocabularyKey MultilineDiscountPercentage { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey SalesPriceQuantity { get; private set; }
public VocabularyKey RequestedReceiptDate { get; private set; }
public VocabularyKey FixedPriceCharges { get; private set; }
public VocabularyKey SalesPrice { get; private set; }
public VocabularyKey OrderedSalesQuantity { get; private set; }
public VocabularyKey SalesUnitSymbol { get; private set; }
public VocabularyKey ConfirmedShippingDate { get; private set; }
public VocabularyKey RequestedShippingDate { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey OrderedInventoryStatusId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey TotalTaxAmount { get; private set; }
public VocabularyKey TotalChargesAmount { get; private set; }
public VocabularyKey TotalDiscountAmount { get; private set; }
public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey AreTotalsCalculated { get; private set; }
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
public VocabularyKey DeliveryAddressPostBox { get; private set; }
public VocabularyKey DeliveryAddressStateId { get; private set; }
public VocabularyKey DeliveryAddressStreet { get; private set; }
public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
public VocabularyKey DeliveryAddressTimeZone { get; private set; }
public VocabularyKey DeliveryAddressZipCode { get; private set; }
public VocabularyKey DeliveryBuildingCompliment { get; private set; }
public VocabularyKey FormattedDeliveryAddress { get; private set; }
public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
public VocabularyKey ProductName { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey SalesOrderProcessingStatus { get; private set; }
public VocabularyKey OrderingCustomerIsExternallyMaintained { get; private set; }
public VocabularyKey InvoiceCustomerIsExternallyMaintained { get; private set; }
public VocabularyKey AreSalesOrderTotalsUpdated { get; private set; }
public VocabularyKey AllowedOverdeliveryPercentage { get; private set; }
public VocabularyKey AllowedUnderdeliveryPercentage { get; private set; }
public VocabularyKey ConfirmedReceiptDate { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey DeliveryTermsId { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey SalesOrderPromisingMethod { get; private set; }
public VocabularyKey SalesProductCategoryName { get; private set; }
public VocabularyKey SalesOrderOriginType { get; private set; }
public VocabularyKey PickedQuantity { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ProjectLinePropertyId { get; private set; }
public VocabularyKey SalesProductCategoryHierarchyName { get; private set; }
public VocabularyKey DeliveryPostalAddressRecId { get; private set; }


    }
}