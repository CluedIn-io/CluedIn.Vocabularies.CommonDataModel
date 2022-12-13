using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class FamilyMemberHistoryVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryVocabulary()
        {
            VocabularyName = "Family Member History";
            KeyPrefix = "commonDataModel.familymemberhistory";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FamilyMemberHistory;

            AddGroup("FamilyMemberHistory Details for ElectronicMedicalRecords", group =>
            {
                Age = group.Add(new VocabularyKey(nameof(Age), "Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AgeRangeHigh = group.Add(new VocabularyKey(nameof(AgeRangeHigh), "Age Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AgeRangeLow = group.Add(new VocabularyKey(nameof(AgeRangeLow), "Age Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AgeString = group.Add(new VocabularyKey(nameof(AgeString), "Age", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgeType = group.Add(new VocabularyKey(nameof(AgeType), "Age Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BornDate = group.Add(new VocabularyKey(nameof(BornDate), "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BornDateString = group.Add(new VocabularyKey(nameof(BornDateString), "Born String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BornPeriodEndDate = group.Add(new VocabularyKey(nameof(BornPeriodEndDate), "Date of Birth Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BornPeriodStartDate = group.Add(new VocabularyKey(nameof(BornPeriodStartDate), "Date of Birth Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BornType = group.Add(new VocabularyKey(nameof(BornType), "Born Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeceasedAge = group.Add(new VocabularyKey(nameof(DeceasedAge), "Deceased Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeceasedAgeHigh = group.Add(new VocabularyKey(nameof(DeceasedAgeHigh), "Deceased Age High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeceasedAgeLow = group.Add(new VocabularyKey(nameof(DeceasedAgeLow), "Deceased Age Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeceasedBoolean = group.Add(new VocabularyKey(nameof(DeceasedBoolean), "Deceased", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeceasedDateString = group.Add(new VocabularyKey(nameof(DeceasedDateString), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeceasedType = group.Add(new VocabularyKey(nameof(DeceasedType), "Deceased Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FamilyMemberHistoryId = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryId), "Family Member History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FamilyMemberHistoryNumber = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryNumber), "Family Member History Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotDone = group.Add(new VocabularyKey(nameof(NotDone), "Not Done", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="PatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReasonReferenceAllergyIntoleranceId"/> to Vocab 'AllergyIntolerance.cdm.json/AllergyIntolerance' with Property 'AllergyIntoleranceId'
            ///Property <see cref="NotDoneReasonId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RelationshipId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionOutcomeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="QuestionnaireId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonReferenceQuestionnaireResponseId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonReferenceConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
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
            ///Property <see cref="FamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
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
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
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
            ///Property <see cref="ReasonReferenceObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'ClinicalImpressionInvestigation.cdm.json/ClinicalImpressionInvestigation' with Property 'ItemFamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'ClinicalImpressionInvestigationItem.cdm.json/ClinicalImpressionInvestigationItem' with Property 'ItemtypeFamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'FamilyMemberHistoryCondition.cdm.json/FamilyMemberHistoryCondition' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'FamilyMemberHistoryDefinition.cdm.json/FamilyMemberHistoryDefinition' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'FamilyMemberHistoryReason.cdm.json/FamilyMemberHistoryReason' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="FamilyMemberHistoryId"/> from Vocab 'FamilyMemberHistoryReasonReference.cdm.json/FamilyMemberHistoryReasonReference' with Property 'FamilyMemberHistoryId'
            #endregion
        }

        public VocabularyKey Age { get; private set; }
        public VocabularyKey AgeRangeHigh { get; private set; }
        public VocabularyKey AgeRangeLow { get; private set; }
        public VocabularyKey AgeString { get; private set; }
        public VocabularyKey AgeType { get; private set; }
        public VocabularyKey BornDate { get; private set; }
        public VocabularyKey BornDateString { get; private set; }
        public VocabularyKey BornPeriodEndDate { get; private set; }
        public VocabularyKey BornPeriodStartDate { get; private set; }
        public VocabularyKey BornType { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey DeceasedAge { get; private set; }
        public VocabularyKey DeceasedAgeHigh { get; private set; }
        public VocabularyKey DeceasedAgeLow { get; private set; }
        public VocabularyKey DeceasedBoolean { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey DeceasedDateString { get; private set; }
        public VocabularyKey DeceasedType { get; private set; }
        public VocabularyKey FamilyMemberHistoryId { get; private set; }
        public VocabularyKey FamilyMemberHistoryNumber { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotDone { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}