using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityPriceListVocabulary : SimpleVocabulary
    {
        public OpportunityPriceListVocabulary()
        {
            VocabularyName = "Opportunity Price List";
            KeyPrefix = "commonDataModel.opportunitypricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OpportunityPriceList";

            AddGroup("OpportunityPriceList Details for ProjectServiceAutomation", group =>
            {
			    OpportunityPricelistId = group.Add(new VocabularyKey(nameof(OpportunityPricelistId), "Opportunity Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpportunityPricelistId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}