using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ProcedurePartOfVocabulary : SimpleVocabulary
    {
        public ProcedurePartOfVocabulary()
        {
            VocabularyName = "Procedure Part Of";
            KeyPrefix = "commonDataModel.procedurepartof";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProcedurePartOf;

            AddGroup("ProcedurePartOf Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfProcedure = group.Add(new VocabularyKey(nameof(PartOfProcedure), "Procedure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfType = group.Add(new VocabularyKey(nameof(PartOfType), "Part Of Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedurePartOfId = group.Add(new VocabularyKey(nameof(ProcedurePartOfId), "Procedure Part Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="PartOfMedAdminId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="PartOfObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ProcedureId"/> to Vocab 'Procedure.cdm.json/Procedure' with Property 'ProcedureId'
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
            
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartOfProcedure { get; private set; }
        public VocabularyKey PartOfType { get; private set; }
        public VocabularyKey ProcedurePartOfId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}