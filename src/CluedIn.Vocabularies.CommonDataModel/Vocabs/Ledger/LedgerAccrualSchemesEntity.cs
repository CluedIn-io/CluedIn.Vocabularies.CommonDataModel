using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAccrualSchemesEntityVocabulary : SimpleVocabulary
    {
        public LedgerAccrualSchemesEntityVocabulary()
        {
            VocabularyName = "Ledger Accrual Schemes Entity";
            KeyPrefix = "commonDataModel.ledgeraccrualschemesentity";
            KeySeparator = ".";
            Grouping = "/LedgerAccrualSchemesEntity";

            AddGroup("LedgerAccrualSchemesEntity Details", group =>
            {
                AccrualIdentification = group.Add(new VocabularyKey(nameof(AccrualIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualSchemeDescription = group.Add(new VocabularyKey(nameof(AccrualSchemeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DebitLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CreditLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLedgerDimension = group.Add(new VocabularyKey(nameof(CreditLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitLedgerDimension = group.Add(new VocabularyKey(nameof(DebitLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDescription = group.Add(new VocabularyKey(nameof(TransactionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualBasis = group.Add(new VocabularyKey(nameof(AccrualBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfOccurrencesPerPeriod = group.Add(new VocabularyKey(nameof(NumberOfOccurrencesPerPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodType = group.Add(new VocabularyKey(nameof(PeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodKey = group.Add(new VocabularyKey(nameof(PeriodKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostTransactions = group.Add(new VocabularyKey(nameof(PostTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostInWeekMonthOrQuarter = group.Add(new VocabularyKey(nameof(PostInWeekMonthOrQuarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpreadMonthAndQuarterValues = group.Add(new VocabularyKey(nameof(SpreadMonthAndQuarterValues), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable_NumberSequence = group.Add(new VocabularyKey(nameof(NumberSequenceTable_NumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable_NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceTable_NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope_DataArea = group.Add(new VocabularyKey(nameof(NumberSequenceScope_DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope_FiscalCalendarPeriod = group.Add(new VocabularyKey(nameof(NumberSequenceScope_FiscalCalendarPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope_LegalEntity = group.Add(new VocabularyKey(nameof(NumberSequenceScope_LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope_OperatingUnit = group.Add(new VocabularyKey(nameof(NumberSequenceScope_OperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope_OperatingUnitType = group.Add(new VocabularyKey(nameof(NumberSequenceScope_OperatingUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarPeriod_FiscalCalendarYear = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriod_FiscalCalendarYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarPeriod_Name = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriod_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYear_FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendarYear_FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYear_Name = group.Add(new VocabularyKey(nameof(FiscalCalendarYear_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendar_CalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendar_CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity_PartyNumber = group.Add(new VocabularyKey(nameof(LegalEntity_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity_DataArea = group.Add(new VocabularyKey(nameof(LegalEntity_DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnit_PartyNumber = group.Add(new VocabularyKey(nameof(OperatingUnit_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable = group.Add(new VocabularyKey(nameof(NumberSequenceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarPeriodFrequency = group.Add(new VocabularyKey(nameof(CalendarPeriodFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPeriodFrequency = group.Add(new VocabularyKey(nameof(FiscalPeriodFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccrualIdentification { get; private set; }
        public VocabularyKey AccrualSchemeDescription { get; private set; }
        public VocabularyKey DebitLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CreditLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey CreditLedgerDimension { get; private set; }
        public VocabularyKey DebitLedgerDimension { get; private set; }
        public VocabularyKey TransactionDescription { get; private set; }
        public VocabularyKey AccrualBasis { get; private set; }
        public VocabularyKey NumberOfOccurrencesPerPeriod { get; private set; }
        public VocabularyKey PeriodType { get; private set; }
        public VocabularyKey PeriodKey { get; private set; }
        public VocabularyKey PostTransactions { get; private set; }
        public VocabularyKey PostInWeekMonthOrQuarter { get; private set; }
        public VocabularyKey SpreadMonthAndQuarterValues { get; private set; }
        public VocabularyKey NumberSequenceTable_NumberSequence { get; private set; }
        public VocabularyKey NumberSequenceTable_NumberSequenceScope { get; private set; }
        public VocabularyKey NumberSequenceScope_DataArea { get; private set; }
        public VocabularyKey NumberSequenceScope_FiscalCalendarPeriod { get; private set; }
        public VocabularyKey NumberSequenceScope_LegalEntity { get; private set; }
        public VocabularyKey NumberSequenceScope_OperatingUnit { get; private set; }
        public VocabularyKey NumberSequenceScope_OperatingUnitType { get; private set; }
        public VocabularyKey FiscalCalendarPeriod_FiscalCalendarYear { get; private set; }
        public VocabularyKey FiscalCalendarPeriod_Name { get; private set; }
        public VocabularyKey FiscalCalendarYear_FiscalCalendar { get; private set; }
        public VocabularyKey FiscalCalendarYear_Name { get; private set; }
        public VocabularyKey FiscalCalendar_CalendarId { get; private set; }
        public VocabularyKey LegalEntity_PartyNumber { get; private set; }
        public VocabularyKey LegalEntity_DataArea { get; private set; }
        public VocabularyKey OperatingUnit_PartyNumber { get; private set; }
        public VocabularyKey NumberSequenceTable { get; private set; }
        public VocabularyKey CalendarPeriodFrequency { get; private set; }
        public VocabularyKey FiscalPeriodFrequency { get; private set; }
    }
}