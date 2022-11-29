using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EpisodeOfCareDiagnosisVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareDiagnosisVocabulary()
        {
            VocabularyName = "Episode Of Care Diagnosis";
            KeyPrefix = "commonDataModel.episodeofcarediagnosis.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCareDiagnosis";

            AddGroup("EpisodeOfCareDiagnosis Details for ElectronicMedicalRecords", group =>
            {
			    ConditionRank = group.Add(new VocabularyKey(nameof(ConditionRank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EpisodeOfCareDiagnosisId = group.Add(new VocabularyKey(nameof(EpisodeOfCareDiagnosisId), "Episode Of Care Diagnosis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConditionRank { get; private set; }
        public VocabularyKey EpisodeOfCareDiagnosisId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}