using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSPackSizeCategoryEntityVocabulary : SimpleVocabulary
    {
        public WHSPackSizeCategoryEntityVocabulary()
        {
            VocabularyName = "WHSPackSizeCategoryEntity";
            KeyPrefix = "commonDataModel.whspacksizecategoryentity";
            KeySeparator = ".";
            Grouping = "/WHSPackSizeCategoryEntity";

            AddGroup("WHSPackSizeCategoryEntity Details", group =>
            {
                PackSizeCategoryId = group.Add(new VocabularyKey(nameof(PackSizeCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackSizeCategoryName = group.Add(new VocabularyKey(nameof(PackSizeCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackSizeCategoryId { get; private set; }
        public VocabularyKey PackSizeCategoryName { get; private set; }


    }
}