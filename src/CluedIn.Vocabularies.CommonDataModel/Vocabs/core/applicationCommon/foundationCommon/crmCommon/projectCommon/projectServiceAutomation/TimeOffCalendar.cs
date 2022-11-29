using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class TimeOffCalendarVocabulary : SimpleVocabulary
    {
        public TimeOffCalendarVocabulary()
        {
            VocabularyName = "Time Off Calendar";
            KeyPrefix = "commonDataModel.timeoffcalendar.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/TimeOffCalendar";

            AddGroup("TimeOffCalendar Details for ProjectServiceAutomation", group =>
            {
			    TimeOffCalendarId = group.Add(new VocabularyKey(nameof(TimeOffCalendarId), "Time Off Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Calendar = group.Add(new VocabularyKey(nameof(Calendar), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TimeOffCalendarId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Calendar { get; private set; }
    }
}