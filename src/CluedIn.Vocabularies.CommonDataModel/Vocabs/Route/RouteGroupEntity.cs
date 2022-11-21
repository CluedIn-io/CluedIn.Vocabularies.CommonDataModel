using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteGroupEntityVocabulary : SimpleVocabulary
    {
        public RouteGroupEntityVocabulary()
        {
            VocabularyName = "Route Group Entity";
            KeyPrefix = "commonDataModel.routegroupentity";
            KeySeparator = ".";
            Grouping = "/RouteGroupEntity";

            AddGroup("RouteGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionEstimationAndCostingUseSetupTimeAndSetupCategory = group.Add(new VocabularyKey(nameof(WillProductionEstimationAndCostingUseSetupTimeAndSetupCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionEstimationAndCostingUseProcessTimeAndProcessCategory = group.Add(new VocabularyKey(nameof(WillProductionEstimationAndCostingUseProcessTimeAndProcessCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionEstimationAndCostingUseQuantityAndQuantityCategory = group.Add(new VocabularyKey(nameof(WillProductionEstimationAndCostingUseQuantityAndQuantityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticRouteConsumptionUseSetupTime = group.Add(new VocabularyKey(nameof(WillAutomaticRouteConsumptionUseSetupTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticRouteConsumptionUseProcessTime = group.Add(new VocabularyKey(nameof(WillAutomaticRouteConsumptionUseProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticRouteConsumptionUseQuantity = group.Add(new VocabularyKey(nameof(WillAutomaticRouteConsumptionUseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationManuallyReportedAsFinishedByDefault = group.Add(new VocabularyKey(nameof(IsOperationManuallyReportedAsFinishedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQueueBeforeJobActive = group.Add(new VocabularyKey(nameof(IsQueueBeforeJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueBeforeJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillQueueBeforeJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueBeforeJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillQueueBeforeJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueBeforeJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillQueueBeforeJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSetupJobActive = group.Add(new VocabularyKey(nameof(IsSetupJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSetupJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillSetupJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSetupJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillSetupJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSetupJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillSetupJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProcessJobActive = group.Add(new VocabularyKey(nameof(IsProcessJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProcessJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillProcessJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProcessJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillProcessJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProcessJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillProcessJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOverlapJobActive = group.Add(new VocabularyKey(nameof(IsOverlapJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOverlapJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillOverlapJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOverlapJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillOverlapJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOverlapJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillOverlapJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransportJobActive = group.Add(new VocabularyKey(nameof(IsTransportJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransportJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillTransportJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransportJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillTransportJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransportJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillTransportJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQueuAfterJobActive = group.Add(new VocabularyKey(nameof(IsQueuAfterJobActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueAfterJobSchedulingUseJobManagement = group.Add(new VocabularyKey(nameof(WillQueueAfterJobSchedulingUseJobManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueAfterJobSchedulingUseWorkingTimeCalendar = group.Add(new VocabularyKey(nameof(WillQueueAfterJobSchedulingUseWorkingTimeCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQueueAfterJobSchedulingCreateResourceCapacityReservations = group.Add(new VocabularyKey(nameof(WillQueueAfterJobSchedulingCreateResourceCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey WillProductionEstimationAndCostingUseSetupTimeAndSetupCategory { get; private set; }
        public VocabularyKey WillProductionEstimationAndCostingUseProcessTimeAndProcessCategory { get; private set; }
        public VocabularyKey WillProductionEstimationAndCostingUseQuantityAndQuantityCategory { get; private set; }
        public VocabularyKey WillAutomaticRouteConsumptionUseSetupTime { get; private set; }
        public VocabularyKey WillAutomaticRouteConsumptionUseProcessTime { get; private set; }
        public VocabularyKey WillAutomaticRouteConsumptionUseQuantity { get; private set; }
        public VocabularyKey IsOperationManuallyReportedAsFinishedByDefault { get; private set; }
        public VocabularyKey IsQueueBeforeJobActive { get; private set; }
        public VocabularyKey WillQueueBeforeJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillQueueBeforeJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillQueueBeforeJobSchedulingCreateResourceCapacityReservations { get; private set; }
        public VocabularyKey IsSetupJobActive { get; private set; }
        public VocabularyKey WillSetupJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillSetupJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillSetupJobSchedulingCreateResourceCapacityReservations { get; private set; }
        public VocabularyKey IsProcessJobActive { get; private set; }
        public VocabularyKey WillProcessJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillProcessJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillProcessJobSchedulingCreateResourceCapacityReservations { get; private set; }
        public VocabularyKey IsOverlapJobActive { get; private set; }
        public VocabularyKey WillOverlapJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillOverlapJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillOverlapJobSchedulingCreateResourceCapacityReservations { get; private set; }
        public VocabularyKey IsTransportJobActive { get; private set; }
        public VocabularyKey WillTransportJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillTransportJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillTransportJobSchedulingCreateResourceCapacityReservations { get; private set; }
        public VocabularyKey IsQueuAfterJobActive { get; private set; }
        public VocabularyKey WillQueueAfterJobSchedulingUseJobManagement { get; private set; }
        public VocabularyKey WillQueueAfterJobSchedulingUseWorkingTimeCalendar { get; private set; }
        public VocabularyKey WillQueueAfterJobSchedulingCreateResourceCapacityReservations { get; private set; }
    }
}