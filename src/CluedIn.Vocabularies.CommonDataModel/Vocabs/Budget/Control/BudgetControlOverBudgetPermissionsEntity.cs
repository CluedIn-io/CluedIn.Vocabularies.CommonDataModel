using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlOverBudgetPermissionsEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlOverBudgetPermissionsEntityVocabulary()
        {
            VocabularyName = "Budget Control Over Budget Permissions Entity";
            KeyPrefix = "commonDataModel.budgetcontroloverbudgetpermissionsentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlOverBudgetPermissionsEntity";

            AddGroup("BudgetControlOverBudgetPermissionsEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupName = group.Add(new VocabularyKey(nameof(UserGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverBudgetOption = group.Add(new VocabularyKey(nameof(OverBudgetOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlConfiguration = group.Add(new VocabularyKey(nameof(BudgetControlConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey UserGroupId { get; private set; }
        public VocabularyKey UserGroupName { get; private set; }
        public VocabularyKey OverBudgetOption { get; private set; }
        public VocabularyKey BudgetControlConfiguration { get; private set; }
    }
}