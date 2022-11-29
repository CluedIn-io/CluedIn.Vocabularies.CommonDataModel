using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureBasedOnVocabulary : SimpleVocabulary
    {
        public ProcedureBasedOnVocabulary()
        {
            VocabularyName = "Procedure Based On";
            KeyPrefix = "commonDataModel.procedurebasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureBasedOn";

            AddGroup("ProcedureBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    BasedOnType = group.Add(new VocabularyKey(nameof(BasedOnType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureBasedOnId = group.Add(new VocabularyKey(nameof(ProcedureBasedOnId), "Procedure Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOnType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureBasedOnId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}