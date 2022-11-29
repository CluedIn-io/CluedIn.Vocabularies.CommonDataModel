using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationPackageBatchVocabulary : SimpleVocabulary
    {
        public MedicationPackageBatchVocabulary()
        {
            VocabularyName = "Medication Package Batch";
            KeyPrefix = "commonDataModel.medicationpackagebatch.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationPackageBatch";

            AddGroup("MedicationPackageBatch Details for ElectronicMedicalRecords", group =>
            {
			    BatchExpirationDate = group.Add(new VocabularyKey(nameof(BatchExpirationDate), "Batch Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BatchLotNumber = group.Add(new VocabularyKey(nameof(BatchLotNumber), "Batch Lot Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationPackageBatchId = group.Add(new VocabularyKey(nameof(MedicationPackageBatchId), "Medication Package Batch", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BatchExpirationDate { get; private set; }
        public VocabularyKey BatchLotNumber { get; private set; }
        public VocabularyKey MedicationPackageBatchId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}