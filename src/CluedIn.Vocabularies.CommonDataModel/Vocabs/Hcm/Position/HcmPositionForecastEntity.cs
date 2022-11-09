using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionForecastEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionForecastEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmPositionForecastEntity";
            KeyPrefix = "commonDataModel.hcmpositionforecastentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionForecastEntity";

            AddGroup("Common Data Model HcmPositionForecastEntity Details", group =>
            {
                AnnualAmount = group.Add(new VocabularyKey(nameof(AnnualAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCostElement = group.Add(new VocabularyKey(nameof(BudgetCostElement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineStartDate = group.Add(new VocabularyKey(nameof(CostElementLineStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineEndDate = group.Add(new VocabularyKey(nameof(CostElementLineEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isPercentageBased = group.Add(new VocabularyKey(nameof(isPercentageBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineMainAccount = group.Add(new VocabularyKey(nameof(CostElementLineMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementSource = group.Add(new VocabularyKey(nameof(CostElementSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineCompensationGrid = group.Add(new VocabularyKey(nameof(CostElementLineCompensationGrid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementRecId = group.Add(new VocabularyKey(nameof(CostElementRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementEffectiveDate = group.Add(new VocabularyKey(nameof(CostElementEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementExpirationDate = group.Add(new VocabularyKey(nameof(CostElementExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLegalEntity = group.Add(new VocabularyKey(nameof(CostElementLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementName = group.Add(new VocabularyKey(nameof(CostElementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDataAreaId = group.Add(new VocabularyKey(nameof(CostElementDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionActivationDate = group.Add(new VocabularyKey(nameof(ForecastPositionActivationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnniversaryDate = group.Add(new VocabularyKey(nameof(AnniversaryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionCompensationGroupDataAreaId = group.Add(new VocabularyKey(nameof(ForecastPositionCompensationGroupDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionCompensationGroupId = group.Add(new VocabularyKey(nameof(ForecastPositionCompensationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastScenario = group.Add(new VocabularyKey(nameof(ForecastScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionFullTimeEquivalency = group.Add(new VocabularyKey(nameof(ForecastPositionFullTimeEquivalency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionPositionLegalEntity = group.Add(new VocabularyKey(nameof(ForecastPositionPositionLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPosition = group.Add(new VocabularyKey(nameof(ForecastPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionCompensationLevelRecId = group.Add(new VocabularyKey(nameof(ForecastPositionCompensationLevelRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionRetirementDate = group.Add(new VocabularyKey(nameof(ForecastPositionRetirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssignedWorker = group.Add(new VocabularyKey(nameof(AssignedWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanScenario = group.Add(new VocabularyKey(nameof(BudgetPlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanScenarioName = group.Add(new VocabularyKey(nameof(BudgetPlanScenarioName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionRecId = group.Add(new VocabularyKey(nameof(ForecastPositionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionId = group.Add(new VocabularyKey(nameof(ForecastPositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionLegalEnitytName = group.Add(new VocabularyKey(nameof(ForecastPositionLegalEnitytName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineReferencePointId = group.Add(new VocabularyKey(nameof(CostElementLineReferencePointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineReferenceSetupId = group.Add(new VocabularyKey(nameof(CostElementLineReferenceSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementLineMainAccountDisplayValue = group.Add(new VocabularyKey(nameof(CostElementLineMainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionCompensationGrid = group.Add(new VocabularyKey(nameof(ForecastPositionCompensationGrid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanningProcessName = group.Add(new VocabularyKey(nameof(BudgetPlanningProcessName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionRefPointId = group.Add(new VocabularyKey(nameof(ForecastPositionRefPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastPositionRefPointSetupId = group.Add(new VocabularyKey(nameof(ForecastPositionRefPointSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionType = group.Add(new VocabularyKey(nameof(PositionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompLocation = group.Add(new VocabularyKey(nameof(CompLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompensationRegionId = group.Add(new VocabularyKey(nameof(CompensationRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionTypeId = group.Add(new VocabularyKey(nameof(PositionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompensationLevelId = group.Add(new VocabularyKey(nameof(CompensationLevelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AnnualAmount { get; private set; }
public VocabularyKey BudgetAmount { get; private set; }
public VocabularyKey BudgetCostElement { get; private set; }
public VocabularyKey CostElementLineStartDate { get; private set; }
public VocabularyKey CostElementLineEndDate { get; private set; }
public VocabularyKey isPercentageBased { get; private set; }
public VocabularyKey CostElementLineMainAccount { get; private set; }
public VocabularyKey Percent { get; private set; }
public VocabularyKey CostElementSource { get; private set; }
public VocabularyKey CostElementLineCompensationGrid { get; private set; }
public VocabularyKey CostElementRecId { get; private set; }
public VocabularyKey CostElementEffectiveDate { get; private set; }
public VocabularyKey CostElementExpirationDate { get; private set; }
public VocabularyKey CostElementLegalEntity { get; private set; }
public VocabularyKey CostElementName { get; private set; }
public VocabularyKey CostElementDataAreaId { get; private set; }
public VocabularyKey ForecastPositionActivationDate { get; private set; }
public VocabularyKey AnniversaryDate { get; private set; }
public VocabularyKey ForecastPositionCompensationGroupDataAreaId { get; private set; }
public VocabularyKey ForecastPositionCompensationGroupId { get; private set; }
public VocabularyKey ForecastScenario { get; private set; }
public VocabularyKey ForecastPositionFullTimeEquivalency { get; private set; }
public VocabularyKey ForecastPositionPositionLegalEntity { get; private set; }
public VocabularyKey ForecastPosition { get; private set; }
public VocabularyKey ForecastPositionCompensationLevelRecId { get; private set; }
public VocabularyKey ForecastPositionRetirementDate { get; private set; }
public VocabularyKey AssignedWorker { get; private set; }
public VocabularyKey BudgetPlanningProcess { get; private set; }
public VocabularyKey BudgetPlanScenario { get; private set; }
public VocabularyKey BudgetPlanScenarioName { get; private set; }
public VocabularyKey ForecastPositionRecId { get; private set; }
public VocabularyKey ForecastPositionId { get; private set; }
public VocabularyKey ForecastPositionLegalEnitytName { get; private set; }
public VocabularyKey CostElementLineReferencePointId { get; private set; }
public VocabularyKey CostElementLineReferenceSetupId { get; private set; }
public VocabularyKey CostElementLineMainAccountDisplayValue { get; private set; }
public VocabularyKey ForecastPositionCompensationGrid { get; private set; }
public VocabularyKey BudgetPlanningProcessName { get; private set; }
public VocabularyKey ForecastPositionRefPointId { get; private set; }
public VocabularyKey ForecastPositionRefPointSetupId { get; private set; }
public VocabularyKey Department { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Job { get; private set; }
public VocabularyKey PositionType { get; private set; }
public VocabularyKey Title { get; private set; }
public VocabularyKey CompLocation { get; private set; }
public VocabularyKey JobId { get; private set; }
public VocabularyKey DepartmentNumber { get; private set; }
public VocabularyKey CompensationRegionId { get; private set; }
public VocabularyKey PositionTypeId { get; private set; }
public VocabularyKey TitleId { get; private set; }
public VocabularyKey CompensationLevelId { get; private set; }


    }
}