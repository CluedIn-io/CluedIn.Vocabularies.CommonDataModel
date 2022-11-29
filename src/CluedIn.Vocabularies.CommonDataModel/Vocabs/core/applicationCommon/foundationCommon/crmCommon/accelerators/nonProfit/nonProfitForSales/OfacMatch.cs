using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class OfacMatchVocabulary : SimpleVocabulary
    {
        public OfacMatchVocabulary()
        {
            VocabularyName = "Ofac Match";
            KeyPrefix = "commonDataModel.ofacmatch.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/OfacMatch";

            AddGroup("OfacMatch Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}