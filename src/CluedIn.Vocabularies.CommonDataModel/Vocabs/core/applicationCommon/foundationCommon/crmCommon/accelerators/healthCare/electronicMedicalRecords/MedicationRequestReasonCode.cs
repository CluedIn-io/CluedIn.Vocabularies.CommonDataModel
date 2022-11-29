using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestReasonCodeVocabulary : SimpleVocabulary
    {
        public MedicationRequestReasonCodeVocabulary()
        {
            VocabularyName = "Medication Request Reason Code";
            KeyPrefix = "commonDataModel.medicationrequestreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestReasonCode";

            AddGroup("MedicationRequestReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestReasonCodeId = group.Add(new VocabularyKey(nameof(MedicationRequestReasonCodeId), "Medication Request Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestReasonCodeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}