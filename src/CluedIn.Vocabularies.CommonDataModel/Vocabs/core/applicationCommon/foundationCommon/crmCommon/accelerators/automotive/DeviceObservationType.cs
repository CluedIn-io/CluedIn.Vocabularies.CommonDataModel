using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class DeviceObservationTypeVocabulary : SimpleVocabulary
    {
        public DeviceObservationTypeVocabulary()
        {
            VocabularyName = "Device Observation Type";
            KeyPrefix = "commonDataModel.deviceobservationtype.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceObservationType;

            AddGroup("DeviceObservationType Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceObservationTypeId = group.Add(new VocabularyKey(nameof(DeviceObservationTypeId), "Device Observation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Severity = group.Add(new VocabularyKey(nameof(Severity), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="DeviceObservationTypeId"/> from Vocab 'DeviceObservation.cdm.json/DeviceObservation' with Property 'DeviceObservationTypeId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceObservationTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Severity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}