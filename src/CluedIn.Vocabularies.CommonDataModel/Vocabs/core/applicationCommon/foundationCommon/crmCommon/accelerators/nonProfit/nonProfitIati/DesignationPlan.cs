using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DesignationPlanVocabulary : SimpleVocabulary
    {
        public DesignationPlanVocabulary()
        {
            VocabularyName = "Designation Plan";
            KeyPrefix = "commonDataModel.designationplan.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DesignationPlan";

            AddGroup("DesignationPlan Details for NonProfitIati", group =>
            {
			                 
            });
        }

        
    }
}