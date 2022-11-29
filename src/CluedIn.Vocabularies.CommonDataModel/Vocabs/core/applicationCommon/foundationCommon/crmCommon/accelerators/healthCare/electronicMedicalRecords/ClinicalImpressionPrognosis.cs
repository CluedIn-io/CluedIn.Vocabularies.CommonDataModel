using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionPrognosisVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionPrognosisVocabulary()
        {
            VocabularyName = "Clinical Impression Prognosis";
            KeyPrefix = "commonDataModel.clinicalimpressionprognosis.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionPrognosis";

            AddGroup("ClinicalImpressionPrognosis Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalImpressionPrognosisId = group.Add(new VocabularyKey(nameof(ClinicalImpressionPrognosisId), "Clinical Impression Prognosis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClinicalImpressionPrognosisId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}