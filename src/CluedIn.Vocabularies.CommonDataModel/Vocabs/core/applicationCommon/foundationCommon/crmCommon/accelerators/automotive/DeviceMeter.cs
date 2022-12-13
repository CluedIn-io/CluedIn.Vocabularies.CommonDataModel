using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceMeterVocabulary : SimpleVocabulary
    {
        public DeviceMeterVocabulary()
        {
            VocabularyName = "Device Meter";
            KeyPrefix = "commonDataModel.devicemeter";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceMeter;

            AddGroup("DeviceMeter Details for Automotive", group =>
            {
                DeviceMeterId = group.Add(new VocabularyKey(nameof(DeviceMeterId), "Device Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedMaximum = group.Add(new VocabularyKey(nameof(ExpectedMaximum), "Expected Maximum", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ExpectedMinimum = group.Add(new VocabularyKey(nameof(ExpectedMinimum), "Expected Minimum", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), "Is Primary", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Offset = group.Add(new VocabularyKey(nameof(Offset), "Offset", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceMeasureId"/> to Vocab 'DeviceMeasure.cdm.json/DeviceMeasure' with Property 'DeviceMeasureId'
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
            ///Property <see cref="DeviceMeterId"/> from Vocab 'DeviceComponent.cdm.json/DeviceComponent' with Property 'DeviceMeterId'
            ///Property <see cref="DeviceMeterId"/> from Vocab 'DeviceMeasurement.cdm.json/DeviceMeasurement' with Property 'DeviceMeterId'
            ///Property <see cref="DeviceMeterId"/> from Vocab 'DeviceSensor.cdm.json/DeviceSensor' with Property 'DeviceMeterId'
            #endregion
        }

        public VocabularyKey DeviceMeterId { get; private set; }
        public VocabularyKey ExpectedMaximum { get; private set; }
        public VocabularyKey ExpectedMinimum { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Offset { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}