using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalPeriodDateEntityVocabulary : SimpleVocabulary
    {
        public FiscalPeriodDateEntityVocabulary()
        {
            VocabularyName = "FiscalPeriodDateEntity";
            KeyPrefix = "commonDataModel.fiscalperioddateentity";
            KeySeparator = ".";
            Grouping = "/FiscalPeriodDateEntity";

            AddGroup("FiscalPeriodDateEntity Details", group =>
            {
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarRecId = group.Add(new VocabularyKey(nameof(CalendarRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GregorianDate = group.Add(new VocabularyKey(nameof(GregorianDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerGregorianDateId = group.Add(new VocabularyKey(nameof(LedgerGregorianDateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodRecId = group.Add(new VocabularyKey(nameof(PeriodRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearName = group.Add(new VocabularyKey(nameof(YearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodOffset = group.Add(new VocabularyKey(nameof(PeriodOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuarterOffset = group.Add(new VocabularyKey(nameof(QuarterOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearOffset = group.Add(new VocabularyKey(nameof(YearOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CalendarRecId { get; private set; }
        public VocabularyKey GregorianDate { get; private set; }
        public VocabularyKey LedgerGregorianDateId { get; private set; }
        public VocabularyKey LedgerRecId { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey PeriodRecId { get; private set; }
        public VocabularyKey Quarter { get; private set; }
        public VocabularyKey YearName { get; private set; }
        public VocabularyKey PeriodOffset { get; private set; }
        public VocabularyKey QuarterOffset { get; private set; }
        public VocabularyKey YearOffset { get; private set; }


    }
}