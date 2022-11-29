using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterEpisodeOfCareVocabulary : SimpleVocabulary
    {
        public EncounterEpisodeOfCareVocabulary()
        {
            VocabularyName = "Encounter Episode Of Care";
            KeyPrefix = "commonDataModel.encounterepisodeofcare.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterEpisodeOfCare";

            AddGroup("EncounterEpisodeOfCare Details for ElectronicMedicalRecords", group =>
            {
			    EncounterEpisodeOfCareId = group.Add(new VocabularyKey(nameof(EncounterEpisodeOfCareId), "Encounter Episode Of Care", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterEpisodeOfCareId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}