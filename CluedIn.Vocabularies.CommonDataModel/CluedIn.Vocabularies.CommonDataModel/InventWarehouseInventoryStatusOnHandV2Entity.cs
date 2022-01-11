using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseInventoryStatusOnHandV2EntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseInventoryStatusOnHandV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model InventWarehouseInventoryStatusOnHandV2Entity";
            KeyPrefix = "commonDataModel.inventwarehouseinventorystatusonhandv2entity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseInventoryStatusOnHandV2Entity";

            AddGroup("Common Data Model InventWarehouseInventoryStatusOnHandV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnHandQuantity = group.Add(new VocabularyKey(nameof(OnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReservedOnHandQuantityMapped = group.Add(new VocabularyKey(nameof(ReservedOnHandQuantityMapped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReservedOnHandQuantity = group.Add(new VocabularyKey(nameof(ReservedOnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableOnHandQuantityMapped = group.Add(new VocabularyKey(nameof(AvailableOnHandQuantityMapped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableOnHandQuantity = group.Add(new VocabularyKey(nameof(AvailableOnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedQuantityMapped = group.Add(new VocabularyKey(nameof(OrderedQuantityMapped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderedQuantity = group.Add(new VocabularyKey(nameof(OrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReservedOrderedQuantityMapped = group.Add(new VocabularyKey(nameof(ReservedOrderedQuantityMapped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReservedOrderedQuantity = group.Add(new VocabularyKey(nameof(ReservedOrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableOrderedQuantityMapped = group.Add(new VocabularyKey(nameof(AvailableOrderedQuantityMapped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableOrderedQuantity = group.Add(new VocabularyKey(nameof(AvailableOrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnOrderQuantity = group.Add(new VocabularyKey(nameof(OnOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalAvailableQuantity = group.Add(new VocabularyKey(nameof(TotalAvailableQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreWarehouseManagementProcessesUsed = group.Add(new VocabularyKey(nameof(AreWarehouseManagementProcessesUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductName { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey InventorySiteId { get; private set; }
public VocabularyKey InventoryWarehouseId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey OnHandQuantity { get; private set; }
public VocabularyKey ReservedOnHandQuantityMapped { get; private set; }
public VocabularyKey ReservedOnHandQuantity { get; private set; }
public VocabularyKey AvailableOnHandQuantityMapped { get; private set; }
public VocabularyKey AvailableOnHandQuantity { get; private set; }
public VocabularyKey OrderedQuantityMapped { get; private set; }
public VocabularyKey OrderedQuantity { get; private set; }
public VocabularyKey ReservedOrderedQuantityMapped { get; private set; }
public VocabularyKey ReservedOrderedQuantity { get; private set; }
public VocabularyKey AvailableOrderedQuantityMapped { get; private set; }
public VocabularyKey AvailableOrderedQuantity { get; private set; }
public VocabularyKey OnOrderQuantity { get; private set; }
public VocabularyKey TotalAvailableQuantity { get; private set; }
public VocabularyKey AreWarehouseManagementProcessesUsed { get; private set; }


    }
}