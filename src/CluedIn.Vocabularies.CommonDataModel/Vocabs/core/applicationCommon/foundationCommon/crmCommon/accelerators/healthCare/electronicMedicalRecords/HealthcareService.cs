using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class HealthcareServiceVocabulary : SimpleVocabulary
    {
        public HealthcareServiceVocabulary()
        {
            VocabularyName = "Healthcare Service";
            KeyPrefix = "commonDataModel.healthcareservice";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.HealthcareService;

            AddGroup("HealthcareService Details for ElectronicMedicalRecords", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentRequired = group.Add(new VocabularyKey(nameof(AppointmentRequired), "Appointment Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AvailabilityExceptions = group.Add(new VocabularyKey(nameof(AvailabilityExceptions), "Availability Exceptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EligibilityNote = group.Add(new VocabularyKey(nameof(EligibilityNote), "Eligibility note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraDetails = group.Add(new VocabularyKey(nameof(ExtraDetails), "Extra Details", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HealthcareService = group.Add(new VocabularyKey(nameof(HealthcareService), "Healthcare Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HealthcareServiceId = group.Add(new VocabularyKey(nameof(HealthcareServiceId), "Healthcare Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotAvailableDescription = group.Add(new VocabularyKey(nameof(NotAvailableDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotAvailableDuringEndDateTime = group.Add(new VocabularyKey(nameof(NotAvailableDuringEndDateTime), "End Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotAvailableDuringStartDateTime = group.Add(new VocabularyKey(nameof(NotAvailableDuringStartDateTime), "Start Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="ProvidedById"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EligibilityId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="TypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CharacteristicsId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ServiceProvisionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReferralMethodId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SpecialtyId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EndPointId"/> to Vocab 'Endpoint.cdm.json/Endpoint' with Property 'EndpointId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CoverageAreaId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="PractitionerRoleId"/> to Vocab 'PractitionerRole.cdm.json/PractitionerRole' with Property 'PractitionerRoleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'AppointmentEMRParticipant.cdm.json/AppointmentEMRParticipant' with Property 'ActorHealthCareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'PerformerTypeHealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceAvailableTime.cdm.json/HealthcareServiceAvailableTime' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceCategory.cdm.json/HealthcareServiceCategory' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceCharacteristic.cdm.json/HealthcareServiceCharacteristic' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceCoverageArea.cdm.json/HealthcareServiceCoverageArea' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceEndpoint.cdm.json/HealthcareServiceEndpoint' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceLocation.cdm.json/HealthcareServiceLocation' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceProgramName.cdm.json/HealthcareServiceProgramName' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceProvision.cdm.json/HealthcareServiceProvision' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceReferralMethod.cdm.json/HealthcareServiceReferralMethod' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceSpecialty.cdm.json/HealthcareServiceSpecialty' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'HealthcareServiceTelecom.cdm.json/HealthcareServiceTelecom' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'PractitionerRoleHealthcareService.cdm.json/PractitionerRoleHealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'ProcedureDefinition.cdm.json/ProcedureDefinition' with Property 'ServiceDefinitionId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'PerformerHealthCareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'ReferralRequestRecipient.cdm.json/ReferralRequestRecipient' with Property 'HealthcareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ActorHealthCareServiceId'
            ///Property <see cref="HealthcareServiceId"/> from Vocab 'ScheduleActor.cdm.json/ScheduleActor' with Property 'ActorHealthCareServiceId'
            #endregion
        }

        public VocabularyKey AppointmentRequired { get; private set; }
        public VocabularyKey AvailabilityExceptions { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey EligibilityNote { get; private set; }
        public VocabularyKey ExtraDetails { get; private set; }
        public VocabularyKey HealthcareService { get; private set; }
        public VocabularyKey HealthcareServiceId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotAvailableDescription { get; private set; }
        public VocabularyKey NotAvailableDuringEndDateTime { get; private set; }
        public VocabularyKey NotAvailableDuringStartDateTime { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}