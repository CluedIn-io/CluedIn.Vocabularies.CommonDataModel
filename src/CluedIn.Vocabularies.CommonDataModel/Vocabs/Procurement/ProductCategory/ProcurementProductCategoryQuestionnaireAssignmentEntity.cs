using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryQuestionnaireAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryQuestionnaireAssignmentEntityVocabulary()
        {
            VocabularyName = "Procurement Product Category Questionnaire Assignment Entity";
            KeyPrefix = "commonDataModel.procurementproductcategoryquestionnaireassignmententity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryQuestionnaireAssignmentEntity";

            AddGroup("ProcurementProductCategoryQuestionnaireAssignmentEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionnaireLegalEntityId = group.Add(new VocabularyKey(nameof(QuestionnaireLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionnaireName = group.Add(new VocabularyKey(nameof(QuestionnaireName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdministrationActivityType = group.Add(new VocabularyKey(nameof(AdministrationActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey QuestionnaireLegalEntityId { get; private set; }
        public VocabularyKey QuestionnaireName { get; private set; }
        public VocabularyKey AdministrationActivityType { get; private set; }
    }
}