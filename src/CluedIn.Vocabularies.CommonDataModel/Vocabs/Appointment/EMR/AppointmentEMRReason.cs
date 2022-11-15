using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRReasonVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReasonVocabulary()
        {
            VocabularyName = "Appointment EMR Reason";
            KeyPrefix = "commonDataModel.appointmentemrreason";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReason";

            AddGroup("AppointmentEMRReason Details", group =>
            {
                AppointmentEMRReasonId = group.Add(new VocabularyKey(nameof(AppointmentEMRReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}