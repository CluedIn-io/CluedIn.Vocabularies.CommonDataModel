using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Scheduling
{
    public class RequirementCharacteristicVocabulary : SimpleVocabulary
    {
        public RequirementCharacteristicVocabulary()
        {
            VocabularyName = "Requirement Characteristic";
            KeyPrefix = "commonDataModel.requirementcharacteristic.scheduling";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequirementCharacteristic;

            AddGroup("RequirementCharacteristic Details for Scheduling", group =>
            {
			    RequirementCharacteristicId = group.Add(new VocabularyKey(nameof(RequirementCharacteristicId), "Requirement Characteristic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="Characteristic"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            ///Property <see cref="RatingValue"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            ///Property <see cref="ResourceRequirement"/> to Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey RequirementCharacteristicId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}