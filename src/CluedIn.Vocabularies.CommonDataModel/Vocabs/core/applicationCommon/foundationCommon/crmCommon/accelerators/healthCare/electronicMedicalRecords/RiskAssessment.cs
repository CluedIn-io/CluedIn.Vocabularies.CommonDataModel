using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RiskAssessmentVocabulary : SimpleVocabulary
    {
        public RiskAssessmentVocabulary()
        {
            VocabularyName = "Risk Assessment";
            KeyPrefix = "commonDataModel.riskassessment";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RiskAssessment;

            AddGroup("RiskAssessment Details for ElectronicMedicalRecords", group =>
            {
                BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), "Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Basis = group.Add(new VocabularyKey(nameof(Basis), "Basis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mitigation = group.Add(new VocabularyKey(nameof(Mitigation), "Mitigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Occurrencedatetime = group.Add(new VocabularyKey(nameof(Occurrencedatetime), "Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Occurrenceenddate = group.Add(new VocabularyKey(nameof(Occurrenceenddate), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Occurrencestartdate = group.Add(new VocabularyKey(nameof(Occurrencestartdate), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parent = group.Add(new VocabularyKey(nameof(Parent), "Parent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerformerType = group.Add(new VocabularyKey(nameof(PerformerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reasonentity = group.Add(new VocabularyKey(nameof(Reasonentity), "Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonType = group.Add(new VocabularyKey(nameof(ReasonType), "Reason Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskAssessmentId = group.Add(new VocabularyKey(nameof(RiskAssessmentId), "Risk Assessment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskAssessmentNumber = group.Add(new VocabularyKey(nameof(RiskAssessmentNumber), "Risk Assessment Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="PerformerPractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubjectpatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MethodId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SubjectgroupId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="OutcomeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="PerformerDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="ContextencounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
            ///Property <see cref="ContextspisodeofcareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
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
            ///Property <see cref="RiskAssessmentId"/> to Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'RiskAssessmentId'
            ///Property <see cref="RiskAssessmentId"/> to Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'RiskAssessmentId'
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
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'ClinicalImpressionInvestigation.cdm.json/ClinicalImpressionInvestigation' with Property 'ItemRiskAssessmentId'
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'ClinicalImpressionInvestigationItem.cdm.json/ClinicalImpressionInvestigationItem' with Property 'ItemTypeRiskAssessmentId'
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'ClinicalImpressionPrognosis.cdm.json/ClinicalImpressionPrognosis' with Property 'ReferenceId'
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'GoalAddresses.cdm.json/GoalAddresses' with Property 'AddressesTypeRiskAssessmentId'
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'RiskAssessmentBasis.cdm.json/RiskAssessmentBasis' with Property 'RiskAssessmentId'
            ///Property <see cref="RiskAssessmentId"/> from Vocab 'RiskAssessmentPrediction.cdm.json/RiskAssessmentPrediction' with Property 'RiskAssessmentId'
            #endregion
        }

        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey Basis { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Mitigation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Occurrencedatetime { get; private set; }
        public VocabularyKey Occurrenceenddate { get; private set; }
        public VocabularyKey Occurrencestartdate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey Parent { get; private set; }
        public VocabularyKey PerformerType { get; private set; }
        public VocabularyKey Reasonentity { get; private set; }
        public VocabularyKey ReasonType { get; private set; }
        public VocabularyKey RiskAssessmentId { get; private set; }
        public VocabularyKey RiskAssessmentNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
    }
}