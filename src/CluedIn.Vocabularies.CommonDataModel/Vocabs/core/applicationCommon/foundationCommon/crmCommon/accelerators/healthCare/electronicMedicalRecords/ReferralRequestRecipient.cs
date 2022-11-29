using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestRecipientVocabulary : SimpleVocabulary
    {
        public ReferralRequestRecipientVocabulary()
        {
            VocabularyName = "Referral Request Recipient";
            KeyPrefix = "commonDataModel.referralrequestrecipient.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestRecipient";

            AddGroup("ReferralRequestRecipient Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientType = group.Add(new VocabularyKey(nameof(RecipientType), "Recipient Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestRecipientId = group.Add(new VocabularyKey(nameof(ReferralRequestRecipientId), "Referral Request Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RecipientType { get; private set; }
        public VocabularyKey ReferralRequestRecipientId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}