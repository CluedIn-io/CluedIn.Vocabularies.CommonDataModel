using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EpisodeOfCareReferralRequestVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareReferralRequestVocabulary()
        {
            VocabularyName = "Episode Of Care Referral Request";
            KeyPrefix = "commonDataModel.episodeofcarereferralrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCareReferralRequest";

            AddGroup("EpisodeOfCareReferralRequest Details for ElectronicMedicalRecords", group =>
            {
			    EpisodeOfCareReferralRequestId = group.Add(new VocabularyKey(nameof(EpisodeOfCareReferralRequestId), "Episode Of Care Referral Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EpisodeOfCareReferralRequestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}