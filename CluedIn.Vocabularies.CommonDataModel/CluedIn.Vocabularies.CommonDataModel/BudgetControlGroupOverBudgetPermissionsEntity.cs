using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlGroupOverBudgetPermissionsEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlGroupOverBudgetPermissionsEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlGroupOverBudgetPermissionsEntity";
            KeyPrefix = "commonDataModel.budgetcontrolgroupoverbudgetpermissionsentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlGroupOverBudgetPermissionsEntity";

            AddGroup("Common Data Model BudgetControlGroupOverBudgetPermissionsEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetGroupName = group.Add(new VocabularyKey(nameof(BudgetGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserGroupName = group.Add(new VocabularyKey(nameof(UserGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverrideOverbudgetOption = group.Add(new VocabularyKey(nameof(OverrideOverbudgetOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetGroup = group.Add(new VocabularyKey(nameof(BudgetGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetOverrideUserGroupOption = group.Add(new VocabularyKey(nameof(BudgetOverrideUserGroupOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey BudgetGroupName { get; private set; }
public VocabularyKey UserGroupId { get; private set; }
public VocabularyKey UserGroupName { get; private set; }
public VocabularyKey OverrideOverbudgetOption { get; private set; }
public VocabularyKey BudgetGroup { get; private set; }
public VocabularyKey BudgetOverrideUserGroupOption { get; private set; }


    }
}