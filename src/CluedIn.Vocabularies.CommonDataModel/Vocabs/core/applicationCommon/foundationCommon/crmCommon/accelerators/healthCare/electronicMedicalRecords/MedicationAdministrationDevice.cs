using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationDeviceVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationDeviceVocabulary()
        {
            VocabularyName = "Medication Administration Device";
            KeyPrefix = "commonDataModel.medicationadministrationdevice.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationDevice";

            AddGroup("MedicationAdministrationDevice Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationDeviceId = group.Add(new VocabularyKey(nameof(MedicationAdministrationDeviceId), "Medication Administration Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationDeviceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}