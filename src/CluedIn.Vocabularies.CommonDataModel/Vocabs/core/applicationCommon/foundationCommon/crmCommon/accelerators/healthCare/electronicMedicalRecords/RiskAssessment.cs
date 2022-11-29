using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RiskAssessmentVocabulary : SimpleVocabulary
    {
        public RiskAssessmentVocabulary()
        {
            VocabularyName = "Risk Assessment";
            KeyPrefix = "commonDataModel.riskassessment.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RiskAssessment";

            AddGroup("RiskAssessment Details for ElectronicMedicalRecords", group =>
            {
			    BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), "Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Basis = group.Add(new VocabularyKey(nameof(Basis), "Basis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Mitigation = group.Add(new VocabularyKey(nameof(Mitigation), "Mitigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occurrencedatetime = group.Add(new VocabularyKey(nameof(Occurrencedatetime), "Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occurrenceenddate = group.Add(new VocabularyKey(nameof(Occurrenceenddate), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occurrencestartdate = group.Add(new VocabularyKey(nameof(Occurrencestartdate), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Parent = group.Add(new VocabularyKey(nameof(Parent), "Parent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformerType = group.Add(new VocabularyKey(nameof(PerformerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reasonentity = group.Add(new VocabularyKey(nameof(Reasonentity), "Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonType = group.Add(new VocabularyKey(nameof(ReasonType), "Reason Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RiskAssessmentId = group.Add(new VocabularyKey(nameof(RiskAssessmentId), "Risk Assessment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RiskAssessmentNumber = group.Add(new VocabularyKey(nameof(RiskAssessmentNumber), "Risk Assessment Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey Basis { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Mitigation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Occurrencedatetime { get; private set; }
        public VocabularyKey Occurrenceenddate { get; private set; }
        public VocabularyKey Occurrencestartdate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey Parent { get; private set; }
        public VocabularyKey PerformerType { get; private set; }
        public VocabularyKey Reasonentity { get; private set; }
        public VocabularyKey ReasonType { get; private set; }
        public VocabularyKey RiskAssessmentId { get; private set; }
        public VocabularyKey RiskAssessmentNumber { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}