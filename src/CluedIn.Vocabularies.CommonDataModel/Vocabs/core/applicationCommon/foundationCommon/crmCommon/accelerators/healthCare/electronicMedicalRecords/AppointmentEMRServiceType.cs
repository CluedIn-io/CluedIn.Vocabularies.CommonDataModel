using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRServiceTypeVocabulary : SimpleVocabulary
    {
        public AppointmentEMRServiceTypeVocabulary()
        {
            VocabularyName = "Appointment EMR Service Type";
            KeyPrefix = "commonDataModel.appointmentemrservicetype.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRServiceType";

            AddGroup("AppointmentEMRServiceType Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRServiceTypeId = group.Add(new VocabularyKey(nameof(AppointmentEMRServiceTypeId), "Appointment (EMR) Service Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRServiceTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}