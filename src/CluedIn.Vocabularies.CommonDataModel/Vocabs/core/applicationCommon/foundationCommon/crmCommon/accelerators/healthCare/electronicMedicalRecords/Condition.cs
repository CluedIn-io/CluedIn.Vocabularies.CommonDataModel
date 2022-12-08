using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class ConditionVocabulary : SimpleVocabulary
    {
        public ConditionVocabulary()
        {
            VocabularyName = "Condition";
            KeyPrefix = "commonDataModel.condition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Condition;

            AddGroup("Condition Details for ElectronicMedicalRecords", group =>
            {
			    AbatementAge = group.Add(new VocabularyKey(nameof(AbatementAge), "Abatement Age", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AbatementDate = group.Add(new VocabularyKey(nameof(AbatementDate), "Abatement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementPeriodEndDate = group.Add(new VocabularyKey(nameof(AbatementPeriodEndDate), "Abatement Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementPeriodStartDate = group.Add(new VocabularyKey(nameof(AbatementPeriodStartDate), "Abatement Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementRangeHigh = group.Add(new VocabularyKey(nameof(AbatementRangeHigh), "Abatement Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AbatementRangeLow = group.Add(new VocabularyKey(nameof(AbatementRangeLow), "Abatement Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AbatementString = group.Add(new VocabularyKey(nameof(AbatementString), "Abatement String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementType = group.Add(new VocabularyKey(nameof(AbatementType), "Abatement Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssertedDate = group.Add(new VocabularyKey(nameof(AssertedDate), "Asserted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalStatus = group.Add(new VocabularyKey(nameof(ClinicalStatus), "Clinical Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConditionId = group.Add(new VocabularyKey(nameof(ConditionId), "Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAbatement = group.Add(new VocabularyKey(nameof(IsAbatement), "Is Abatement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetAge = group.Add(new VocabularyKey(nameof(OnsetAge), "Onset Age", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OnsetDate = group.Add(new VocabularyKey(nameof(OnsetDate), "Onset Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetPeriodEndDate = group.Add(new VocabularyKey(nameof(OnsetPeriodEndDate), "Onset Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetPeriodStartDate = group.Add(new VocabularyKey(nameof(OnsetPeriodStartDate), "Onset Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetRangeHigh = group.Add(new VocabularyKey(nameof(OnsetRangeHigh), "Onset Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnsetRangeLow = group.Add(new VocabularyKey(nameof(OnsetRangeLow), "Onset Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnsetString = group.Add(new VocabularyKey(nameof(OnsetString), "Onset String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetType = group.Add(new VocabularyKey(nameof(OnsetType), "Onset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VerificationStatus = group.Add(new VocabularyKey(nameof(VerificationStatus), "Verification Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AsserterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubjectTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AppointmentId"/> to Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActivityId'
            ///Property <see cref="CarePlanId"/> to Vocab 'CarePlan.cdm.json/CarePlan' with Property 'CarePlanId'
            ///Property <see cref="CategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SeverityId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="StageId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SubjectTypeGroupId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="BodySiteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EvidenceCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="StageAssessmentDiagnosticRecordId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionOutcomeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="ContextEncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
            ///Property <see cref="ContextEpisodeOfCareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
            ///Property <see cref="EncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
            ///Property <see cref="ReasonReferenceReferralRequestId"/> to Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'ReferralRequestId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
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
            ///Property <see cref="StageAssessmentClinicalImpressionId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="StageAssessmentObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="FamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
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
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
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
            ///Property <see cref="ConditionId"/> from Vocab 'AppointmentEMRIndication.cdm.json/AppointmentEMRIndication' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'BodySite.cdm.json/BodySite' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'CarePlanActivityReasonReference.cdm.json/CarePlanActivityReasonReference' with Property 'PlanActivityReasonReferenceId'
            ///Property <see cref="ConditionId"/> from Vocab 'CarePlanAddresses.cdm.json/CarePlanAddresses' with Property 'AddressesId'
            ///Property <see cref="ConditionId"/> from Vocab 'CareTeamReasonReference.cdm.json/CareTeamReasonReference' with Property 'ReferenceId'
            ///Property <see cref="ConditionId"/> from Vocab 'ClinicalImpressionFinding.cdm.json/ClinicalImpressionFinding' with Property 'ItemConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ClinicalImpressionProblem.cdm.json/ClinicalImpressionProblem' with Property 'ProblemConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'CommunicationRequestReasonReference.cdm.json/CommunicationRequestReasonReference' with Property 'ReasonReferenceConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ConditionBodySite.cdm.json/ConditionBodySite' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ConditionCategory.cdm.json/ConditionCategory' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ConditionEvidence.cdm.json/ConditionEvidence' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ConditionStage.cdm.json/ConditionStage' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'EncounterDiagnosis.cdm.json/EncounterDiagnosis' with Property 'EncounterConditionIdentifierId'
            ///Property <see cref="ConditionId"/> from Vocab 'EpisodeOfCareDiagnosis.cdm.json/EpisodeOfCareDiagnosis' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'FamilyMemberHistoryReasonReference.cdm.json/FamilyMemberHistoryReasonReference' with Property 'ReasonReferenceConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'GoalAddresses.cdm.json/GoalAddresses' with Property 'AddressesTypeConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'MedicationAdministrationReasonReference.cdm.json/MedicationAdministrationReasonReference' with Property 'ReasonReferenceTypeConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'MedicationRequestReasonReference.cdm.json/MedicationRequestReasonReference' with Property 'ReasonReferenceConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ProcedureComplicationDetail.cdm.json/ProcedureComplicationDetail' with Property 'ComplicationConditionIdentifierId'
            ///Property <see cref="ConditionId"/> from Vocab 'ProcedureReasonReference.cdm.json/ProcedureReasonReference' with Property 'ReferenceConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ProcedureRequestReasonReference.cdm.json/ProcedureRequestReasonReference' with Property 'ReferenceReasonConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'ReferralRequestReasonReference.cdm.json/ReferralRequestReasonReference' with Property 'ReferenceReasonConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'ConditionId'
            ///Property <see cref="ConditionId"/> from Vocab 'VisionPrescription.cdm.json/VisionPrescription' with Property 'ReasonReferenceId'
            #endregion
        }

        public VocabularyKey AbatementAge { get; private set; }
        public VocabularyKey AbatementDate { get; private set; }
        public VocabularyKey AbatementPeriodEndDate { get; private set; }
        public VocabularyKey AbatementPeriodStartDate { get; private set; }
        public VocabularyKey AbatementRangeHigh { get; private set; }
        public VocabularyKey AbatementRangeLow { get; private set; }
        public VocabularyKey AbatementString { get; private set; }
        public VocabularyKey AbatementType { get; private set; }
        public VocabularyKey AssertedDate { get; private set; }
        public VocabularyKey ClinicalStatus { get; private set; }
        public VocabularyKey ConditionId { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey IsAbatement { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OnsetAge { get; private set; }
        public VocabularyKey OnsetDate { get; private set; }
        public VocabularyKey OnsetPeriodEndDate { get; private set; }
        public VocabularyKey OnsetPeriodStartDate { get; private set; }
        public VocabularyKey OnsetRangeHigh { get; private set; }
        public VocabularyKey OnsetRangeLow { get; private set; }
        public VocabularyKey OnsetString { get; private set; }
        public VocabularyKey OnsetType { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey VerificationStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}