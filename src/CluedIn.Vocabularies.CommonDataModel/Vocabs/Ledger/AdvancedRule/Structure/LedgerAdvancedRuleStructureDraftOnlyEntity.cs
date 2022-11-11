using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAdvancedRuleStructureDraftOnlyEntityVocabulary : SimpleVocabulary
    {
        public LedgerAdvancedRuleStructureDraftOnlyEntityVocabulary()
        {
            VocabularyName = "LedgerAdvancedRuleStructureDraftOnlyEntity";
            KeyPrefix = "commonDataModel.ledgeradvancedrulestructuredraftonlyentity";
            KeySeparator = ".";
            Grouping = "/LedgerAdvancedRuleStructureDraftOnlyEntity";

            AddGroup("LedgerAdvancedRuleStructureDraftOnlyEntity Details", group =>
            {
                AccountRuleStructureName = group.Add(new VocabularyKey(nameof(AccountRuleStructureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StructureType = group.Add(new VocabularyKey(nameof(StructureType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName01 = group.Add(new VocabularyKey(nameof(SegmentName01), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName02 = group.Add(new VocabularyKey(nameof(SegmentName02), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName03 = group.Add(new VocabularyKey(nameof(SegmentName03), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName04 = group.Add(new VocabularyKey(nameof(SegmentName04), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName05 = group.Add(new VocabularyKey(nameof(SegmentName05), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName06 = group.Add(new VocabularyKey(nameof(SegmentName06), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName07 = group.Add(new VocabularyKey(nameof(SegmentName07), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName08 = group.Add(new VocabularyKey(nameof(SegmentName08), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName09 = group.Add(new VocabularyKey(nameof(SegmentName09), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName10 = group.Add(new VocabularyKey(nameof(SegmentName10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName11 = group.Add(new VocabularyKey(nameof(SegmentName11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountRuleStructureName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StructureType { get; private set; }
        public VocabularyKey SegmentName01 { get; private set; }
        public VocabularyKey SegmentName02 { get; private set; }
        public VocabularyKey SegmentName03 { get; private set; }
        public VocabularyKey SegmentName04 { get; private set; }
        public VocabularyKey SegmentName05 { get; private set; }
        public VocabularyKey SegmentName06 { get; private set; }
        public VocabularyKey SegmentName07 { get; private set; }
        public VocabularyKey SegmentName08 { get; private set; }
        public VocabularyKey SegmentName09 { get; private set; }
        public VocabularyKey SegmentName10 { get; private set; }
        public VocabularyKey SegmentName11 { get; private set; }


    }
}