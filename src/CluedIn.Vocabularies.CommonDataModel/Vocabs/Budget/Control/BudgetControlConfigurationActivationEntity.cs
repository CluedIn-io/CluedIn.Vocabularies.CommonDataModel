using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlConfigurationActivationEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlConfigurationActivationEntityVocabulary()
        {
            VocabularyName = "BudgetControlConfigurationActivationEntity";
            KeyPrefix = "commonDataModel.budgetcontrolconfigurationactivationentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlConfigurationActivationEntity";

            AddGroup("BudgetControlConfigurationActivationEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivateDraft = group.Add(new VocabularyKey(nameof(ActivateDraft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TurnOnBudgetControl = group.Add(new VocabularyKey(nameof(TurnOnBudgetControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey ActivateDraft { get; private set; }
        public VocabularyKey TurnOnBudgetControl { get; private set; }


    }
}