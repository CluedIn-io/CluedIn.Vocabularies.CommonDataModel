using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRReasonVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReasonVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRReason";
            KeyPrefix = "commonDataModel.appointmentemrreason";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReason";

            AddGroup("Common Data Model AppointmentEMRReason Details", group =>
            {
                appointmentEMRReasonId = group.Add(new VocabularyKey(nameof(appointmentEMRReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRReasonId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}