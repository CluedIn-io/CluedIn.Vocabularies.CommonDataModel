using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRSpecialtyVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSpecialtyVocabulary()
        {
            VocabularyName = "Appointment EMR Specialty";
            KeyPrefix = "commonDataModel.appointmentemrspecialty";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSpecialty";

            AddGroup("AppointmentEMRSpecialty Details", group =>
            {
                AppointmentEMRSpecialtyId = group.Add(new VocabularyKey(nameof(AppointmentEMRSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRSpecialtyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}