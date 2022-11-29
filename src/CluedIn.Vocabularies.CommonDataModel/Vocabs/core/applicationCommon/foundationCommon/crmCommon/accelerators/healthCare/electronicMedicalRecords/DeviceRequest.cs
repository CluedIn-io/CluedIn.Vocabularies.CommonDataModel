using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestVocabulary : SimpleVocabulary
    {
        public DeviceRequestVocabulary()
        {
            VocabularyName = "Device Request";
            KeyPrefix = "commonDataModel.devicerequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequest";

            AddGroup("DeviceRequest Details for ElectronicMedicalRecords", group =>
            {
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeType = group.Add(new VocabularyKey(nameof(CodeType), "Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceRequestId = group.Add(new VocabularyKey(nameof(DeviceRequestId), "Device Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceRequestNumber = group.Add(new VocabularyKey(nameof(DeviceRequestNumber), "Device Request Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupNumber = group.Add(new VocabularyKey(nameof(GroupNumber), "Group Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrencePeriodEndDate = group.Add(new VocabularyKey(nameof(OccurrencePeriodEndDate), "Occurrence Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrencePeriodStartDate = group.Add(new VocabularyKey(nameof(OccurrencePeriodStartDate), "Occurrence Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceTypeDateTime = group.Add(new VocabularyKey(nameof(OccurrenceTypeDateTime), "Occurrence Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerfomerType = group.Add(new VocabularyKey(nameof(PerfomerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgentType = group.Add(new VocabularyKey(nameof(RequesterAgentType), "Agent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey CodeType { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey DeviceRequestId { get; private set; }
        public VocabularyKey DeviceRequestNumber { get; private set; }
        public VocabularyKey GroupNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OccurrencePeriodEndDate { get; private set; }
        public VocabularyKey OccurrencePeriodStartDate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey OccurrenceTypeDateTime { get; private set; }
        public VocabularyKey PerfomerType { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey RequesterAgentType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}