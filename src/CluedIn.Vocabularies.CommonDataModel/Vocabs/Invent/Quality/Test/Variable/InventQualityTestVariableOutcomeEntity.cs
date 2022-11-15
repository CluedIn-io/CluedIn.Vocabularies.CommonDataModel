using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestVariableOutcomeEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestVariableOutcomeEntityVocabulary()
        {
            VocabularyName = "Invent Quality Test Variable Outcome Entity";
            KeyPrefix = "commonDataModel.inventqualitytestvariableoutcomeentity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestVariableOutcomeEntity";

            AddGroup("InventQualityTestVariableOutcomeEntity Details", group =>
            {
                QualityTestVariableId = group.Add(new VocabularyKey(nameof(QualityTestVariableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutcomeId = group.Add(new VocabularyKey(nameof(OutcomeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutcomeDescription = group.Add(new VocabularyKey(nameof(OutcomeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutcomeStatus = group.Add(new VocabularyKey(nameof(OutcomeStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey QualityTestVariableId { get; private set; }
        public VocabularyKey OutcomeId { get; private set; }
        public VocabularyKey OutcomeDescription { get; private set; }
        public VocabularyKey OutcomeStatus { get; private set; }
    }
}