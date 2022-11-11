using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkCalendarTimeIntervalEntityVocabulary : SimpleVocabulary
    {
        public WorkCalendarTimeIntervalEntityVocabulary()
        {
            VocabularyName = "WorkCalendarTimeIntervalEntity";
            KeyPrefix = "commonDataModel.workcalendartimeintervalentity";
            KeySeparator = ".";
            Grouping = "/WorkCalendarTimeIntervalEntity";

            AddGroup("WorkCalendarTimeIntervalEntity Details", group =>
            {
                WorkCalendarId = group.Add(new VocabularyKey(nameof(WorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCalendarDate = group.Add(new VocabularyKey(nameof(WorkCalendarDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EfficiencyPercentage = group.Add(new VocabularyKey(nameof(EfficiencyPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollEarningCode = group.Add(new VocabularyKey(nameof(PayrollEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkCalendarId { get; private set; }
        public VocabularyKey WorkCalendarDate { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey EfficiencyPercentage { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey PayrollEarningCode { get; private set; }


    }
}