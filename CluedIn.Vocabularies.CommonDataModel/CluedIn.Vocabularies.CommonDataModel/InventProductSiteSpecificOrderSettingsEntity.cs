using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProductSiteSpecificOrderSettingsEntityVocabulary : SimpleVocabulary
    {
        public InventProductSiteSpecificOrderSettingsEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventProductSiteSpecificOrderSettingsEntity";
            KeyPrefix = "commonDataModel.inventproductsitespecificordersettingsentity";
            KeySeparator = ".";
            Grouping = "/InventProductSiteSpecificOrderSettingsEntity";

            AddGroup("Common Data Model InventProductSiteSpecificOrderSettingsEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreInventoryDefaultOrderSettingsOverridden = group.Add(new VocabularyKey(nameof(AreInventoryDefaultOrderSettingsOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryOrderPromisingMethod = group.Add(new VocabularyKey(nameof(InventoryOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryATPDelayedDemandOffsetDays = group.Add(new VocabularyKey(nameof(InventoryATPDelayedDemandOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryATPDelayedSupplyOffsetDays = group.Add(new VocabularyKey(nameof(InventoryATPDelayedSupplyOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryATPBackwardDemandTimeFenceDays = group.Add(new VocabularyKey(nameof(InventoryATPBackwardDemandTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryATPBackwardSupplyTimeFenceDays = group.Add(new VocabularyKey(nameof(InventoryATPBackwardSupplyTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryATPIncludingPlannedOrders = group.Add(new VocabularyKey(nameof(IsInventoryATPIncludingPlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryATPTimeFenceDays = group.Add(new VocabularyKey(nameof(InventoryATPTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsInventoryUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLeadTimeDays = group.Add(new VocabularyKey(nameof(InventoryLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumInventoryOrderQuantity = group.Add(new VocabularyKey(nameof(MaximumInventoryOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumInventoryOrderQuantity = group.Add(new VocabularyKey(nameof(MinimumInventoryOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardInventoryOrderQuantity = group.Add(new VocabularyKey(nameof(StandardInventoryOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryQuantityMultiples = group.Add(new VocabularyKey(nameof(InventoryQuantityMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryProcessingStopped = group.Add(new VocabularyKey(nameof(IsInventoryProcessingStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryWarehouseMandatory = group.Add(new VocabularyKey(nameof(IsInventoryWarehouseMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreProcurementDefaultOrderSettingsOverridden = group.Add(new VocabularyKey(nameof(AreProcurementDefaultOrderSettingsOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProcurementProcessingstopped = group.Add(new VocabularyKey(nameof(IsProcurementProcessingstopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProcurementUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsProcurementUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementQuantityMultiples = group.Add(new VocabularyKey(nameof(ProcurementQuantityMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumProcurementOrderQuantity = group.Add(new VocabularyKey(nameof(MaximumProcurementOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumProcurementOrderQuantity = group.Add(new VocabularyKey(nameof(MinimumProcurementOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardProcurementOrderQuantity = group.Add(new VocabularyKey(nameof(StandardProcurementOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementLeadTimeDays = group.Add(new VocabularyKey(nameof(ProcurementLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementWarehouseId = group.Add(new VocabularyKey(nameof(ProcurementWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProcurementWarehouseMandatory = group.Add(new VocabularyKey(nameof(IsProcurementWarehouseMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreSalesDefaultOrderSettingsOverridden = group.Add(new VocabularyKey(nameof(AreSalesDefaultOrderSettingsOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesATPDelayedDemandOffsetDays = group.Add(new VocabularyKey(nameof(SalesATPDelayedDemandOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesATPDelayedSupplyOffsetDays = group.Add(new VocabularyKey(nameof(SalesATPDelayedSupplyOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesATPBackwardDemandTimeFenceDays = group.Add(new VocabularyKey(nameof(SalesATPBackwardDemandTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesATPBackwardSupplyTimeFenceDays = group.Add(new VocabularyKey(nameof(SalesATPBackwardSupplyTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSalesATPIncludingPlannedOrders = group.Add(new VocabularyKey(nameof(IsSalesATPIncludingPlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesATPTimeFenceDays = group.Add(new VocabularyKey(nameof(SalesATPTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSalesProcessingStopped = group.Add(new VocabularyKey(nameof(IsSalesProcessingStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesQuantityMultiples = group.Add(new VocabularyKey(nameof(SalesQuantityMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumSalesOrderQuantity = group.Add(new VocabularyKey(nameof(MaximumSalesOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumSalesOrderQuantity = group.Add(new VocabularyKey(nameof(MinimumSalesOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardSalesOrderQuantity = group.Add(new VocabularyKey(nameof(StandardSalesOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLeadTimeDays = group.Add(new VocabularyKey(nameof(SalesLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesWarehouseId = group.Add(new VocabularyKey(nameof(SalesWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSalesWarehouseMandatory = group.Add(new VocabularyKey(nameof(IsSalesWarehouseMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey OperationalSiteId { get; private set; }
public VocabularyKey AreInventoryDefaultOrderSettingsOverridden { get; private set; }
public VocabularyKey InventoryOrderPromisingMethod { get; private set; }
public VocabularyKey InventoryATPDelayedDemandOffsetDays { get; private set; }
public VocabularyKey InventoryATPDelayedSupplyOffsetDays { get; private set; }
public VocabularyKey InventoryATPBackwardDemandTimeFenceDays { get; private set; }
public VocabularyKey InventoryATPBackwardSupplyTimeFenceDays { get; private set; }
public VocabularyKey IsInventoryATPIncludingPlannedOrders { get; private set; }
public VocabularyKey InventoryATPTimeFenceDays { get; private set; }
public VocabularyKey IsInventoryUsingWorkingDays { get; private set; }
public VocabularyKey InventoryLeadTimeDays { get; private set; }
public VocabularyKey MaximumInventoryOrderQuantity { get; private set; }
public VocabularyKey MinimumInventoryOrderQuantity { get; private set; }
public VocabularyKey StandardInventoryOrderQuantity { get; private set; }
public VocabularyKey InventoryQuantityMultiples { get; private set; }
public VocabularyKey IsInventoryProcessingStopped { get; private set; }
public VocabularyKey InventoryWarehouseId { get; private set; }
public VocabularyKey IsInventoryWarehouseMandatory { get; private set; }
public VocabularyKey AreProcurementDefaultOrderSettingsOverridden { get; private set; }
public VocabularyKey IsProcurementProcessingstopped { get; private set; }
public VocabularyKey IsProcurementUsingWorkingDays { get; private set; }
public VocabularyKey ProcurementQuantityMultiples { get; private set; }
public VocabularyKey MaximumProcurementOrderQuantity { get; private set; }
public VocabularyKey MinimumProcurementOrderQuantity { get; private set; }
public VocabularyKey StandardProcurementOrderQuantity { get; private set; }
public VocabularyKey ProcurementLeadTimeDays { get; private set; }
public VocabularyKey ProcurementWarehouseId { get; private set; }
public VocabularyKey IsProcurementWarehouseMandatory { get; private set; }
public VocabularyKey AreSalesDefaultOrderSettingsOverridden { get; private set; }
public VocabularyKey SalesOrderPromisingMethod { get; private set; }
public VocabularyKey SalesATPDelayedDemandOffsetDays { get; private set; }
public VocabularyKey SalesATPDelayedSupplyOffsetDays { get; private set; }
public VocabularyKey SalesATPBackwardDemandTimeFenceDays { get; private set; }
public VocabularyKey SalesATPBackwardSupplyTimeFenceDays { get; private set; }
public VocabularyKey IsSalesATPIncludingPlannedOrders { get; private set; }
public VocabularyKey SalesATPTimeFenceDays { get; private set; }
public VocabularyKey IsSalesProcessingStopped { get; private set; }
public VocabularyKey SalesQuantityMultiples { get; private set; }
public VocabularyKey MaximumSalesOrderQuantity { get; private set; }
public VocabularyKey MinimumSalesOrderQuantity { get; private set; }
public VocabularyKey StandardSalesOrderQuantity { get; private set; }
public VocabularyKey SalesLeadTimeDays { get; private set; }
public VocabularyKey SalesWarehouseId { get; private set; }
public VocabularyKey IsSalesWarehouseMandatory { get; private set; }


    }
}