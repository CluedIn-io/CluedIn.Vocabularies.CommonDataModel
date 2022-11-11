using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationRuleSourceEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationRuleSourceEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerAllocationRuleSourceEntity";
            KeyPrefix = "commonDataModel.ledgerallocationrulesourceentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationRuleSourceEntity";

            AddGroup("Common Data Model LedgerAllocationRuleSourceEntity Details", group =>
            {
                FieldSetting = group.Add(new VocabularyKey(nameof(FieldSetting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rule = group.Add(new VocabularyKey(nameof(Rule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCriteria = group.Add(new VocabularyKey(nameof(SourceCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeRecId = group.Add(new VocabularyKey(nameof(DimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeName = group.Add(new VocabularyKey(nameof(DimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldSetting { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Rule { get; private set; }
        public VocabularyKey SourceCriteria { get; private set; }
        public VocabularyKey DimensionAttributeRecId { get; private set; }
        public VocabularyKey DimensionAttributeName { get; private set; }


    }
}