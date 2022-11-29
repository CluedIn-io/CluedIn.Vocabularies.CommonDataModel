using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestVocabulary : SimpleVocabulary
    {
        public CommunicationRequestVocabulary()
        {
            VocabularyName = "Communication Request";
            KeyPrefix = "commonDataModel.communicationrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequest";

            AddGroup("CommunicationRequest Details for ElectronicMedicalRecords", group =>
            {
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommunicationRequestId = group.Add(new VocabularyKey(nameof(CommunicationRequestId), "Communication Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupIdentifier = group.Add(new VocabularyKey(nameof(GroupIdentifier), "Group Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceDate = group.Add(new VocabularyKey(nameof(OccurrenceDate), "Occurrence Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceEndDate = group.Add(new VocabularyKey(nameof(OccurrenceEndDate), "Occurrence End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceStartDate = group.Add(new VocabularyKey(nameof(OccurrenceStartDate), "Occurrence Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgentType = group.Add(new VocabularyKey(nameof(RequesterAgentType), "Requester Agent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SenderType = group.Add(new VocabularyKey(nameof(SenderType), "Sender Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey CommunicationRequestId { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey GroupIdentifier { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OccurrenceDate { get; private set; }
        public VocabularyKey OccurrenceEndDate { get; private set; }
        public VocabularyKey OccurrenceStartDate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey RequesterAgentType { get; private set; }
        public VocabularyKey SenderType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}