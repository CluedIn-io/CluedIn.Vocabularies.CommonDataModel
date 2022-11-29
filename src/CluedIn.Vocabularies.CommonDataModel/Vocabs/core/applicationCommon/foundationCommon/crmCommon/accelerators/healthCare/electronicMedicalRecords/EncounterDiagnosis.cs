using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterDiagnosisVocabulary : SimpleVocabulary
    {
        public EncounterDiagnosisVocabulary()
        {
            VocabularyName = "Encounter Diagnosis";
            KeyPrefix = "commonDataModel.encounterdiagnosis.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterDiagnosis";

            AddGroup("EncounterDiagnosis Details for ElectronicMedicalRecords", group =>
            {
			    EncounterDiagnosisId = group.Add(new VocabularyKey(nameof(EncounterDiagnosisId), "Encounter Diagnosis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterRank = group.Add(new VocabularyKey(nameof(EncounterRank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterDiagnosisId { get; private set; }
        public VocabularyKey EncounterRank { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}