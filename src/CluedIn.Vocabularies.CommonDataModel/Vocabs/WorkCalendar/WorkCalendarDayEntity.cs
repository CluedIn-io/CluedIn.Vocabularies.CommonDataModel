using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkCalendarDayEntityVocabulary : SimpleVocabulary
    {
        public WorkCalendarDayEntityVocabulary()
        {
            VocabularyName = "WorkCalendarDayEntity";
            KeyPrefix = "commonDataModel.workcalendardayentity";
            KeySeparator = ".";
            Grouping = "/WorkCalendarDayEntity";

            AddGroup("WorkCalendarDayEntity Details", group =>
            {
                WorkCalendarId = group.Add(new VocabularyKey(nameof(WorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarDate = group.Add(new VocabularyKey(nameof(CalendarDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosed = group.Add(new VocabularyKey(nameof(IsPickingUpClosed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingDayDefinition = group.Add(new VocabularyKey(nameof(WorkingDayDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkCalendarId { get; private set; }
        public VocabularyKey CalendarDate { get; private set; }
        public VocabularyKey IsPickingUpClosed { get; private set; }
        public VocabularyKey WorkingDayDefinition { get; private set; }


    }
}