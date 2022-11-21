using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmDirectMailingCategoryItemEntityVocabulary : SimpleVocabulary
    {
        public SmmDirectMailingCategoryItemEntityVocabulary()
        {
            VocabularyName = "Smm Direct Mailing Category Item Entity";
            KeyPrefix = "commonDataModel.smmdirectmailingcategoryitementity";
            KeySeparator = ".";
            Grouping = "/SmmDirectMailingCategoryItemEntity";

            AddGroup("SmmDirectMailingCategoryItemEntity Details", group =>
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