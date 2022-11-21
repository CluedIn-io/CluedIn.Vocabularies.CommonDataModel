using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRIndicationVocabulary : SimpleVocabulary
    {
        public AppointmentEMRIndicationVocabulary()
        {
            VocabularyName = "Appointment EMR Indication";
            KeyPrefix = "commonDataModel.appointmentemrindication";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRIndication";

            AddGroup("AppointmentEMRIndication Details", group =>
            {
                AppointmentEMRIndicationId = group.Add(new VocabularyKey(nameof(AppointmentEMRIndicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRIndicationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}