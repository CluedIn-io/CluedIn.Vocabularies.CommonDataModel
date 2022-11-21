using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlRuleOverBudgetPermissionsEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlRuleOverBudgetPermissionsEntityVocabulary()
        {
            VocabularyName = "Budget Control Rule Over Budget Permissions Entity";
            KeyPrefix = "commonDataModel.budgetcontrolruleoverbudgetpermissionsentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlRuleOverBudgetPermissionsEntity";

            AddGroup("BudgetControlRuleOverBudgetPermissionsEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleName = group.Add(new VocabularyKey(nameof(RuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupName = group.Add(new VocabularyKey(nameof(UserGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideOverbudgetOption = group.Add(new VocabularyKey(nameof(OverrideOverbudgetOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverbudgetBudgetGroupCheckOption = group.Add(new VocabularyKey(nameof(OverbudgetBudgetGroupCheckOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey RuleName { get; private set; }
        public VocabularyKey UserGroupId { get; private set; }
        public VocabularyKey UserGroupName { get; private set; }
        public VocabularyKey OverrideOverbudgetOption { get; private set; }
        public VocabularyKey OverbudgetBudgetGroupCheckOption { get; private set; }
    }
}