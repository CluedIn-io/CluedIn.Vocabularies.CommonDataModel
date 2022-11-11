using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ResResourceCategoryDataEntityVocabulary : SimpleVocabulary
    {
        public ResResourceCategoryDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model ResResourceCategoryDataEntity";
            KeyPrefix = "commonDataModel.resresourcecategorydataentity";
            KeySeparator = ".";
            Grouping = "/ResResourceCategoryDataEntity";

            AddGroup("Common Data Model ResResourceCategoryDataEntity Details", group =>
            {
                RoleId = group.Add(new VocabularyKey(nameof(RoleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultResourceCategory = group.Add(new VocabularyKey(nameof(DefaultResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategoryDisabled = group.Add(new VocabularyKey(nameof(IsCategoryDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoleId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DefaultResourceCategory { get; private set; }
        public VocabularyKey IsCategoryDisabled { get; private set; }


    }
}