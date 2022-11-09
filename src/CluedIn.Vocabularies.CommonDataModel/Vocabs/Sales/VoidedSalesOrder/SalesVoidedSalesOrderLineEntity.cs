using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesVoidedSalesOrderLineEntityVocabulary : SimpleVocabulary
    {
        public SalesVoidedSalesOrderLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesVoidedSalesOrderLineEntity";
            KeyPrefix = "commonDataModel.salesvoidedsalesorderlineentity";
            KeySeparator = ".";
            Grouping = "/SalesVoidedSalesOrderLineEntity";

            AddGroup("Common Data Model SalesVoidedSalesOrderLineEntity Details", group =>
            {
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProjectActivityNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey SalesOrderNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey OrderedInventoryStatusId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey SalesProductCategoryName { get; private set; }
public VocabularyKey InventoryLotId { get; private set; }
public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
public VocabularyKey OrderingCustomerAccountNumber { get; private set; }


    }
}