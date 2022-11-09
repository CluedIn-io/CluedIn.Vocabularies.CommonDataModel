using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlConfigurationEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlConfigurationEntity";
            KeyPrefix = "commonDataModel.budgetcontrolconfigurationentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlConfigurationEntity";

            AddGroup("Common Data Model BudgetControlConfigurationEntity Details", group =>
            {
                DefaultBudgetCycleTimeSpan = group.Add(new VocabularyKey(nameof(DefaultBudgetCycleTimeSpan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBudgetCycleTimeSpanFiscalCalendarId = group.Add(new VocabularyKey(nameof(DefaultBudgetCycleTimeSpanFiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBudgetCycleTimeSpanName = group.Add(new VocabularyKey(nameof(DefaultBudgetCycleTimeSpanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBudgetControlInterval = group.Add(new VocabularyKey(nameof(DefaultBudgetControlInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBudgetManager = group.Add(new VocabularyKey(nameof(DefaultBudgetManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBudgetThresholdPercent = group.Add(new VocabularyKey(nameof(DefaultBudgetThresholdPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionHierarchyAccountStructure = group.Add(new VocabularyKey(nameof(DimensionHierarchyAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayAMessageWhenExceedingBudgetThreshold = group.Add(new VocabularyKey(nameof(DisplayAMessageWhenExceedingBudgetThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseSinceDateTime = group.Add(new VocabularyKey(nameof(InUseSinceDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLedger = group.Add(new VocabularyKey(nameof(PrimaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumOriginalBudgetInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumOriginalBudgetInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumPreliminaryBudgetInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumPreliminaryBudgetInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumRevisionsInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumRevisionsInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumDraftRevisionsInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumDraftRevisionsInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumTransfersInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumTransfersInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumDraftTransfersInInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumDraftTransfersInInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumDraftTransfersOutInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SumDraftTransfersOutInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeCarryforwardAmountsInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(IncludeCarryforwardAmountsInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractActualExpendituresInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractActualExpendituresInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractUnpostedActualExpendituresInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractUnpostedActualExpendituresInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractEncumbrancesInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractEncumbrancesInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractUnconfirmedEncumbrancesInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractUnconfirmedEncumbrancesInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractUnconfirmedEncumbranceReductionsInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractUnconfirmedEncumbranceReductionsInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractPreencumbrancesInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractPreencumbrancesInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubtractUnconfirmedPreencumbrancesInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(SubtractUnconfirmedPreencumbrancesInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseOnlyApportionedAmountInBudgetFundsAvailableCalculation = group.Add(new VocabularyKey(nameof(UseOnlyApportionedAmountInBudgetFundsAvailableCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultBudgetCycleTimeSpan { get; private set; }
public VocabularyKey DefaultBudgetCycleTimeSpanFiscalCalendarId { get; private set; }
public VocabularyKey DefaultBudgetCycleTimeSpanName { get; private set; }
public VocabularyKey DefaultBudgetControlInterval { get; private set; }
public VocabularyKey DefaultBudgetManager { get; private set; }
public VocabularyKey DefaultBudgetThresholdPercent { get; private set; }
public VocabularyKey DimensionHierarchyAccountStructure { get; private set; }
public VocabularyKey AccountStructure { get; private set; }
public VocabularyKey DisplayAMessageWhenExceedingBudgetThreshold { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey InUseSinceDateTime { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey PrimaryLedger { get; private set; }
public VocabularyKey SumOriginalBudgetInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumPreliminaryBudgetInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumRevisionsInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumDraftRevisionsInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumTransfersInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumDraftTransfersInInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SumDraftTransfersOutInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey IncludeCarryforwardAmountsInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractActualExpendituresInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractUnpostedActualExpendituresInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractEncumbrancesInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractUnconfirmedEncumbrancesInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractUnconfirmedEncumbranceReductionsInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractPreencumbrancesInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey SubtractUnconfirmedPreencumbrancesInBudgetFundsAvailableCalculation { get; private set; }
public VocabularyKey UseOnlyApportionedAmountInBudgetFundsAvailableCalculation { get; private set; }


    }
}