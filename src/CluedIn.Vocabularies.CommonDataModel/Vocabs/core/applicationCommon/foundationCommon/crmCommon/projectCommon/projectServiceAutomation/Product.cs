using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProductVocabulary : SimpleVocabulary
    {
        public ProductVocabulary()
        {
            VocabularyName = "Product";
            KeyPrefix = "commonDataModel.product.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Product";

            AddGroup("Product Details for ProjectServiceAutomation", group =>
            {
			                 
            });
        }

        
    }
}