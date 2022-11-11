using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRIndicationVocabulary : SimpleVocabulary
    {
        public AppointmentEMRIndicationVocabulary()
        {
            VocabularyName = "AppointmentEMRIndication";
            KeyPrefix = "commonDataModel.appointmentemrindication";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRIndication";

            AddGroup("AppointmentEMRIndication Details", group =>
            {
                appointmentEMRIndicationId = group.Add(new VocabularyKey(nameof(appointmentEMRIndicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRIndicationId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}