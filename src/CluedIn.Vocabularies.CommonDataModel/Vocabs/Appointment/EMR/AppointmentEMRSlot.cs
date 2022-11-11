using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRSlotVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSlotVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRSlot";
            KeyPrefix = "commonDataModel.appointmentemrslot";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSlot";

            AddGroup("Common Data Model AppointmentEMRSlot Details", group =>
            {
                appointmentEMRSlotId = group.Add(new VocabularyKey(nameof(appointmentEMRSlotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRSlotId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}