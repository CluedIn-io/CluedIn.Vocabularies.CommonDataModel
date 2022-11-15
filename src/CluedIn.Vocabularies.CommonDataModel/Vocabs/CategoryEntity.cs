using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CategoryEntityVocabulary : SimpleVocabulary
    {
        public CategoryEntityVocabulary()
        {
            VocabularyName = "Category Entity";
            KeyPrefix = "commonDataModel.categoryentity";
            KeySeparator = ".";
            Grouping = "/CategoryEntity";

            AddGroup("CategoryEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedCategory = group.Add(new VocabularyKey(nameof(SharedCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInExpense = group.Add(new VocabularyKey(nameof(UseInExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInProduction = group.Add(new VocabularyKey(nameof(UseInProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInProject = group.Add(new VocabularyKey(nameof(UseInProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedCategoryId = group.Add(new VocabularyKey(nameof(SharedCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey SharedCategory { get; private set; }
        public VocabularyKey UseInExpense { get; private set; }
        public VocabularyKey UseInProduction { get; private set; }
        public VocabularyKey UseInProject { get; private set; }
        public VocabularyKey SharedCategoryId { get; private set; }
    }
}