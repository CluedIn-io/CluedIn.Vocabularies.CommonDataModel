using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionInvestigationItemVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionInvestigationItemVocabulary()
        {
            VocabularyName = "Clinical Impression Investigation Item";
            KeyPrefix = "commonDataModel.clinicalimpressioninvestigationitem.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionInvestigationItem";

            AddGroup("ClinicalImpressionInvestigationItem Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalimpressioninvetigationitemId = group.Add(new VocabularyKey(nameof(ClinicalimpressioninvetigationitemId), "Clinical Impression Investigation Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemType = group.Add(new VocabularyKey(nameof(ItemType), "Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClinicalimpressioninvetigationitemId { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}