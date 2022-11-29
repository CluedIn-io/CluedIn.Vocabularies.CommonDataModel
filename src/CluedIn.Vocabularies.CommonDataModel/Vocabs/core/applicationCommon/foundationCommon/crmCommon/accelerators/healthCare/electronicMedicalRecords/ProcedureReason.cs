using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureReasonVocabulary : SimpleVocabulary
    {
        public ProcedureReasonVocabulary()
        {
            VocabularyName = "Procedure Reason";
            KeyPrefix = "commonDataModel.procedurereason.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureReason";

            AddGroup("ProcedureReason Details for ElectronicMedicalRecords", group =>
            {
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureReasonId = group.Add(new VocabularyKey(nameof(ProcedureReasonId), "Procedure Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Display { get; private set; }
        public VocabularyKey ProcedureReasonId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}