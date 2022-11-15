using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerPeriodAllocationCategoryEntityVocabulary : SimpleVocabulary
    {
        public LedgerPeriodAllocationCategoryEntityVocabulary()
        {
            VocabularyName = "Ledger Period Allocation Category Entity";
            KeyPrefix = "commonDataModel.ledgerperiodallocationcategoryentity";
            KeySeparator = ".";
            Grouping = "/LedgerPeriodAllocationCategoryEntity";

            AddGroup("LedgerPeriodAllocationCategoryEntity Details", group =>
            {
                IsFixed = group.Add(new VocabularyKey(nameof(IsFixed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodKey = group.Add(new VocabularyKey(nameof(PeriodKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeInterval = group.Add(new VocabularyKey(nameof(TimeInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfTime = group.Add(new VocabularyKey(nameof(UnitOfTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPercentage = group.Add(new VocabularyKey(nameof(AllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsFixed { get; private set; }
        public VocabularyKey PeriodKey { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey TimeInterval { get; private set; }
        public VocabularyKey UnitOfTime { get; private set; }
        public VocabularyKey AllocationPercentage { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
    }
}