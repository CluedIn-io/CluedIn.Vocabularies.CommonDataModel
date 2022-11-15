using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetAllocationTermEntityVocabulary : SimpleVocabulary
    {
        public BudgetAllocationTermEntityVocabulary()
        {
            VocabularyName = "Budget Allocation Term Entity";
            KeyPrefix = "commonDataModel.budgetallocationtermentity";
            KeySeparator = ".";
            Grouping = "/BudgetAllocationTermEntity";

            AddGroup("BudgetAllocationTermEntity Details", group =>
            {
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAllocationTerm = group.Add(new VocabularyKey(nameof(BudgetAllocationTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey BudgetAllocationTerm { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}