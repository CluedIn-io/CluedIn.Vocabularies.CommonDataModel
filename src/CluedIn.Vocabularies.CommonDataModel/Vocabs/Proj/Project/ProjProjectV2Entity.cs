using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectV2EntityVocabulary : SimpleVocabulary
    {
        public ProjProjectV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectV2Entity";
            KeyPrefix = "commonDataModel.projprojectv2entity";
            KeySeparator = ".";
            Grouping = "/ProjProjectV2Entity";

            AddGroup("Common Data Model ProjProjectV2Entity Details", group =>
            {
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AlternateProjectId = group.Add(new VocabularyKey(nameof(AlternateProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankDocumentType = group.Add(new VocabularyKey(nameof(BankDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCertifiedPayroll = group.Add(new VocabularyKey(nameof(IsCertifiedPayroll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanVerifyCostAgainstRemainingForecast = group.Add(new VocabularyKey(nameof(CanVerifyCostAgainstRemainingForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractAmendment = group.Add(new VocabularyKey(nameof(ZakatContractAmendment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractDate = group.Add(new VocabularyKey(nameof(ZakatContractDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatContractPeriod = group.Add(new VocabularyKey(nameof(ZakatContractPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatProjectValue = group.Add(new VocabularyKey(nameof(ZakatProjectValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateOfCreation = group.Add(new VocabularyKey(nameof(DateOfCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryLocation = group.Add(new VocabularyKey(nameof(DeliveryLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualEndDate = group.Add(new VocabularyKey(nameof(ActualEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExtensionDate = group.Add(new VocabularyKey(nameof(ExtensionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubprojectIdFormat = group.Add(new VocabularyKey(nameof(SubprojectIdFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsHeader = group.Add(new VocabularyKey(nameof(IsHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobIdentification = group.Add(new VocabularyKey(nameof(JobIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOCIPWorkerCompensation = group.Add(new VocabularyKey(nameof(IsOCIPWorkerCompensation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOCIPGeneralLiability = group.Add(new VocabularyKey(nameof(IsOCIPGeneralLiability), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentProjectId = group.Add(new VocabularyKey(nameof(ParentProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionTypesControlled = group.Add(new VocabularyKey(nameof(TransactionTypesControlled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetControlInterval = group.Add(new VocabularyKey(nameof(BudgetControlInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectBudgetManagement = group.Add(new VocabularyKey(nameof(ProjectBudgetManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetOverrunDefault = group.Add(new VocabularyKey(nameof(BudgetOverrunDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowNegativeBudgetsToBeCarriedForward = group.Add(new VocabularyKey(nameof(AllowNegativeBudgetsToBeCarriedForward), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanCarryForwardRemainingBudgets = group.Add(new VocabularyKey(nameof(CanCarryForwardRemainingBudgets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectedEndDate = group.Add(new VocabularyKey(nameof(ProjectedEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectedStartDate = group.Add(new VocabularyKey(nameof(ProjectedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectGroupId = group.Add(new VocabularyKey(nameof(ProjectGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerPostingSortPriority = group.Add(new VocabularyKey(nameof(LedgerPostingSortPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinePropertySearchPriority = group.Add(new VocabularyKey(nameof(LinePropertySearchPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceGroupId = group.Add(new VocabularyKey(nameof(SalesPriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SchedulingCalendarId = group.Add(new VocabularyKey(nameof(SchedulingCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduleDurationInDays = group.Add(new VocabularyKey(nameof(ScheduleDurationInDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalPlannedEffortInHours = group.Add(new VocabularyKey(nameof(TotalPlannedEffortInHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduleEndDate = group.Add(new VocabularyKey(nameof(ScheduleEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsResourceCalendarIgnored = group.Add(new VocabularyKey(nameof(IsResourceCalendarIgnored), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduleStartDate = group.Add(new VocabularyKey(nameof(ScheduleStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForExpenseForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForExpenseForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForExpenseTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForExpenseTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForHourForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForHourForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForHourTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForHourTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForItemForecast = group.Add(new VocabularyKey(nameof(IsActivityRequiredForItemForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivityRequiredForItemTransaction = group.Add(new VocabularyKey(nameof(IsActivityRequiredForItemTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualStartDate = group.Add(new VocabularyKey(nameof(ActualStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectStage = group.Add(new VocabularyKey(nameof(ProjectStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZakatSubject = group.Add(new VocabularyKey(nameof(ZakatSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupId = group.Add(new VocabularyKey(nameof(SalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProjectTemplate = group.Add(new VocabularyKey(nameof(IsProjectTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingLevel = group.Add(new VocabularyKey(nameof(PostingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanUseAlternateProjectBudget = group.Add(new VocabularyKey(nameof(CanUseAlternateProjectBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBudgetControlEnabled = group.Add(new VocabularyKey(nameof(IsBudgetControlEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProjectCategoryValidationEnabled = group.Add(new VocabularyKey(nameof(IsProjectCategoryValidationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimateProjectId = group.Add(new VocabularyKey(nameof(EstimateProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArchitectRecId = group.Add(new VocabularyKey(nameof(ArchitectRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectManagerRecId = group.Add(new VocabularyKey(nameof(ProjectManagerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectControllerRecId = group.Add(new VocabularyKey(nameof(ProjectControllerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesManagerRecId = group.Add(new VocabularyKey(nameof(SalesManagerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTemplateApplied = group.Add(new VocabularyKey(nameof(IsTemplateApplied), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArchitectPersonnelNumber = group.Add(new VocabularyKey(nameof(ArchitectPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectControllerPersonnelNumber = group.Add(new VocabularyKey(nameof(ProjectControllerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectManagerPersonnelNumber = group.Add(new VocabularyKey(nameof(ProjectManagerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesManagerPersonnelNumber = group.Add(new VocabularyKey(nameof(SalesManagerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingField1 = group.Add(new VocabularyKey(nameof(SortingField1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingField2 = group.Add(new VocabularyKey(nameof(SortingField2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingField3 = group.Add(new VocabularyKey(nameof(SortingField3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntegrationSourceDataId = group.Add(new VocabularyKey(nameof(IntegrationSourceDataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProjectId { get; private set; }
public VocabularyKey AlternateProjectId { get; private set; }
public VocabularyKey BankDocumentType { get; private set; }
public VocabularyKey IsCertifiedPayroll { get; private set; }
public VocabularyKey CanVerifyCostAgainstRemainingForecast { get; private set; }
public VocabularyKey ZakatContractAmendment { get; private set; }
public VocabularyKey ZakatContractDate { get; private set; }
public VocabularyKey ZakatContractPeriod { get; private set; }
public VocabularyKey ZakatProjectValue { get; private set; }
public VocabularyKey DateOfCreation { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey DefaultLedgerDimension { get; private set; }
public VocabularyKey DeliveryLocation { get; private set; }
public VocabularyKey DeliveryName { get; private set; }
public VocabularyKey Email { get; private set; }
public VocabularyKey ActualEndDate { get; private set; }
public VocabularyKey ExtensionDate { get; private set; }
public VocabularyKey SubprojectIdFormat { get; private set; }
public VocabularyKey IsHeader { get; private set; }
public VocabularyKey JobIdentification { get; private set; }
public VocabularyKey ProjectName { get; private set; }
public VocabularyKey IsOCIPWorkerCompensation { get; private set; }
public VocabularyKey IsOCIPGeneralLiability { get; private set; }
public VocabularyKey ParentProjectId { get; private set; }
public VocabularyKey TransactionTypesControlled { get; private set; }
public VocabularyKey BudgetControlInterval { get; private set; }
public VocabularyKey ProjectBudgetManagement { get; private set; }
public VocabularyKey BudgetOverrunDefault { get; private set; }
public VocabularyKey AllowNegativeBudgetsToBeCarriedForward { get; private set; }
public VocabularyKey CanCarryForwardRemainingBudgets { get; private set; }
public VocabularyKey ProjectedEndDate { get; private set; }
public VocabularyKey ProjectedStartDate { get; private set; }
public VocabularyKey ProjectGroupId { get; private set; }
public VocabularyKey ProjectContractId { get; private set; }
public VocabularyKey LedgerPostingSortPriority { get; private set; }
public VocabularyKey LinePropertySearchPriority { get; private set; }
public VocabularyKey SalesPriceGroupId { get; private set; }
public VocabularyKey SchedulingCalendarId { get; private set; }
public VocabularyKey ScheduleDurationInDays { get; private set; }
public VocabularyKey TotalPlannedEffortInHours { get; private set; }
public VocabularyKey ScheduleEndDate { get; private set; }
public VocabularyKey IsResourceCalendarIgnored { get; private set; }
public VocabularyKey ScheduleStartDate { get; private set; }
public VocabularyKey IsActivityRequiredForExpenseForecast { get; private set; }
public VocabularyKey IsActivityRequiredForExpenseTransaction { get; private set; }
public VocabularyKey IsActivityRequiredForHourForecast { get; private set; }
public VocabularyKey IsActivityRequiredForHourTransaction { get; private set; }
public VocabularyKey IsActivityRequiredForItemForecast { get; private set; }
public VocabularyKey IsActivityRequiredForItemTransaction { get; private set; }
public VocabularyKey ActualStartDate { get; private set; }
public VocabularyKey ProjectStage { get; private set; }
public VocabularyKey ZakatSubject { get; private set; }
public VocabularyKey SalesTaxGroupId { get; private set; }
public VocabularyKey IsProjectTemplate { get; private set; }
public VocabularyKey PostingLevel { get; private set; }
public VocabularyKey CanUseAlternateProjectBudget { get; private set; }
public VocabularyKey IsBudgetControlEnabled { get; private set; }
public VocabularyKey IsProjectCategoryValidationEnabled { get; private set; }
public VocabularyKey EstimateProjectId { get; private set; }
public VocabularyKey ArchitectRecId { get; private set; }
public VocabularyKey ProjectManagerRecId { get; private set; }
public VocabularyKey ProjectControllerRecId { get; private set; }
public VocabularyKey SalesManagerRecId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey IsTemplateApplied { get; private set; }
public VocabularyKey DeliveryAddressLocationId { get; private set; }
public VocabularyKey ArchitectPersonnelNumber { get; private set; }
public VocabularyKey ProjectControllerPersonnelNumber { get; private set; }
public VocabularyKey ProjectManagerPersonnelNumber { get; private set; }
public VocabularyKey SalesManagerPersonnelNumber { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }
public VocabularyKey SortingField1 { get; private set; }
public VocabularyKey SortingField2 { get; private set; }
public VocabularyKey SortingField3 { get; private set; }
public VocabularyKey IntegrationSourceDataId { get; private set; }


    }
}