using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionInvestigationVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionInvestigationVocabulary()
        {
            VocabularyName = "Clinical Impression Investigation";
            KeyPrefix = "commonDataModel.clinicalimpressioninvestigation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionInvestigation";

            AddGroup("ClinicalImpressionInvestigation Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalImpressionInvestigationId = group.Add(new VocabularyKey(nameof(ClinicalImpressionInvestigationId), "Clinical Impression Investigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemType = group.Add(new VocabularyKey(nameof(ItemType), "Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClinicalImpressionInvestigationId { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}