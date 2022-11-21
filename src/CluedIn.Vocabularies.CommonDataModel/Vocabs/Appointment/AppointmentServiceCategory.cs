using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentServiceCategoryVocabulary : SimpleVocabulary
    {
        public AppointmentServiceCategoryVocabulary()
        {
            VocabularyName = "Appointment Service Category";
            KeyPrefix = "commonDataModel.appointmentservicecategory";
            KeySeparator = ".";
            Grouping = "/AppointmentServiceCategory";

            AddGroup("AppointmentServiceCategory Details", group =>
            {
                AppointmentServiceCategoryId = group.Add(new VocabularyKey(nameof(AppointmentServiceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentServiceCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}