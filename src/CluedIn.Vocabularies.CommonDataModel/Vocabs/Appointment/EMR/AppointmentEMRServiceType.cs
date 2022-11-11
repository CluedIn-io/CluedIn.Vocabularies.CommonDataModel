using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRServiceTypeVocabulary : SimpleVocabulary
    {
        public AppointmentEMRServiceTypeVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRServiceType";
            KeyPrefix = "commonDataModel.appointmentemrservicetype";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRServiceType";

            AddGroup("Common Data Model AppointmentEMRServiceType Details", group =>
            {
                appointmentEMRServiceTypeId = group.Add(new VocabularyKey(nameof(appointmentEMRServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRServiceTypeId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}