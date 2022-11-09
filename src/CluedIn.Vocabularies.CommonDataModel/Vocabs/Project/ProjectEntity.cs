using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectEntityVocabulary : SimpleVocabulary
    {
        public ProjectEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjectEntity";
            KeyPrefix = "commonDataModel.projectentity";
            KeySeparator = ".";
            Grouping = "/ProjectEntity";

            AddGroup("Common Data Model ProjectEntity Details", group =>
            {
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AlternateProject = group.Add(new VocabularyKey(nameof(AlternateProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankDocumentType = group.Add(new VocabularyKey(nameof(BankDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertifiedPayroll = group.Add(new VocabularyKey(nameof(CertifiedPayroll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanVerifyCostAgainstRemainingForecast = group.Add(new VocabularyKey(nameof(CanVerifyCostAgainstRemainingForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaskCompletelyScheduled = group.Add(new VocabularyKey(nameof(TaskCompletelyScheduled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractAmendment = group.Add(new VocabularyKey(nameof(ZakatContractAmendment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractDate = group.Add(new VocabularyKey(nameof(ZakatContractDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractPeriod = group.Add(new VocabularyKey(nameof(ZakatContractPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatProjectValue = group.Add(new VocabularyKey(nameof(ZakatProjectValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateOfCreation = group.Add(new VocabularyKey(nameof(DateOfCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualEndDate = group.Add(new VocabularyKey(nameof(ActualEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExtensionDate = group.Add(new VocabularyKey(nameof(ExtensionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubprojectIDFormat = group.Add(new VocabularyKey(nameof(SubprojectIDFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Header = group.Add(new VocabularyKey(nameof(Header), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobIdentification = group.Add(new VocabularyKey(nameof(JobIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobPayType = group.Add(new VocabularyKey(nameof(JobPayType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumTimeIncrement = group.Add(new VocabularyKey(nameof(MinimumTimeIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentProject = group.Add(new VocabularyKey(nameof(ParentProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionTypesControlled = group.Add(new VocabularyKey(nameof(TransactionTypesControlled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetControlInterval = group.Add(new VocabularyKey(nameof(BudgetControlInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectBudgetManagement = group.Add(new VocabularyKey(nameof(ProjectBudgetManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetOverrunDefault = group.Add(new VocabularyKey(nameof(BudgetOverrunDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowNegativeBudgetsToBeCarriedForward = group.Add(new VocabularyKey(nameof(AllowNegativeBudgetsToBeCarriedForward), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanCarryForwardRemainingBudgets = group.Add(new VocabularyKey(nameof(CanCarryForwardRemainingBudgets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectedEndDate = group.Add(new VocabularyKey(nameof(ProjectedEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectedStartDate = group.Add(new VocabularyKey(nameof(ProjectedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectGroup = group.Add(new VocabularyKey(nameof(ProjectGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerPostingSortPriority = group.Add(new VocabularyKey(nameof(LedgerPostingSortPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SearchPriority = group.Add(new VocabularyKey(nameof(SearchPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceGroup = group.Add(new VocabularyKey(nameof(SalesPriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCost = group.Add(new VocabularyKey(nameof(InvoiceCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActiveRevision = group.Add(new VocabularyKey(nameof(ActiveRevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalRevision = group.Add(new VocabularyKey(nameof(ExternalRevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicingMethod = group.Add(new VocabularyKey(nameof(InvoicingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduleStatus = group.Add(new VocabularyKey(nameof(ScheduleStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DurationInDays = group.Add(new VocabularyKey(nameof(DurationInDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalEffortInHours = group.Add(new VocabularyKey(nameof(TotalEffortInHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate1 = group.Add(new VocabularyKey(nameof(EndDate1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PSASchedIgnoreCalendar = group.Add(new VocabularyKey(nameof(PSASchedIgnoreCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Scheduled = group.Add(new VocabularyKey(nameof(Scheduled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate1 = group.Add(new VocabularyKey(nameof(StartDate1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DurationDeterminesEndDate = group.Add(new VocabularyKey(nameof(DurationDeterminesEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForExpenseForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForExpenseForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForExpenseTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForExpenseTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForHourForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForHourForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForHourTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForHourTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForItemForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForItemForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForItemTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForItemTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualStartDate = group.Add(new VocabularyKey(nameof(ActualStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectStage = group.Add(new VocabularyKey(nameof(ProjectStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatSubject = group.Add(new VocabularyKey(nameof(ZakatSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTemplate = group.Add(new VocabularyKey(nameof(ProjectTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingLevel = group.Add(new VocabularyKey(nameof(PostingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectType = group.Add(new VocabularyKey(nameof(ProjectType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanUseAlternateProjectBudget = group.Add(new VocabularyKey(nameof(CanUseAlternateProjectBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanUseBudgetControl = group.Add(new VocabularyKey(nameof(CanUseBudgetControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimateProjectID = group.Add(new VocabularyKey(nameof(EstimateProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectManager = group.Add(new VocabularyKey(nameof(ProjectManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectController = group.Add(new VocabularyKey(nameof(ProjectController), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesManager = group.Add(new VocabularyKey(nameof(SalesManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateApplied = group.Add(new VocabularyKey(nameof(TemplateApplied), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AlertTimeFrameWeeks = group.Add(new VocabularyKey(nameof(AlertTimeFrameWeeks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationID = group.Add(new VocabularyKey(nameof(LocationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerArchitectPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerArchitectPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerRespFinancialPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerRespFinancialPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerRespSalesPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerRespSalesPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingId1 = group.Add(new VocabularyKey(nameof(SortingId1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingId2 = group.Add(new VocabularyKey(nameof(SortingId2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingId3 = group.Add(new VocabularyKey(nameof(SortingId3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProjectID { get; private set; }
public VocabularyKey AlternateProject { get; private set; }
public VocabularyKey FixedAssetNumber { get; private set; }
public VocabularyKey BankDocumentType { get; private set; }
public VocabularyKey CertifiedPayroll { get; private set; }
public VocabularyKey CanVerifyCostAgainstRemainingForecast { get; private set; }
public VocabularyKey TaskCompletelyScheduled { get; private set; }
public VocabularyKey ZakatContractAmendment { get; private set; }
public VocabularyKey ZakatContractDate { get; private set; }
public VocabularyKey ZakatContractPeriod { get; private set; }
public VocabularyKey ZakatProjectValue { get; private set; }
public VocabularyKey DateOfCreation { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey DeliveryName { get; private set; }
public VocabularyKey Email { get; private set; }
public VocabularyKey ActualEndDate { get; private set; }
public VocabularyKey ExtensionDate { get; private set; }
public VocabularyKey SubprojectIDFormat { get; private set; }
public VocabularyKey Header { get; private set; }
public VocabularyKey JobIdentification { get; private set; }
public VocabularyKey JobPayType { get; private set; }
public VocabularyKey MinimumTimeIncrement { get; private set; }
public VocabularyKey ProjectName { get; private set; }
public VocabularyKey ParentProject { get; private set; }
public VocabularyKey TransactionTypesControlled { get; private set; }
public VocabularyKey BudgetControlInterval { get; private set; }
public VocabularyKey ProjectBudgetManagement { get; private set; }
public VocabularyKey BudgetOverrunDefault { get; private set; }
public VocabularyKey AllowNegativeBudgetsToBeCarriedForward { get; private set; }
public VocabularyKey CanCarryForwardRemainingBudgets { get; private set; }
public VocabularyKey ProjectedEndDate { get; private set; }
public VocabularyKey ProjectedStartDate { get; private set; }
public VocabularyKey ProjectGroup { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey LedgerPostingSortPriority { get; private set; }
public VocabularyKey SearchPriority { get; private set; }
public VocabularyKey SalesPriceGroup { get; private set; }
public VocabularyKey InvoiceCost { get; private set; }
public VocabularyKey ActiveRevision { get; private set; }
public VocabularyKey ExternalRevision { get; private set; }
public VocabularyKey InvoicingMethod { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey ScheduleStatus { get; private set; }
public VocabularyKey Calendar { get; private set; }
public VocabularyKey DurationInDays { get; private set; }
public VocabularyKey TotalEffortInHours { get; private set; }
public VocabularyKey EndDate1 { get; private set; }
public VocabularyKey StartTime { get; private set; }
public VocabularyKey PSASchedIgnoreCalendar { get; private set; }
public VocabularyKey Scheduled { get; private set; }
public VocabularyKey StartDate1 { get; private set; }
public VocabularyKey EndTime { get; private set; }
public VocabularyKey DurationDeterminesEndDate { get; private set; }
public VocabularyKey IsActivityRequiredForExpenseForecast { get; private set; }
public VocabularyKey IsActivityRequiredForExpenseTransaction { get; private set; }
public VocabularyKey IsActivityRequiredForHourForecast { get; private set; }
public VocabularyKey IsActivityRequiredForHourTransaction { get; private set; }
public VocabularyKey IsActivityRequiredForItemForecast { get; private set; }
public VocabularyKey IsActivityRequiredForItemTransaction { get; private set; }
public VocabularyKey ActualStartDate { get; private set; }
public VocabularyKey ProjectStage { get; private set; }
public VocabularyKey ZakatSubject { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ProjectTemplate { get; private set; }
public VocabularyKey PostingLevel { get; private set; }
public VocabularyKey ProjectType { get; private set; }
public VocabularyKey CanUseAlternateProjectBudget { get; private set; }
public VocabularyKey CanUseBudgetControl { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey EstimateProjectID { get; private set; }
public VocabularyKey Reference { get; private set; }
public VocabularyKey ProjectManager { get; private set; }
public VocabularyKey ProjectController { get; private set; }
public VocabularyKey SalesManager { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TemplateApplied { get; private set; }
public VocabularyKey AlertTimeFrameWeeks { get; private set; }
public VocabularyKey LocationID { get; private set; }
public VocabularyKey WorkerArchitectPersonnelNumber { get; private set; }
public VocabularyKey WorkerRespFinancialPersonnelNumber { get; private set; }
public VocabularyKey WorkerResponsiblePersonnelNumber { get; private set; }
public VocabularyKey WorkerRespSalesPersonnelNumber { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }
public VocabularyKey SortingId1 { get; private set; }
public VocabularyKey SortingId2 { get; private set; }
public VocabularyKey SortingId3 { get; private set; }


    }
}