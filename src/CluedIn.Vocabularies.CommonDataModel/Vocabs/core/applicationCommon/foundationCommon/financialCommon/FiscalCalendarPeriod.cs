using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class FiscalCalendarPeriodVocabulary : SimpleVocabulary
    {
        public FiscalCalendarPeriodVocabulary()
        {
            VocabularyName = "Fiscal Calendar Period";
            KeyPrefix = "commonDataModel.fiscalcalendarperiod";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FiscalCalendarPeriod;

            AddGroup("FiscalCalendarPeriod Details for FinancialCommon", group =>
            {
			    FiscalCalendarPeriodId = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriodId), "Fiscal Calendar Period ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FiscalCalendarName = group.Add(new VocabularyKey(nameof(FiscalCalendarName), "Fiscal Calendar Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), "Period Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodOffset = group.Add(new VocabularyKey(nameof(PeriodOffset), "Period Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    YearName = group.Add(new VocabularyKey(nameof(YearName), "Year Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YearOffset = group.Add(new VocabularyKey(nameof(YearOffset), "Year Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Quarter = group.Add(new VocabularyKey(nameof(Quarter), "Quarter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuarterOffset = group.Add(new VocabularyKey(nameof(QuarterOffset), "Quarter Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Month = group.Add(new VocabularyKey(nameof(Month), "Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="FiscalCalendarPeriodId"/> from Vocab 'FinancialActivity.cdm.json/FinancialActivity' with Property 'FiscalCalendarPeriodKey'
            #endregion
        }

        public VocabularyKey FiscalCalendarName { get; private set; }
        public VocabularyKey FiscalCalendarPeriodId { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey PeriodOffset { get; private set; }
        public VocabularyKey Quarter { get; private set; }
        public VocabularyKey QuarterOffset { get; private set; }
        public VocabularyKey YearName { get; private set; }
        public VocabularyKey YearOffset { get; private set; }
    }
}