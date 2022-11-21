using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerEliminationRuleLineEntityVocabulary : SimpleVocabulary
    {
        public LedgerEliminationRuleLineEntityVocabulary()
        {
            VocabularyName = "Ledger Elimination Rule Line Entity";
            KeyPrefix = "commonDataModel.ledgereliminationrulelineentity";
            KeySeparator = ".";
            Grouping = "/LedgerEliminationRuleLineEntity";

            AddGroup("LedgerEliminationRuleLineEntity Details", group =>
            {
                RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EliminationMethod = group.Add(new VocabularyKey(nameof(EliminationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceAccount = group.Add(new VocabularyKey(nameof(SourceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAccount = group.Add(new VocabularyKey(nameof(DestinationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationDimension = group.Add(new VocabularyKey(nameof(DestinationDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey EliminationMethod { get; private set; }
        public VocabularyKey SourceAccount { get; private set; }
        public VocabularyKey DestinationAccount { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DestinationDimension { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
    }
}