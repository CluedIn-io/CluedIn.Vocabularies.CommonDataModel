using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OrderPriceListVocabulary : SimpleVocabulary
    {
        public OrderPriceListVocabulary()
        {
            VocabularyName = "Order Price List";
            KeyPrefix = "commonDataModel.orderpricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OrderPriceList";

            AddGroup("OrderPriceList Details for ProjectServiceAutomation", group =>
            {
			    OrderPriceListId = group.Add(new VocabularyKey(nameof(OrderPriceListId), "Project Contract Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderPriceListId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}