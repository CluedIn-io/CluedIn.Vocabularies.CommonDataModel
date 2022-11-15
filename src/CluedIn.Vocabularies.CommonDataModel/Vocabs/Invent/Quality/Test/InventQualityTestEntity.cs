using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestEntityVocabulary()
        {
            VocabularyName = "Invent Quality Test Entity";
            KeyPrefix = "commonDataModel.inventqualitytestentity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestEntity";

            AddGroup("InventQualityTestEntity Details", group =>
            {
                TestDescription = group.Add(new VocabularyKey(nameof(TestDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestId = group.Add(new VocabularyKey(nameof(TestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestInstrumentId = group.Add(new VocabularyKey(nameof(TestInstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestMeasurementType = group.Add(new VocabularyKey(nameof(QualityTestMeasurementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestMeasurementUnitSymbol = group.Add(new VocabularyKey(nameof(TestMeasurementUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TestDescription { get; private set; }
        public VocabularyKey TestId { get; private set; }
        public VocabularyKey TestInstrumentId { get; private set; }
        public VocabularyKey QualityTestMeasurementType { get; private set; }
        public VocabularyKey TestMeasurementUnitSymbol { get; private set; }
    }
}