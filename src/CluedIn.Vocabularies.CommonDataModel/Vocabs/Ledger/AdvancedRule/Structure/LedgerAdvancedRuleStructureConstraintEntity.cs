using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAdvancedRuleStructureConstraintEntityVocabulary : SimpleVocabulary
    {
        public LedgerAdvancedRuleStructureConstraintEntityVocabulary()
        {
            VocabularyName = "Ledger Advanced Rule Structure Constraint Entity";
            KeyPrefix = "commonDataModel.ledgeradvancedrulestructureconstraintentity";
            KeySeparator = ".";
            Grouping = "/LedgerAdvancedRuleStructureConstraintEntity";

            AddGroup("LedgerAdvancedRuleStructureConstraintEntity Details", group =>
            {
                AdvancedRuleStructure = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchy = group.Add(new VocabularyKey(nameof(DimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria01 = group.Add(new VocabularyKey(nameof(SegmentCriteria01), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria02 = group.Add(new VocabularyKey(nameof(SegmentCriteria02), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria03 = group.Add(new VocabularyKey(nameof(SegmentCriteria03), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria04 = group.Add(new VocabularyKey(nameof(SegmentCriteria04), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria05 = group.Add(new VocabularyKey(nameof(SegmentCriteria05), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria06 = group.Add(new VocabularyKey(nameof(SegmentCriteria06), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria07 = group.Add(new VocabularyKey(nameof(SegmentCriteria07), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria08 = group.Add(new VocabularyKey(nameof(SegmentCriteria08), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria09 = group.Add(new VocabularyKey(nameof(SegmentCriteria09), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria10 = group.Add(new VocabularyKey(nameof(SegmentCriteria10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentCriteria11 = group.Add(new VocabularyKey(nameof(SegmentCriteria11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AdvancedRuleStructure { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey DimensionHierarchy { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SegmentCriteria01 { get; private set; }
        public VocabularyKey SegmentCriteria02 { get; private set; }
        public VocabularyKey SegmentCriteria03 { get; private set; }
        public VocabularyKey SegmentCriteria04 { get; private set; }
        public VocabularyKey SegmentCriteria05 { get; private set; }
        public VocabularyKey SegmentCriteria06 { get; private set; }
        public VocabularyKey SegmentCriteria07 { get; private set; }
        public VocabularyKey SegmentCriteria08 { get; private set; }
        public VocabularyKey SegmentCriteria09 { get; private set; }
        public VocabularyKey SegmentCriteria10 { get; private set; }
        public VocabularyKey SegmentCriteria11 { get; private set; }
    }
}