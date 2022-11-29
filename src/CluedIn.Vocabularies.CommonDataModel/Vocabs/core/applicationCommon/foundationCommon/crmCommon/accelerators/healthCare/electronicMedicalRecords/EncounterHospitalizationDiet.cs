using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterHospitalizationDietVocabulary : SimpleVocabulary
    {
        public EncounterHospitalizationDietVocabulary()
        {
            VocabularyName = "Encounter Hospitalization Diet";
            KeyPrefix = "commonDataModel.encounterhospitalizationdiet.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterHospitalizationDiet";

            AddGroup("EncounterHospitalizationDiet Details for ElectronicMedicalRecords", group =>
            {
			    EncounterHospitalizationDietId = group.Add(new VocabularyKey(nameof(EncounterHospitalizationDietId), "Encounter Hospitalization Diet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterHospitalizationDietId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}