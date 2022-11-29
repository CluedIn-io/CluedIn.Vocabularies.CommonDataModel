using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestBasedOnVocabulary : SimpleVocabulary
    {
        public ReferralRequestBasedOnVocabulary()
        {
            VocabularyName = "Referral Request Based On";
            KeyPrefix = "commonDataModel.referralrequestbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequestBasedOn";

            AddGroup("ReferralRequestBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    BasedOnType = group.Add(new VocabularyKey(nameof(BasedOnType), "Based on Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestBasedOnId = group.Add(new VocabularyKey(nameof(ReferralRequestBasedOnId), "Referral Request Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOnType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReferralRequestBasedOnId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}