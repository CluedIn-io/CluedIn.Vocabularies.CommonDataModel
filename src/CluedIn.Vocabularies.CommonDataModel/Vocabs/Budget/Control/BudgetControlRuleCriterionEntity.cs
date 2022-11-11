using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlRuleCriterionEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlRuleCriterionEntityVocabulary()
        {
            VocabularyName = "BudgetControlRuleCriterionEntity";
            KeyPrefix = "commonDataModel.budgetcontrolrulecriterionentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlRuleCriterionEntity";

            AddGroup("BudgetControlRuleCriterionEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlDimensionAttribute = group.Add(new VocabularyKey(nameof(BudgetControlDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlRule = group.Add(new VocabularyKey(nameof(BudgetControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeId = group.Add(new VocabularyKey(nameof(DimensionAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Criterion = group.Add(new VocabularyKey(nameof(Criterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BudgetControlDimensionAttribute { get; private set; }
        public VocabularyKey BudgetControlRule { get; private set; }
        public VocabularyKey DimensionAttributeId { get; private set; }
        public VocabularyKey Criterion { get; private set; }


    }
}