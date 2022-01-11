using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanHeaderEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanHeaderEntity";
            KeyPrefix = "commonDataModel.budgetplanheaderentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanHeaderEntity";

            AddGroup("Common Data Model BudgetPlanHeaderEntity Details", group =>
            {
                BudgetingOrganization = group.Add(new VocabularyKey(nameof(BudgetingOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanPreparer = group.Add(new VocabularyKey(nameof(BudgetPlanPreparer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanPriority = group.Add(new VocabularyKey(nameof(BudgetPlanPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsHistorical = group.Add(new VocabularyKey(nameof(IsHistorical), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentBudgetPlanHeader = group.Add(new VocabularyKey(nameof(ParentBudgetPlanHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserGroup = group.Add(new VocabularyKey(nameof(UserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rank = group.Add(new VocabularyKey(nameof(Rank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanLayout = group.Add(new VocabularyKey(nameof(BudgetPlanLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResponsibilityCenterPartyNumber = group.Add(new VocabularyKey(nameof(ResponsibilityCenterPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Stage = group.Add(new VocabularyKey(nameof(Stage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreparerPersonnelNumber = group.Add(new VocabularyKey(nameof(PreparerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentBudgetPlan = group.Add(new VocabularyKey(nameof(ParentBudgetPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelName = group.Add(new VocabularyKey(nameof(PersonnelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetingOrganizationName = group.Add(new VocabularyKey(nameof(BudgetingOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NeedsUpdate = group.Add(new VocabularyKey(nameof(NeedsUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetingOrganization { get; private set; }
public VocabularyKey BudgetPlanningProcess { get; private set; }
public VocabularyKey BudgetPlanningStage { get; private set; }
public VocabularyKey BudgetPlanPreparer { get; private set; }
public VocabularyKey BudgetPlanPriority { get; private set; }
public VocabularyKey DocumentNumber { get; private set; }
public VocabularyKey DocumentStatus { get; private set; }
public VocabularyKey IsHistorical { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ParentBudgetPlanHeader { get; private set; }
public VocabularyKey UserGroup { get; private set; }
public VocabularyKey Rank { get; private set; }
public VocabularyKey WorkflowStatus { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey BudgetPlanLayout { get; private set; }
public VocabularyKey ResponsibilityCenterPartyNumber { get; private set; }
public VocabularyKey Process { get; private set; }
public VocabularyKey Stage { get; private set; }
public VocabularyKey PreparerPersonnelNumber { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey ParentBudgetPlan { get; private set; }
public VocabularyKey Layout { get; private set; }
public VocabularyKey PersonnelName { get; private set; }
public VocabularyKey BudgetingOrganizationName { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey NeedsUpdate { get; private set; }


    }
}