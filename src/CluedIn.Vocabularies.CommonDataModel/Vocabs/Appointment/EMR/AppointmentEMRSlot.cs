using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRSlotVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSlotVocabulary()
        {
            VocabularyName = "Appointment EMR Slot";
            KeyPrefix = "commonDataModel.appointmentemrslot";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSlot";

            AddGroup("AppointmentEMRSlot Details", group =>
            {
                AppointmentEMRSlotId = group.Add(new VocabularyKey(nameof(AppointmentEMRSlotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRSlotId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}