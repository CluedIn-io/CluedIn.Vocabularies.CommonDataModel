using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRVocabulary : SimpleVocabulary
    {
        public AppointmentEMRVocabulary()
        {
            VocabularyName = "Appointment EMR";
            KeyPrefix = "commonDataModel.appointmentemr.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMR";

            AddGroup("AppointmentEMR Details for ElectronicMedicalRecords", group =>
            {
			    ActivityAdditionalParams = group.Add(new VocabularyKey(nameof(ActivityAdditionalParams), "Activity Additional Parameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), "Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDurationMinutes = group.Add(new VocabularyKey(nameof(ActualDurationMinutes), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "BCC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "CC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Customers = group.Add(new VocabularyKey(nameof(Customers), "Customers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryLastAttemptedOn = group.Add(new VocabularyKey(nameof(DeliveryLastAttemptedOn), "Date Delivery Last Attempted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeItemID = group.Add(new VocabularyKey(nameof(ExchangeItemID), "Exchange Item ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeWebLink = group.Add(new VocabularyKey(nameof(ExchangeWebLink), "Exchange WebLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InstanceTypeCode = group.Add(new VocabularyKey(nameof(InstanceTypeCode), "Recurring Instance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBilled = group.Add(new VocabularyKey(nameof(IsBilled), "Is Billed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMapiPrivate = group.Add(new VocabularyKey(nameof(IsMapiPrivate), "Is Private", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsRegularActivity = group.Add(new VocabularyKey(nameof(IsRegularActivity), "Is Regular Activity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsWorkflowCreated = group.Add(new VocabularyKey(nameof(IsWorkflowCreated), "Is Workflow Created", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeftVoiceMail = group.Add(new VocabularyKey(nameof(LeftVoiceMail), "Left Voice Mail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AppointmentCreationDate = group.Add(new VocabularyKey(nameof(AppointmentCreationDate), "Appointment Creation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AppointmentStatus = group.Add(new VocabularyKey(nameof(AppointmentStatus), "Appointment Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Emrdescription = group.Add(new VocabularyKey(nameof(Emrdescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndTime = group.Add(new VocabularyKey(nameof(EndTime), "End time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MinutesDuration = group.Add(new VocabularyKey(nameof(MinutesDuration), "Minutes Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ParticipantActorType = group.Add(new VocabularyKey(nameof(ParticipantActorType), "Participant Actor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipantStatus = group.Add(new VocabularyKey(nameof(ParticipantStatus), "Participant Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PatientInstruction = group.Add(new VocabularyKey(nameof(PatientInstruction), "Patient Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Required = group.Add(new VocabularyKey(nameof(Required), "Required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartTime = group.Add(new VocabularyKey(nameof(StartTime), "Start time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInformation = group.Add(new VocabularyKey(nameof(SupportingInformation), "Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OptionalAttendees = group.Add(new VocabularyKey(nameof(OptionalAttendees), "Optional Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Organizer = group.Add(new VocabularyKey(nameof(Organizer), "Organizer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Partners = group.Add(new VocabularyKey(nameof(Partners), "Outsource Vendors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostponeActivityProcessingUntil = group.Add(new VocabularyKey(nameof(PostponeActivityProcessingUntil), "Delay activity processing until", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    RequiredAttendees = group.Add(new VocabularyKey(nameof(RequiredAttendees), "Required Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resources = group.Add(new VocabularyKey(nameof(Resources), "Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Appointment (EMR) Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SenderMailboxId = group.Add(new VocabularyKey(nameof(SenderMailboxId), "Sender's Mailbox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SentOn = group.Add(new VocabularyKey(nameof(SentOn), "Date Sent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeriesId = group.Add(new VocabularyKey(nameof(SeriesId), "Series Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SortDate = group.Add(new VocabularyKey(nameof(SortDate), "Sort Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityAdditionalParams { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey ActualDurationMinutes { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey Customers { get; private set; }
        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeItemID { get; private set; }
        public VocabularyKey ExchangeWebLink { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey InstanceTypeCode { get; private set; }
        public VocabularyKey IsBilled { get; private set; }
        public VocabularyKey IsMapiPrivate { get; private set; }
        public VocabularyKey IsRegularActivity { get; private set; }
        public VocabularyKey IsWorkflowCreated { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey LeftVoiceMail { get; private set; }
        public VocabularyKey AppointmentCreationDate { get; private set; }
        public VocabularyKey AppointmentStatus { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey Emrdescription { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey MinutesDuration { get; private set; }
        public VocabularyKey ParticipantActorType { get; private set; }
        public VocabularyKey ParticipantStatus { get; private set; }
        public VocabularyKey PatientInstruction { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey Required { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey SupportingInformation { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OptionalAttendees { get; private set; }
        public VocabularyKey Organizer { get; private set; }
        public VocabularyKey Partners { get; private set; }
        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey RequiredAttendees { get; private set; }
        public VocabularyKey Resources { get; private set; }
        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey SenderMailboxId { get; private set; }
        public VocabularyKey SentOn { get; private set; }
        public VocabularyKey SeriesId { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey SortDate { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}