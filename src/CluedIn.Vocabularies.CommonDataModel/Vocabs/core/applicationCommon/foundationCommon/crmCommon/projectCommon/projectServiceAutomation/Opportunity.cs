using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Opportunity";

            AddGroup("Opportunity Details for ProjectServiceAutomation", group =>
            {
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderType { get; private set; }
    }
}