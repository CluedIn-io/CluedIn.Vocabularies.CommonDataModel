using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureVocabulary : SimpleVocabulary
    {
        public ProcedureVocabulary()
        {
            VocabularyName = "Procedure";
            KeyPrefix = "commonDataModel.procedure.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Procedure";

            AddGroup("Procedure Details for ElectronicMedicalRecords", group =>
            {
			    DateTime = group.Add(new VocabularyKey(nameof(DateTime), "Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotDone = group.Add(new VocabularyKey(nameof(NotDone), "Not Done", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PerformedEndDate = group.Add(new VocabularyKey(nameof(PerformedEndDate), "Performed End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformedStartDate = group.Add(new VocabularyKey(nameof(PerformedStartDate), "Performed Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureId = group.Add(new VocabularyKey(nameof(ProcedureId), "Procedure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureIdentifier = group.Add(new VocabularyKey(nameof(ProcedureIdentifier), "Procedure ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DateTime { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NotDone { get; private set; }
        public VocabularyKey PerformedEndDate { get; private set; }
        public VocabularyKey PerformedStartDate { get; private set; }
        public VocabularyKey ProcedureId { get; private set; }
        public VocabularyKey ProcedureIdentifier { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}