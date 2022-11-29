using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRReasonVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReasonVocabulary()
        {
            VocabularyName = "Appointment EMR Reason";
            KeyPrefix = "commonDataModel.appointmentemrreason.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReason";

            AddGroup("AppointmentEMRReason Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRReasonId = group.Add(new VocabularyKey(nameof(AppointmentEMRReasonId), "Appointment (EMR) Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}