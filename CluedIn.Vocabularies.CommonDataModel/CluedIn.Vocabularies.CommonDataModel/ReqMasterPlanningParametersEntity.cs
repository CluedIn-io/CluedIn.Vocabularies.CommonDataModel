using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqMasterPlanningParametersEntityVocabulary : SimpleVocabulary
    {
        public ReqMasterPlanningParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqMasterPlanningParametersEntity";
            KeyPrefix = "commonDataModel.reqmasterplanningparametersentity";
            KeySeparator = ".";
            Grouping = "/ReqMasterPlanningParametersEntity";

            AddGroup("Common Data Model ReqMasterPlanningParametersEntity Details", group =>
            {
                WillCompletedStaticPlanBeCopiedToDynamicPlan = group.Add(new VocabularyKey(nameof(WillCompletedStaticPlanBeCopiedToDynamicPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumBundleSize = group.Add(new VocabularyKey(nameof(MaximumBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobSchedulingStartTimeRule = group.Add(new VocabularyKey(nameof(JobSchedulingStartTimeRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrentForecastPlanId = group.Add(new VocabularyKey(nameof(CurrentForecastPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrentDynamicMasterPlanId = group.Add(new VocabularyKey(nameof(CurrentDynamicMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrentStaticMasterPlanId = group.Add(new VocabularyKey(nameof(CurrentStaticMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTransferOrderPeriodGroupingRule = group.Add(new VocabularyKey(nameof(DefaultTransferOrderPeriodGroupingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultInventoryMarkingRule = group.Add(new VocabularyKey(nameof(DefaultInventoryMarkingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningCalculateDynamicNegativeDays = group.Add(new VocabularyKey(nameof(WillMasterPlanningCalculateDynamicNegativeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSafetyMarginsUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsSafetyMarginsUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillErrorsAbortFirmingByDefault = group.Add(new VocabularyKey(nameof(WillErrorsAbortFirmingByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPurchaseOrderPeriodGroupingRule = group.Add(new VocabularyKey(nameof(DefaultPurchaseOrderPeriodGroupingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePurchaseOrdersCombinedPerBuyerGroupByDefault = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersCombinedPerBuyerGroupByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePurchaseOrdersCombinedPerPurchaseAgreementByDefault = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersCombinedPerPurchaseAgreementByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePurchaseOrdersCombinedPerVendorByDefault = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersCombinedPerVendorByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePurchaseOrdersAssignedPurchaseAgreements = group.Add(new VocabularyKey(nameof(ArePurchaseOrdersAssignedPurchaseAgreements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillVendorSelectionConsiderPriceAgreements = group.Add(new VocabularyKey(nameof(WillVendorSelectionConsiderPriceAgreements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceAgreementVendorSelectionRule = group.Add(new VocabularyKey(nameof(PriceAgreementVendorSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DelayStartTime = group.Add(new VocabularyKey(nameof(DelayStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPlannedOrderReceiptTime = group.Add(new VocabularyKey(nameof(DefaultPlannedOrderReceiptTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultMasterPlanningProductCoverageGroupId = group.Add(new VocabularyKey(nameof(DefaultMasterPlanningProductCoverageGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TodaysWorkCalendarId = group.Add(new VocabularyKey(nameof(TodaysWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CachingLevel = group.Add(new VocabularyKey(nameof(CachingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSchedulingConsiderProductionOrderCapacityReservations = group.Add(new VocabularyKey(nameof(WillSchedulingConsiderProductionOrderCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSchedulingConsiderProjectCapacityReservations = group.Add(new VocabularyKey(nameof(WillSchedulingConsiderProjectCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreAllPlanningProcessesDisabled = group.Add(new VocabularyKey(nameof(AreAllPlanningProcessesDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultNumberOfThreads = group.Add(new VocabularyKey(nameof(DefaultNumberOfThreads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FirmingBundleSize = group.Add(new VocabularyKey(nameof(FirmingBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillPostProcessingAutomaticallyFilterItems = group.Add(new VocabularyKey(nameof(WillPostProcessingAutomaticallyFilterItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillPreProcessingAutomaticallyFilterItems = group.Add(new VocabularyKey(nameof(WillPreProcessingAutomaticallyFilterItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTransferOrderStockTransferPriceType_IN = group.Add(new VocabularyKey(nameof(DefaultTransferOrderStockTransferPriceType_IN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTranferOrderTransferType_IN = group.Add(new VocabularyKey(nameof(DefaultTranferOrderTransferType_IN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillCompletedStaticPlanBeCopiedToDynamicPlan { get; private set; }
public VocabularyKey MaximumBundleSize { get; private set; }
public VocabularyKey JobSchedulingStartTimeRule { get; private set; }
public VocabularyKey CurrentForecastPlanId { get; private set; }
public VocabularyKey CurrentDynamicMasterPlanId { get; private set; }
public VocabularyKey CurrentStaticMasterPlanId { get; private set; }
public VocabularyKey DefaultTransferOrderPeriodGroupingRule { get; private set; }
public VocabularyKey DefaultInventoryMarkingRule { get; private set; }
public VocabularyKey WillMasterPlanningCalculateDynamicNegativeDays { get; private set; }
public VocabularyKey IsSafetyMarginsUsingWorkingDays { get; private set; }
public VocabularyKey WillErrorsAbortFirmingByDefault { get; private set; }
public VocabularyKey DefaultPurchaseOrderPeriodGroupingRule { get; private set; }
public VocabularyKey ArePurchaseOrdersCombinedPerBuyerGroupByDefault { get; private set; }
public VocabularyKey ArePurchaseOrdersCombinedPerPurchaseAgreementByDefault { get; private set; }
public VocabularyKey ArePurchaseOrdersCombinedPerVendorByDefault { get; private set; }
public VocabularyKey ArePurchaseOrdersAssignedPurchaseAgreements { get; private set; }
public VocabularyKey WillVendorSelectionConsiderPriceAgreements { get; private set; }
public VocabularyKey PriceAgreementVendorSelectionRule { get; private set; }
public VocabularyKey DelayStartTime { get; private set; }
public VocabularyKey DefaultPlannedOrderReceiptTime { get; private set; }
public VocabularyKey DefaultMasterPlanningProductCoverageGroupId { get; private set; }
public VocabularyKey TodaysWorkCalendarId { get; private set; }
public VocabularyKey CachingLevel { get; private set; }
public VocabularyKey WillSchedulingConsiderProductionOrderCapacityReservations { get; private set; }
public VocabularyKey WillSchedulingConsiderProjectCapacityReservations { get; private set; }
public VocabularyKey AreAllPlanningProcessesDisabled { get; private set; }
public VocabularyKey DefaultNumberOfThreads { get; private set; }
public VocabularyKey FirmingBundleSize { get; private set; }
public VocabularyKey WillPostProcessingAutomaticallyFilterItems { get; private set; }
public VocabularyKey WillPreProcessingAutomaticallyFilterItems { get; private set; }
public VocabularyKey DefaultTransferOrderStockTransferPriceType_IN { get; private set; }
public VocabularyKey DefaultTranferOrderTransferType_IN { get; private set; }


    }
}