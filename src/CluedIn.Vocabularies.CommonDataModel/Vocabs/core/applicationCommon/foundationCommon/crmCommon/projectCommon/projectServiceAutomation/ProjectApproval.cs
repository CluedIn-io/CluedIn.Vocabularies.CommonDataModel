using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class ProjectApprovalVocabulary : SimpleVocabulary
    {
        public ProjectApprovalVocabulary()
        {
            VocabularyName = "Project Approval";
            KeyPrefix = "commonDataModel.projectapproval.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProjectApproval;

            AddGroup("ProjectApproval Details for ProjectServiceAutomation", group =>
            {
			    ProjectApprovalId = group.Add(new VocabularyKey(nameof(ProjectApprovalId), "ApprovalsTable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApprovedOn = group.Add(new VocabularyKey(nameof(ApprovedOn), "Approved On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), "Cost Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostPriceBase = group.Add(new VocabularyKey(nameof(CostPriceBase), "Cost Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostQuantity = group.Add(new VocabularyKey(nameof(CostQuantity), "Submitted (hrs)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntryType = group.Add(new VocabularyKey(nameof(EntryType), "Entry Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalComments = group.Add(new VocabularyKey(nameof(ExternalComments), "External Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HasReceipt = group.Add(new VocabularyKey(nameof(HasReceipt), "Has Receipt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    InternalComments = group.Add(new VocabularyKey(nameof(InternalComments), "Internal Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JournalTransaction = group.Add(new VocabularyKey(nameof(JournalTransaction), "JournalTransaction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecordStage = group.Add(new VocabularyKey(nameof(RecordStage), "Record Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferenceExpenseId = group.Add(new VocabularyKey(nameof(ReferenceExpenseId), "Reference expense id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferenceTimeId = group.Add(new VocabularyKey(nameof(ReferenceTimeId), "Reference time id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), "Sales Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesPriceBase = group.Add(new VocabularyKey(nameof(SalesPriceBase), "Sales Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesQuantity = group.Add(new VocabularyKey(nameof(SalesQuantity), "Billable (hrs)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesAmount = group.Add(new VocabularyKey(nameof(SalesAmount), "Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesAmountBase = group.Add(new VocabularyKey(nameof(SalesAmountBase), "Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ExpenseEntry"/> to Vocab 'Expense.cdm.json/Expense' with Property 'ExpenseId'
            ///Property <see cref="ExpenseCategory"/> to Vocab 'ExpenseCategory.cdm.json/ExpenseCategory' with Property 'ExpenseCategoryId'
            ///Property <see cref="ReferenceJournalLine"/> to Vocab 'JournalLine.cdm.json/JournalLine' with Property 'JournalLineId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ApprovedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BookableResource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Manager"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ProjectTask"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            ///Property <see cref="SubmittedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="TimeEntry"/> to Vocab 'TimeEntry.cdm.json/TimeEntry' with Property 'TimeEntryId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ProjectApprovalId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ApprovedOn { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostPriceBase { get; private set; }
        public VocabularyKey CostQuantity { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey EntryType { get; private set; }
        public VocabularyKey ExternalComments { get; private set; }
        public VocabularyKey HasReceipt { get; private set; }
        public VocabularyKey InternalComments { get; private set; }
        public VocabularyKey JournalTransaction { get; private set; }
        public VocabularyKey RecordStage { get; private set; }
        public VocabularyKey ReferenceExpenseId { get; private set; }
        public VocabularyKey ReferenceTimeId { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceBase { get; private set; }
        public VocabularyKey SalesQuantity { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey SalesAmount { get; private set; }
        public VocabularyKey SalesAmountBase { get; private set; }
    }
}