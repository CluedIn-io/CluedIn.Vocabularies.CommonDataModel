using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class PropertyInstanceVocabulary : SimpleVocabulary
    {
        public PropertyInstanceVocabulary()
        {
            VocabularyName = "Property Instance";
            KeyPrefix = "commonDataModel.propertyinstance.sales";
            KeySeparator = ".";
            Grouping = "/PropertyInstance";

            AddGroup("PropertyInstance Details for Sales", group =>
            {
			                 
            });
        }

        
    }
}