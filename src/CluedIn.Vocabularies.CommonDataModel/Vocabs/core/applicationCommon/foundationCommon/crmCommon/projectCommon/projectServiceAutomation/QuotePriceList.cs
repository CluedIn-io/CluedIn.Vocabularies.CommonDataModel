using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuotePriceListVocabulary : SimpleVocabulary
    {
        public QuotePriceListVocabulary()
        {
            VocabularyName = "Quote Price List";
            KeyPrefix = "commonDataModel.quotepricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuotePriceList";

            AddGroup("QuotePriceList Details for ProjectServiceAutomation", group =>
            {
			    QuotePriceListId = group.Add(new VocabularyKey(nameof(QuotePriceListId), "Quote Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QuotePriceListId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}