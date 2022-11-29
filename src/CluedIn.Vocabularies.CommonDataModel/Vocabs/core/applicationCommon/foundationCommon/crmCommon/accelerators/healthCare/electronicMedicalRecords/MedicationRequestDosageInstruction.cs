using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestDosageInstructionVocabulary : SimpleVocabulary
    {
        public MedicationRequestDosageInstructionVocabulary()
        {
            VocabularyName = "Medication Request Dosage Instruction";
            KeyPrefix = "commonDataModel.medicationrequestdosageinstruction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestDosageInstruction";

            AddGroup("MedicationRequestDosageInstruction Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestDosageInstructionId = group.Add(new VocabularyKey(nameof(MedicationRequestDosageInstructionId), "Medication Request Dosage Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestDosageInstructionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}