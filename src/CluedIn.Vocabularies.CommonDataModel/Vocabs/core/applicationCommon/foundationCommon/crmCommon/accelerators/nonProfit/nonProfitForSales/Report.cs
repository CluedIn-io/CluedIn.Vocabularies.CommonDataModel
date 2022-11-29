using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class ReportVocabulary : SimpleVocabulary
    {
        public ReportVocabulary()
        {
            VocabularyName = "Report";
            KeyPrefix = "commonDataModel.report.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Report";

            AddGroup("Report Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}