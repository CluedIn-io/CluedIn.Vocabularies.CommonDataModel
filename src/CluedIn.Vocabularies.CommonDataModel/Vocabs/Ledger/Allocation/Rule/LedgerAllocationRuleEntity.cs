using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationRuleEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationRuleEntityVocabulary()
        {
            VocabularyName = "Ledger Allocation Rule Entity";
            KeyPrefix = "commonDataModel.ledgerallocationruleentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationRuleEntity";

            AddGroup("LedgerAllocationRuleEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MathematicalOperation = group.Add(new VocabularyKey(nameof(MathematicalOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSource = group.Add(new VocabularyKey(nameof(DataSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateIntervalCode = group.Add(new VocabularyKey(nameof(DateIntervalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateLastRun = group.Add(new VocabularyKey(nameof(DateLastRun), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeepAccountFrom = group.Add(new VocabularyKey(nameof(KeepAccountFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeepDimensionFrom = group.Add(new VocabularyKey(nameof(KeepDimensionFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedValue = group.Add(new VocabularyKey(nameof(FixedValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyRule = group.Add(new VocabularyKey(nameof(IntercompanyRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountFrom = group.Add(new VocabularyKey(nameof(OffsetAccountFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetDimensionFrom = group.Add(new VocabularyKey(nameof(OffsetDimensionFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rule = group.Add(new VocabularyKey(nameof(Rule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Active { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey MathematicalOperation { get; private set; }
        public VocabularyKey DataSource { get; private set; }
        public VocabularyKey DateIntervalCode { get; private set; }
        public VocabularyKey DateLastRun { get; private set; }
        public VocabularyKey KeepAccountFrom { get; private set; }
        public VocabularyKey KeepDimensionFrom { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey FixedValue { get; private set; }
        public VocabularyKey IntercompanyRule { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey OffsetAccountFrom { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey OffsetDimensionFrom { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey Rule { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
    }
}