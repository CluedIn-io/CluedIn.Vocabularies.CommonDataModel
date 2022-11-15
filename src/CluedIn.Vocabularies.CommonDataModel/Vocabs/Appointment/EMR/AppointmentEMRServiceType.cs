using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRServiceTypeVocabulary : SimpleVocabulary
    {
        public AppointmentEMRServiceTypeVocabulary()
        {
            VocabularyName = "Appointment EMR Service Type";
            KeyPrefix = "commonDataModel.appointmentemrservicetype";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRServiceType";

            AddGroup("AppointmentEMRServiceType Details", group =>
            {
                AppointmentEMRServiceTypeId = group.Add(new VocabularyKey(nameof(AppointmentEMRServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRServiceTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}