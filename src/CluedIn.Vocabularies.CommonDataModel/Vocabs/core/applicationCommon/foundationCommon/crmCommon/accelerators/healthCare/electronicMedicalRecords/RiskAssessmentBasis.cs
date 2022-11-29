using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RiskAssessmentBasisVocabulary : SimpleVocabulary
    {
        public RiskAssessmentBasisVocabulary()
        {
            VocabularyName = "Risk Assessment Basis";
            KeyPrefix = "commonDataModel.riskassessmentbasis.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RiskAssessmentBasis";

            AddGroup("RiskAssessmentBasis Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RiskAssessmentBasis = group.Add(new VocabularyKey(nameof(RiskAssessmentBasis), "Basis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RiskAssessmentBasisId = group.Add(new VocabularyKey(nameof(RiskAssessmentBasisId), "Risk Assessment Basis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RiskAssessmentBasis { get; private set; }
        public VocabularyKey RiskAssessmentBasisId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}