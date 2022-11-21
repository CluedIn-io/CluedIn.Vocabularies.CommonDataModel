using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRReferralRequestVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReferralRequestVocabulary()
        {
            VocabularyName = "Appointment EMR Referral Request";
            KeyPrefix = "commonDataModel.appointmentemrreferralrequest";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReferralRequest";

            AddGroup("AppointmentEMRReferralRequest Details", group =>
            {
                AppointmentEMRReferralRequestId = group.Add(new VocabularyKey(nameof(AppointmentEMRReferralRequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRReferralRequestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}