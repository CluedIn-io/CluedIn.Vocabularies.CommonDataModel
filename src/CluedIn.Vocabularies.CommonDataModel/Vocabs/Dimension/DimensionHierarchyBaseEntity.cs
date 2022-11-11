using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionHierarchyBaseEntityVocabulary : SimpleVocabulary
    {
        public DimensionHierarchyBaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimensionHierarchyBaseEntity";
            KeyPrefix = "commonDataModel.dimensionhierarchybaseentity";
            KeySeparator = ".";
            Grouping = "/DimensionHierarchyBaseEntity";

            AddGroup("Common Data Model DimensionHierarchyBaseEntity Details", group =>
            {
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyDescription = group.Add(new VocabularyKey(nameof(HierarchyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName1 = group.Add(new VocabularyKey(nameof(SegmentName1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName2 = group.Add(new VocabularyKey(nameof(SegmentName2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName3 = group.Add(new VocabularyKey(nameof(SegmentName3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName4 = group.Add(new VocabularyKey(nameof(SegmentName4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName5 = group.Add(new VocabularyKey(nameof(SegmentName5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName6 = group.Add(new VocabularyKey(nameof(SegmentName6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName7 = group.Add(new VocabularyKey(nameof(SegmentName7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName8 = group.Add(new VocabularyKey(nameof(SegmentName8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName9 = group.Add(new VocabularyKey(nameof(SegmentName9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName10 = group.Add(new VocabularyKey(nameof(SegmentName10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName11 = group.Add(new VocabularyKey(nameof(SegmentName11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStatus = group.Add(new VocabularyKey(nameof(HierarchyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyName { get; private set; }
        public VocabularyKey HierarchyDescription { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey SegmentName1 { get; private set; }
        public VocabularyKey SegmentName2 { get; private set; }
        public VocabularyKey SegmentName3 { get; private set; }
        public VocabularyKey SegmentName4 { get; private set; }
        public VocabularyKey SegmentName5 { get; private set; }
        public VocabularyKey SegmentName6 { get; private set; }
        public VocabularyKey SegmentName7 { get; private set; }
        public VocabularyKey SegmentName8 { get; private set; }
        public VocabularyKey SegmentName9 { get; private set; }
        public VocabularyKey SegmentName10 { get; private set; }
        public VocabularyKey SegmentName11 { get; private set; }
        public VocabularyKey HierarchyStatus { get; private set; }


    }
}