using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class PriceListItemVocabulary : SimpleVocabulary
    {
        public PriceListItemVocabulary()
        {
            VocabularyName = "Price List Item";
            KeyPrefix = "commonDataModel.pricelistitem.sales";
            KeySeparator = ".";
            Grouping = "/PriceListItem";

            AddGroup("PriceListItem Details for Sales", group =>
            {
			                 
            });
        }

        
    }
}