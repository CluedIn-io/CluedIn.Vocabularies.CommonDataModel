using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationFormatSegmentEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationFormatSegmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationFormatSegmentEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationformatsegmententity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationFormatSegmentEntity";

            AddGroup("Common Data Model WHSWarehouseLocationFormatSegmentEntity Details", group =>
            {
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationFormatId = group.Add(new VocabularyKey(nameof(WarehouseLocationFormatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentDescription = group.Add(new VocabularyKey(nameof(SegmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentLength = group.Add(new VocabularyKey(nameof(SegmentLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentSeparator = group.Add(new VocabularyKey(nameof(SegmentSeparator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey WarehouseLocationFormatId { get; private set; }
        public VocabularyKey SegmentDescription { get; private set; }
        public VocabularyKey SegmentLength { get; private set; }
        public VocabularyKey SegmentSeparator { get; private set; }


    }
}