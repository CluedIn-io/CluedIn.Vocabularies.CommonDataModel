using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterReferralRequestVocabulary : SimpleVocabulary
    {
        public EncounterReferralRequestVocabulary()
        {
            VocabularyName = "Encounter Referral Request";
            KeyPrefix = "commonDataModel.encounterreferralrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterReferralRequest";

            AddGroup("EncounterReferralRequest Details for ElectronicMedicalRecords", group =>
            {
			    EncounterReferralRequestId = group.Add(new VocabularyKey(nameof(EncounterReferralRequestId), "Encounter Referral Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterReferralRequestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}