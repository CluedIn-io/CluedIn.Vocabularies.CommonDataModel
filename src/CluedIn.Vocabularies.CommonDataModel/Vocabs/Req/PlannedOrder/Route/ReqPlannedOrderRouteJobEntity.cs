using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqPlannedOrderRouteJobEntityVocabulary : SimpleVocabulary
    {
        public ReqPlannedOrderRouteJobEntityVocabulary()
        {
            VocabularyName = "Req Planned Order Route Job Entity";
            KeyPrefix = "commonDataModel.reqplannedorderroutejobentity";
            KeySeparator = ".";
            Grouping = "/ReqPlannedOrderRouteJobEntity";

            AddGroup("ReqPlannedOrderRouteJobEntity Details", group =>
            {
                CalculatedJobDurationHours = group.Add(new VocabularyKey(nameof(CalculatedJobDurationHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartDate = group.Add(new VocabularyKey(nameof(ScheduledStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartTime = group.Add(new VocabularyKey(nameof(ScheduledStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobManagementUsed = group.Add(new VocabularyKey(nameof(IsJobManagementUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLink = group.Add(new VocabularyKey(nameof(NextOperationLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLinkType = group.Add(new VocabularyKey(nameof(NextOperationLinkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryJobNumber = group.Add(new VocabularyKey(nameof(PrimaryJobNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryJobNumber = group.Add(new VocabularyKey(nameof(SecondaryJobNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobSequence = group.Add(new VocabularyKey(nameof(JobSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationPriority = group.Add(new VocabularyKey(nameof(RouteOperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumber = group.Add(new VocabularyKey(nameof(PlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobCancelled = group.Add(new VocabularyKey(nameof(IsJobCancelled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledJobDurationHours = group.Add(new VocabularyKey(nameof(ScheduledJobDurationHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanId = group.Add(new VocabularyKey(nameof(RequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteJobDataAreaId = group.Add(new VocabularyKey(nameof(RouteJobDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalculatedJobDurationHours { get; private set; }
        public VocabularyKey ScheduledStartDate { get; private set; }
        public VocabularyKey ScheduledStartTime { get; private set; }
        public VocabularyKey IsJobManagementUsed { get; private set; }
        public VocabularyKey RouteJobType { get; private set; }
        public VocabularyKey NextOperationLink { get; private set; }
        public VocabularyKey NextOperationLinkType { get; private set; }
        public VocabularyKey PrimaryJobNumber { get; private set; }
        public VocabularyKey SecondaryJobNumber { get; private set; }
        public VocabularyKey JobSequence { get; private set; }
        public VocabularyKey RouteOperationNumber { get; private set; }
        public VocabularyKey RouteOperationPriority { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey PlannedOrderNumber { get; private set; }
        public VocabularyKey IsJobCancelled { get; private set; }
        public VocabularyKey ScheduledJobDurationHours { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey ScheduledEndTime { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey RequirementPlanId { get; private set; }
        public VocabularyKey RouteJobDataAreaId { get; private set; }
    }
}