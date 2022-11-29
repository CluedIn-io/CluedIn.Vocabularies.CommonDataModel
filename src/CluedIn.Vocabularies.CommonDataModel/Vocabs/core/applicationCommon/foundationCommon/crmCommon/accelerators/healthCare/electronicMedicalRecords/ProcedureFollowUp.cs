using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureFollowUpVocabulary : SimpleVocabulary
    {
        public ProcedureFollowUpVocabulary()
        {
            VocabularyName = "Procedure Follow Up";
            KeyPrefix = "commonDataModel.procedurefollowup.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureFollowUp";

            AddGroup("ProcedureFollowUp Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureFollowUpId = group.Add(new VocabularyKey(nameof(ProcedureFollowUpId), "Procedure Follow Up", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureFollowUpId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}