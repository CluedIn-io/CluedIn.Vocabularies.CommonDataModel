using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureUsedCodeVocabulary : SimpleVocabulary
    {
        public ProcedureUsedCodeVocabulary()
        {
            VocabularyName = "Procedure Used Code";
            KeyPrefix = "commonDataModel.procedureusedcode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureUsedCode";

            AddGroup("ProcedureUsedCode Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureUsedCodeId = group.Add(new VocabularyKey(nameof(ProcedureUsedCodeId), "Procedure Used Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureUsedCodeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}