using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterParticipantTypeVocabulary : SimpleVocabulary
    {
        public EncounterParticipantTypeVocabulary()
        {
            VocabularyName = "Encounter Participant Type";
            KeyPrefix = "commonDataModel.encounterparticipanttype.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterParticipantType";

            AddGroup("EncounterParticipantType Details for ElectronicMedicalRecords", group =>
            {
			    EncounterParticipantTypeId = group.Add(new VocabularyKey(nameof(EncounterParticipantTypeId), "Encounter Participant Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterParticipantTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}