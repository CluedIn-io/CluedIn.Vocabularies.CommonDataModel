using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestCategoryVocabulary : SimpleVocabulary
    {
        public ProcedureRequestCategoryVocabulary()
        {
            VocabularyName = "Procedure Request Category";
            KeyPrefix = "commonDataModel.procedurerequestcategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestCategory";

            AddGroup("ProcedureRequestCategory Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestCategoryId = group.Add(new VocabularyKey(nameof(ProcedureRequestCategoryId), "Procedure Request Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}