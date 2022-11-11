using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmEmailCategoryEntityVocabulary : SimpleVocabulary
    {
        public smmEmailCategoryEntityVocabulary()
        {
            VocabularyName = "smmEmailCategoryEntity";
            KeyPrefix = "commonDataModel.smmemailcategoryentity";
            KeySeparator = ".";
            Grouping = "/smmEmailCategoryEntity";

            AddGroup("smmEmailCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }


    }
}