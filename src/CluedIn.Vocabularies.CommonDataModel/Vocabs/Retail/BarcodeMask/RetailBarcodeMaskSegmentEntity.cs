using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailBarcodeMaskSegmentEntityVocabulary : SimpleVocabulary
    {
        public RetailBarcodeMaskSegmentEntityVocabulary()
        {
            VocabularyName = "Retail Barcode Mask Segment Entity";
            KeyPrefix = "commonDataModel.retailbarcodemasksegmententity";
            KeySeparator = ".";
            Grouping = "/RetailBarcodeMaskSegmentEntity";

            AddGroup("RetailBarcodeMaskSegmentEntity Details", group =>
            {
                Character = group.Add(new VocabularyKey(nameof(Character), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Decimals = group.Add(new VocabularyKey(nameof(Decimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Length = group.Add(new VocabularyKey(nameof(Length), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaskId = group.Add(new VocabularyKey(nameof(MaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentNumber = group.Add(new VocabularyKey(nameof(SegmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CharacterType = group.Add(new VocabularyKey(nameof(CharacterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Character { get; private set; }
        public VocabularyKey Decimals { get; private set; }
        public VocabularyKey Length { get; private set; }
        public VocabularyKey MaskId { get; private set; }
        public VocabularyKey SegmentNumber { get; private set; }
        public VocabularyKey CharacterType { get; private set; }
    }
}