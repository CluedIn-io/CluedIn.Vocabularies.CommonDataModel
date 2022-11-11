using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAdvancedRuleStructureActivationEntityVocabulary : SimpleVocabulary
    {
        public LedgerAdvancedRuleStructureActivationEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerAdvancedRuleStructureActivationEntity";
            KeyPrefix = "commonDataModel.ledgeradvancedrulestructureactivationentity";
            KeySeparator = ".";
            Grouping = "/LedgerAdvancedRuleStructureActivationEntity";

            AddGroup("Common Data Model LedgerAdvancedRuleStructureActivationEntity Details", group =>
            {
                AdvancedRuleStructure = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoActivate = group.Add(new VocabularyKey(nameof(DoActivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdvancedRuleStructure { get; private set; }
        public VocabularyKey DoActivate { get; private set; }


    }
}