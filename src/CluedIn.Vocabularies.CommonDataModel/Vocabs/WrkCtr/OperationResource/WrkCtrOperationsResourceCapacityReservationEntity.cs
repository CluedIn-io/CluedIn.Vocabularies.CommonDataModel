using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WrkCtrOperationsResourceCapacityReservationEntityVocabulary : SimpleVocabulary
    {
        public WrkCtrOperationsResourceCapacityReservationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WrkCtrOperationsResourceCapacityReservationEntity";
            KeyPrefix = "commonDataModel.wrkctroperationsresourcecapacityreservationentity";
            KeySeparator = ".";
            Grouping = "/WrkCtrOperationsResourceCapacityReservationEntity";

            AddGroup("Common Data Model WrkCtrOperationsResourceCapacityReservationEntity Details", group =>
            {
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderRouteJobId = group.Add(new VocabularyKey(nameof(ProductionOrderRouteJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReservationLocked = group.Add(new VocabularyKey(nameof(IsReservationLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacitySchedulingType = group.Add(new VocabularyKey(nameof(CapacitySchedulingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationPriority = group.Add(new VocabularyKey(nameof(RouteOperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanVersionRecId = group.Add(new VocabularyKey(nameof(PlanVersionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacityReservationSeconds = group.Add(new VocabularyKey(nameof(CapacityReservationSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadPercentage = group.Add(new VocabularyKey(nameof(LoadPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationReferenceNumber = group.Add(new VocabularyKey(nameof(ReservationReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationSourceType = group.Add(new VocabularyKey(nameof(ReservationSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartTime = group.Add(new VocabularyKey(nameof(ScheduledStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationDate = group.Add(new VocabularyKey(nameof(ReservationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityId = group.Add(new VocabularyKey(nameof(ProjectActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumber = group.Add(new VocabularyKey(nameof(PlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanId = group.Add(new VocabularyKey(nameof(RequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReserveHours = group.Add(new VocabularyKey(nameof(ReserveHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ScheduledEndTime { get; private set; }
        public VocabularyKey ProductionOrderRouteJobId { get; private set; }
        public VocabularyKey IsReservationLocked { get; private set; }
        public VocabularyKey CapacitySchedulingType { get; private set; }
        public VocabularyKey RouteJobType { get; private set; }
        public VocabularyKey RouteOperationNumber { get; private set; }
        public VocabularyKey RouteOperationPriority { get; private set; }
        public VocabularyKey PlanVersionRecId { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey CapacityReservationSeconds { get; private set; }
        public VocabularyKey LoadPercentage { get; private set; }
        public VocabularyKey ReservationReferenceNumber { get; private set; }
        public VocabularyKey ReservationSourceType { get; private set; }
        public VocabularyKey ScheduledStartTime { get; private set; }
        public VocabularyKey ReservationDate { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectActivityId { get; private set; }
        public VocabularyKey PlannedOrderNumber { get; private set; }
        public VocabularyKey RequirementPlanId { get; private set; }
        public VocabularyKey ReserveHours { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }


    }
}