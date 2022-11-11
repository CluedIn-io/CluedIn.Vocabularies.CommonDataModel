using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlRuleEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlRuleEntityVocabulary()
        {
            VocabularyName = "BudgetControlRuleEntity";
            KeyPrefix = "commonDataModel.budgetcontrolruleentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlRuleEntity";

            AddGroup("BudgetControlRuleEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BudgetCycleTimeSpan { get; private set; }
        public VocabularyKey BudgetCycleTimeSpanName { get; private set; }
        public VocabularyKey BudgetCycleTimeSpanFiscalCalendarId { get; private set; }
        public VocabularyKey BudgetControlInterval { get; private set; }
        public VocabularyKey BudgetManager { get; private set; }
        public VocabularyKey BudgetThresholdPercent { get; private set; }


    }
}