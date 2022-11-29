using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestDefinitionVocabulary : SimpleVocabulary
    {
        public ProcedureRequestDefinitionVocabulary()
        {
            VocabularyName = "Procedure Request Definition";
            KeyPrefix = "commonDataModel.procedurerequestdefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestDefinition";

            AddGroup("ProcedureRequestDefinition Details for ElectronicMedicalRecords", group =>
            {
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestDefinitionId = group.Add(new VocabularyKey(nameof(ProcedureRequestDefinitionId), "Procedure Request Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestDefinitionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}