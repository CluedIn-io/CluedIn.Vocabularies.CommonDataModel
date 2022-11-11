using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmDirectMailingCategoryItemEntityVocabulary : SimpleVocabulary
    {
        public smmDirectMailingCategoryItemEntityVocabulary()
        {
            VocabularyName = "smmDirectMailingCategoryItemEntity";
            KeyPrefix = "commonDataModel.smmdirectmailingcategoryitementity";
            KeySeparator = ".";
            Grouping = "/smmDirectMailingCategoryItemEntity";

            AddGroup("smmDirectMailingCategoryItemEntity Details", group =>
            {
                DirectMailingCategoryName = group.Add(new VocabularyKey(nameof(DirectMailingCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemDescription = group.Add(new VocabularyKey(nameof(ItemDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemName = group.Add(new VocabularyKey(nameof(ItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DirectMailingCategoryName { get; private set; }
        public VocabularyKey ItemDescription { get; private set; }
        public VocabularyKey ItemName { get; private set; }


    }
}