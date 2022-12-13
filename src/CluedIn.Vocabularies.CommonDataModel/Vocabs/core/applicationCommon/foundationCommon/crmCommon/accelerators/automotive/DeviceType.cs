using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceTypeVocabulary : SimpleVocabulary
    {
        public DeviceTypeVocabulary()
        {
            VocabularyName = "Device Type";
            KeyPrefix = "commonDataModel.devicetype";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceType;

            AddGroup("DeviceType Details for Automotive", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceTypeId = group.Add(new VocabularyKey(nameof(DeviceTypeId), "Device Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
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
            ///Property <see cref="DeviceTypeId"/> from Vocab 'Device.cdm.json/Device' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'DeviceStyle.cdm.json/DeviceStyle' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceTypeId"/> from Vocab 'LeadDevice.cdm.json/LeadDevice' with Property 'DeviceTypeId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceTypeId { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}