using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowStepEntityVocabulary : SimpleVocabulary
    {
        public WorkflowStepEntityVocabulary()
        {
            VocabularyName = "Workflow Step Entity";
            KeyPrefix = "commonDataModel.workflowstepentity";
            KeySeparator = ".";
            Grouping = "/WorkflowStepEntity";

            AddGroup("WorkflowStepEntity Details", group =>
            {
                CompletionPolicy = group.Add(new VocabularyKey(nameof(CompletionPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompletionPolicyPercentage = group.Add(new VocabularyKey(nameof(CompletionPolicyPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunStep = group.Add(new VocabularyKey(nameof(RunStep), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunStepConditionId = group.Add(new VocabularyKey(nameof(RunStepConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StepId = group.Add(new VocabularyKey(nameof(StepId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowUserValue = group.Add(new VocabularyKey(nameof(WorkflowUserValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentRelationType = group.Add(new VocabularyKey(nameof(AssignmentRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentType = group.Add(new VocabularyKey(nameof(AssignmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyFilterConditionId = group.Add(new VocabularyKey(nameof(HierarchyFilterConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyFilterType = group.Add(new VocabularyKey(nameof(HierarchyFilterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyProviderName = group.Add(new VocabularyKey(nameof(HierarchyProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStopConditionId = group.Add(new VocabularyKey(nameof(HierarchyStopConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyTokenName = group.Add(new VocabularyKey(nameof(HierarchyTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantProviderName = group.Add(new VocabularyKey(nameof(ParticipantProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantTokenName = group.Add(new VocabularyKey(nameof(ParticipantTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueProviderName = group.Add(new VocabularyKey(nameof(QueueProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueTokenName = group.Add(new VocabularyKey(nameof(QueueTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserValue = group.Add(new VocabularyKey(nameof(UserValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyCalendar = group.Add(new VocabularyKey(nameof(DailyCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyCalendarProvider = group.Add(new VocabularyKey(nameof(DailyCalendarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeFriday = group.Add(new VocabularyKey(nameof(DailyIncludeFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeMonday = group.Add(new VocabularyKey(nameof(DailyIncludeMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeSaturday = group.Add(new VocabularyKey(nameof(DailyIncludeSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeSunday = group.Add(new VocabularyKey(nameof(DailyIncludeSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeThursday = group.Add(new VocabularyKey(nameof(DailyIncludeThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeTuesday = group.Add(new VocabularyKey(nameof(DailyIncludeTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyIncludeWednesday = group.Add(new VocabularyKey(nameof(DailyIncludeWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyUseNonCalendar = group.Add(new VocabularyKey(nameof(DailyUseNonCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyValue = group.Add(new VocabularyKey(nameof(DailyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateType = group.Add(new VocabularyKey(nameof(DateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourCalendar = group.Add(new VocabularyKey(nameof(HourCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourCalendarProvider = group.Add(new VocabularyKey(nameof(HourCalendarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeFriday = group.Add(new VocabularyKey(nameof(HourIncludeFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeMonday = group.Add(new VocabularyKey(nameof(HourIncludeMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeSaturday = group.Add(new VocabularyKey(nameof(HourIncludeSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeSunday = group.Add(new VocabularyKey(nameof(HourIncludeSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeThursday = group.Add(new VocabularyKey(nameof(HourIncludeThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeTuesday = group.Add(new VocabularyKey(nameof(HourIncludeTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourIncludeWednesday = group.Add(new VocabularyKey(nameof(HourIncludeWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoursAvailable = group.Add(new VocabularyKey(nameof(HoursAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourStartTime = group.Add(new VocabularyKey(nameof(HourStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourUseNonCalendar = group.Add(new VocabularyKey(nameof(HourUseNonCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourValue = group.Add(new VocabularyKey(nameof(HourValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthlyDayOfWeek = group.Add(new VocabularyKey(nameof(MonthlyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthlyWeekInMonth = group.Add(new VocabularyKey(nameof(MonthlyWeekInMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeSpanRelationType = group.Add(new VocabularyKey(nameof(TimeSpanRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeeklyDayOfWeek = group.Add(new VocabularyKey(nameof(WeeklyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeeklyValue = group.Add(new VocabularyKey(nameof(WeeklyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearlyDayOfWeek = group.Add(new VocabularyKey(nameof(YearlyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearlyMonthInYear = group.Add(new VocabularyKey(nameof(YearlyMonthInYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearlyWeekInMonth = group.Add(new VocabularyKey(nameof(YearlyWeekInMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EscalationAction = group.Add(new VocabularyKey(nameof(EscalationAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EscalationType = group.Add(new VocabularyKey(nameof(EscalationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EscalationPathAction = group.Add(new VocabularyKey(nameof(EscalationPathAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CompletionPolicy { get; private set; }
        public VocabularyKey CompletionPolicyPercentage { get; private set; }
        public VocabularyKey ElementId { get; private set; }
        public VocabularyKey RunStep { get; private set; }
        public VocabularyKey RunStepConditionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey StepId { get; private set; }
        public VocabularyKey WorkflowUserValue { get; private set; }
        public VocabularyKey AssignmentRelationType { get; private set; }
        public VocabularyKey AssignmentType { get; private set; }
        public VocabularyKey HierarchyFilterConditionId { get; private set; }
        public VocabularyKey HierarchyFilterType { get; private set; }
        public VocabularyKey HierarchyProviderName { get; private set; }
        public VocabularyKey HierarchyStopConditionId { get; private set; }
        public VocabularyKey HierarchyTokenName { get; private set; }
        public VocabularyKey ParticipantProviderName { get; private set; }
        public VocabularyKey ParticipantTokenName { get; private set; }
        public VocabularyKey QueueProviderName { get; private set; }
        public VocabularyKey QueueTokenName { get; private set; }
        public VocabularyKey UserValue { get; private set; }
        public VocabularyKey DailyCalendar { get; private set; }
        public VocabularyKey DailyCalendarProvider { get; private set; }
        public VocabularyKey DailyIncludeFriday { get; private set; }
        public VocabularyKey DailyIncludeMonday { get; private set; }
        public VocabularyKey DailyIncludeSaturday { get; private set; }
        public VocabularyKey DailyIncludeSunday { get; private set; }
        public VocabularyKey DailyIncludeThursday { get; private set; }
        public VocabularyKey DailyIncludeTuesday { get; private set; }
        public VocabularyKey DailyIncludeWednesday { get; private set; }
        public VocabularyKey DailyUseNonCalendar { get; private set; }
        public VocabularyKey DailyValue { get; private set; }
        public VocabularyKey DateType { get; private set; }
        public VocabularyKey HourCalendar { get; private set; }
        public VocabularyKey HourCalendarProvider { get; private set; }
        public VocabularyKey HourIncludeFriday { get; private set; }
        public VocabularyKey HourIncludeMonday { get; private set; }
        public VocabularyKey HourIncludeSaturday { get; private set; }
        public VocabularyKey HourIncludeSunday { get; private set; }
        public VocabularyKey HourIncludeThursday { get; private set; }
        public VocabularyKey HourIncludeTuesday { get; private set; }
        public VocabularyKey HourIncludeWednesday { get; private set; }
        public VocabularyKey HoursAvailable { get; private set; }
        public VocabularyKey HourStartTime { get; private set; }
        public VocabularyKey HourUseNonCalendar { get; private set; }
        public VocabularyKey HourValue { get; private set; }
        public VocabularyKey MonthlyDayOfWeek { get; private set; }
        public VocabularyKey MonthlyWeekInMonth { get; private set; }
        public VocabularyKey TimeSpanRelationType { get; private set; }
        public VocabularyKey WeeklyDayOfWeek { get; private set; }
        public VocabularyKey WeeklyValue { get; private set; }
        public VocabularyKey YearlyDayOfWeek { get; private set; }
        public VocabularyKey YearlyMonthInYear { get; private set; }
        public VocabularyKey YearlyWeekInMonth { get; private set; }
        public VocabularyKey EscalationAction { get; private set; }
        public VocabularyKey EscalationType { get; private set; }
        public VocabularyKey EscalationPathAction { get; private set; }
    }
}