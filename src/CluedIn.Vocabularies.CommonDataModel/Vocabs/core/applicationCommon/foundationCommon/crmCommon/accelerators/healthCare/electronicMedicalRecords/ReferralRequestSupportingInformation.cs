using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestSupportingInformationVocabulary : SimpleVocabulary
    {
        public ReferralRequestSupportingInformationVocabulary()
        {
            VocabularyName = "Referral Request Supporting Information";
            KeyPrefix = "commonDataModel.referralrequestsupportinginformation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestSupportingInformation";

            AddGroup("ReferralRequestSupportingInformation Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestSupportingInformationId = group.Add(new VocabularyKey(nameof(ReferralRequestSupportingInformationId), "Referral Request Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInfo = group.Add(new VocabularyKey(nameof(SupportingInfo), "Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReferralRequestSupportingInformationId { get; private set; }
        public VocabularyKey SupportingInfo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}