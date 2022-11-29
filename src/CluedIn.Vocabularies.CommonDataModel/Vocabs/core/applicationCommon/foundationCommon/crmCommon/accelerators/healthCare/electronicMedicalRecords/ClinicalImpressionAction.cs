using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionActionVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionActionVocabulary()
        {
            VocabularyName = "Clinical Impression Action";
            KeyPrefix = "commonDataModel.clinicalimpressionaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionAction";

            AddGroup("ClinicalImpressionAction Details for ElectronicMedicalRecords", group =>
            {
			    ActionType = group.Add(new VocabularyKey(nameof(ActionType), "Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalImpressionActionId = group.Add(new VocabularyKey(nameof(ClinicalImpressionActionId), "Clinical Impression Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActionType { get; private set; }
        public VocabularyKey ClinicalImpressionActionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}