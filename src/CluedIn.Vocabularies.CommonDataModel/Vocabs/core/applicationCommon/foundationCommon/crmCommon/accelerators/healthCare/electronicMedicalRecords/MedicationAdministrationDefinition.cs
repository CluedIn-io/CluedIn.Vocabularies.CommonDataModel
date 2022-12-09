using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MedicationAdministrationDefinitionVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationDefinitionVocabulary()
        {
            VocabularyName = "Medication Administration Definition";
            KeyPrefix = "commonDataModel.medicationadministrationdefinition";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MedicationAdministrationDefinition;

            AddGroup("MedicationAdministrationDefinition Details for ElectronicMedicalRecords", group =>
            {
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationAdministrationDefinitionId = group.Add(new VocabularyKey(nameof(MedicationAdministrationDefinitionId), "Medication Administration Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="DefinitionTypeActivityDefintionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
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
            ///Property <see cref="DefintionTypePlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey MedicationAdministrationDefinitionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}