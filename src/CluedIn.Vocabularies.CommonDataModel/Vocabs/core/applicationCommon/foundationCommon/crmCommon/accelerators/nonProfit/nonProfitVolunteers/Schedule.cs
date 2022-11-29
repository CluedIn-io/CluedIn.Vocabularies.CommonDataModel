using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitVolunteers
{
    public class ScheduleVocabulary : SimpleVocabulary
    {
        public ScheduleVocabulary()
        {
            VocabularyName = "Schedule";
            KeyPrefix = "commonDataModel.schedule.nonprofitvolunteers";
            KeySeparator = ".";
            Grouping = "/Schedule";

            AddGroup("Schedule Details for NonProfitVolunteers", group =>
            {
			    EffectiveFrom = group.Add(new VocabularyKey(nameof(EffectiveFrom), "Effective From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveTo = group.Add(new VocabularyKey(nameof(EffectiveTo), "Effective To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndPeriod = group.Add(new VocabularyKey(nameof(EndPeriod), "End Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HoursPerDay = group.Add(new VocabularyKey(nameof(HoursPerDay), "Hours per Day", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleId = group.Add(new VocabularyKey(nameof(ScheduleId), "Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartPeriod = group.Add(new VocabularyKey(nameof(StartPeriod), "Start Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalHours = group.Add(new VocabularyKey(nameof(TotalHours), "Total Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    WorkingDays = group.Add(new VocabularyKey(nameof(WorkingDays), "Working Days", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EffectiveFrom { get; private set; }
        public VocabularyKey EffectiveTo { get; private set; }
        public VocabularyKey EndPeriod { get; private set; }
        public VocabularyKey HoursPerDay { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleId { get; private set; }
        public VocabularyKey StartPeriod { get; private set; }
        public VocabularyKey TotalHours { get; private set; }
        public VocabularyKey WorkingDays { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}