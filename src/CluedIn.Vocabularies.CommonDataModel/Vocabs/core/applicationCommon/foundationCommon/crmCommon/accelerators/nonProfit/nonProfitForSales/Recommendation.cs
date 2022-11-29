using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class RecommendationVocabulary : SimpleVocabulary
    {
        public RecommendationVocabulary()
        {
            VocabularyName = "Recommendation";
            KeyPrefix = "commonDataModel.recommendation.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Recommendation";

            AddGroup("Recommendation Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}