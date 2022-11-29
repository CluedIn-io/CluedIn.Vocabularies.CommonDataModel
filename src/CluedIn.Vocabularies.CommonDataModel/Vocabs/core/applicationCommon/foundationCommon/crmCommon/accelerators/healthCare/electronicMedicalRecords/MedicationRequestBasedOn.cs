using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestBasedOnVocabulary : SimpleVocabulary
    {
        public MedicationRequestBasedOnVocabulary()
        {
            VocabularyName = "Medication Request Based On";
            KeyPrefix = "commonDataModel.medicationrequestbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestBasedOn";

            AddGroup("MedicationRequestBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestBasedOnId = group.Add(new VocabularyKey(nameof(MedicationRequestBasedOnId), "Medication Request Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationRequestBasedOnType = group.Add(new VocabularyKey(nameof(MedicationRequestBasedOnType), "Based On Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestBasedOnId { get; private set; }
        public VocabularyKey MedicationRequestBasedOnType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}