using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectTaskVocabulary : SimpleVocabulary
    {
        public ProjectTaskVocabulary()
        {
            VocabularyName = "Project Task";
            KeyPrefix = "commonDataModel.projecttask.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectTask";

            AddGroup("ProjectTask Details for ProjectServiceAutomation", group =>
            {
			    ProjectTaskId = group.Add(new VocabularyKey(nameof(ProjectTaskId), "Project task", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Project Task Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProjectTaskName = group.Add(new VocabularyKey(nameof(ProjectTaskName), "Project Task Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDuration = group.Add(new VocabularyKey(nameof(ActualDuration), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualEffort = group.Add(new VocabularyKey(nameof(ActualEffort), "Actual Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualEndDateTime = group.Add(new VocabularyKey(nameof(ActualEndDateTime), "Actual End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualSales = group.Add(new VocabularyKey(nameof(ActualSales), "Actual Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualsalesBase = group.Add(new VocabularyKey(nameof(ActualsalesBase), "Actual Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AggregationDirection = group.Add(new VocabularyKey(nameof(AggregationDirection), "Aggregation Direction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssignedResources = group.Add(new VocabularyKey(nameof(AssignedResources), "Assigned Resources (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AutoScheduling = group.Add(new VocabularyKey(nameof(AutoScheduling), "Auto Scheduling", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CostEstimateContour = group.Add(new VocabularyKey(nameof(CostEstimateContour), "CostEstimateContour (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Estimated Effort", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EffortContour = group.Add(new VocabularyKey(nameof(EffortContour), "Effort Contour (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffortEstimateAtComplete = group.Add(new VocabularyKey(nameof(EffortEstimateAtComplete), "Effort estimate at complete (EAC)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsLineTask = group.Add(new VocabularyKey(nameof(IsLineTask), "IsLineTask", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMilestone = group.Add(new VocabularyKey(nameof(IsMilestone), "Is Milestone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MSProjectClientId = group.Add(new VocabularyKey(nameof(MSProjectClientId), "MS Project Client Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfResources = group.Add(new VocabularyKey(nameof(NumberOfResources), "Number of resources (Deprecated in v3.0)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PlannedCost = group.Add(new VocabularyKey(nameof(PlannedCost), "Planned cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedCostBase = group.Add(new VocabularyKey(nameof(PlannedCostBase), "Estimated cost", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedSales = group.Add(new VocabularyKey(nameof(PlannedSales), "Planned Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedSalesBase = group.Add(new VocabularyKey(nameof(PlannedSalesBase), "Planned Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PluginProcessingData = group.Add(new VocabularyKey(nameof(PluginProcessingData), "Plugin Processing Data", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Progress = group.Add(new VocabularyKey(nameof(Progress), "Progress %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RemainingCost = group.Add(new VocabularyKey(nameof(RemainingCost), "Remaining Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RemainingCostBase = group.Add(new VocabularyKey(nameof(RemainingCostBase), "Remaining Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemainingHours = group.Add(new VocabularyKey(nameof(RemainingHours), "Remaining Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RemainingSales = group.Add(new VocabularyKey(nameof(RemainingSales), "Remaining Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RemainingSalesBase = group.Add(new VocabularyKey(nameof(RemainingSalesBase), "Remaining Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedHours = group.Add(new VocabularyKey(nameof(RequestedHours), "Requested Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ResourceUtilization = group.Add(new VocabularyKey(nameof(ResourceUtilization), "ResourceUtilization", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesEstimateContour = group.Add(new VocabularyKey(nameof(SalesEstimateContour), "SalesEstimateContour (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledHours = group.Add(new VocabularyKey(nameof(ScheduledHours), "Scheduled Hours (Deprecated in v3.0)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ScheduleStartDate = group.Add(new VocabularyKey(nameof(ScheduleStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleVariance = group.Add(new VocabularyKey(nameof(ScheduleVariance), "Schedule Variance", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SkipUpdateEstimateLine = group.Add(new VocabularyKey(nameof(SkipUpdateEstimateLine), "Skip Update Estimate Line", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    WBSID = group.Add(new VocabularyKey(nameof(WBSID), "WBS ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostAtCompleteEstimate = group.Add(new VocabularyKey(nameof(CostAtCompleteEstimate), "Cost estimate at complete (EAC)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostAtCompleteEstimateBase = group.Add(new VocabularyKey(nameof(CostAtCompleteEstimateBase), "Cost estimate at completion (EAC) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostConsumptionPercentage = group.Add(new VocabularyKey(nameof(CostConsumptionPercentage), "Cost Consumption %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesConsumptionPercentage = group.Add(new VocabularyKey(nameof(SalesConsumptionPercentage), "Sales Consumption %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesEstimateAtComplete = group.Add(new VocabularyKey(nameof(SalesEstimateAtComplete), "Sales Estimate At Complete (EAC)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesEstimateAtCompleteBase = group.Add(new VocabularyKey(nameof(SalesEstimateAtCompleteBase), "Sales Estimate At Complete (EAC) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesVariance = group.Add(new VocabularyKey(nameof(SalesVariance), "Sales Variance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesVarianceBase = group.Add(new VocabularyKey(nameof(SalesVarianceBase), "Sales Variance (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VarianceOfCost = group.Add(new VocabularyKey(nameof(VarianceOfCost), "Cost Variance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    VarianceOfCostBase = group.Add(new VocabularyKey(nameof(VarianceOfCostBase), "Cost Variance (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProjectTaskId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ProjectTaskName { get; private set; }
        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey ActualDuration { get; private set; }
        public VocabularyKey ActualEffort { get; private set; }
        public VocabularyKey ActualEndDateTime { get; private set; }
        public VocabularyKey ActualSales { get; private set; }
        public VocabularyKey ActualsalesBase { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey AggregationDirection { get; private set; }
        public VocabularyKey AssignedResources { get; private set; }
        public VocabularyKey AutoScheduling { get; private set; }
        public VocabularyKey CostEstimateContour { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey EffortContour { get; private set; }
        public VocabularyKey EffortEstimateAtComplete { get; private set; }
        public VocabularyKey IsLineTask { get; private set; }
        public VocabularyKey IsMilestone { get; private set; }
        public VocabularyKey MSProjectClientId { get; private set; }
        public VocabularyKey NumberOfResources { get; private set; }
        public VocabularyKey PlannedCost { get; private set; }
        public VocabularyKey PlannedCostBase { get; private set; }
        public VocabularyKey PlannedSales { get; private set; }
        public VocabularyKey PlannedSalesBase { get; private set; }
        public VocabularyKey PluginProcessingData { get; private set; }
        public VocabularyKey Progress { get; private set; }
        public VocabularyKey RemainingCost { get; private set; }
        public VocabularyKey RemainingCostBase { get; private set; }
        public VocabularyKey RemainingHours { get; private set; }
        public VocabularyKey RemainingSales { get; private set; }
        public VocabularyKey RemainingSalesBase { get; private set; }
        public VocabularyKey RequestedHours { get; private set; }
        public VocabularyKey ResourceUtilization { get; private set; }
        public VocabularyKey SalesEstimateContour { get; private set; }
        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey ScheduledHours { get; private set; }
        public VocabularyKey ScheduleStartDate { get; private set; }
        public VocabularyKey ScheduleVariance { get; private set; }
        public VocabularyKey SkipUpdateEstimateLine { get; private set; }
        public VocabularyKey WBSID { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey CostAtCompleteEstimate { get; private set; }
        public VocabularyKey CostAtCompleteEstimateBase { get; private set; }
        public VocabularyKey CostConsumptionPercentage { get; private set; }
        public VocabularyKey SalesConsumptionPercentage { get; private set; }
        public VocabularyKey SalesEstimateAtComplete { get; private set; }
        public VocabularyKey SalesEstimateAtCompleteBase { get; private set; }
        public VocabularyKey SalesVariance { get; private set; }
        public VocabularyKey SalesVarianceBase { get; private set; }
        public VocabularyKey VarianceOfCost { get; private set; }
        public VocabularyKey VarianceOfCostBase { get; private set; }
    }
}