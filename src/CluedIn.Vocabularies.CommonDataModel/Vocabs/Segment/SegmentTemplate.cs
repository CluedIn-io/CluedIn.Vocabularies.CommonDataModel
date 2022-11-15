using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SegmentTemplateVocabulary : SimpleVocabulary
    {
        public SegmentTemplateVocabulary()
        {
            VocabularyName = "Segment Template";
            KeyPrefix = "commonDataModel.segmenttemplate";
            KeySeparator = ".";
            Grouping = "/SegmentTemplate";

            AddGroup("SegmentTemplate Details", group =>
            {
                SegmentName = group.Add(new VocabularyKey(nameof(SegmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentTemplateId = group.Add(new VocabularyKey(nameof(SegmentTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentfilterquery = group.Add(new VocabularyKey(nameof(Segmentfilterquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentmemberids = group.Add(new VocabularyKey(nameof(Segmentmemberids), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentquery = group.Add(new VocabularyKey(nameof(Segmentquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentType = group.Add(new VocabularyKey(nameof(SegmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryType = group.Add(new VocabularyKey(nameof(QueryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tag = group.Add(new VocabularyKey(nameof(Tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SegmentName { get; private set; }
        public VocabularyKey SegmentTemplateId { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Segmentfilterquery { get; private set; }
        public VocabularyKey Segmentmemberids { get; private set; }
        public VocabularyKey Segmentquery { get; private set; }
        public VocabularyKey SegmentType { get; private set; }
        public VocabularyKey QueryType { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Tag { get; private set; }
        public VocabularyKey Label { get; private set; }
    }
}