using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceMeasurementVocabulary : SimpleVocabulary
    {
        public DeviceMeasurementVocabulary()
        {
            VocabularyName = "Device Measurement";
            KeyPrefix = "commonDataModel.devicemeasurement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceMeasurement;

            AddGroup("DeviceMeasurement Details for Automotive", group =>
            {
			    DeviceMeasurementId = group.Add(new VocabularyKey(nameof(DeviceMeasurementId), "Device Measurement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasuredOn = group.Add(new VocabularyKey(nameof(MeasuredOn), "Measured On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasuredValue = group.Add(new VocabularyKey(nameof(MeasuredValue), "Measured Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="DeviceMeterId"/> to Vocab 'DeviceMeter.cdm.json/DeviceMeter' with Property 'DeviceMeterId'
            ///Property <see cref="MeasuredById"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ServiceOrderId"/> to Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'ServiceOrderId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey DeviceMeasurementId { get; private set; }
        public VocabularyKey MeasuredOn { get; private set; }
        public VocabularyKey MeasuredValue { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}