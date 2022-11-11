using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetAllowTransferRuleEntityVocabulary : SimpleVocabulary
    {
        public BudgetAllowTransferRuleEntityVocabulary()
        {
            VocabularyName = "BudgetAllowTransferRuleEntity";
            KeyPrefix = "commonDataModel.budgetallowtransferruleentity";
            KeySeparator = ".";
            Grouping = "/BudgetAllowTransferRuleEntity";

            AddGroup("BudgetAllowTransferRuleEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetTransferRule = group.Add(new VocabularyKey(nameof(BudgetTransferRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureId = group.Add(new VocabularyKey(nameof(AccountStructureId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleMember = group.Add(new VocabularyKey(nameof(RuleMember), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeId = group.Add(new VocabularyKey(nameof(DimensionAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Criterion = group.Add(new VocabularyKey(nameof(Criterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleMemberId = group.Add(new VocabularyKey(nameof(RuleMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey BudgetTransferRule { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountStructureId { get; private set; }
        public VocabularyKey RuleMember { get; private set; }
        public VocabularyKey DimensionAttributeId { get; private set; }
        public VocabularyKey Criterion { get; private set; }
        public VocabularyKey RuleMemberId { get; private set; }


    }
}