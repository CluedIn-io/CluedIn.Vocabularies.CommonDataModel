using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TestDriveVocabulary : SimpleVocabulary
    {
        public TestDriveVocabulary()
        {
            VocabularyName = "Test Drive";
            KeyPrefix = "commonDataModel.testdrive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TestDrive;

            AddGroup("TestDrive Details for Automotive", group =>
            {
                ActualDuration = group.Add(new VocabularyKey(nameof(ActualDuration), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationExpiresOn = group.Add(new VocabularyKey(nameof(IdentificationExpiresOn), "Identification Expires On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationNumber = group.Add(new VocabularyKey(nameof(IdentificationNumber), "Identification Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationType = group.Add(new VocabularyKey(nameof(IdentificationType), "Identification Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledDuration = group.Add(new VocabularyKey(nameof(ScheduledDuration), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Scheduled End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Scheduled Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestDriveId = group.Add(new VocabularyKey(nameof(TestDriveId), "Test Drive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey(nameof(Year), "Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="BusinessId"/> to Vocab 'Business.cdm.json/Business' with Property 'BusinessId'
            ///Property <see cref="BusinessFacilityId"/> to Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'BusinessFacilityId'
            ///Property <see cref="BusinessOperationId"/> to Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'BusinessOperationId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceBrandId"/> to Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'DeviceBrandId'
            ///Property <see cref="DeviceClassId"/> to Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'DeviceClassId'
            ///Property <see cref="DeviceGenerationId"/> to Vocab 'DeviceGeneration.cdm.json/DeviceGeneration' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceModelId"/> to Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceModelId'
            ///Property <see cref="DeviceModelCodeId"/> to Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceModelCodeId'
            ///Property <see cref="DeviceStyleId"/> to Vocab 'DeviceStyle.cdm.json/DeviceStyle' with Property 'DeviceStyleId'
            ///Property <see cref="DeviceVariantId"/> to Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'DeviceVariantId'
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
            ///Property <see cref="AppointmentId"/> to Vocab '/core/applicationCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="ContactId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OpportunityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="TestDriveId"/> from Vocab 'DealerPlateDeviceAssignment.cdm.json/DealerPlateDeviceAssignment' with Property 'TestDriveId'
            #endregion
        }

        public VocabularyKey ActualDuration { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey IdentificationExpiresOn { get; private set; }
        public VocabularyKey IdentificationNumber { get; private set; }
        public VocabularyKey IdentificationType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduledDuration { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TestDriveId { get; private set; }
        public VocabularyKey Year { get; private set; }
    }
}