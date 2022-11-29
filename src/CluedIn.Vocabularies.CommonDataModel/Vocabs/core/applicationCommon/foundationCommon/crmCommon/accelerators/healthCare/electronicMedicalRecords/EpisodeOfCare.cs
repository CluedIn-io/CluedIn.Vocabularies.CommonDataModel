using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EpisodeOfCareVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareVocabulary()
        {
            VocabularyName = "Episode Of Care";
            KeyPrefix = "commonDataModel.episodeofcare.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCare";

            AddGroup("EpisodeOfCare Details for ElectronicMedicalRecords", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EpisodeOfCareId = group.Add(new VocabularyKey(nameof(EpisodeOfCareId), "Episode of Care", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Episode Of Care Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey EpisodeOfCareId { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}