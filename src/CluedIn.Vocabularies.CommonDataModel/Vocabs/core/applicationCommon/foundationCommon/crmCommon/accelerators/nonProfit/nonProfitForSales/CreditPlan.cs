using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class CreditPlanVocabulary : SimpleVocabulary
    {
        public CreditPlanVocabulary()
        {
            VocabularyName = "Credit Plan";
            KeyPrefix = "commonDataModel.creditplan.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/CreditPlan";

            AddGroup("CreditPlan Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}