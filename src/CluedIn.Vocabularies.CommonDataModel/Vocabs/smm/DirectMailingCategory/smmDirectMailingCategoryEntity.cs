using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmDirectMailingCategoryEntityVocabulary : SimpleVocabulary
    {
        public smmDirectMailingCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmDirectMailingCategoryEntity";
            KeyPrefix = "commonDataModel.smmdirectmailingcategoryentity";
            KeySeparator = ".";
            Grouping = "/smmDirectMailingCategoryEntity";

            AddGroup("Common Data Model smmDirectMailingCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }


    }
}