using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestReplaceVocabulary : SimpleVocabulary
    {
        public ProcedureRequestReplaceVocabulary()
        {
            VocabularyName = "Procedure Request Replace";
            KeyPrefix = "commonDataModel.procedurerequestreplace.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestReplace";

            AddGroup("ProcedureRequestReplace Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestReplaceId = group.Add(new VocabularyKey(nameof(ProcedureRequestReplaceId), "Procedure Request Replace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Replaces = group.Add(new VocabularyKey(nameof(Replaces), "Replaces", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestReplaceId { get; private set; }
        public VocabularyKey Replaces { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}