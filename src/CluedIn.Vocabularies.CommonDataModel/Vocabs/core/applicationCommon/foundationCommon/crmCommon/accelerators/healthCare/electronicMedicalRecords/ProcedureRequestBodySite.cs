using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestBodySiteVocabulary : SimpleVocabulary
    {
        public ProcedureRequestBodySiteVocabulary()
        {
            VocabularyName = "Procedure Request Body Site";
            KeyPrefix = "commonDataModel.procedurerequestbodysite.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestBodySite";

            AddGroup("ProcedureRequestBodySite Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestBodySiteId = group.Add(new VocabularyKey(nameof(ProcedureRequestBodySiteId), "Procedure Request Body Site", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestBodySiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}