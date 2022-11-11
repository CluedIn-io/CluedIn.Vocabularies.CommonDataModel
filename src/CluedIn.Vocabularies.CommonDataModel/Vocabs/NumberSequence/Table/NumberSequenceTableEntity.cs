using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequenceTableEntityVocabulary : SimpleVocabulary
    {
        public NumberSequenceTableEntityVocabulary()
        {
            VocabularyName = "NumberSequenceTableEntity";
            KeyPrefix = "commonDataModel.numbersequencetableentity";
            KeySeparator = ".";
            Grouping = "/NumberSequenceTableEntity";

            AddGroup("NumberSequenceTableEntity Details", group =>
            {
                ToALowerNumber = group.Add(new VocabularyKey(nameof(ToALowerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAHigherNumber = group.Add(new VocabularyKey(nameof(ToAHigherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stopped = group.Add(new VocabularyKey(nameof(Stopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CleanUp = group.Add(new VocabularyKey(nameof(CleanUp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interval = group.Add(new VocabularyKey(nameof(Interval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Continuous = group.Add(new VocabularyKey(nameof(Continuous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cyclical = group.Add(new VocabularyKey(nameof(Cyclical), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Preallocation = group.Add(new VocabularyKey(nameof(Preallocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityOfNumbers = group.Add(new VocabularyKey(nameof(QuantityOfNumbers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Largest = group.Add(new VocabularyKey(nameof(Largest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUse = group.Add(new VocabularyKey(nameof(InUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTime = group.Add(new VocabularyKey(nameof(DateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Smallest = group.Add(new VocabularyKey(nameof(Smallest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manual = group.Add(new VocabularyKey(nameof(Manual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Next = group.Add(new VocabularyKey(nameof(Next), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCounting = group.Add(new VocabularyKey(nameof(SkipCounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScopeRecId = group.Add(new VocabularyKey(nameof(NumberSequenceScopeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarPeriod = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnit = group.Add(new VocabularyKey(nameof(OperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitTypes = group.Add(new VocabularyKey(nameof(OperatingUnitTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScopeValue = group.Add(new VocabularyKey(nameof(ScopeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScopeType = group.Add(new VocabularyKey(nameof(ScopeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnnotatedFormat = group.Add(new VocabularyKey(nameof(AnnotatedFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ToALowerNumber { get; private set; }
        public VocabularyKey ToAHigherNumber { get; private set; }
        public VocabularyKey Stopped { get; private set; }
        public VocabularyKey CleanUp { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey Continuous { get; private set; }
        public VocabularyKey Cyclical { get; private set; }
        public VocabularyKey Preallocation { get; private set; }
        public VocabularyKey QuantityOfNumbers { get; private set; }
        public VocabularyKey Format { get; private set; }
        public VocabularyKey Largest { get; private set; }
        public VocabularyKey InUse { get; private set; }
        public VocabularyKey DateTime { get; private set; }
        public VocabularyKey Smallest { get; private set; }
        public VocabularyKey Manual { get; private set; }
        public VocabularyKey Next { get; private set; }
        public VocabularyKey SkipCounting { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey NumberSequenceScopeRecId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey FiscalCalendarPeriod { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey OperatingUnit { get; private set; }
        public VocabularyKey OperatingUnitTypes { get; private set; }
        public VocabularyKey ScopeValue { get; private set; }
        public VocabularyKey ScopeType { get; private set; }
        public VocabularyKey AnnotatedFormat { get; private set; }


    }
}