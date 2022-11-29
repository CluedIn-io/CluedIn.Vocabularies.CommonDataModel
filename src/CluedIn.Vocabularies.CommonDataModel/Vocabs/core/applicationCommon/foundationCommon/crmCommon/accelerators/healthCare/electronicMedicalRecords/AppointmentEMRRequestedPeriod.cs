using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRRequestedPeriodVocabulary : SimpleVocabulary
    {
        public AppointmentEMRRequestedPeriodVocabulary()
        {
            VocabularyName = "Appointment EMR Requested Period";
            KeyPrefix = "commonDataModel.appointmentemrrequestedperiod.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRRequestedPeriod";

            AddGroup("AppointmentEMRRequestedPeriod Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRRequestedPeriodId = group.Add(new VocabularyKey(nameof(AppointmentEMRRequestedPeriodId), "Appointment (EMR) Requested Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedPeriodEndDate = group.Add(new VocabularyKey(nameof(RequestedPeriodEndDate), "Requested Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedPeriodStartDate = group.Add(new VocabularyKey(nameof(RequestedPeriodStartDate), "Requested Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRRequestedPeriodId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestedPeriodEndDate { get; private set; }
        public VocabularyKey RequestedPeriodStartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}