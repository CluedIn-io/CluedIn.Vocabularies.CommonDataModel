using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class BodySiteVocabulary : SimpleVocabulary
    {
        public BodySiteVocabulary()
        {
            VocabularyName = "Body Site";
            KeyPrefix = "commonDataModel.bodysite.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/BodySite";

            AddGroup("BodySite Details for ElectronicMedicalRecords", group =>
            {
			    BodySiteId = group.Add(new VocabularyKey(nameof(BodySiteId), "Body Site", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BodySiteId { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}