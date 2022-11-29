using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class PriceListVocabulary : SimpleVocabulary
    {
        public PriceListVocabulary()
        {
            VocabularyName = "Price List";
            KeyPrefix = "commonDataModel.pricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/PriceList";

            AddGroup("PriceList Details for ProjectServiceAutomation", group =>
            {
			    Entity = group.Add(new VocabularyKey(nameof(Entity), "Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Module = group.Add(new VocabularyKey(nameof(Module), "Context", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Entity { get; private set; }
        public VocabularyKey Module { get; private set; }
    }
}