using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalCalendarYearEntityVocabulary : SimpleVocabulary
    {
        public FiscalCalendarYearEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalCalendarYearEntity";
            KeyPrefix = "commonDataModel.fiscalcalendaryearentity";
            KeySeparator = ".";
            Grouping = "/FiscalCalendarYearEntity";

            AddGroup("Common Data Model FiscalCalendarYearEntity Details", group =>
            {
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendar_CalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendar_CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FiscalCalendar { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey FiscalCalendar_CalendarId { get; private set; }


    }
}