using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationEventHistoryVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationEventHistoryVocabulary()
        {
            VocabularyName = "Medication Administration Event History";
            KeyPrefix = "commonDataModel.medicationadministrationeventhistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationEventHistory";

            AddGroup("MedicationAdministrationEventHistory Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationEventHistoryId = group.Add(new VocabularyKey(nameof(MedicationAdministrationEventHistoryId), "Medication Administration Event History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationEventHistoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}