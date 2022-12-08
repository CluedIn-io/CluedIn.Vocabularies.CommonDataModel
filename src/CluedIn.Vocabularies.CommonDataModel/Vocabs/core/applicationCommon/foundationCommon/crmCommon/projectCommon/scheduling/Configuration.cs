using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Scheduling
{
    public class ConfigurationVocabulary : SimpleVocabulary
    {
        public ConfigurationVocabulary()
        {
            VocabularyName = "Configuration";
            KeyPrefix = "commonDataModel.configuration.scheduling";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Configuration;

            AddGroup("Configuration Details for Scheduling", group =>
            {
			    ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), "Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ConfigurationId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'CloneEntityQuery'
            ///Property <see cref="ConfigurationId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'RetrieveConstraintsQuery'
            ///Property <see cref="ConfigurationId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'RetrieveResourcesQuery'
            ///Property <see cref="ConfigurationId"/> from Vocab 'ScheduleBoardSetting.cdm.json/ScheduleBoardSetting' with Property 'FilterLayout'
            ///Property <see cref="ConfigurationId"/> from Vocab 'ScheduleBoardSetting.cdm.json/ScheduleBoardSetting' with Property 'ResourceCellTemplate'
            ///Property <see cref="ConfigurationId"/> from Vocab 'ScheduleBoardSetting.cdm.json/ScheduleBoardSetting' with Property 'RetrieveResourcesQuery'
            #endregion
        }

        public VocabularyKey ConfigurationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}