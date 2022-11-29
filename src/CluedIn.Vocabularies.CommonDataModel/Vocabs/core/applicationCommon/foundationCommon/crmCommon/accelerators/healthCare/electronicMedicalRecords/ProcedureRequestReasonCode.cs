using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestReasonCodeVocabulary : SimpleVocabulary
    {
        public ProcedureRequestReasonCodeVocabulary()
        {
            VocabularyName = "Procedure Request Reason Code";
            KeyPrefix = "commonDataModel.procedurerequestreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestReasonCode";

            AddGroup("ProcedureRequestReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestReasonCodeId = group.Add(new VocabularyKey(nameof(ProcedureRequestReasonCodeId), "Procedure Request Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestReasonCodeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}