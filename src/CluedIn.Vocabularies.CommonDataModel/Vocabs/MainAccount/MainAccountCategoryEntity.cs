using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountCategoryEntityVocabulary : SimpleVocabulary
    {
        public MainAccountCategoryEntityVocabulary()
        {
            VocabularyName = "MainAccountCategoryEntity";
            KeyPrefix = "commonDataModel.mainaccountcategoryentity";
            KeySeparator = ".";
            Grouping = "/MainAccountCategoryEntity";

            AddGroup("MainAccountCategoryEntity Details", group =>
            {
                MainAccountCategory = group.Add(new VocabularyKey(nameof(MainAccountCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceId = group.Add(new VocabularyKey(nameof(ReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountType = group.Add(new VocabularyKey(nameof(MainAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountCategory { get; private set; }
        public VocabularyKey ReferenceId { get; private set; }
        public VocabularyKey MainAccountType { get; private set; }
        public VocabularyKey Closed { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }


    }
}