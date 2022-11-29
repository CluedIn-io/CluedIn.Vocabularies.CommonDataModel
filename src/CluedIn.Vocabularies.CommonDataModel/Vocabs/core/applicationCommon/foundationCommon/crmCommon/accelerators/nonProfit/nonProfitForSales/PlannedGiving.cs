using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class PlannedGivingVocabulary : SimpleVocabulary
    {
        public PlannedGivingVocabulary()
        {
            VocabularyName = "Planned Giving";
            KeyPrefix = "commonDataModel.plannedgiving.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/PlannedGiving";

            AddGroup("PlannedGiving Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}