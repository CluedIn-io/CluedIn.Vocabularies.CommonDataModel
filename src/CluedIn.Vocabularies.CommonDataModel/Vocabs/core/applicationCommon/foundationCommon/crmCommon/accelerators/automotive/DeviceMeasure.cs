using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceMeasureVocabulary : SimpleVocabulary
    {
        public DeviceMeasureVocabulary()
        {
            VocabularyName = "Device Measure";
            KeyPrefix = "commonDataModel.devicemeasure";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceMeasure;

            AddGroup("DeviceMeasure Details for Automotive", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceMeasureId = group.Add(new VocabularyKey(nameof(DeviceMeasureId), "Device Measure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayNumberOfDecimals = group.Add(new VocabularyKey(nameof(DisplayNumberOfDecimals), "Display Number of Decimals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
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
            ///Property <see cref="UnitId"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UnitId'
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
            ///Property <see cref="DeviceMeasureId"/> from Vocab 'DeviceMeasurement.cdm.json/DeviceMeasurement' with Property 'DeviceMeasureId'
            ///Property <see cref="DeviceMeasureId"/> from Vocab 'DeviceMeter.cdm.json/DeviceMeter' with Property 'DeviceMeasureId'
            ///Property <see cref="DeviceMeasureId"/> from Vocab 'DeviceWarrantyLimit.cdm.json/DeviceWarrantyLimit' with Property 'DeviceMeasureId'
            ///Property <see cref="DeviceMeasureId"/> from Vocab 'WarrantyLimit.cdm.json/WarrantyLimit' with Property 'DeviceMeasureId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceMeasureId { get; private set; }
        public VocabularyKey DisplayNumberOfDecimals { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}