using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ResourceCatalogVocabulary : SimpleVocabulary
    {
        public ResourceCatalogVocabulary()
        {
            VocabularyName = "Resource Catalog";
            KeyPrefix = "commonDataModel.resourcecatalog.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/ResourceCatalog";

            AddGroup("ResourceCatalog Details for NonProfitCore", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResourceCatalogId = group.Add(new VocabularyKey(nameof(ResourceCatalogId), "Resource Catalog", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResourceCatalogType = group.Add(new VocabularyKey(nameof(ResourceCatalogType), "Resource Catalog Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ResourceCatalogId { get; private set; }
        public VocabularyKey ResourceCatalogType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}