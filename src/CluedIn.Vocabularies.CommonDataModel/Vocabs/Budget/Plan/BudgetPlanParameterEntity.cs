using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanParameterEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanParameterEntityVocabulary()
        {
            VocabularyName = "Budget Plan Parameter Entity";
            KeyPrefix = "commonDataModel.budgetplanparameterentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanParameterEntity";

            AddGroup("BudgetPlanParameterEntity Details", group =>
            {
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBudgetPlanningUserGroups = group.Add(new VocabularyKey(nameof(UseBudgetPlanningUserGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityModel = group.Add(new VocabularyKey(nameof(SecurityModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchy = group.Add(new VocabularyKey(nameof(DimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCurrencyConversion = group.Add(new VocabularyKey(nameof(SkipCurrencyConversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchyName = group.Add(new VocabularyKey(nameof(DimensionHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey UseBudgetPlanningUserGroups { get; private set; }
        public VocabularyKey SecurityModel { get; private set; }
        public VocabularyKey DimensionHierarchy { get; private set; }
        public VocabularyKey SkipCurrencyConversion { get; private set; }
        public VocabularyKey DimensionHierarchyName { get; private set; }
    }
}