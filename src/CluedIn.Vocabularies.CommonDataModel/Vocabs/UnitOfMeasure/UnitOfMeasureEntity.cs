using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UnitOfMeasureEntityVocabulary : SimpleVocabulary
    {
        public UnitOfMeasureEntityVocabulary()
        {
            VocabularyName = "Unit Of Measure Entity";
            KeyPrefix = "commonDataModel.unitofmeasureentity";
            KeySeparator = ".";
            Grouping = "/UnitOfMeasureEntity";

            AddGroup("UnitOfMeasureEntity Details", group =>
            {
                DecimalPrecision = group.Add(new VocabularyKey(nameof(DecimalPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemOfUnits = group.Add(new VocabularyKey(nameof(SystemOfUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitClass = group.Add(new VocabularyKey(nameof(UnitClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedUnitSymbolAssignment = group.Add(new VocabularyKey(nameof(FixedUnitSymbolAssignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFixedUnitSymbolAssigned = group.Add(new VocabularyKey(nameof(IsFixedUnitSymbolAssigned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBaseUnit = group.Add(new VocabularyKey(nameof(IsBaseUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSystemUnit = group.Add(new VocabularyKey(nameof(IsSystemUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitDescription = group.Add(new VocabularyKey(nameof(UnitDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionLanguageId = group.Add(new VocabularyKey(nameof(DescriptionLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseUnitClass = group.Add(new VocabularyKey(nameof(BaseUnitClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUnitClass = group.Add(new VocabularyKey(nameof(SystemUnitClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalCode = group.Add(new VocabularyKey(nameof(NationalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DecimalPrecision { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey SystemOfUnits { get; private set; }
        public VocabularyKey UnitClass { get; private set; }
        public VocabularyKey FixedUnitSymbolAssignment { get; private set; }
        public VocabularyKey IsFixedUnitSymbolAssigned { get; private set; }
        public VocabularyKey IsBaseUnit { get; private set; }
        public VocabularyKey IsSystemUnit { get; private set; }
        public VocabularyKey UnitDescription { get; private set; }
        public VocabularyKey DescriptionLanguageId { get; private set; }
        public VocabularyKey BaseUnitClass { get; private set; }
        public VocabularyKey SystemUnitClass { get; private set; }
        public VocabularyKey NationalCode { get; private set; }
    }
}