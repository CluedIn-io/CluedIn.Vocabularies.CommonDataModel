using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRSlotVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSlotVocabulary()
        {
            VocabularyName = "Appointment EMR Slot";
            KeyPrefix = "commonDataModel.appointmentemrslot.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSlot";

            AddGroup("AppointmentEMRSlot Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRSlotId = group.Add(new VocabularyKey(nameof(AppointmentEMRSlotId), "Appointment (EMR) Slot", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentEMRSlotId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}