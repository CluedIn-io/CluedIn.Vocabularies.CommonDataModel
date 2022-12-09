using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MedicationAdministrationPartOfVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationPartOfVocabulary()
        {
            VocabularyName = "Medication Administration Part Of";
            KeyPrefix = "commonDataModel.medicationadministrationpartof";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MedicationAdministrationPartOf;

            AddGroup("MedicationAdministrationPartOf Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationPartOfId = group.Add(new VocabularyKey(nameof(MedicationAdministrationPartOfId), "Medication Administration Part Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfType = group.Add(new VocabularyKey(nameof(PartOfType), "Part Of Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="PartOfTypeMedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
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
            ///Property <see cref="PartOfTypeProcedureId"/> to Vocab 'Procedure.cdm.json/Procedure' with Property 'ProcedureId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey MedicationAdministrationPartOfId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartOfType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}