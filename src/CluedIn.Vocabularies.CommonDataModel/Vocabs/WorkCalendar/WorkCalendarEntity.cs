using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkCalendarEntityVocabulary : SimpleVocabulary
    {
        public WorkCalendarEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkCalendarEntity";
            KeyPrefix = "commonDataModel.workcalendarentity";
            KeySeparator = ".";
            Grouping = "/WorkCalendarEntity";

            AddGroup("Common Data Model WorkCalendarEntity Details", group =>
            {
                BaseWorkCalendarId = group.Add(new VocabularyKey(nameof(BaseWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarName = group.Add(new VocabularyKey(nameof(CalendarName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkHours = group.Add(new VocabularyKey(nameof(WorkHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BaseWorkCalendarId { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CalendarName { get; private set; }
        public VocabularyKey WorkHours { get; private set; }


    }
}