using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjControlCostGroupCategoriesEntityVocabulary : SimpleVocabulary
    {
        public ProjControlCostGroupCategoriesEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjControlCostGroupCategoriesEntity";
            KeyPrefix = "commonDataModel.projcontrolcostgroupcategoriesentity";
            KeySeparator = ".";
            Grouping = "/ProjControlCostGroupCategoriesEntity";

            AddGroup("Common Data Model ProjControlCostGroupCategoriesEntity Details", group =>
            {
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlId = group.Add(new VocabularyKey(nameof(ControlId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ControlId { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }


    }
}