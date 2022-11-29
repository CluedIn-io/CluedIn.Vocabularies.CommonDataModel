using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedurePartOfVocabulary : SimpleVocabulary
    {
        public ProcedurePartOfVocabulary()
        {
            VocabularyName = "Procedure Part Of";
            KeyPrefix = "commonDataModel.procedurepartof.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedurePartOf";

            AddGroup("ProcedurePartOf Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfProcedure = group.Add(new VocabularyKey(nameof(PartOfProcedure), "Procedure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfType = group.Add(new VocabularyKey(nameof(PartOfType), "Part Of Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedurePartOfId = group.Add(new VocabularyKey(nameof(ProcedurePartOfId), "Procedure Part Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartOfProcedure { get; private set; }
        public VocabularyKey PartOfType { get; private set; }
        public VocabularyKey ProcedurePartOfId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}