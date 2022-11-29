using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestVocabulary : SimpleVocabulary
    {
        public ProcedureRequestVocabulary()
        {
            VocabularyName = "Procedure Request";
            KeyPrefix = "commonDataModel.procedurerequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequest";

            AddGroup("ProcedureRequest Details for ElectronicMedicalRecords", group =>
            {
			    AsNeededBoolean = group.Add(new VocabularyKey(nameof(AsNeededBoolean), "As needed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotPerform = group.Add(new VocabularyKey(nameof(DoNotPerform), "Do not perform", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Intent = group.Add(new VocabularyKey(nameof(Intent), "Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurenceDateTime = group.Add(new VocabularyKey(nameof(OccurenceDateTime), "Occurrence Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurencePeriodEndDate = group.Add(new VocabularyKey(nameof(OccurencePeriodEndDate), "Occurrence End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurencePeriodStartDate = group.Add(new VocabularyKey(nameof(OccurencePeriodStartDate), "Occurrence Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformerType = group.Add(new VocabularyKey(nameof(PerformerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestId = group.Add(new VocabularyKey(nameof(ProcedureRequestId), "Procedure Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestNumber = group.Add(new VocabularyKey(nameof(ProcedureRequestNumber), "Procedure Request Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgent = group.Add(new VocabularyKey(nameof(RequesterAgent), "Requester Agent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Requisition = group.Add(new VocabularyKey(nameof(Requisition), "Requisition Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AsNeededBoolean { get; private set; }
        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey DoNotPerform { get; private set; }
        public VocabularyKey Intent { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OccurenceDateTime { get; private set; }
        public VocabularyKey OccurencePeriodEndDate { get; private set; }
        public VocabularyKey OccurencePeriodStartDate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey PerformerType { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey ProcedureRequestId { get; private set; }
        public VocabularyKey ProcedureRequestNumber { get; private set; }
        public VocabularyKey RequesterAgent { get; private set; }
        public VocabularyKey Requisition { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}