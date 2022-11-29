using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureComplicationDetailVocabulary : SimpleVocabulary
    {
        public ProcedureComplicationDetailVocabulary()
        {
            VocabularyName = "Procedure Complication Detail";
            KeyPrefix = "commonDataModel.procedurecomplicationdetail.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureComplicationDetail";

            AddGroup("ProcedureComplicationDetail Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureComplicationDetailId = group.Add(new VocabularyKey(nameof(ProcedureComplicationDetailId), "Procedure Complication Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureComplicationDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}