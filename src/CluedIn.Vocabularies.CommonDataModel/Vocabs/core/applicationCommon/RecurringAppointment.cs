using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RecurringAppointmentVocabulary : SimpleVocabulary
    {
        public RecurringAppointmentVocabulary()
        {
            VocabularyName = "Recurring Appointment";
            KeyPrefix = "commonDataModel.recurringappointment";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RecurringAppointment;

            AddGroup("RecurringAppointment Details for ApplicationCommon", group =>
            {
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
            AddGroup("RecurringAppointment Details for CrmCommon", group =>
            {
                OptionalAttendees = group.Add(new VocabularyKey(nameof(OptionalAttendees), "Optional Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredAttendees = group.Add(new VocabularyKey(nameof(RequiredAttendees), "Required Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ActivityId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'SeriesId'
            ///Property <see cref="ActivityId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ActivityId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="ActivityId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'QueueItem.cdm.json/QueueItem' with Property 'ObjectId'
            #endregion
        }

        public VocabularyKey DayOfMonth { get; private set; }
        public VocabularyKey DaysOfWeekMask { get; private set; }
        public VocabularyKey DeletedExceptionsList { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EffectiveEndDate { get; private set; }
        public VocabularyKey EffectiveStartDate { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpansionStateCode { get; private set; }
        public VocabularyKey FirstDayOfWeek { get; private set; }
        public VocabularyKey GlobalObjectId { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Instance { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey IsAllDayEvent { get; private set; }
        public VocabularyKey IsNthMonthly { get; private set; }
        public VocabularyKey IsNthYearly { get; private set; }
        public VocabularyKey IsRegenerate { get; private set; }
        public VocabularyKey IsUnsafe { get; private set; }
        public VocabularyKey IsWeekDayPattern { get; private set; }
        public VocabularyKey LastExpandedInstanceDate { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey MonthOfYear { get; private set; }
        public VocabularyKey NextExpansionInstanceDate { get; private set; }
        public VocabularyKey Occurrences { get; private set; }
        public VocabularyKey OptionalAttendees { get; private set; }
        public VocabularyKey OutlookOwnerApptId { get; private set; }
        public VocabularyKey PatternEndDate { get; private set; }
        public VocabularyKey PatternEndType { get; private set; }
        public VocabularyKey PatternStartDate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey RecurrencePatternType { get; private set; }
        public VocabularyKey RequiredAttendees { get; private set; }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey SeriesStatus { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}