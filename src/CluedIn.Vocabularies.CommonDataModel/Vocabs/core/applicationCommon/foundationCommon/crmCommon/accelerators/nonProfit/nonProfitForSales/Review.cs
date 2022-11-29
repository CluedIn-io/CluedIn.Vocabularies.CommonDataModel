using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class ReviewVocabulary : SimpleVocabulary
    {
        public ReviewVocabulary()
        {
            VocabularyName = "Review";
            KeyPrefix = "commonDataModel.review.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Review";

            AddGroup("Review Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}