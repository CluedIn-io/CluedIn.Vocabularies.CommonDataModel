using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProcessEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProcessEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanProcessEntity";
            KeyPrefix = "commonDataModel.budgetplanprocessentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProcessEntity";

            AddGroup("Common Data Model BudgetPlanProcessEntity Details", group =>
            {
                ApprovalProcessState = group.Add(new VocabularyKey(nameof(ApprovalProcessState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleRecId = group.Add(new VocabularyKey(nameof(BudgetCycleRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationHierarchyTypeRecId = group.Add(new VocabularyKey(nameof(OrganizationHierarchyTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountStructureRecId = group.Add(new VocabularyKey(nameof(AccountStructureRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpanRecId = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycle = group.Add(new VocabularyKey(nameof(BudgetCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleStartFiscalCalendarPeriod = group.Add(new VocabularyKey(nameof(BudgetCycleStartFiscalCalendarPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpanFiscalCalendar = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanFiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpan = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationtHierarchyType = group.Add(new VocabularyKey(nameof(OrganizationtHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ApprovalProcessState { get; private set; }
public VocabularyKey BudgetCycleRecId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey LedgerRecId { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey OrganizationHierarchyTypeRecId { get; private set; }
public VocabularyKey AccountStructureRecId { get; private set; }
public VocabularyKey BudgetCycleTimeSpanRecId { get; private set; }
public VocabularyKey BudgetCycle { get; private set; }
public VocabularyKey BudgetCycleStartFiscalCalendarPeriod { get; private set; }
public VocabularyKey BudgetCycleTimeSpanFiscalCalendar { get; private set; }
public VocabularyKey BudgetCycleTimeSpan { get; private set; }
public VocabularyKey FiscalCalendarId { get; private set; }
public VocabularyKey Ledger { get; private set; }
public VocabularyKey OrganizationtHierarchyType { get; private set; }
public VocabularyKey AccountStructure { get; private set; }


    }
}