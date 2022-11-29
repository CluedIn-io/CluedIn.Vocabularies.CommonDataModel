using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RiskAssessmentPredictionVocabulary : SimpleVocabulary
    {
        public RiskAssessmentPredictionVocabulary()
        {
            VocabularyName = "Risk Assessment Prediction";
            KeyPrefix = "commonDataModel.riskassessmentprediction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RiskAssessmentPrediction";

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
        public VocabularyKey UpperLimit { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}