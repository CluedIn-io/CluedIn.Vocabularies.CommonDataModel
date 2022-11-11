using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SharedCategoryEntityVocabulary : SimpleVocabulary
    {
        public SharedCategoryEntityVocabulary()
        {
            VocabularyName = "SharedCategoryEntity";
            KeyPrefix = "commonDataModel.sharedcategoryentity";
            KeySeparator = ".";
            Grouping = "/SharedCategoryEntity";

            AddGroup("SharedCategoryEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseType = group.Add(new VocabularyKey(nameof(ExpenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInProject = group.Add(new VocabularyKey(nameof(UseInProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInExpense = group.Add(new VocabularyKey(nameof(UseInExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInProduction = group.Add(new VocabularyKey(nameof(UseInProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey ExpenseType { get; private set; }
        public VocabularyKey UseInProject { get; private set; }
        public VocabularyKey UseInExpense { get; private set; }
        public VocabularyKey UseInProduction { get; private set; }


    }
}