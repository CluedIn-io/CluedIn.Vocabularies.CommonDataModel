using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSDockDoorAppointmentChangeReasonEntityVocabulary : SimpleVocabulary
    {
        public TMSDockDoorAppointmentChangeReasonEntityVocabulary()
        {
            VocabularyName = "TMSDockDoorAppointmentChangeReasonEntity";
            KeyPrefix = "commonDataModel.tmsdockdoorappointmentchangereasonentity";
            KeySeparator = ".";
            Grouping = "/TMSDockDoorAppointmentChangeReasonEntity";

            AddGroup("TMSDockDoorAppointmentChangeReasonEntity Details", group =>
            {
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonDescription { get; private set; }


    }
}