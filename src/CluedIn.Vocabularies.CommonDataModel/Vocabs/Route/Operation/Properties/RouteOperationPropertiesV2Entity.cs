using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteOperationPropertiesV2EntityVocabulary : SimpleVocabulary
    {
        public RouteOperationPropertiesV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model RouteOperationPropertiesV2Entity";
            KeyPrefix = "commonDataModel.routeoperationpropertiesv2entity";
            KeySeparator = ".";
            Grouping = "/RouteOperationPropertiesV2Entity";

            AddGroup("Common Data Model RouteOperationPropertiesV2Entity Details", group =>
            {
                SetupCostCategoryId = group.Add(new VocabularyKey(nameof(SetupCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuantityCostCategoryId = group.Add(new VocabularyKey(nameof(QuantityCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessCostCategoryId = group.Add(new VocabularyKey(nameof(ProcessCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationFormula = group.Add(new VocabularyKey(nameof(ConsumptionCalculationFormula), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationFactor = group.Add(new VocabularyKey(nameof(ConsumptionCalculationFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessQuantity = group.Add(new VocabularyKey(nameof(ProcessQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessTime = group.Add(new VocabularyKey(nameof(ProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QueueTimeAfter = group.Add(new VocabularyKey(nameof(QueueTimeAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QueueTimeBefore = group.Add(new VocabularyKey(nameof(QueueTimeBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteGroupId = group.Add(new VocabularyKey(nameof(RouteGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteType = group.Add(new VocabularyKey(nameof(RouteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SetupTime = group.Add(new VocabularyKey(nameof(SetupTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsTimeToHourConversionFactor = group.Add(new VocabularyKey(nameof(OperationsTimeToHourConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferBatchQuantity = group.Add(new VocabularyKey(nameof(TransferBatchQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransitTime = group.Add(new VocabularyKey(nameof(TransitTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostingOperationResourceId = group.Add(new VocabularyKey(nameof(CostingOperationResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadPercentage = group.Add(new VocabularyKey(nameof(LoadPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceQuantity = group.Add(new VocabularyKey(nameof(ResourceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteCode = group.Add(new VocabularyKey(nameof(RouteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WrkCtrActivityRequirementSetRecId = group.Add(new VocabularyKey(nameof(WrkCtrActivityRequirementSetRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SetupCostCategoryId { get; private set; }
public VocabularyKey QuantityCostCategoryId { get; private set; }
public VocabularyKey ProcessCostCategoryId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ConsumptionCalculationFormula { get; private set; }
public VocabularyKey ConsumptionCalculationFactor { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey OperationId { get; private set; }
public VocabularyKey ProcessQuantity { get; private set; }
public VocabularyKey ProcessTime { get; private set; }
public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
public VocabularyKey QueueTimeAfter { get; private set; }
public VocabularyKey QueueTimeBefore { get; private set; }
public VocabularyKey RouteGroupId { get; private set; }
public VocabularyKey RouteId { get; private set; }
public VocabularyKey RouteType { get; private set; }
public VocabularyKey SetupTime { get; private set; }
public VocabularyKey ProductionSiteId { get; private set; }
public VocabularyKey OperationsTimeToHourConversionFactor { get; private set; }
public VocabularyKey TransferBatchQuantity { get; private set; }
public VocabularyKey TransitTime { get; private set; }
public VocabularyKey CostingOperationResourceId { get; private set; }
public VocabularyKey LoadPercentage { get; private set; }
public VocabularyKey ResourceQuantity { get; private set; }
public VocabularyKey RouteCode { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey WrkCtrActivityRequirementSetRecId { get; private set; }


    }
}