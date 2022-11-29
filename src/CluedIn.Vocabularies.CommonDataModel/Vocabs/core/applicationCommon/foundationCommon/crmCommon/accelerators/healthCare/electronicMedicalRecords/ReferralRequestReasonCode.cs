using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestReasonCodeVocabulary : SimpleVocabulary
    {
        public ReferralRequestReasonCodeVocabulary()
        {
            VocabularyName = "Referral Request Reason Code";
            KeyPrefix = "commonDataModel.referralrequestreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestReasonCode";

            AddGroup("ReferralRequestReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestReasonCodeId = group.Add(new VocabularyKey(nameof(ReferralRequestReasonCodeId), "Referral Request Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Display { get; private set; }
        public VocabularyKey ReferralRequestReasonCodeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}