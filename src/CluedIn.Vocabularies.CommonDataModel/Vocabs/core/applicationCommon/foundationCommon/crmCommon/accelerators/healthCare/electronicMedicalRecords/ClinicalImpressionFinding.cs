using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionFindingVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionFindingVocabulary()
        {
            VocabularyName = "Clinical Impression Finding";
            KeyPrefix = "commonDataModel.clinicalimpressionfinding.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionFinding";

            AddGroup("ClinicalImpressionFinding Details for ElectronicMedicalRecords", group =>
            {
			    Basis = group.Add(new VocabularyKey(nameof(Basis), "Basis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalImpressionFindingId = group.Add(new VocabularyKey(nameof(ClinicalImpressionFindingId), "Clinical Impression Finding", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemType = group.Add(new VocabularyKey(nameof(ItemType), "Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Basis { get; private set; }
        public VocabularyKey ClinicalImpressionFindingId { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}