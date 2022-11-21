using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmEmailCategoryEntityVocabulary : SimpleVocabulary
    {
        public SmmEmailCategoryEntityVocabulary()
        {
            VocabularyName = "Smm Email Category Entity";
            KeyPrefix = "commonDataModel.smmemailcategoryentity";
            KeySeparator = ".";
            Grouping = "/SmmEmailCategoryEntity";

            AddGroup("SmmEmailCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }
    }
}