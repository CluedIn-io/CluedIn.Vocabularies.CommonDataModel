using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class RequestVocabulary : SimpleVocabulary
    {
        public RequestVocabulary()
        {
            VocabularyName = "Request";
            KeyPrefix = "commonDataModel.request.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Request";

            AddGroup("Request Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}