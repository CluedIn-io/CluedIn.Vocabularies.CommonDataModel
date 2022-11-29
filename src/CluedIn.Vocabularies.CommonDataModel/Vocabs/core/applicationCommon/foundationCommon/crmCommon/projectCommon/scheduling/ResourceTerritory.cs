using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class ResourceTerritoryVocabulary : SimpleVocabulary
    {
        public ResourceTerritoryVocabulary()
        {
            VocabularyName = "Resource Territory";
            KeyPrefix = "commonDataModel.resourceterritory.scheduling";
            KeySeparator = ".";
            Grouping = "/ResourceTerritory";

            AddGroup("ResourceTerritory Details for Scheduling", group =>
            {
			    ResourceTerritoryId = group.Add(new VocabularyKey(nameof(ResourceTerritoryId), "Resource Territory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceTerritoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}