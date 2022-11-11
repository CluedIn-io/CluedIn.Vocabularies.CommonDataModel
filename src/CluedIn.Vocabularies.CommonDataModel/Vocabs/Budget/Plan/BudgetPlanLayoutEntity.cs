using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanLayoutEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanLayoutEntityVocabulary()
        {
            VocabularyName = "BudgetPlanLayoutEntity";
            KeyPrefix = "commonDataModel.budgetplanlayoutentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanLayoutEntity";

            AddGroup("BudgetPlanLayoutEntity Details", group =>
            {
                Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementDefinition = group.Add(new VocabularyKey(nameof(ElementDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEditable = group.Add(new VocabularyKey(nameof(IsEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InWorksheet = group.Add(new VocabularyKey(nameof(InWorksheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutName = group.Add(new VocabularyKey(nameof(LayoutName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutDescription = group.Add(new VocabularyKey(nameof(LayoutDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutDimensionHierarchy = group.Add(new VocabularyKey(nameof(LayoutDimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionFocusName = group.Add(new VocabularyKey(nameof(DimensionFocusName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionFocusStructureType = group.Add(new VocabularyKey(nameof(DimensionFocusStructureType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementDefinitionName = group.Add(new VocabularyKey(nameof(ElementDefinitionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ordinal = group.Add(new VocabularyKey(nameof(Ordinal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Layout { get; private set; }
        public VocabularyKey ElementDefinition { get; private set; }
        public VocabularyKey IsEditable { get; private set; }
        public VocabularyKey InWorksheet { get; private set; }
        public VocabularyKey LayoutName { get; private set; }
        public VocabularyKey LayoutDescription { get; private set; }
        public VocabularyKey LayoutDimensionHierarchy { get; private set; }
        public VocabularyKey DimensionFocusName { get; private set; }
        public VocabularyKey DimensionFocusStructureType { get; private set; }
        public VocabularyKey ElementDefinitionName { get; private set; }
        public VocabularyKey Ordinal { get; private set; }


    }
}