using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestServiceRequestedVocabulary : SimpleVocabulary
    {
        public ReferralRequestServiceRequestedVocabulary()
        {
            VocabularyName = "Referral Request Service Requested";
            KeyPrefix = "commonDataModel.referralrequestservicerequested.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestServiceRequested";

            AddGroup("ReferralRequestServiceRequested Details for ElectronicMedicalRecords", group =>
            {
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestServiceReqId = group.Add(new VocabularyKey(nameof(ReferralRequestServiceReqId), "Referral Request Service Req", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Display { get; private set; }
        public VocabularyKey ReferralRequestServiceReqId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}