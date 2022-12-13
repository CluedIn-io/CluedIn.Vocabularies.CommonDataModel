using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceClassVocabulary : SimpleVocabulary
    {
        public DeviceClassVocabulary()
        {
            VocabularyName = "Device Class";
            KeyPrefix = "commonDataModel.deviceclass";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceClass;

            AddGroup("DeviceClass Details for Automotive", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceClassId = group.Add(new VocabularyKey(nameof(DeviceClassId), "Device Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="DeviceBrandId"/> to Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'DeviceBrandId'
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
            ///Property <see cref="DeviceTypeId"/> to Vocab 'DeviceType.cdm.json/DeviceType' with Property 'DeviceTypeId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="DeviceClassId"/> from Vocab 'Device.cdm.json/Device' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'DeviceGeneration.cdm.json/DeviceGeneration' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'LeadDevice.cdm.json/LeadDevice' with Property 'DeviceClassId'
            ///Property <see cref="DeviceClassId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'DeviceClassId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceClassId { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}