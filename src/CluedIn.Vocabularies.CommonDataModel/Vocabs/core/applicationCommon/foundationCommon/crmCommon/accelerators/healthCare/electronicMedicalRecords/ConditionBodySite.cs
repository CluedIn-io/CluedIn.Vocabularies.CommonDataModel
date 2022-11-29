using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ConditionBodySiteVocabulary : SimpleVocabulary
    {
        public ConditionBodySiteVocabulary()
        {
            VocabularyName = "Condition Body Site";
            KeyPrefix = "commonDataModel.conditionbodysite.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ConditionBodySite";

            AddGroup("ConditionBodySite Details for ElectronicMedicalRecords", group =>
            {
			    ConditionBodySiteId = group.Add(new VocabularyKey(nameof(ConditionBodySiteId), "ConditionBodySite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConditionBodySiteId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}