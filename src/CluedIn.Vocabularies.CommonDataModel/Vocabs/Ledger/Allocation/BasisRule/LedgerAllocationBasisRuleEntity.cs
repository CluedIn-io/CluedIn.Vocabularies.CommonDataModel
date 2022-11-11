using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAllocationBasisRuleEntityVocabulary : SimpleVocabulary
    {
        public LedgerAllocationBasisRuleEntityVocabulary()
        {
            VocabularyName = "LedgerAllocationBasisRuleEntity";
            KeyPrefix = "commonDataModel.ledgerallocationbasisruleentity";
            KeySeparator = ".";
            Grouping = "/LedgerAllocationBasisRuleEntity";

            AddGroup("LedgerAllocationBasisRuleEntity Details", group =>
            {
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisId = group.Add(new VocabularyKey(nameof(BasisId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateInterval = group.Add(new VocabularyKey(nameof(DateInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey BasisId { get; private set; }
        public VocabularyKey DateInterval { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }


    }
}