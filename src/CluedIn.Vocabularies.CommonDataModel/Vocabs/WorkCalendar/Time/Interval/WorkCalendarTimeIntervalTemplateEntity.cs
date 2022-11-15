using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkCalendarTimeIntervalTemplateEntityVocabulary : SimpleVocabulary
    {
        public WorkCalendarTimeIntervalTemplateEntityVocabulary()
        {
            VocabularyName = "Work Calendar Time Interval Template Entity";
            KeyPrefix = "commonDataModel.workcalendartimeintervaltemplateentity";
            KeySeparator = ".";
            Grouping = "/WorkCalendarTimeIntervalTemplateEntity";

            AddGroup("WorkCalendarTimeIntervalTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeekDay = group.Add(new VocabularyKey(nameof(WeekDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EfficiencyPercentage = group.Add(new VocabularyKey(nameof(EfficiencyPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey WeekDay { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey EfficiencyPercentage { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
    }
}