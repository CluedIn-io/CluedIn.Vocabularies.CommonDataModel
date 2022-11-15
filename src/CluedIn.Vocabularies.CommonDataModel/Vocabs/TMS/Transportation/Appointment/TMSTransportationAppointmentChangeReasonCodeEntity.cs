using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAppointmentChangeReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAppointmentChangeReasonCodeEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Appointment Change Reason Code Entity";
            KeyPrefix = "commonDataModel.tmstransportationappointmentchangereasoncodeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAppointmentChangeReasonCodeEntity";

            AddGroup("TMSTransportationAppointmentChangeReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}