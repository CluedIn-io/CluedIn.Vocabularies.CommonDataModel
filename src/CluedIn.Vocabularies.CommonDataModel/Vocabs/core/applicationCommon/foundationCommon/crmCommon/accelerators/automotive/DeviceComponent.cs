using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class DeviceComponentVocabulary : SimpleVocabulary
    {
        public DeviceComponentVocabulary()
        {
            VocabularyName = "Device Component";
            KeyPrefix = "commonDataModel.devicecomponent.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceComponent;

            AddGroup("DeviceComponent Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Behavior = group.Add(new VocabularyKey(nameof(Behavior), "Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceComponentId = group.Add(new VocabularyKey(nameof(DeviceComponentId), "Device Component", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemName = group.Add(new VocabularyKey(nameof(ItemName), "Item Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ConfigurationOptionId"/> to Vocab 'ConfigurationOption.cdm.json/ConfigurationOption' with Property 'ConfigurationOptionId'
            ///Property <see cref="ComponentDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
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
            ///Property <see cref="DeviceMeterId"/> to Vocab 'DeviceMeter.cdm.json/DeviceMeter' with Property 'DeviceMeterId'
            ///Property <see cref="DeviceSensorId"/> to Vocab 'DeviceSensor.cdm.json/DeviceSensor' with Property 'DeviceSensorId'
            ///Property <see cref="ParentComponentId"/> to Vocab 'DeviceComponent.cdm.json/DeviceComponent' with Property 'DeviceComponentId'
            ///Property <see cref="SpecificationAccessoryId"/> to Vocab 'SpecificationAccessory.cdm.json/SpecificationAccessory' with Property 'SpecificationAccessoryId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DeviceComponentId"/> from Vocab 'DeviceComponent.cdm.json/DeviceComponent' with Property 'ParentComponentId'
            #endregion
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Behavior { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceComponentId { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}