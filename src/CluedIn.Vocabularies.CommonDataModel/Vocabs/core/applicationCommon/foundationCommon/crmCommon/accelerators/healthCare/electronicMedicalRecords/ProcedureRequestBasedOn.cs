using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestBasedOnVocabulary : SimpleVocabulary
    {
        public ProcedureRequestBasedOnVocabulary()
        {
            VocabularyName = "Procedure Request Based On";
            KeyPrefix = "commonDataModel.procedurerequestbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestBasedOn";

            AddGroup("ProcedureRequestBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), "Based on", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestBasedOnId = group.Add(new VocabularyKey(nameof(ProcedureRequestBasedOnId), "Procedure Request Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestBasedOnId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}