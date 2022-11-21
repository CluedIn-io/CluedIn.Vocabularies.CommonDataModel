using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmDirectMailingCategoryEntityVocabulary : SimpleVocabulary
    {
        public SmmDirectMailingCategoryEntityVocabulary()
        {
            VocabularyName = "Smm Direct Mailing Category Entity";
            KeyPrefix = "commonDataModel.smmdirectmailingcategoryentity";
            KeySeparator = ".";
            Grouping = "/SmmDirectMailingCategoryEntity";

            AddGroup("SmmDirectMailingCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }
    }
}