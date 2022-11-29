using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class ProductVocabulary : SimpleVocabulary
    {
        public ProductVocabulary()
        {
            VocabularyName = "Product";
            KeyPrefix = "commonDataModel.product.banking";
            KeySeparator = ".";
            Grouping = "/Product";

            AddGroup("Product Details for Banking", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}