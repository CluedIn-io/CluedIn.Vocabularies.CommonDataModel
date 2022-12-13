using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RiskAssessmentPredictionVocabulary : SimpleVocabulary
    {
        public RiskAssessmentPredictionVocabulary()
        {
            VocabularyName = "Risk Assessment Prediction";
            KeyPrefix = "commonDataModel.riskassessmentprediction";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RiskAssessmentPrediction;

            AddGroup("RiskAssessmentPrediction Details for ElectronicMedicalRecords", group =>
            {
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerLimit = group.Add(new VocabularyKey(nameof(LowerLimit), "Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodType = group.Add(new VocabularyKey(nameof(PeriodType), "Period Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Probabilitydecimal = group.Add(new VocabularyKey(nameof(Probabilitydecimal), "Probability", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Probabilitylowerlimit = group.Add(new VocabularyKey(nameof(Probabilitylowerlimit), "Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ProbabilityType = group.Add(new VocabularyKey(nameof(ProbabilityType), "Probability Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Probabilityupperlimit = group.Add(new VocabularyKey(nameof(Probabilityupperlimit), "Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                QualitativeRisk = group.Add(new VocabularyKey(nameof(QualitativeRisk), "Qualitative Risk", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rationale = group.Add(new VocabularyKey(nameof(Rationale), "Rationale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelativeRisk = group.Add(new VocabularyKey(nameof(RelativeRisk), "Relative Risk", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RiskAssessmentPredictionId = group.Add(new VocabularyKey(nameof(RiskAssessmentPredictionId), "Risk Assessment Prediction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperLimit = group.Add(new VocabularyKey(nameof(UpperLimit), "Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OutcomeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey LowerLimit { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodType { get; private set; }
        public VocabularyKey Probabilitydecimal { get; private set; }
        public VocabularyKey Probabilitylowerlimit { get; private set; }
        public VocabularyKey ProbabilityType { get; private set; }
        public VocabularyKey Probabilityupperlimit { get; private set; }
        public VocabularyKey QualitativeRisk { get; private set; }
        public VocabularyKey Rationale { get; private set; }
        public VocabularyKey RelativeRisk { get; private set; }
        public VocabularyKey RiskAssessmentPredictionId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey UpperLimit { get; private set; }
    }
}