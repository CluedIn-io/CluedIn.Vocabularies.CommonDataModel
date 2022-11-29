using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRReferralRequestVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReferralRequestVocabulary()
        {
            VocabularyName = "Appointment EMR Referral Request";
            KeyPrefix = "commonDataModel.appointmentemrreferralrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReferralRequest";

            AddGroup("AppointmentEMRReferralRequest Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRReferralRequestId = group.Add(new VocabularyKey(nameof(AppointmentEMRReferralRequestId), "Appointment EMR Referral Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRReferralRequestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}