using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceAppointmentTypeVocabulary : SimpleVocabulary
    {
        public ServiceAppointmentTypeVocabulary()
        {
            VocabularyName = "Service Appointment Type";
            KeyPrefix = "commonDataModel.serviceappointmenttype.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceAppointmentType";

            AddGroup("ServiceAppointmentType Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceAppointmentTypeId = group.Add(new VocabularyKey(nameof(ServiceAppointmentTypeId), "Service Appointment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ServiceAppointmentTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}