using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorLayoutLinesEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorLayoutLinesEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorLayoutLinesEntity";
            KeyPrefix = "commonDataModel.configuratorlayoutlinesentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorLayoutLinesEntity";

            AddGroup("Common Data Model ConfiguratorLayoutLinesEntity Details", group =>
            {
                BatchId = group.Add(new VocabularyKey(nameof(BatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchRecordType = group.Add(new VocabularyKey(nameof(BatchRecordType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordSize = group.Add(new VocabularyKey(nameof(RecordSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordName = group.Add(new VocabularyKey(nameof(RecordName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hide = group.Add(new VocabularyKey(nameof(Hide), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordType = group.Add(new VocabularyKey(nameof(RecordType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segment = group.Add(new VocabularyKey(nameof(Segment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchId { get; private set; }
        public VocabularyKey BatchRecordType { get; private set; }
        public VocabularyKey RecordSize { get; private set; }
        public VocabularyKey RecordName { get; private set; }
        public VocabularyKey Hide { get; private set; }
        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RecordType { get; private set; }
        public VocabularyKey Segment { get; private set; }


    }
}