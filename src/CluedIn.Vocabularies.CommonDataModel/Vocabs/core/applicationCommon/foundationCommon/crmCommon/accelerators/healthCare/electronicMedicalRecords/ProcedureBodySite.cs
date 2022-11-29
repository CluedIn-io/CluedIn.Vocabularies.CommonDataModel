using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureBodySiteVocabulary : SimpleVocabulary
    {
        public ProcedureBodySiteVocabulary()
        {
            VocabularyName = "Procedure Body Site";
            KeyPrefix = "commonDataModel.procedurebodysite.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureBodySite";

            AddGroup("ProcedureBodySite Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureBodySiteId = group.Add(new VocabularyKey(nameof(ProcedureBodySiteId), "Procedure Body Site", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureBodySiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}