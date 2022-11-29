using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterLocationVocabulary : SimpleVocabulary
    {
        public EncounterLocationVocabulary()
        {
            VocabularyName = "Encounter Location";
            KeyPrefix = "commonDataModel.encounterlocation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterLocation";

            AddGroup("EncounterLocation Details for ElectronicMedicalRecords", group =>
            {
			    EncounterLocationEndDate = group.Add(new VocabularyKey(nameof(EncounterLocationEndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterLocationId = group.Add(new VocabularyKey(nameof(EncounterLocationId), "Encounter Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterLocationStartDate = group.Add(new VocabularyKey(nameof(EncounterLocationStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterLocationStatus = group.Add(new VocabularyKey(nameof(EncounterLocationStatus), "Location Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterLocationEndDate { get; private set; }
        public VocabularyKey EncounterLocationId { get; private set; }
        public VocabularyKey EncounterLocationStartDate { get; private set; }
        public VocabularyKey EncounterLocationStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}