using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRIndicationVocabulary : SimpleVocabulary
    {
        public AppointmentEMRIndicationVocabulary()
        {
            VocabularyName = "Appointment EMR Indication";
            KeyPrefix = "commonDataModel.appointmentemrindication.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRIndication";

            AddGroup("AppointmentEMRIndication Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRIndicationId = group.Add(new VocabularyKey(nameof(AppointmentEMRIndicationId), "Appointment (EMR) Indication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRIndicationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}