using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRSpecialtyVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSpecialtyVocabulary()
        {
            VocabularyName = "Appointment EMR Specialty";
            KeyPrefix = "commonDataModel.appointmentemrspecialty.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSpecialty";

            AddGroup("AppointmentEMRSpecialty Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRSpecialtyId = group.Add(new VocabularyKey(nameof(AppointmentEMRSpecialtyId), "Appointment (EMR) Specialty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Specialty Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRSpecialtyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}