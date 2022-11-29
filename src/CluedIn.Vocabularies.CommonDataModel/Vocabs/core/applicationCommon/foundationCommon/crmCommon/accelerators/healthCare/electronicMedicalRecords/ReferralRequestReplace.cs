using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestReplaceVocabulary : SimpleVocabulary
    {
        public ReferralRequestReplaceVocabulary()
        {
            VocabularyName = "Referral Request Replace";
            KeyPrefix = "commonDataModel.referralrequestreplace.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestReplace";

            AddGroup("ReferralRequestReplace Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestReplaceId = group.Add(new VocabularyKey(nameof(ReferralRequestReplaceId), "Referral Request Replace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReferralRequestReplaceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}