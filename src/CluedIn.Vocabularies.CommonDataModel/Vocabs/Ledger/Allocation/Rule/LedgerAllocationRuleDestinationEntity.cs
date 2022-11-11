using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationRuleDestinationEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationRuleDestinationEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerAllocationRuleDestinationEntity";
            KeyPrefix = "commonDataModel.ledgerallocationruledestinationentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationRuleDestinationEntity";

            AddGroup("Common Data Model LedgerAllocationRuleDestinationEntity Details", group =>
            {
                BasisId = group.Add(new VocabularyKey(nameof(BasisId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPercentage = group.Add(new VocabularyKey(nameof(FixedPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedWeight = group.Add(new VocabularyKey(nameof(FixedWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rule = group.Add(new VocabularyKey(nameof(Rule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimensions = group.Add(new VocabularyKey(nameof(ToDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromCompany = group.Add(new VocabularyKey(nameof(FromCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAccount = group.Add(new VocabularyKey(nameof(ToAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(ToDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAccountDisplayValue = group.Add(new VocabularyKey(nameof(ToAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BasisId { get; private set; }
        public VocabularyKey FixedPercentage { get; private set; }
        public VocabularyKey FixedWeight { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Rule { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey ToDimensions { get; private set; }
        public VocabularyKey FromCompany { get; private set; }
        public VocabularyKey ToAccount { get; private set; }
        public VocabularyKey ToDimensionsDisplayValue { get; private set; }
        public VocabularyKey ToAccountDisplayValue { get; private set; }


    }
}