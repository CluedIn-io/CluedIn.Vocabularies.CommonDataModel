using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterAccountVocabulary : SimpleVocabulary
    {
        public EncounterAccountVocabulary()
        {
            VocabularyName = "Encounter Account";
            KeyPrefix = "commonDataModel.encounteraccount.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterAccount";

            AddGroup("EncounterAccount Details for ElectronicMedicalRecords", group =>
            {
			    EncounterAccountId = group.Add(new VocabularyKey(nameof(EncounterAccountId), "Encounter Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}