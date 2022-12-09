using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AppointmentEMRParticipantVocabulary : SimpleVocabulary
    {
        public AppointmentEMRParticipantVocabulary()
        {
            VocabularyName = "Appointment EMR Participant";
            KeyPrefix = "commonDataModel.appointmentemrparticipant";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AppointmentEMRParticipant;

            AddGroup("AppointmentEMRParticipant Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRParticipantId = group.Add(new VocabularyKey(nameof(AppointmentEMRParticipantId), "Appointment (EMR) Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipantActorType = group.Add(new VocabularyKey(nameof(ParticipantActorType), "Participant Actor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipationStatus = group.Add(new VocabularyKey(nameof(ParticipationStatus), "Participation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Required = group.Add(new VocabularyKey(nameof(Required), "Required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ActorPatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActorPhysicianId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActorRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AppointmentEMRId"/> to Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActivityId'
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
            ///Property <see cref="ActorDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="ActorHealthCareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="ActorLocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="ParticpantTypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AppointmentEMRParticipantId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParticipantActorType { get; private set; }
        public VocabularyKey ParticipationStatus { get; private set; }
        public VocabularyKey Required { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}