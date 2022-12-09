using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MedicationRequestBasedOnVocabulary : SimpleVocabulary
    {
        public MedicationRequestBasedOnVocabulary()
        {
            VocabularyName = "Medication Request Based On";
            KeyPrefix = "commonDataModel.medicationrequestbasedon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MedicationRequestBasedOn;

            AddGroup("MedicationRequestBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestBasedOnId = group.Add(new VocabularyKey(nameof(MedicationRequestBasedOnId), "Medication Request Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationRequestBasedOnType = group.Add(new VocabularyKey(nameof(MedicationRequestBasedOnType), "Based On Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="MedicationRequesBasedOnCarePlanId"/> to Vocab 'CarePlan.cdm.json/CarePlan' with Property 'CarePlanId'
            ///Property <see cref="MedicationRequesBasedOnMedicationRequestId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="MedicationRequestId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
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
            ///Property <see cref="MedicationRequesBasedOnProcedureRequestId"/> to Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'ProcedureRequestId'
            ///Property <see cref="MedicationRequesBasedOnReferralRequestId"/> to Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'ReferralRequestId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey MedicationRequestBasedOnId { get; private set; }
        public VocabularyKey MedicationRequestBasedOnType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}