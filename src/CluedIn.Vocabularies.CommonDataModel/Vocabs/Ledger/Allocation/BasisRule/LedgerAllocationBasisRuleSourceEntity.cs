using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationBasisRuleSourceEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationBasisRuleSourceEntityVocabulary()
        {
            VocabularyName = "Ledger Allocation Basis Rule Source Entity";
            KeyPrefix = "commonDataModel.ledgerallocationbasisrulesourceentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationBasisRuleSourceEntity";

            AddGroup("LedgerAllocationBasisRuleSourceEntity Details", group =>
            {
                BasisCriteria = group.Add(new VocabularyKey(nameof(BasisCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisDimensionAttribute = group.Add(new VocabularyKey(nameof(BasisDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisId = group.Add(new VocabularyKey(nameof(BasisId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSetting = group.Add(new VocabularyKey(nameof(FieldSetting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisDimensionAttributeName = group.Add(new VocabularyKey(nameof(BasisDimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BasisCriteria { get; private set; }
        public VocabularyKey BasisDimensionAttribute { get; private set; }
        public VocabularyKey BasisId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey FieldSetting { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey BasisDimensionAttributeName { get; private set; }
    }
}