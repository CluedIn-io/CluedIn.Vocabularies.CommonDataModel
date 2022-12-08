using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class DeviceVariantVocabulary : SimpleVocabulary
    {
        public DeviceVariantVocabulary()
        {
            VocabularyName = "Device Variant";
            KeyPrefix = "commonDataModel.devicevariant.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceVariant;

            AddGroup("DeviceVariant Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceVariantId = group.Add(new VocabularyKey(nameof(DeviceVariantId), "Device Variant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="DeviceBrandId"/> to Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'DeviceBrandId'
            ///Property <see cref="DeviceClassId"/> to Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'DeviceClassId'
            ///Property <see cref="DeviceGenerationId"/> to Vocab 'DeviceGeneration.cdm.json/DeviceGeneration' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceModelId"/> to Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceModelId'
            ///Property <see cref="DeviceModelCodeId"/> to Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceModelCodeId'
            ///Property <see cref="DeviceStyleId"/> to Vocab 'DeviceStyle.cdm.json/DeviceStyle' with Property 'DeviceStyleId'
            ///Property <see cref="DeviceTypeId"/> to Vocab 'DeviceType.cdm.json/DeviceType' with Property 'DeviceTypeId'
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
            ///Property <see cref="SpecificationId"/> to Vocab 'Specification.cdm.json/Specification' with Property 'SpecificationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DeviceVariantId"/> from Vocab 'Device.cdm.json/Device' with Property 'DeviceVariantId'
            ///Property <see cref="DeviceVariantId"/> from Vocab 'LeadDevice.cdm.json/LeadDevice' with Property 'DeviceVariantId'
            ///Property <see cref="DeviceVariantId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'DeviceVariantId'
            #endregion
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceVariantId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}