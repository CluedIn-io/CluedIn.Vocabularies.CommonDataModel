using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmrAppointmentVocabulary : SimpleVocabulary
    {
        public EmrAppointmentVocabulary()
        {
            VocabularyName = "Emr Appointment";
            KeyPrefix = "commonDataModel.emrappointment";
            KeySeparator = ".";
            Grouping = "/EmrAppointment";

            AddGroup("EmrAppointment Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                IsBilled = group.Add(new VocabularyKey(nameof(IsBilled), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityTypeCode = group.Add(new VocabularyKey(nameof(ActivityTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ActivityTypeCode_display = group.Add(new VocabularyKey(nameof(ActivityTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ActualDurationMinutes = group.Add(new VocabularyKey(nameof(ActualDurationMinutes), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PriorityCode_display = group.Add(new VocabularyKey(nameof(PriorityCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegardingObjectId = group.Add(new VocabularyKey(nameof(RegardingObjectId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkflowCreated = group.Add(new VocabularyKey(nameof(IsWorkflowCreated), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                InstanceTypeCode = group.Add(new VocabularyKey(nameof(InstanceTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                InstanceTypeCode_display = group.Add(new VocabularyKey(nameof(InstanceTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeriesId = group.Add(new VocabularyKey(nameof(SeriesId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                IsRegularActivity = group.Add(new VocabularyKey(nameof(IsRegularActivity), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                LeftVoiceMail = group.Add(new VocabularyKey(nameof(LeftVoiceMail), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Community = group.Add(new VocabularyKey(nameof(Community), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Community_display = group.Add(new VocabularyKey(nameof(Community_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMapiPrivate = group.Add(new VocabularyKey(nameof(IsMapiPrivate), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExchangeWebLink = group.Add(new VocabularyKey(nameof(ExchangeWebLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeItemId = group.Add(new VocabularyKey(nameof(ExchangeItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPriorityCode = group.Add(new VocabularyKey(nameof(DeliveryPriorityCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeliveryPriorityCode_display = group.Add(new VocabularyKey(nameof(DeliveryPriorityCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SentOn = group.Add(new VocabularyKey(nameof(SentOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                DeliveryLastAttemptedOn = group.Add(new VocabularyKey(nameof(DeliveryLastAttemptedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SenderMailboxId = group.Add(new VocabularyKey(nameof(SenderMailboxId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PostponeActivityProcessingUntil = group.Add(new VocabularyKey(nameof(PostponeActivityProcessingUntil), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActivityAdditionalParams = group.Add(new VocabularyKey(nameof(ActivityAdditionalParams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SLAId = group.Add(new VocabularyKey(nameof(SLAId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                SLAInvokedId = group.Add(new VocabularyKey(nameof(SLAInvokedId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SortDate = group.Add(new VocabularyKey(nameof(SortDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                From = group.Add(new VocabularyKey(nameof(From), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                To = group.Add(new VocabularyKey(nameof(To), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CC = group.Add(new VocabularyKey(nameof(CC), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                BCC = group.Add(new VocabularyKey(nameof(BCC), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                RequiredAttendees = group.Add(new VocabularyKey(nameof(RequiredAttendees), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OptionalAttendees = group.Add(new VocabularyKey(nameof(OptionalAttendees), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Organizer = group.Add(new VocabularyKey(nameof(Organizer), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Resources = group.Add(new VocabularyKey(nameof(Resources), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Customers = group.Add(new VocabularyKey(nameof(Customers), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Partners = group.Add(new VocabularyKey(nameof(Partners), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActorDevice = group.Add(new VocabularyKey(nameof(ActorDevice), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActorLocation = group.Add(new VocabularyKey(nameof(ActorLocation), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActorPatient = group.Add(new VocabularyKey(nameof(ActorPatient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActorPractitioner = group.Add(new VocabularyKey(nameof(ActorPractitioner), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ActorRelatedPerson = group.Add(new VocabularyKey(nameof(ActorRelatedPerson), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                AppointmentCreationDate = group.Add(new VocabularyKey(nameof(AppointmentCreationDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AppointmentType = group.Add(new VocabularyKey(nameof(AppointmentType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmrDescription = group.Add(new VocabularyKey(nameof(EmrDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                MinutesDuration = group.Add(new VocabularyKey(nameof(MinutesDuration), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ParticipantActorType = group.Add(new VocabularyKey(nameof(ParticipantActorType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ParticipantActorType_display = group.Add(new VocabularyKey(nameof(ParticipantActorType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantStatus = group.Add(new VocabularyKey(nameof(ParticipantStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ParticipantStatus_display = group.Add(new VocabularyKey(nameof(ParticipantStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticpantType = group.Add(new VocabularyKey(nameof(ParticpantType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PatientInstruction = group.Add(new VocabularyKey(nameof(PatientInstruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Required = group.Add(new VocabularyKey(nameof(Required), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Required_display = group.Add(new VocabularyKey(nameof(Required_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCategory = group.Add(new VocabularyKey(nameof(ServiceCategory), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                SupportingInformation = group.Add(new VocabularyKey(nameof(SupportingInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey IsBilled { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ActivityTypeCode { get; private set; }
        public VocabularyKey ActivityTypeCode_display { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey ActualDurationMinutes { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey PriorityCode_display { get; private set; }
        public VocabularyKey RegardingObjectId { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey IsWorkflowCreated { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey InstanceTypeCode { get; private set; }
        public VocabularyKey InstanceTypeCode_display { get; private set; }
        public VocabularyKey SeriesId { get; private set; }
        public VocabularyKey IsRegularActivity { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey LeftVoiceMail { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey Community_display { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey IsMapiPrivate { get; private set; }
        public VocabularyKey ExchangeWebLink { get; private set; }
        public VocabularyKey ExchangeItemId { get; private set; }
        public VocabularyKey DeliveryPriorityCode { get; private set; }
        public VocabularyKey DeliveryPriorityCode_display { get; private set; }
        public VocabularyKey SentOn { get; private set; }
        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }
        public VocabularyKey SenderMailboxId { get; private set; }
        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ActivityAdditionalParams { get; private set; }
        public VocabularyKey SLAId { get; private set; }
        public VocabularyKey SLAInvokedId { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey SortDate { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey RequiredAttendees { get; private set; }
        public VocabularyKey OptionalAttendees { get; private set; }
        public VocabularyKey Organizer { get; private set; }
        public VocabularyKey Resources { get; private set; }
        public VocabularyKey Customers { get; private set; }
        public VocabularyKey Partners { get; private set; }
        public VocabularyKey ActorDevice { get; private set; }
        public VocabularyKey ActorLocation { get; private set; }
        public VocabularyKey ActorPatient { get; private set; }
        public VocabularyKey ActorPractitioner { get; private set; }
        public VocabularyKey ActorRelatedPerson { get; private set; }
        public VocabularyKey AppointmentCreationDate { get; private set; }
        public VocabularyKey AppointmentType { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey EmrDescription { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey MinutesDuration { get; private set; }
        public VocabularyKey ParticipantActorType { get; private set; }
        public VocabularyKey ParticipantActorType_display { get; private set; }
        public VocabularyKey ParticipantStatus { get; private set; }
        public VocabularyKey ParticipantStatus_display { get; private set; }
        public VocabularyKey ParticpantType { get; private set; }
        public VocabularyKey PatientInstruction { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey Required { get; private set; }
        public VocabularyKey Required_display { get; private set; }
        public VocabularyKey ServiceCategory { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SupportingInformation { get; private set; }
    }
}