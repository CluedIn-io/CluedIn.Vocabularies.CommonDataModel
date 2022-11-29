using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public ReferralRequestReasonReferenceVocabulary()
        {
            VocabularyName = "Referral Request Reason Reference";
            KeyPrefix = "commonDataModel.referralrequestreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestReasonReference";

            AddGroup("ReferralRequestReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), "Reason Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestReasonReferenceId = group.Add(new VocabularyKey(nameof(ReferralRequestReasonReferenceId), "Referral Request Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey ReferralRequestReasonReferenceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}