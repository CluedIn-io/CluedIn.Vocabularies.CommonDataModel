using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EpisodeOfCareAccountVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareAccountVocabulary()
        {
            VocabularyName = "Episode Of Care Account";
            KeyPrefix = "commonDataModel.episodeofcareaccount.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCareAccount";

            AddGroup("EpisodeOfCareAccount Details for ElectronicMedicalRecords", group =>
            {
			    EpisodeOfCareAccountId = group.Add(new VocabularyKey(nameof(EpisodeOfCareAccountId), "Episode Of Care Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EpisodeOfCareAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}