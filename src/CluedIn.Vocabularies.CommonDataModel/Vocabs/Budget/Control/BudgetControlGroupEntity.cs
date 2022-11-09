using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlGroupEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlGroupEntity";
            KeyPrefix = "commonDataModel.budgetcontrolgroupentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlGroupEntity";

            AddGroup("Common Data Model BudgetControlGroupEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetGroup = group.Add(new VocabularyKey(nameof(BudgetGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentBudgetGroupMember = group.Add(new VocabularyKey(nameof(ParentBudgetGroupMember), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentMemberName = group.Add(new VocabularyKey(nameof(ParentMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MemberName = group.Add(new VocabularyKey(nameof(MemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MemberDescription = group.Add(new VocabularyKey(nameof(MemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpan = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpanName = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpanFiscalCalendarId = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanFiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetControlInterval = group.Add(new VocabularyKey(nameof(BudgetControlInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetManager = group.Add(new VocabularyKey(nameof(BudgetManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetThresholdPercent = group.Add(new VocabularyKey(nameof(BudgetThresholdPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey BudgetGroup { get; private set; }
public VocabularyKey ParentBudgetGroupMember { get; private set; }
public VocabularyKey ParentMemberName { get; private set; }
public VocabularyKey MemberName { get; private set; }
public VocabularyKey MemberDescription { get; private set; }
public VocabularyKey BudgetCycleTimeSpan { get; private set; }
public VocabularyKey BudgetCycleTimeSpanName { get; private set; }
public VocabularyKey BudgetCycleTimeSpanFiscalCalendarId { get; private set; }
public VocabularyKey BudgetControlInterval { get; private set; }
public VocabularyKey BudgetManager { get; private set; }
public VocabularyKey BudgetThresholdPercent { get; private set; }


    }
}