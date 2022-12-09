using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ClinicalImpressionActionVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionActionVocabulary()
        {
            VocabularyName = "Clinical Impression Action";
            KeyPrefix = "commonDataModel.clinicalimpressionaction";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ClinicalImpressionAction;

            AddGroup("ClinicalImpressionAction Details for ElectronicMedicalRecords", group =>
            {
			    ActionType = group.Add(new VocabularyKey(nameof(ActionType), "Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalImpressionActionId = group.Add(new VocabularyKey(nameof(ClinicalImpressionActionId), "Clinical Impression Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ActionAppointmentId"/> to Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActivityId'
            ///Property <see cref="ClinicalImpressionIdentifierId"/> to Vocab 'ClinicalImpression.cdm.json/ClinicalImpression' with Property 'ClinicalImpressionId'
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
            ///Property <see cref="ActionMedicationRequestId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="ActionProcedureId"/> to Vocab 'Procedure.cdm.json/Procedure' with Property 'ProcedureId'
            ///Property <see cref="ActionProcedureRequestId"/> to Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'ProcedureRequestId'
            ///Property <see cref="ActionReferralRequestId"/> to Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'ReferralRequestId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ActionType { get; private set; }
        public VocabularyKey ClinicalImpressionActionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}