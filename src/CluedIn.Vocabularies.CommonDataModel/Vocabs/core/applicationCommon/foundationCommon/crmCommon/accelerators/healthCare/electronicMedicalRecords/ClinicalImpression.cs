using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionVocabulary()
        {
            VocabularyName = "Clinical Impression";
            KeyPrefix = "commonDataModel.clinicalimpression.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpression";

            AddGroup("ClinicalImpression Details for ElectronicMedicalRecords", group =>
            {
			    AssessmentDateTime = group.Add(new VocabularyKey(nameof(AssessmentDateTime), "Assessment Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssessmentEndDateTime = group.Add(new VocabularyKey(nameof(AssessmentEndDateTime), "Assessment End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssessmentStartDateTime = group.Add(new VocabularyKey(nameof(AssessmentStartDateTime), "Assessment Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssessmentTimeType = group.Add(new VocabularyKey(nameof(AssessmentTimeType), "Assessment Time Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalImpressionId = group.Add(new VocabularyKey(nameof(ClinicalImpressionId), "Clinical Impression", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalImpressionNumber = group.Add(new VocabularyKey(nameof(ClinicalImpressionNumber), "Clinical Impression Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationDate = group.Add(new VocabularyKey(nameof(DocumentationDate), "Documentation Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AssessmentDateTime { get; private set; }
        public VocabularyKey AssessmentEndDateTime { get; private set; }
        public VocabularyKey AssessmentStartDateTime { get; private set; }
        public VocabularyKey AssessmentTimeType { get; private set; }
        public VocabularyKey ClinicalImpressionId { get; private set; }
        public VocabularyKey ClinicalImpressionNumber { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentationDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey Summary { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}