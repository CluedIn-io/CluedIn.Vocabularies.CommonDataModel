using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ClinicalImpressionInvestigationVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionInvestigationVocabulary()
        {
            VocabularyName = "Clinical Impression Investigation";
            KeyPrefix = "commonDataModel.clinicalimpressioninvestigation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ClinicalImpressionInvestigation;

            AddGroup("ClinicalImpressionInvestigation Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalImpressionInvestigationId = group.Add(new VocabularyKey(nameof(ClinicalImpressionInvestigationId), "Clinical Impression Investigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemType = group.Add(new VocabularyKey(nameof(ItemType), "Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ClinicalImpressionId"/> to Vocab 'ClinicalImpression.cdm.json/ClinicalImpression' with Property 'ClinicalImpressionId'
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
            ///Property <see cref="CodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemDiagnosticReportId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemFamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="ItemImagingStudyId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ItemQuestionaireResponseId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemRiskAssessmentId"/> to Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'RiskAssessmentId'
            ///Property <see cref="ClinicalmpressionInvestigationId"/> to Vocab 'ClinicalImpressionInvestigation.cdm.json/ClinicalImpressionInvestigation' with Property 'ClinicalImpressionInvestigationId'
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
            ///Property <see cref="ItemtypeDiagnosticReportId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemtypeFamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="ItemTypeImagingStudyId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemTypeObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ItemtypeQuestionnaireResponseId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ItemTypeRiskAssessmentId"/> to Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'RiskAssessmentId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ClinicalImpressionInvestigationId"/> from Vocab 'ClinicalImpressionInvestigationItem.cdm.json/ClinicalImpressionInvestigationItem' with Property 'ClinicalmpressionInvestigationId'
            #endregion
        }

        public VocabularyKey ClinicalImpressionInvestigationId { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}