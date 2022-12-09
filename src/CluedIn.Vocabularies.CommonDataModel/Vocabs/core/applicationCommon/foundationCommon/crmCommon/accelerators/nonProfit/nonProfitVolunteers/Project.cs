using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ProjectVocabulary : SimpleVocabulary
    {
        public ProjectVocabulary()
        {
            VocabularyName = "Project";
            KeyPrefix = "commonDataModel.project";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Project;

            AddGroup("Project Details for NonProfitVolunteers", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Project Details for ProjectServiceAutomation", group =>
            {
			    ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), "Project", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Project Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDuration = group.Add(new VocabularyKey(nameof(ActualDuration), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualExpenseCost = group.Add(new VocabularyKey(nameof(ActualExpenseCost), "Actual Expense Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualexpensecostBase = group.Add(new VocabularyKey(nameof(ActualexpensecostBase), "Actual Expense Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualHours = group.Add(new VocabularyKey(nameof(ActualHours), "Actual Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualLaborCost = group.Add(new VocabularyKey(nameof(ActualLaborCost), "Actual Labor Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActuallaborcostBase = group.Add(new VocabularyKey(nameof(ActuallaborcostBase), "Actual Labor Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualSales = group.Add(new VocabularyKey(nameof(ActualSales), "Actual Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualsalesBase = group.Add(new VocabularyKey(nameof(ActualsalesBase), "Actual Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BulkGenerationStatus = group.Add(new VocabularyKey(nameof(BulkGenerationStatus), "Bulk Generation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisableCreateOfTeamMemberForProjectManager = group.Add(new VocabularyKey(nameof(DisableCreateOfTeamMemberForProjectManager), "Disable create of team member for project manager", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EffortestimateatcompleteEAC = group.Add(new VocabularyKey(nameof(EffortestimateatcompleteEAC), "Effort estimate at complete (EAC)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProjectExchangeRate = group.Add(new VocabularyKey(nameof(ProjectExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsLinkedToMSProjectClient = group.Add(new VocabularyKey(nameof(IsLinkedToMSProjectClient), "Is Linked To MS Project Client", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Is Template", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LinkedDocumentURL = group.Add(new VocabularyKey(nameof(LinkedDocumentURL), "Linked Document URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    OverallProjectStatus = group.Add(new VocabularyKey(nameof(OverallProjectStatus), "Overall Project Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedExpenseCost = group.Add(new VocabularyKey(nameof(EstimatedExpenseCost), "Estimated Expense Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedexpensecostBase = group.Add(new VocabularyKey(nameof(PlannedexpensecostBase), "Estimated Expense Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedHours = group.Add(new VocabularyKey(nameof(EstimatedHours), "Estimated Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstimatedLaborCost = group.Add(new VocabularyKey(nameof(EstimatedLaborCost), "Estimated Labor Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedlaborcostBase = group.Add(new VocabularyKey(nameof(PlannedlaborcostBase), "Estimated Labor Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedSales = group.Add(new VocabularyKey(nameof(PlannedSales), "Planned Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedSalesBase = group.Add(new VocabularyKey(nameof(PlannedSalesBase), "Planned Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Progress = group.Add(new VocabularyKey(nameof(Progress), "Progress %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProjectResourceRequirementsVisibleToResources = group.Add(new VocabularyKey(nameof(ProjectResourceRequirementsVisibleToResources), "Project resource requirements visible to resources", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RemainingCost = group.Add(new VocabularyKey(nameof(RemainingCost), "Remaining Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RemainingCostBase = group.Add(new VocabularyKey(nameof(RemainingCostBase), "Remaining Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemainingHours = group.Add(new VocabularyKey(nameof(RemainingHours), "Remaining Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RemainingSales = group.Add(new VocabularyKey(nameof(RemainingSales), "Remaining Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RemainingSalesBase = group.Add(new VocabularyKey(nameof(RemainingSalesBase), "Remaining Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EstimatedFinishDate = group.Add(new VocabularyKey(nameof(EstimatedFinishDate), "Estimated Finish Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleStartDate = group.Add(new VocabularyKey(nameof(ScheduleStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SchedulePerformance = group.Add(new VocabularyKey(nameof(SchedulePerformance), "Schedule Performance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleVariance = group.Add(new VocabularyKey(nameof(ScheduleVariance), "Schedule Variance", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StageName = group.Add(new VocabularyKey(nameof(StageName), "Stage Name (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusUpdatedOn = group.Add(new VocabularyKey(nameof(StatusUpdatedOn), "Status Updated On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalActualCost = group.Add(new VocabularyKey(nameof(TotalActualCost), "Actual Total Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalActualCostBase = group.Add(new VocabularyKey(nameof(TotalActualCostBase), "Actual Total Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalPlannedCost = group.Add(new VocabularyKey(nameof(TotalPlannedCost), "Estimated Total Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPlannedCostBase = group.Add(new VocabularyKey(nameof(TotalPlannedCostBase), "Estimated Total Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WbsDuration = group.Add(new VocabularyKey(nameof(WbsDuration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CostConsumption = group.Add(new VocabularyKey(nameof(CostConsumption), "Cost Consumption %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostEstimateAtComplete = group.Add(new VocabularyKey(nameof(CostEstimateAtComplete), "Cost estimate at completion (EAC)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostEstimateAtCompleteBase = group.Add(new VocabularyKey(nameof(CostEstimateAtCompleteBase), "Cost estimate at completion (EAC)(Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPerformence = group.Add(new VocabularyKey(nameof(CostPerformence), "Cost Performance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostVariance = group.Add(new VocabularyKey(nameof(CostVariance), "Cost Variance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostVarianceBase = group.Add(new VocabularyKey(nameof(CostVarianceBase), "Cost Variance (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesConsumption = group.Add(new VocabularyKey(nameof(SalesConsumption), "Sales Consumption %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesEstimateAtCompleteEAC = group.Add(new VocabularyKey(nameof(SalesEstimateAtCompleteEAC), "Sales Estimate At Complete (EAC)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesEstimateAtCompleteEACBase = group.Add(new VocabularyKey(nameof(SalesEstimateAtCompleteEACBase), "Sales Estimate At Complete (EAC) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesVariance = group.Add(new VocabularyKey(nameof(SalesVariance), "Sales Variance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesVarianceBase = group.Add(new VocabularyKey(nameof(SalesVarianceBase), "Sales Variance (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeamSize = group.Add(new VocabularyKey(nameof(TeamSize), "Team Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TeamsizeDate = group.Add(new VocabularyKey(nameof(TeamsizeDate), "Team Size (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeamsizeState = group.Add(new VocabularyKey(nameof(TeamsizeState), "Team Size (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Customer"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContractOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="ProjectManager"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ProjectTeamId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ProjectTemplate"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="SalesOrderId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="WorkHourTemplate"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/WorkHourTemplate.cdm.json/WorkHourTemplate' with Property 'WorkHourTemplateId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="ProjectTemplate"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ProjectId"/> from Vocab 'Project.cdm.json/Project' with Property 'ProjectTemplate'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ProjectId'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'ProjectId'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ContractLineScheduleOfValue.cdm.json/ContractLineScheduleOfValue' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Estimate.cdm.json/Estimate' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Fact.cdm.json/Fact' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Journal.cdm.json/Journal' with Property 'DefaultProject'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderProduct.cdm.json/OrderProduct' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectTemplate'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectApproval.cdm.json/ProjectApproval' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectPriceList.cdm.json/ProjectPriceList' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTask.cdm.json/ProjectTask' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTaskDependency.cdm.json/ProjectTaskDependency' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTransactionCategory.cdm.json/ProjectTransactionCategory' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteProduct.cdm.json/QuoteProduct' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceAssignment.cdm.json/ResourceAssignment' with Property 'ProjectId'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TimeEntry.cdm.json/TimeEntry' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'Project'
            ///Property <see cref="ProjectId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ProjectId'
            ///Property <see cref="ProjectTeamId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ProjectTeamId'
            #endregion
        }

        public VocabularyKey ActualDuration { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualExpenseCost { get; private set; }
        public VocabularyKey ActualexpensecostBase { get; private set; }
        public VocabularyKey ActualHours { get; private set; }
        public VocabularyKey ActualLaborCost { get; private set; }
        public VocabularyKey ActuallaborcostBase { get; private set; }
        public VocabularyKey ActualSales { get; private set; }
        public VocabularyKey ActualsalesBase { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey BulkGenerationStatus { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey CostConsumption { get; private set; }
        public VocabularyKey CostEstimateAtComplete { get; private set; }
        public VocabularyKey CostEstimateAtCompleteBase { get; private set; }
        public VocabularyKey CostPerformence { get; private set; }
        public VocabularyKey CostVariance { get; private set; }
        public VocabularyKey CostVarianceBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisableCreateOfTeamMemberForProjectManager { get; private set; }
        public VocabularyKey EffortestimateatcompleteEAC { get; private set; }
        public VocabularyKey EstimatedExpenseCost { get; private set; }
        public VocabularyKey EstimatedFinishDate { get; private set; }
        public VocabularyKey EstimatedHours { get; private set; }
        public VocabularyKey EstimatedLaborCost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey IsLinkedToMSProjectClient { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey LinkedDocumentURL { get; private set; }
        public VocabularyKey OverallProjectStatus { get; private set; }
        public VocabularyKey PlannedexpensecostBase { get; private set; }
        public VocabularyKey PlannedlaborcostBase { get; private set; }
        public VocabularyKey PlannedSales { get; private set; }
        public VocabularyKey PlannedSalesBase { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey Progress { get; private set; }
        public VocabularyKey ProjectExchangeRate { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectResourceRequirementsVisibleToResources { get; private set; }
        public VocabularyKey RemainingCost { get; private set; }
        public VocabularyKey RemainingCostBase { get; private set; }
        public VocabularyKey RemainingHours { get; private set; }
        public VocabularyKey RemainingSales { get; private set; }
        public VocabularyKey RemainingSalesBase { get; private set; }
        public VocabularyKey SalesConsumption { get; private set; }
        public VocabularyKey SalesEstimateAtCompleteEAC { get; private set; }
        public VocabularyKey SalesEstimateAtCompleteEACBase { get; private set; }
        public VocabularyKey SalesVariance { get; private set; }
        public VocabularyKey SalesVarianceBase { get; private set; }
        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey SchedulePerformance { get; private set; }
        public VocabularyKey ScheduleStartDate { get; private set; }
        public VocabularyKey ScheduleVariance { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StageName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusUpdatedOn { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey TeamSize { get; private set; }
        public VocabularyKey TeamsizeDate { get; private set; }
        public VocabularyKey TeamsizeState { get; private set; }
        public VocabularyKey TotalActualCost { get; private set; }
        public VocabularyKey TotalActualCostBase { get; private set; }
        public VocabularyKey TotalPlannedCost { get; private set; }
        public VocabularyKey TotalPlannedCostBase { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey WbsDuration { get; private set; }
    }
}