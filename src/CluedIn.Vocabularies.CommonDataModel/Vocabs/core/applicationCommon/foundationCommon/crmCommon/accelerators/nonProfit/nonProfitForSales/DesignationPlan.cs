using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class DesignationPlanVocabulary : SimpleVocabulary
    {
        public DesignationPlanVocabulary()
        {
            VocabularyName = "Designation Plan";
            KeyPrefix = "commonDataModel.designationplan.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/DesignationPlan";

            AddGroup("DesignationPlan Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}