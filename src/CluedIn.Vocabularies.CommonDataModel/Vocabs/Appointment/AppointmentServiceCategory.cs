using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentServiceCategoryVocabulary : SimpleVocabulary
    {
        public AppointmentServiceCategoryVocabulary()
        {
            VocabularyName = "AppointmentServiceCategory";
            KeyPrefix = "commonDataModel.appointmentservicecategory";
            KeySeparator = ".";
            Grouping = "/AppointmentServiceCategory";

            AddGroup("AppointmentServiceCategory Details", group =>
            {
                appointmentServiceCategoryId = group.Add(new VocabularyKey(nameof(appointmentServiceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentServiceCategoryId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}