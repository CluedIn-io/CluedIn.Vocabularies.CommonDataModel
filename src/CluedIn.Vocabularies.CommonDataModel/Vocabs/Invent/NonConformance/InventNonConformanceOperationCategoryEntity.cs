using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventNonConformanceOperationCategoryEntityVocabulary : SimpleVocabulary
    {
        public InventNonConformanceOperationCategoryEntityVocabulary()
        {
            VocabularyName = "Invent Non Conformance Operation Category Entity";
            KeyPrefix = "commonDataModel.inventnonconformanceoperationcategoryentity";
            KeySeparator = ".";
            Grouping = "/InventNonConformanceOperationCategoryEntity";

            AddGroup("InventNonConformanceOperationCategoryEntity Details", group =>
            {
                CategoryCode = group.Add(new VocabularyKey(nameof(CategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedOperationType = group.Add(new VocabularyKey(nameof(AssociatedOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryCode { get; private set; }
        public VocabularyKey AssociatedOperationType { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }
    }
}