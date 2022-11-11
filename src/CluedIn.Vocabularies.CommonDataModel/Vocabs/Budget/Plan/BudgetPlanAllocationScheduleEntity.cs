using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanAllocationScheduleEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanAllocationScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanAllocationScheduleEntity";
            KeyPrefix = "commonDataModel.budgetplanallocationscheduleentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanAllocationScheduleEntity";

            AddGroup("Common Data Model BudgetPlanAllocationScheduleEntity Details", group =>
            {
                AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationTerm = group.Add(new VocabularyKey(nameof(AllocationTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisPlanScenario = group.Add(new VocabularyKey(nameof(BasisPlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationPlanScenario = group.Add(new VocabularyKey(nameof(DestinationPlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Factor = group.Add(new VocabularyKey(nameof(Factor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodKey = group.Add(new VocabularyKey(nameof(PeriodKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAllocationKeyDataAreaId = group.Add(new VocabularyKey(nameof(LedgerAllocationKeyDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationRule = group.Add(new VocabularyKey(nameof(AllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAllocationRuleDataAreaId = group.Add(new VocabularyKey(nameof(LedgerAllocationRuleDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationSchedule = group.Add(new VocabularyKey(nameof(AllocationSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourcePlanScenario = group.Add(new VocabularyKey(nameof(SourcePlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSourceEffectiveDate = group.Add(new VocabularyKey(nameof(UseSourceEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisScenario = group.Add(new VocabularyKey(nameof(BasisScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAllocationTerm = group.Add(new VocabularyKey(nameof(BudgetAllocationTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationScenario = group.Add(new VocabularyKey(nameof(DestinationScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceScenario = group.Add(new VocabularyKey(nameof(SourceScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppendLines = group.Add(new VocabularyKey(nameof(AppendLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey AllocationTerm { get; private set; }
        public VocabularyKey BasisPlanScenario { get; private set; }
        public VocabularyKey DestinationPlanScenario { get; private set; }
        public VocabularyKey Factor { get; private set; }
        public VocabularyKey LedgerRecId { get; private set; }
        public VocabularyKey PeriodKey { get; private set; }
        public VocabularyKey LedgerAllocationKeyDataAreaId { get; private set; }
        public VocabularyKey AllocationRule { get; private set; }
        public VocabularyKey LedgerAllocationRuleDataAreaId { get; private set; }
        public VocabularyKey AllocationSchedule { get; private set; }
        public VocabularyKey SourcePlanScenario { get; private set; }
        public VocabularyKey UseSourceEffectiveDate { get; private set; }
        public VocabularyKey BasisScenario { get; private set; }
        public VocabularyKey BudgetAllocationTerm { get; private set; }
        public VocabularyKey DestinationScenario { get; private set; }
        public VocabularyKey Ledger { get; private set; }
        public VocabularyKey SourceScenario { get; private set; }
        public VocabularyKey AppendLines { get; private set; }


    }
}