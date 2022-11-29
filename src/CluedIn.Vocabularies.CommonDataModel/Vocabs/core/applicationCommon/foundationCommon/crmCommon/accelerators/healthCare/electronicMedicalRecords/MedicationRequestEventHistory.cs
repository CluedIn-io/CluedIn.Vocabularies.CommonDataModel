using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestEventHistoryVocabulary : SimpleVocabulary
    {
        public MedicationRequestEventHistoryVocabulary()
        {
            VocabularyName = "Medication Request Event History";
            KeyPrefix = "commonDataModel.medicationrequesteventhistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestEventHistory";

            AddGroup("MedicationRequestEventHistory Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestEventHistoryId = group.Add(new VocabularyKey(nameof(MedicationRequestEventHistoryId), "Medication Request Event History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestEventHistoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}