using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestRelevantHistoryVocabulary : SimpleVocabulary
    {
        public ProcedureRequestRelevantHistoryVocabulary()
        {
            VocabularyName = "Procedure Request Relevant History";
            KeyPrefix = "commonDataModel.procedurerequestrelevanthistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestRelevantHistory";

            AddGroup("ProcedureRequestRelevantHistory Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestRelevantHistoryId = group.Add(new VocabularyKey(nameof(ProcedureRequestRelevantHistoryId), "Procedure Request Relevant History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestRelevantHistoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}