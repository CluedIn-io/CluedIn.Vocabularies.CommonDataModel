using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceAppointmentVocabulary : SimpleVocabulary
    {
        public ServiceAppointmentVocabulary()
        {
            VocabularyName = "Service Appointment";
            KeyPrefix = "commonDataModel.serviceappointment.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceAppointment";

            AddGroup("ServiceAppointment Details for Automotive", group =>
            {
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KeyTag = group.Add(new VocabularyKey(nameof(KeyTag), "Key Tag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PromisedOn = group.Add(new VocabularyKey(nameof(PromisedOn), "Promised On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Scheduled End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Scheduled Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceAppointmentId = group.Add(new VocabularyKey(nameof(ServiceAppointmentId), "Service Appointment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey KeyTag { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PromisedOn { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey ServiceAppointmentId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}