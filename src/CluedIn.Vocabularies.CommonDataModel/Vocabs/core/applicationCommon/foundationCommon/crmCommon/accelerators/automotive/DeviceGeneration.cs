using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceGenerationVocabulary : SimpleVocabulary
    {
        public DeviceGenerationVocabulary()
        {
            VocabularyName = "Device Generation";
            KeyPrefix = "commonDataModel.devicegeneration";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceGeneration;

            AddGroup("DeviceGeneration Details for Automotive", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceGenerationId = group.Add(new VocabularyKey(nameof(DeviceGenerationId), "Device Generation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromYear = group.Add(new VocabularyKey(nameof(FromYear), "From Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToYear = group.Add(new VocabularyKey(nameof(ToYear), "To Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="DeviceBrandId"/> to Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'DeviceBrandId'
            ///Property <see cref="DeviceClassId"/> to Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'DeviceClassId'
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
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'Device.cdm.json/Device' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'LeadDevice.cdm.json/LeadDevice' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceGenerationId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'DeviceGenerationId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceGenerationId { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey FromYear { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ToYear { get; private set; }
    }
}