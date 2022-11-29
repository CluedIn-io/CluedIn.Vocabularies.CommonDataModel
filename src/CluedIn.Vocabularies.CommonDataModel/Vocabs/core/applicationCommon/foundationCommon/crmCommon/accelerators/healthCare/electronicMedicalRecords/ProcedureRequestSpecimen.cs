using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestSpecimenVocabulary : SimpleVocabulary
    {
        public ProcedureRequestSpecimenVocabulary()
        {
            VocabularyName = "Procedure Request Specimen";
            KeyPrefix = "commonDataModel.procedurerequestspecimen.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestSpecimen";

            AddGroup("ProcedureRequestSpecimen Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestSpecimenId = group.Add(new VocabularyKey(nameof(ProcedureRequestSpecimenId), "Procedure Request Specimen", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestSpecimenId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}