using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemV3EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemV3EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseMobileDeviceMenuItemV3Entity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemv3entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemV3Entity";

            AddGroup("Common Data Model WHSWarehouseMobileDeviceMenuItemV3Entity Details", group =>
            {
                MenuItemName = group.Add(new VocabularyKey(nameof(MenuItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MenuItemMode = group.Add(new VocabularyKey(nameof(MenuItemMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseExistingWork = group.Add(new VocabularyKey(nameof(UseExistingWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityCode = group.Add(new VocabularyKey(nameof(ActivityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectedBy = group.Add(new VocabularyKey(nameof(DirectedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordsPerPage = group.Add(new VocabularyKey(nameof(RecordsPerPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkTransactionTypeUserFilteringAllowed = group.Add(new VocabularyKey(nameof(IsWorkTransactionTypeUserFilteringAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCreationProcess = group.Add(new VocabularyKey(nameof(WorkCreationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultDataUsed = group.Add(new VocabularyKey(nameof(IsDefaultDataUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLicensePlateGenerated = group.Add(new VocabularyKey(nameof(IsLicensePlateGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCancelationConfirmed = group.Add(new VocabularyKey(nameof(IsCancelationConfirmed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryAdjustmentTypeId = group.Add(new VocabularyKey(nameof(InventoryAdjustmentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLocationOverflowAllowed = group.Add(new VocabularyKey(nameof(IsLocationOverflowAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDispositionCodeDisplayed = group.Add(new VocabularyKey(nameof(IsDispositionCodeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLabelPrinted = group.Add(new VocabularyKey(nameof(IsLabelPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryStatusDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLicensePlateOverridenDuringPut = group.Add(new VocabularyKey(nameof(IsLicensePlateOverridenDuringPut), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsGroupPutAwayUsed = group.Add(new VocabularyKey(nameof(IsGroupPutAwayUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AuditTemplateId = group.Add(new VocabularyKey(nameof(AuditTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReportAsFinishedAllowProductionOrderEnding = group.Add(new VocabularyKey(nameof(WillReportAsFinishedAllowProductionOrderEnding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlateGroupingPolicy = group.Add(new VocabularyKey(nameof(LicensePlateGroupingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkTemplateId = group.Add(new VocabularyKey(nameof(WorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectiveCode = group.Add(new VocabularyKey(nameof(DirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBatchDispositionCodeDisplayed = group.Add(new VocabularyKey(nameof(IsBatchDispositionCodeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBatchNumberOverriden = group.Add(new VocabularyKey(nameof(IsBatchNumberOverriden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMovementCreated = group.Add(new VocabularyKey(nameof(IsMovementCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTotalItemQuantityCountedFirst = group.Add(new VocabularyKey(nameof(IsTotalItemQuantityCountedFirst), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAnchoringUsed = group.Add(new VocabularyKey(nameof(IsAnchoringUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnchorBy = group.Add(new VocabularyKey(nameof(AnchorBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkSplittingAllowed = group.Add(new VocabularyKey(nameof(IsWorkSplittingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsUserKeepingWorkLocked = group.Add(new VocabularyKey(nameof(IsUserKeepingWorkLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPickScreenSummaryDisplayed = group.Add(new VocabularyKey(nameof(IsPickScreenSummaryDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreCycleCountThresholdsDisabled = group.Add(new VocabularyKey(nameof(AreCycleCountThresholdsDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PickOldestBatchCriteria = group.Add(new VocabularyKey(nameof(PickOldestBatchCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOverPickAllowed = group.Add(new VocabularyKey(nameof(IsOverPickAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPickAndPackUsed = group.Add(new VocabularyKey(nameof(IsPickAndPackUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTargetLicensePlateOverriden = group.Add(new VocabularyKey(nameof(IsTargetLicensePlateOverriden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLicensePlateHandlingUsed = group.Add(new VocabularyKey(nameof(IsLicensePlateHandlingUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupingField = group.Add(new VocabularyKey(nameof(GroupingField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupingLabel = group.Add(new VocabularyKey(nameof(GroupingLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterProfileId = group.Add(new VocabularyKey(nameof(ClusterProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkListQuery = group.Add(new VocabularyKey(nameof(WorkListQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsASNItemReceivingPrevented = group.Add(new VocabularyKey(nameof(IsASNItemReceivingPrevented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanLicensePlateConsolidationCancelRemainingOriginWorkLines = group.Add(new VocabularyKey(nameof(CanLicensePlateConsolidationCancelRemainingOriginWorkLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MixedLicensePlateReceivingMode = group.Add(new VocabularyKey(nameof(MixedLicensePlateReceivingMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsContainerTypeDisplayed = group.Add(new VocabularyKey(nameof(IsContainerTypeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillContainerRemovalCancelRelatedWork = group.Add(new VocabularyKey(nameof(WillContainerRemovalCancelRelatedWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCancelingReplenishmentWorkWithDependentWorkAllowed = group.Add(new VocabularyKey(nameof(IsCancelingReplenishmentWorkWithDependentWorkAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumDisplayedRecords = group.Add(new VocabularyKey(nameof(MaximumDisplayedRecords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkListGroupingFilterDisplayed = group.Add(new VocabularyKey(nameof(IsWorkListGroupingFilterDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreOlderBatchesWithinWarehouseDisplayed = group.Add(new VocabularyKey(nameof(AreOlderBatchesWithinWarehouseDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCountingReasonCodeEditable = group.Add(new VocabularyKey(nameof(IsCountingReasonCodeEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCountingReasonCodeDisplayed = group.Add(new VocabularyKey(nameof(IsCountingReasonCodeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCountingReasonCode = group.Add(new VocabularyKey(nameof(DefaultCountingReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCatchWeightTagGenerated = group.Add(new VocabularyKey(nameof(IsCatchWeightTagGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillUseProcessGuideFramework = group.Add(new VocabularyKey(nameof(WillUseProcessGuideFramework), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsGroupPickEnabled = group.Add(new VocabularyKey(nameof(IsGroupPickEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveLabelPrintMode = group.Add(new VocabularyKey(nameof(WaveLabelPrintMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutboundSortingTemplateId = group.Add(new VocabularyKey(nameof(OutboundSortingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CartonGroupQuery = group.Add(new VocabularyKey(nameof(CartonGroupQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeferredPutProcessingPolicy = group.Add(new VocabularyKey(nameof(DeferredPutProcessingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReceiptAssignPutawayCluster = group.Add(new VocabularyKey(nameof(WillReceiptAssignPutawayCluster), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillInboundProcessesUseExistingCatchWeightTag = group.Add(new VocabularyKey(nameof(WillInboundProcessesUseExistingCatchWeightTag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingSummaryPageDisplayRule = group.Add(new VocabularyKey(nameof(ReceivingSummaryPageDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFastValidationEnabled = group.Add(new VocabularyKey(nameof(IsFastValidationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MenuItemName { get; private set; }
public VocabularyKey Title { get; private set; }
public VocabularyKey MenuItemMode { get; private set; }
public VocabularyKey UseExistingWork { get; private set; }
public VocabularyKey ActivityCode { get; private set; }
public VocabularyKey DirectedBy { get; private set; }
public VocabularyKey RecordsPerPage { get; private set; }
public VocabularyKey IsWorkTransactionTypeUserFilteringAllowed { get; private set; }
public VocabularyKey WorkCreationProcess { get; private set; }
public VocabularyKey IsDefaultDataUsed { get; private set; }
public VocabularyKey IsLicensePlateGenerated { get; private set; }
public VocabularyKey IsCancelationConfirmed { get; private set; }
public VocabularyKey InventoryAdjustmentTypeId { get; private set; }
public VocabularyKey IsLocationOverflowAllowed { get; private set; }
public VocabularyKey IsDispositionCodeDisplayed { get; private set; }
public VocabularyKey IsLabelPrinted { get; private set; }
public VocabularyKey IsInventoryStatusDisplayed { get; private set; }
public VocabularyKey IsLicensePlateOverridenDuringPut { get; private set; }
public VocabularyKey IsGroupPutAwayUsed { get; private set; }
public VocabularyKey AuditTemplateId { get; private set; }
public VocabularyKey WillReportAsFinishedAllowProductionOrderEnding { get; private set; }
public VocabularyKey LicensePlateGroupingPolicy { get; private set; }
public VocabularyKey WorkTemplateId { get; private set; }
public VocabularyKey DirectiveCode { get; private set; }
public VocabularyKey IsBatchDispositionCodeDisplayed { get; private set; }
public VocabularyKey IsBatchNumberOverriden { get; private set; }
public VocabularyKey IsMovementCreated { get; private set; }
public VocabularyKey IsTotalItemQuantityCountedFirst { get; private set; }
public VocabularyKey IsAnchoringUsed { get; private set; }
public VocabularyKey AnchorBy { get; private set; }
public VocabularyKey IsWorkSplittingAllowed { get; private set; }
public VocabularyKey IsUserKeepingWorkLocked { get; private set; }
public VocabularyKey IsPickScreenSummaryDisplayed { get; private set; }
public VocabularyKey AreCycleCountThresholdsDisabled { get; private set; }
public VocabularyKey PickOldestBatchCriteria { get; private set; }
public VocabularyKey IsOverPickAllowed { get; private set; }
public VocabularyKey IsPickAndPackUsed { get; private set; }
public VocabularyKey IsTargetLicensePlateOverriden { get; private set; }
public VocabularyKey IsLicensePlateHandlingUsed { get; private set; }
public VocabularyKey GroupingField { get; private set; }
public VocabularyKey GroupingLabel { get; private set; }
public VocabularyKey ClusterProfileId { get; private set; }
public VocabularyKey WorkListQuery { get; private set; }
public VocabularyKey IsASNItemReceivingPrevented { get; private set; }
public VocabularyKey CanLicensePlateConsolidationCancelRemainingOriginWorkLines { get; private set; }
public VocabularyKey MixedLicensePlateReceivingMode { get; private set; }
public VocabularyKey IsContainerTypeDisplayed { get; private set; }
public VocabularyKey WillContainerRemovalCancelRelatedWork { get; private set; }
public VocabularyKey IsCancelingReplenishmentWorkWithDependentWorkAllowed { get; private set; }
public VocabularyKey MaximumDisplayedRecords { get; private set; }
public VocabularyKey IsWorkListGroupingFilterDisplayed { get; private set; }
public VocabularyKey AreOlderBatchesWithinWarehouseDisplayed { get; private set; }
public VocabularyKey IsCountingReasonCodeEditable { get; private set; }
public VocabularyKey IsCountingReasonCodeDisplayed { get; private set; }
public VocabularyKey DefaultCountingReasonCode { get; private set; }
public VocabularyKey IsCatchWeightTagGenerated { get; private set; }
public VocabularyKey WillUseProcessGuideFramework { get; private set; }
public VocabularyKey IsGroupPickEnabled { get; private set; }
public VocabularyKey WaveLabelPrintMode { get; private set; }
public VocabularyKey OutboundSortingTemplateId { get; private set; }
public VocabularyKey CartonGroupQuery { get; private set; }
public VocabularyKey DeferredPutProcessingPolicy { get; private set; }
public VocabularyKey WillReceiptAssignPutawayCluster { get; private set; }
public VocabularyKey WillInboundProcessesUseExistingCatchWeightTag { get; private set; }
public VocabularyKey ReceivingSummaryPageDisplayRule { get; private set; }
public VocabularyKey IsFastValidationEnabled { get; private set; }


    }
}