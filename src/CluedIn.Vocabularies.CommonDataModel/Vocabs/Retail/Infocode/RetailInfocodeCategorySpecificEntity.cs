using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeCategorySpecificEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeCategorySpecificEntityVocabulary()
        {
            VocabularyName = "RetailInfocodeCategorySpecificEntity";
            KeyPrefix = "commonDataModel.retailinfocodecategoryspecificentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeCategorySpecificEntity";

            AddGroup("RetailInfocodeCategorySpecificEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfoCodeNumber = group.Add(new VocabularyKey(nameof(InfoCodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputRequired = group.Add(new VocabularyKey(nameof(InputRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WhenRequired = group.Add(new VocabularyKey(nameof(WhenRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey InfoCodeNumber { get; private set; }
        public VocabularyKey InputRequired { get; private set; }
        public VocabularyKey WhenRequired { get; private set; }
        public VocabularyKey Sequence { get; private set; }


    }
}