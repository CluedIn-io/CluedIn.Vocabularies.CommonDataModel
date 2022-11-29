using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EpisodeOfCareTypeVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareTypeVocabulary()
        {
            VocabularyName = "Episode Of Care Type";
            KeyPrefix = "commonDataModel.episodeofcaretype.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCareType";

            AddGroup("EpisodeOfCareType Details for ElectronicMedicalRecords", group =>
            {
			    EpisodeOfCareTypeId = group.Add(new VocabularyKey(nameof(EpisodeOfCareTypeId), "Episode Of Care Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EpisodeOfCareTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}