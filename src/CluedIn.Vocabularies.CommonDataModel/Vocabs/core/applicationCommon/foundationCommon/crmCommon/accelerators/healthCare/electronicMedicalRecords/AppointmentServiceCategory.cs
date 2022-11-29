using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentServiceCategoryVocabulary : SimpleVocabulary
    {
        public AppointmentServiceCategoryVocabulary()
        {
            VocabularyName = "Appointment Service Category";
            KeyPrefix = "commonDataModel.appointmentservicecategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentServiceCategory";

            AddGroup("AppointmentServiceCategory Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentServiceCategoryId = group.Add(new VocabularyKey(nameof(AppointmentServiceCategoryId), "Appointment Service Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentServiceCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}