using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmrAppointmentVocabulary : SimpleVocabulary
    {
        public EmrAppointmentVocabulary()
        {
            VocabularyName = "EmrAppointment";
            KeyPrefix = "commonDataModel.emrappointment";
            KeySeparator = ".";
            Grouping = "/EmrAppointment";

            AddGroup("EmrAppointment Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ownerId = group.Add(new VocabularyKey(nameof(ownerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                owningBusinessUnit = group.Add(new VocabularyKey(nameof(owningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                owningUser = group.Add(new VocabularyKey(nameof(owningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                owningTeam = group.Add(new VocabularyKey(nameof(owningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                actualEnd = group.Add(new VocabularyKey(nameof(actualEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                activityId = group.Add(new VocabularyKey(nameof(activityId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                isBilled = group.Add(new VocabularyKey(nameof(isBilled), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activityTypeCode = group.Add(new VocabularyKey(nameof(activityTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                activityTypeCode_display = group.Add(new VocabularyKey(nameof(activityTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                scheduledEnd = group.Add(new VocabularyKey(nameof(scheduledEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                scheduledDurationMinutes = group.Add(new VocabularyKey(nameof(scheduledDurationMinutes), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                actualDurationMinutes = group.Add(new VocabularyKey(nameof(actualDurationMinutes), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualStart = group.Add(new VocabularyKey(nameof(actualStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                priorityCode = group.Add(new VocabularyKey(nameof(priorityCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                priorityCode_display = group.Add(new VocabularyKey(nameof(priorityCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                regardingObjectId = group.Add(new VocabularyKey(nameof(regardingObjectId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                subject = group.Add(new VocabularyKey(nameof(subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isWorkflowCreated = group.Add(new VocabularyKey(nameof(isWorkflowCreated), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                scheduledStart = group.Add(new VocabularyKey(nameof(scheduledStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                instanceTypeCode = group.Add(new VocabularyKey(nameof(instanceTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                instanceTypeCode_display = group.Add(new VocabularyKey(nameof(instanceTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                seriesId = group.Add(new VocabularyKey(nameof(seriesId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                isRegularActivity = group.Add(new VocabularyKey(nameof(isRegularActivity), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                transactionCurrencyId = group.Add(new VocabularyKey(nameof(transactionCurrencyId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                leftVoiceMail = group.Add(new VocabularyKey(nameof(leftVoiceMail), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                community = group.Add(new VocabularyKey(nameof(community), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                community_display = group.Add(new VocabularyKey(nameof(community_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                traversedPath = group.Add(new VocabularyKey(nameof(traversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isMapiPrivate = group.Add(new VocabularyKey(nameof(isMapiPrivate), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                exchangeWebLink = group.Add(new VocabularyKey(nameof(exchangeWebLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exchangeItemId = group.Add(new VocabularyKey(nameof(exchangeItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                deliveryPriorityCode = group.Add(new VocabularyKey(nameof(deliveryPriorityCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                deliveryPriorityCode_display = group.Add(new VocabularyKey(nameof(deliveryPriorityCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sentOn = group.Add(new VocabularyKey(nameof(sentOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                deliveryLastAttemptedOn = group.Add(new VocabularyKey(nameof(deliveryLastAttemptedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                senderMailboxId = group.Add(new VocabularyKey(nameof(senderMailboxId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                postponeActivityProcessingUntil = group.Add(new VocabularyKey(nameof(postponeActivityProcessingUntil), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                processId = group.Add(new VocabularyKey(nameof(processId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                stageId = group.Add(new VocabularyKey(nameof(stageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                activityAdditionalParams = group.Add(new VocabularyKey(nameof(activityAdditionalParams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SLAId = group.Add(new VocabularyKey(nameof(SLAId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                SLAInvokedId = group.Add(new VocabularyKey(nameof(SLAInvokedId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                onHoldTime = group.Add(new VocabularyKey(nameof(onHoldTime), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                lastOnHoldTime = group.Add(new VocabularyKey(nameof(lastOnHoldTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                sortDate = group.Add(new VocabularyKey(nameof(sortDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                serviceId = group.Add(new VocabularyKey(nameof(serviceId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                from = group.Add(new VocabularyKey(nameof(from), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                to = group.Add(new VocabularyKey(nameof(to), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CC = group.Add(new VocabularyKey(nameof(CC), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                BCC = group.Add(new VocabularyKey(nameof(BCC), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                requiredAttendees = group.Add(new VocabularyKey(nameof(requiredAttendees), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                optionalAttendees = group.Add(new VocabularyKey(nameof(optionalAttendees), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                organizer = group.Add(new VocabularyKey(nameof(organizer), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                resources = group.Add(new VocabularyKey(nameof(resources), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                customers = group.Add(new VocabularyKey(nameof(customers), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                partners = group.Add(new VocabularyKey(nameof(partners), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                actorDevice = group.Add(new VocabularyKey(nameof(actorDevice), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                actorLocation = group.Add(new VocabularyKey(nameof(actorLocation), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                actorPatient = group.Add(new VocabularyKey(nameof(actorPatient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                actorPractitioner = group.Add(new VocabularyKey(nameof(actorPractitioner), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                actorRelatedPerson = group.Add(new VocabularyKey(nameof(actorRelatedPerson), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                appointmentCreationDate = group.Add(new VocabularyKey(nameof(appointmentCreationDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                appointmentType = group.Add(new VocabularyKey(nameof(appointmentType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                comment = group.Add(new VocabularyKey(nameof(comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emrDescription = group.Add(new VocabularyKey(nameof(emrDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endTime = group.Add(new VocabularyKey(nameof(endTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                minutesDuration = group.Add(new VocabularyKey(nameof(minutesDuration), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                participantActorType = group.Add(new VocabularyKey(nameof(participantActorType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                participantActorType_display = group.Add(new VocabularyKey(nameof(participantActorType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                participantStatus = group.Add(new VocabularyKey(nameof(participantStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                participantStatus_display = group.Add(new VocabularyKey(nameof(participantStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                particpantType = group.Add(new VocabularyKey(nameof(particpantType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                patientInstruction = group.Add(new VocabularyKey(nameof(patientInstruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                priority = group.Add(new VocabularyKey(nameof(priority), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                required = group.Add(new VocabularyKey(nameof(required), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                required_display = group.Add(new VocabularyKey(nameof(required_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                serviceCategory = group.Add(new VocabularyKey(nameof(serviceCategory), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                startTime = group.Add(new VocabularyKey(nameof(startTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                supportingInformation = group.Add(new VocabularyKey(nameof(supportingInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey ownerId { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey owningBusinessUnit { get; private set; }
        public VocabularyKey owningUser { get; private set; }
        public VocabularyKey owningTeam { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey versionNumber { get; private set; }
        public VocabularyKey actualEnd { get; private set; }
        public VocabularyKey activityId { get; private set; }
        public VocabularyKey isBilled { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey activityTypeCode { get; private set; }
        public VocabularyKey activityTypeCode_display { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey stateCode_display { get; private set; }
        public VocabularyKey scheduledEnd { get; private set; }
        public VocabularyKey scheduledDurationMinutes { get; private set; }
        public VocabularyKey actualDurationMinutes { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey statusCode_display { get; private set; }
        public VocabularyKey actualStart { get; private set; }
        public VocabularyKey priorityCode { get; private set; }
        public VocabularyKey priorityCode_display { get; private set; }
        public VocabularyKey regardingObjectId { get; private set; }
        public VocabularyKey subject { get; private set; }
        public VocabularyKey isWorkflowCreated { get; private set; }
        public VocabularyKey scheduledStart { get; private set; }
        public VocabularyKey instanceTypeCode { get; private set; }
        public VocabularyKey instanceTypeCode_display { get; private set; }
        public VocabularyKey seriesId { get; private set; }
        public VocabularyKey isRegularActivity { get; private set; }
        public VocabularyKey transactionCurrencyId { get; private set; }
        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey leftVoiceMail { get; private set; }
        public VocabularyKey community { get; private set; }
        public VocabularyKey community_display { get; private set; }
        public VocabularyKey traversedPath { get; private set; }
        public VocabularyKey isMapiPrivate { get; private set; }
        public VocabularyKey exchangeWebLink { get; private set; }
        public VocabularyKey exchangeItemId { get; private set; }
        public VocabularyKey deliveryPriorityCode { get; private set; }
        public VocabularyKey deliveryPriorityCode_display { get; private set; }
        public VocabularyKey sentOn { get; private set; }
        public VocabularyKey deliveryLastAttemptedOn { get; private set; }
        public VocabularyKey senderMailboxId { get; private set; }
        public VocabularyKey postponeActivityProcessingUntil { get; private set; }
        public VocabularyKey processId { get; private set; }
        public VocabularyKey stageId { get; private set; }
        public VocabularyKey activityAdditionalParams { get; private set; }
        public VocabularyKey SLAId { get; private set; }
        public VocabularyKey SLAInvokedId { get; private set; }
        public VocabularyKey onHoldTime { get; private set; }
        public VocabularyKey lastOnHoldTime { get; private set; }
        public VocabularyKey sortDate { get; private set; }
        public VocabularyKey serviceId { get; private set; }
        public VocabularyKey from { get; private set; }
        public VocabularyKey to { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey requiredAttendees { get; private set; }
        public VocabularyKey optionalAttendees { get; private set; }
        public VocabularyKey organizer { get; private set; }
        public VocabularyKey resources { get; private set; }
        public VocabularyKey customers { get; private set; }
        public VocabularyKey partners { get; private set; }
        public VocabularyKey actorDevice { get; private set; }
        public VocabularyKey actorLocation { get; private set; }
        public VocabularyKey actorPatient { get; private set; }
        public VocabularyKey actorPractitioner { get; private set; }
        public VocabularyKey actorRelatedPerson { get; private set; }
        public VocabularyKey appointmentCreationDate { get; private set; }
        public VocabularyKey appointmentType { get; private set; }
        public VocabularyKey comment { get; private set; }
        public VocabularyKey emrDescription { get; private set; }
        public VocabularyKey endTime { get; private set; }
        public VocabularyKey minutesDuration { get; private set; }
        public VocabularyKey participantActorType { get; private set; }
        public VocabularyKey participantActorType_display { get; private set; }
        public VocabularyKey participantStatus { get; private set; }
        public VocabularyKey participantStatus_display { get; private set; }
        public VocabularyKey particpantType { get; private set; }
        public VocabularyKey patientInstruction { get; private set; }
        public VocabularyKey priority { get; private set; }
        public VocabularyKey required { get; private set; }
        public VocabularyKey required_display { get; private set; }
        public VocabularyKey serviceCategory { get; private set; }
        public VocabularyKey startTime { get; private set; }
        public VocabularyKey status { get; private set; }
        public VocabularyKey supportingInformation { get; private set; }


    }
}