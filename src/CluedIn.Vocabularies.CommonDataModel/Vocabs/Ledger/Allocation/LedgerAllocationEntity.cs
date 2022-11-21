using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationEntityVocabulary()
        {
            VocabularyName = "Ledger Allocation Entity";
            KeyPrefix = "commonDataModel.ledgerallocationentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationEntity";

            AddGroup("LedgerAllocationEntity Details", group =>
            {
                SourceAccount = group.Add(new VocabularyKey(nameof(SourceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromMainAccountRecId = group.Add(new VocabularyKey(nameof(FromMainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromMainAccountLedgerChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(FromMainAccountLedgerChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPercentage = group.Add(new VocabularyKey(nameof(AllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceSelectionCriteria = group.Add(new VocabularyKey(nameof(SourceSelectionCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceSelectionCriteriaDisplayValue = group.Add(new VocabularyKey(nameof(SourceSelectionCriteriaDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceSelectionCriteriaDimensions = group.Add(new VocabularyKey(nameof(SourceSelectionCriteriaDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceSelectionCriteriaDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(SourceSelectionCriteriaDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAccount = group.Add(new VocabularyKey(nameof(DestinationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAccountDisplayValue = group.Add(new VocabularyKey(nameof(DestinationAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationKeepSourceDimensions = group.Add(new VocabularyKey(nameof(DestinationKeepSourceDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationKeepSourceDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(DestinationKeepSourceDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationDimensions = group.Add(new VocabularyKey(nameof(DestinationDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(DestinationDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SourceAccount { get; private set; }
        public VocabularyKey FromMainAccountRecId { get; private set; }
        public VocabularyKey FromMainAccountLedgerChartOfAccountsRecId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey AllocationPercentage { get; private set; }
        public VocabularyKey SourceSelectionCriteria { get; private set; }
        public VocabularyKey SourceSelectionCriteriaDisplayValue { get; private set; }
        public VocabularyKey SourceSelectionCriteriaDimensions { get; private set; }
        public VocabularyKey SourceSelectionCriteriaDimensionsDisplayValue { get; private set; }
        public VocabularyKey DestinationAccount { get; private set; }
        public VocabularyKey DestinationAccountDisplayValue { get; private set; }
        public VocabularyKey DestinationKeepSourceDimensions { get; private set; }
        public VocabularyKey DestinationKeepSourceDimensionsDisplayValue { get; private set; }
        public VocabularyKey DestinationDimensions { get; private set; }
        public VocabularyKey DestinationDimensionsDisplayValue { get; private set; }
    }
}