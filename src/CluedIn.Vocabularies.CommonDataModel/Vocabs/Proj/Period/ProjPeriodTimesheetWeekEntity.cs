using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjPeriodTimesheetWeekEntityVocabulary : SimpleVocabulary
    {
        public ProjPeriodTimesheetWeekEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjPeriodTimesheetWeekEntity";
            KeyPrefix = "commonDataModel.projperiodtimesheetweekentity";
            KeySeparator = ".";
            Grouping = "/ProjPeriodTimesheetWeekEntity";

            AddGroup("Common Data Model ProjPeriodTimesheetWeekEntity Details", group =>
            {
                PeriodFrom = group.Add(new VocabularyKey(nameof(PeriodFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTo = group.Add(new VocabularyKey(nameof(PeriodTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PeriodFrom { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey PeriodTo { get; private set; }


    }
}