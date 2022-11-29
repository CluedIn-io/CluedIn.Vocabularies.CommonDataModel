using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterClassHistoryVocabulary : SimpleVocabulary
    {
        public EncounterClassHistoryVocabulary()
        {
            VocabularyName = "Encounter Class History";
            KeyPrefix = "commonDataModel.encounterclasshistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterClassHistory";

            AddGroup("EncounterClassHistory Details for ElectronicMedicalRecords", group =>
            {
			    EncounterClass = group.Add(new VocabularyKey(nameof(EncounterClass), "Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterClassEndDate = group.Add(new VocabularyKey(nameof(EncounterClassEndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterClassHistoryId = group.Add(new VocabularyKey(nameof(EncounterClassHistoryId), "Encounter Class History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterClassStartDate = group.Add(new VocabularyKey(nameof(EncounterClassStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterClass { get; private set; }
        public VocabularyKey EncounterClassEndDate { get; private set; }
        public VocabularyKey EncounterClassHistoryId { get; private set; }
        public VocabularyKey EncounterClassStartDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}