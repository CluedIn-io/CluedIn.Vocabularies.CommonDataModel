using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedurePerformerVocabulary : SimpleVocabulary
    {
        public ProcedurePerformerVocabulary()
        {
            VocabularyName = "Procedure Performer";
            KeyPrefix = "commonDataModel.procedureperformer.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedurePerformer";

            AddGroup("ProcedurePerformer Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformerType = group.Add(new VocabularyKey(nameof(PerformerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedurePerformerId = group.Add(new VocabularyKey(nameof(ProcedurePerformerId), "Procedure Performer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PerformerType { get; private set; }
        public VocabularyKey ProcedurePerformerId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}