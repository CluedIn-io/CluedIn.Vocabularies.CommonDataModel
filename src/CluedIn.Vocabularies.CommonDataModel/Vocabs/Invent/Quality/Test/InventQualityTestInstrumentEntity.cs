using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestInstrumentEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestInstrumentEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventQualityTestInstrumentEntity";
            KeyPrefix = "commonDataModel.inventqualitytestinstrumententity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestInstrumentEntity";

            AddGroup("Common Data Model InventQualityTestInstrumentEntity Details", group =>
            {
                InstrumentId = group.Add(new VocabularyKey(nameof(InstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstrumentDescription = group.Add(new VocabularyKey(nameof(InstrumentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestMeasurementUnitSymbol = group.Add(new VocabularyKey(nameof(TestMeasurementUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestInstrumentUnitPrecision = group.Add(new VocabularyKey(nameof(QualityTestInstrumentUnitPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InstrumentId { get; private set; }
        public VocabularyKey InstrumentDescription { get; private set; }
        public VocabularyKey TestMeasurementUnitSymbol { get; private set; }
        public VocabularyKey QualityTestInstrumentUnitPrecision { get; private set; }


    }
}