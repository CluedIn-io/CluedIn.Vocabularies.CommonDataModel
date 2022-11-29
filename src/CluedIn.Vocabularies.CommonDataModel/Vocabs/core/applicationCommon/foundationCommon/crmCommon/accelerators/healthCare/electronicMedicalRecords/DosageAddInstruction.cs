using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DosageAddInstructionVocabulary : SimpleVocabulary
    {
        public DosageAddInstructionVocabulary()
        {
            VocabularyName = "Dosage Add Instruction";
            KeyPrefix = "commonDataModel.dosageaddinstruction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DosageAddInstruction";

            AddGroup("DosageAddInstruction Details for ElectronicMedicalRecords", group =>
            {
			    DosageAddInstructionId = group.Add(new VocabularyKey(nameof(DosageAddInstructionId), "Dosage Add Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DosageAddInstructionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}