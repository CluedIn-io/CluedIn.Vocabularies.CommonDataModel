using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LocationVocabulary : SimpleVocabulary
    {
        public LocationVocabulary()
        {
            VocabularyName = "Location";
            KeyPrefix = "commonDataModel.location";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Location;

            AddGroup("Location Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), "Address City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), "Address Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressDistinct = group.Add(new VocabularyKey(nameof(AddressDistinct), "Address Distinct", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressPeriodEnd = group.Add(new VocabularyKey(nameof(AddressPeriodEnd), "Address Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressPeriodStart = group.Add(new VocabularyKey(nameof(AddressPeriodStart), "Address Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressPostalCode = group.Add(new VocabularyKey(nameof(AddressPostalCode), "Address Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressState = group.Add(new VocabularyKey(nameof(AddressState), "Address State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressText = group.Add(new VocabularyKey(nameof(AddressText), "Address Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressType = group.Add(new VocabularyKey(nameof(AddressType), "Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressUse = group.Add(new VocabularyKey(nameof(AddressUse), "Address Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationAlias1 = group.Add(new VocabularyKey(nameof(LocationAlias1), "Alias 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationAlias2 = group.Add(new VocabularyKey(nameof(LocationAlias2), "Alias 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationAlias3 = group.Add(new VocabularyKey(nameof(LocationAlias3), "Alias 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationId = group.Add(new VocabularyKey(nameof(LocationId), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationNumber = group.Add(new VocabularyKey(nameof(LocationNumber), "Location Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationPositionAltitude = group.Add(new VocabularyKey(nameof(LocationPositionAltitude), "Position Altitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LocationPositionLatitude = group.Add(new VocabularyKey(nameof(LocationPositionLatitude), "Position Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LocationPositionLongitude = group.Add(new VocabularyKey(nameof(LocationPositionLongitude), "Position Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Mode = group.Add(new VocabularyKey(nameof(Mode), "Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OperationalStatus = group.Add(new VocabularyKey(nameof(OperationalStatus), "Operational Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Location Details for NonProfitIati", group =>
            {
			    ActivityLocationDescription = group.Add(new VocabularyKey(nameof(ActivityLocationDescription), "Activity Location Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Level = group.Add(new VocabularyKey(nameof(Level), "Level", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Pos = group.Add(new VocabularyKey(nameof(Pos), "Position", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ManagingOrganizationId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PhysicalTypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="TypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
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
            ///Property <see cref="EncounterLocationIdentifierId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="LocationEndpointId"/> to Vocab 'Endpoint.cdm.json/Endpoint' with Property 'EndpointId'
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PartOfId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
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
            ///Property <see cref="LocationId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActorLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'AppointmentEMRParticipant.cdm.json/AppointmentEMRParticipant' with Property 'ActorLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'ActivityLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Device.cdm.json/Device' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'SubjectTypeLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Encounter.cdm.json/Encounter' with Property 'HospitalizationDestinationId'
            ///Property <see cref="LocationId"/> from Vocab 'Encounter.cdm.json/Encounter' with Property 'HospitalizationOriginId'
            ///Property <see cref="LocationId"/> from Vocab 'EncounterLocation.cdm.json/EncounterLocation' with Property 'EncounterLocationIdentifierId'
            ///Property <see cref="LocationId"/> from Vocab 'HealthcareServiceCoverageArea.cdm.json/HealthcareServiceCoverageArea' with Property 'CoverageAreaId'
            ///Property <see cref="LocationId"/> from Vocab 'HealthcareServiceLocation.cdm.json/HealthcareServiceLocation' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Location.cdm.json/Location' with Property 'PartOfId'
            ///Property <see cref="LocationId"/> from Vocab 'LocationEndPoint.cdm.json/LocationEndPoint' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'LocationTelecom.cdm.json/LocationTelecom' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Observation.cdm.json/Observation' with Property 'SubjectTypeLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'PractitionerRoleLocation.cdm.json/PractitionerRoleLocation' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Procedure.cdm.json/Procedure' with Property 'LocationId'
            ///Property <see cref="LocationId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'SubjectLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ActorLocationId'
            ///Property <see cref="LocationId"/> from Vocab 'ScheduleActor.cdm.json/ScheduleActor' with Property 'ActorLocationId'
            #endregion
        }

        public VocabularyKey ActivityLocationDescription { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressDistinct { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey AddressPeriodEnd { get; private set; }
        public VocabularyKey AddressPeriodStart { get; private set; }
        public VocabularyKey AddressPostalCode { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressText { get; private set; }
        public VocabularyKey AddressType { get; private set; }
        public VocabularyKey AddressUse { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Level { get; private set; }
        public VocabularyKey LocationAlias1 { get; private set; }
        public VocabularyKey LocationAlias2 { get; private set; }
        public VocabularyKey LocationAlias3 { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey LocationNumber { get; private set; }
        public VocabularyKey LocationPositionAltitude { get; private set; }
        public VocabularyKey LocationPositionLatitude { get; private set; }
        public VocabularyKey LocationPositionLongitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey Mode { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OperationalStatus { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey Pos { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}