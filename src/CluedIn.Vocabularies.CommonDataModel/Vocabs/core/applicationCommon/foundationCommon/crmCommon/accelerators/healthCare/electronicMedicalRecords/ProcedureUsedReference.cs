using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureUsedReferenceVocabulary : SimpleVocabulary
    {
        public ProcedureUsedReferenceVocabulary()
        {
            VocabularyName = "Procedure Used Reference";
            KeyPrefix = "commonDataModel.procedureusedreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureUsedReference";

            AddGroup("ProcedureUsedReference Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureUsedReferenceId = group.Add(new VocabularyKey(nameof(ProcedureUsedReferenceId), "Procedure Used Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RefType = group.Add(new VocabularyKey(nameof(RefType), "Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureUsedReferenceId { get; private set; }
        public VocabularyKey RefType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}