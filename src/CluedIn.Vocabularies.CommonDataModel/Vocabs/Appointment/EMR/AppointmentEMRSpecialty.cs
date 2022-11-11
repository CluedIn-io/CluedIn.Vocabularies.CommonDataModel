using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRSpecialtyVocabulary : SimpleVocabulary
    {
        public AppointmentEMRSpecialtyVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRSpecialty";
            KeyPrefix = "commonDataModel.appointmentemrspecialty";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRSpecialty";

            AddGroup("Common Data Model AppointmentEMRSpecialty Details", group =>
            {
                appointmentEMRSpecialtyId = group.Add(new VocabularyKey(nameof(appointmentEMRSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRSpecialtyId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}