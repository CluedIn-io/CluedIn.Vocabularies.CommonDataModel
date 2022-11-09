using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendProductReceiptLineEntityVocabulary : SimpleVocabulary
    {
        public VendProductReceiptLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendProductReceiptLineEntity";
            KeyPrefix = "commonDataModel.vendproductreceiptlineentity";
            KeySeparator = ".";
            Grouping = "/VendProductReceiptLineEntity";

            AddGroup("Common Data Model VendProductReceiptLineEntity Details", group =>
            {
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpectedDeliveryDate = group.Add(new VocabularyKey(nameof(ExpectedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductReceiptDate = group.Add(new VocabularyKey(nameof(ProductReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivedInventoryQuantity = group.Add(new VocabularyKey(nameof(ReceivedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedPurchaseQuantity = group.Add(new VocabularyKey(nameof(OrderedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductReceiptNumber = group.Add(new VocabularyKey(nameof(ProductReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryRecId = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderLineNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivedPurchaseQuantity = group.Add(new VocabularyKey(nameof(ReceivedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingPurchaseQuantity = group.Add(new VocabularyKey(nameof(RemainingPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingInventoryQuantity = group.Add(new VocabularyKey(nameof(RemainingInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductReceiptHeaderRecordId = group.Add(new VocabularyKey(nameof(ProductReceiptHeaderRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaserRecId = group.Add(new VocabularyKey(nameof(PurchaserRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaserPersonnelNumber = group.Add(new VocabularyKey(nameof(PurchaserPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivedInventoryStatusId = group.Add(new VocabularyKey(nameof(ReceivedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RecordId { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
public VocabularyKey DeliveryAddressCountyId { get; private set; }
public VocabularyKey ExpectedDeliveryDate { get; private set; }
public VocabularyKey DeliveryAddressStateId { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey ProductReceiptDate { get; private set; }
public VocabularyKey ReceivedInventoryQuantity { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey OrderedPurchaseQuantity { get; private set; }
public VocabularyKey PurchaseOrderNumber { get; private set; }
public VocabularyKey ProductReceiptNumber { get; private set; }
public VocabularyKey ProcurementProductCategoryRecId { get; private set; }
public VocabularyKey PurchaseOrderLineNumber { get; private set; }
public VocabularyKey PurchaseUnitSymbol { get; private set; }
public VocabularyKey ReceivedPurchaseQuantity { get; private set; }
public VocabularyKey RemainingPurchaseQuantity { get; private set; }
public VocabularyKey RemainingInventoryQuantity { get; private set; }
public VocabularyKey ProductReceiptHeaderRecordId { get; private set; }
public VocabularyKey PurchaserRecId { get; private set; }
public VocabularyKey ProcurementProductCategoryName { get; private set; }
public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
public VocabularyKey PurchaserPersonnelNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ReceivingWarehouseId { get; private set; }
public VocabularyKey ItemSerialNumber { get; private set; }
public VocabularyKey ReceivingSiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ReceivedInventoryStatusId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ReceivingWarehouseLocationId { get; private set; }


    }
}