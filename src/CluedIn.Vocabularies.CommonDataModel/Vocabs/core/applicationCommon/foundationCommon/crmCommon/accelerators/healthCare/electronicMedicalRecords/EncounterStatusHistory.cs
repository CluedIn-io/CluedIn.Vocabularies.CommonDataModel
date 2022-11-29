using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterStatusHistoryVocabulary : SimpleVocabulary
    {
        public EncounterStatusHistoryVocabulary()
        {
            VocabularyName = "Encounter Status History";
            KeyPrefix = "commonDataModel.encounterstatushistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterStatusHistory";

            AddGroup("EncounterStatusHistory Details for ElectronicMedicalRecords", group =>
            {
			    EncounterStatus = group.Add(new VocabularyKey(nameof(EncounterStatus), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterStatusEndDate = group.Add(new VocabularyKey(nameof(EncounterStatusEndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterStatusHistoryId = group.Add(new VocabularyKey(nameof(EncounterStatusHistoryId), "Encounter Status History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterStatusStartDate = group.Add(new VocabularyKey(nameof(EncounterStatusStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterStatus { get; private set; }
        public VocabularyKey EncounterStatusEndDate { get; private set; }
        public VocabularyKey EncounterStatusHistoryId { get; private set; }
        public VocabularyKey EncounterStatusStartDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}