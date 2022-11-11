using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionEnumerationEntityVocabulary : SimpleVocabulary
    {
        public DimensionEnumerationEntityVocabulary()
        {
            VocabularyName = "DimensionEnumerationEntity";
            KeyPrefix = "commonDataModel.dimensionenumerationentity";
            KeySeparator = ".";
            Grouping = "/DimensionEnumerationEntity";

            AddGroup("DimensionEnumerationEntity Details", group =>
            {
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayValue = group.Add(new VocabularyKey(nameof(DisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey DisplayValue { get; private set; }


    }
}