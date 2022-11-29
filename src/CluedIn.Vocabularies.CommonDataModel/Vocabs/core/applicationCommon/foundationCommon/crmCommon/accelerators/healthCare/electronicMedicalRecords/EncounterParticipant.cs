using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterParticipantVocabulary : SimpleVocabulary
    {
        public EncounterParticipantVocabulary()
        {
            VocabularyName = "Encounter Participant";
            KeyPrefix = "commonDataModel.encounterparticipant.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterParticipant";

            AddGroup("EncounterParticipant Details for ElectronicMedicalRecords", group =>
            {
			    EncounterParticipantId = group.Add(new VocabularyKey(nameof(EncounterParticipantId), "Encounter Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IndividualType = group.Add(new VocabularyKey(nameof(IndividualType), "Individual Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipantName = group.Add(new VocabularyKey(nameof(ParticipantName), "Participant Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterParticipantId { get; private set; }
        public VocabularyKey IndividualType { get; private set; }
        public VocabularyKey ParticipantName { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}