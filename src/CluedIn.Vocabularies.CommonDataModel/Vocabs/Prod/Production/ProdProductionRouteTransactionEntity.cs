using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionRouteTransactionEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionRouteTransactionEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdProductionRouteTransactionEntity";
            KeyPrefix = "commonDataModel.prodproductionroutetransactionentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionRouteTransactionEntity";

            AddGroup("Common Data Model ProdProductionRouteTransactionEntity Details", group =>
            {
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCostAccounted = group.Add(new VocabularyKey(nameof(IsCostAccounted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteCostCategoryId = group.Add(new VocabularyKey(nameof(RouteCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RealizedAccountingDate = group.Add(new VocabularyKey(nameof(RealizedAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedAccountingDate = group.Add(new VocabularyKey(nameof(EstimatedAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobProcessingPercentage = group.Add(new VocabularyKey(nameof(JobProcessingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledFromTime = group.Add(new VocabularyKey(nameof(ScheduledFromTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HourlyCostCategoryRate = group.Add(new VocabularyKey(nameof(HourlyCostCategoryRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsJobEnded = group.Add(new VocabularyKey(nameof(IsJobEnded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOperationCompleted = group.Add(new VocabularyKey(nameof(IsOperationCompleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationPriority = group.Add(new VocabularyKey(nameof(OperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedErrorCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedGoodCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionUnitId = group.Add(new VocabularyKey(nameof(ProductionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedErrorInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedGoodInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuantityCostCategoryUnitCost = group.Add(new VocabularyKey(nameof(QuantityCostCategoryUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceGroupId = group.Add(new VocabularyKey(nameof(OperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RealizedAccountingVoucherNumber = group.Add(new VocabularyKey(nameof(RealizedAccountingVoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedAccountingVoucherNumber = group.Add(new VocabularyKey(nameof(EstimatedAccountingVoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationResourceId = group.Add(new VocabularyKey(nameof(OperationResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegisteredHours = group.Add(new VocabularyKey(nameof(RegisteredHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CostAmount { get; private set; }
public VocabularyKey IsCostAccounted { get; private set; }
public VocabularyKey RouteCostCategoryId { get; private set; }
public VocabularyKey RealizedAccountingDate { get; private set; }
public VocabularyKey EstimatedAccountingDate { get; private set; }
public VocabularyKey ErrorCause { get; private set; }
public VocabularyKey JobProcessingPercentage { get; private set; }
public VocabularyKey ScheduledFromTime { get; private set; }
public VocabularyKey HourlyCostCategoryRate { get; private set; }
public VocabularyKey IsJobEnded { get; private set; }
public VocabularyKey JobId { get; private set; }
public VocabularyKey RouteJobType { get; private set; }
public VocabularyKey IsOperationCompleted { get; private set; }
public VocabularyKey OperationId { get; private set; }
public VocabularyKey OperationNumber { get; private set; }
public VocabularyKey OperationPriority { get; private set; }
public VocabularyKey ReportedErrorCatchWeightQuantity { get; private set; }
public VocabularyKey ReportedGoodCatchWeightQuantity { get; private set; }
public VocabularyKey ProductionUnitId { get; private set; }
public VocabularyKey ReportedErrorInventoryQuantity { get; private set; }
public VocabularyKey ReportedGoodInventoryQuantity { get; private set; }
public VocabularyKey QuantityCostCategoryUnitCost { get; private set; }
public VocabularyKey OperationsResourceGroupId { get; private set; }
public VocabularyKey ScheduledEndTime { get; private set; }
public VocabularyKey RealizedAccountingVoucherNumber { get; private set; }
public VocabularyKey EstimatedAccountingVoucherNumber { get; private set; }
public VocabularyKey OperationResourceId { get; private set; }
public VocabularyKey RecordId { get; private set; }
public VocabularyKey RegisteredHours { get; private set; }


    }
}