using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionSetEntityVocabulary : SimpleVocabulary
    {
        public DimensionSetEntityVocabulary()
        {
            VocabularyName = "Dimension Set Entity";
            KeyPrefix = "commonDataModel.dimensionsetentity";
            KeySeparator = ".";
            Grouping = "/DimensionSetEntity";

            AddGroup("DimensionSetEntity Details", group =>
            {
                DisplayValue = group.Add(new VocabularyKey(nameof(DisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DisplayValue { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
    }
}