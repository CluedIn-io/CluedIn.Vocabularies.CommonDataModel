using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitVolunteers
{
    public class ProjectVocabulary : SimpleVocabulary
    {
        public ProjectVocabulary()
        {
            VocabularyName = "Project";
            KeyPrefix = "commonDataModel.project.nonprofitvolunteers";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Project;

            AddGroup("Project Details for NonProfitVolunteers", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}