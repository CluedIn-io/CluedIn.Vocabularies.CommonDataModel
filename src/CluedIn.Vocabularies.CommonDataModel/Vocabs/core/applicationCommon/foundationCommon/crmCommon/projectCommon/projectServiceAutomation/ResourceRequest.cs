using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ResourceRequestVocabulary : SimpleVocabulary
    {
        public ResourceRequestVocabulary()
        {
            VocabularyName = "Resource Request";
            KeyPrefix = "commonDataModel.resourcerequest.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ResourceRequest";

            AddGroup("ResourceRequest Details for ProjectServiceAutomation", group =>
            {
			    ResourceRequestId = group.Add(new VocabularyKey(nameof(ResourceRequestId), "Resource Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PositionDescription = group.Add(new VocabularyKey(nameof(PositionDescription), "Position Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceRequestId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey PositionDescription { get; private set; }
    }
}