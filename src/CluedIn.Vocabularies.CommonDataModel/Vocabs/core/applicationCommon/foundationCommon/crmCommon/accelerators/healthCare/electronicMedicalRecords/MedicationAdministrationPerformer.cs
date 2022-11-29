using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationPerformerVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationPerformerVocabulary()
        {
            VocabularyName = "Medication Administration Performer";
            KeyPrefix = "commonDataModel.medicationadministrationperformer.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationPerformer";

            AddGroup("MedicationAdministrationPerformer Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationPerformerId = group.Add(new VocabularyKey(nameof(MedicationAdministrationPerformerId), "Medication Administration Performer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformerActorType = group.Add(new VocabularyKey(nameof(PerformerActorType), "Performer Actor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationPerformerId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PerformerActorType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}