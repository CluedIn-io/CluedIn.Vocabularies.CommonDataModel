using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionProblemVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionProblemVocabulary()
        {
            VocabularyName = "Clinical Impression Problem";
            KeyPrefix = "commonDataModel.clinicalimpressionproblem.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionProblem";

            AddGroup("ClinicalImpressionProblem Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalImpressionProblemId = group.Add(new VocabularyKey(nameof(ClinicalImpressionProblemId), "Clinical Impression Problem", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProblemType = group.Add(new VocabularyKey(nameof(ProblemType), "Problem Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClinicalImpressionProblemId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProblemType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}