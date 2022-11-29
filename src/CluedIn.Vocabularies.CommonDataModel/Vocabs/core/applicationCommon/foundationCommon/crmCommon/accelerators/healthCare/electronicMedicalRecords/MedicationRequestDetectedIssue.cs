using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestDetectedIssueVocabulary : SimpleVocabulary
    {
        public MedicationRequestDetectedIssueVocabulary()
        {
            VocabularyName = "Medication Request Detected Issue";
            KeyPrefix = "commonDataModel.medicationrequestdetectedissue.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestDetectedIssue";

            AddGroup("MedicationRequestDetectedIssue Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestDetectedIssueId = group.Add(new VocabularyKey(nameof(MedicationRequestDetectedIssueId), "Medication Request Detected Issue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestDetectedIssueId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}