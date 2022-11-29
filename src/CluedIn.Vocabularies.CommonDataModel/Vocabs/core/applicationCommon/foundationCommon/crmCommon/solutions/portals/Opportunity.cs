using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.portals";
            KeySeparator = ".";
            Grouping = "/Opportunity";

            AddGroup("Opportunity Details for Portals", group =>
            {
			                 
            });
        }

        
    }
}