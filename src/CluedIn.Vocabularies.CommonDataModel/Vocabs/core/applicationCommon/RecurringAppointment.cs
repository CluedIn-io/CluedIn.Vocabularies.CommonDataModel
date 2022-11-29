using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class RecurringAppointmentVocabulary : SimpleVocabulary
    {
        public RecurringAppointmentVocabulary()
        {
            VocabularyName = "Recurring Appointment";
            KeyPrefix = "commonDataModel.recurringappointment.applicationcommon";
            KeySeparator = ".";
            Grouping = "/RecurringAppointment";

            AddGroup("RecurringAppointment Details for ApplicationCommon", group =>
            {
			    ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDurationMinutes = group.Add(new VocabularyKey(nameof(ActualDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsWeekDayPattern = group.Add(new VocabularyKey(nameof(IsWeekDayPattern), "Every Weekday", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RuleId = group.Add(new VocabularyKey(nameof(RuleId), "Recurrence Rule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsNthYearly = group.Add(new VocabularyKey(nameof(IsNthYearly), "Nth Yearly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupId = group.Add(new VocabularyKey(nameof(GroupId), "Group Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastExpandedInstanceDate = group.Add(new VocabularyKey(nameof(LastExpandedInstanceDate), "Last Expanded Instance Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveEndDate = group.Add(new VocabularyKey(nameof(EffectiveEndDate), "Effective End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PatternStartDate = group.Add(new VocabularyKey(nameof(PatternStartDate), "Recurrence Range Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRegenerate = group.Add(new VocabularyKey(nameof(IsRegenerate), "Regenerate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstDayOfWeek = group.Add(new VocabularyKey(nameof(FirstDayOfWeek), "First Day Of Week", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OutlookOwnerApptId = group.Add(new VocabularyKey(nameof(OutlookOwnerApptId), "Outlook Recurring Appointment Master Owner", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RecurrencePatternType = group.Add(new VocabularyKey(nameof(RecurrencePatternType), "Recurrence Frequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextExpansionInstanceDate = group.Add(new VocabularyKey(nameof(NextExpansionInstanceDate), "Next Expanded Instance Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpansionStateCode = group.Add(new VocabularyKey(nameof(ExpansionStateCode), "Expansion State Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PatternEndDate = group.Add(new VocabularyKey(nameof(PatternEndDate), "Recurrence Range End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GlobalObjectId = group.Add(new VocabularyKey(nameof(GlobalObjectId), "Outlook Recurring Appointment Master", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveStartDate = group.Add(new VocabularyKey(nameof(EffectiveStartDate), "Effective Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DayOfMonth = group.Add(new VocabularyKey(nameof(DayOfMonth), "Day Of Month", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartTime = group.Add(new VocabularyKey(nameof(StartTime), "Pattern Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occurrences = group.Add(new VocabularyKey(nameof(Occurrences), "Occurrences", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsAllDayEvent = group.Add(new VocabularyKey(nameof(IsAllDayEvent), "All Day Event", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SeriesStatus = group.Add(new VocabularyKey(nameof(SeriesStatus), "Series Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsNthMonthly = group.Add(new VocabularyKey(nameof(IsNthMonthly), "Nth Monthly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EndTime = group.Add(new VocabularyKey(nameof(EndTime), "Pattern End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DaysOfWeekMask = group.Add(new VocabularyKey(nameof(DaysOfWeekMask), "Days Of Week Mask", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Instance = group.Add(new VocabularyKey(nameof(Instance), "Instance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeletedExceptionsList = group.Add(new VocabularyKey(nameof(DeletedExceptionsList), "Deleted Appointments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Interval = group.Add(new VocabularyKey(nameof(Interval), "Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MonthOfYear = group.Add(new VocabularyKey(nameof(MonthOfYear), "Month Of Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Location = group.Add(new VocabularyKey(nameof(Location), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PatternEndType = group.Add(new VocabularyKey(nameof(PatternEndType), "Pattern End Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsUnsafe = group.Add(new VocabularyKey(nameof(IsUnsafe), "IsUnsafe", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey ActualDurationMinutes { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey IsWeekDayPattern { get; private set; }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey IsNthYearly { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey LastExpandedInstanceDate { get; private set; }
        public VocabularyKey EffectiveEndDate { get; private set; }
        public VocabularyKey PatternStartDate { get; private set; }
        public VocabularyKey IsRegenerate { get; private set; }
        public VocabularyKey FirstDayOfWeek { get; private set; }
        public VocabularyKey OutlookOwnerApptId { get; private set; }
        public VocabularyKey RecurrencePatternType { get; private set; }
        public VocabularyKey NextExpansionInstanceDate { get; private set; }
        public VocabularyKey ExpansionStateCode { get; private set; }
        public VocabularyKey PatternEndDate { get; private set; }
        public VocabularyKey GlobalObjectId { get; private set; }
        public VocabularyKey EffectiveStartDate { get; private set; }
        public VocabularyKey DayOfMonth { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey Occurrences { get; private set; }
        public VocabularyKey IsAllDayEvent { get; private set; }
        public VocabularyKey SeriesStatus { get; private set; }
        public VocabularyKey IsNthMonthly { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey DaysOfWeekMask { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Instance { get; private set; }
        public VocabularyKey DeletedExceptionsList { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey MonthOfYear { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey PatternEndType { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey IsUnsafe { get; private set; }
    }
}