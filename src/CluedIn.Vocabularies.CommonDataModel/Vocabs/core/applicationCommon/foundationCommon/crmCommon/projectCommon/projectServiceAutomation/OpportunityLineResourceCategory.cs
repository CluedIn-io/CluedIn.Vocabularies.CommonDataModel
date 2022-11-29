using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityLineResourceCategoryVocabulary : SimpleVocabulary
    {
        public OpportunityLineResourceCategoryVocabulary()
        {
            VocabularyName = "Opportunity Line Resource Category";
            KeyPrefix = "commonDataModel.opportunitylineresourcecategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OpportunityLineResourceCategory";

            AddGroup("OpportunityLineResourceCategory Details for ProjectServiceAutomation", group =>
            {
			    OpportunityLineResourceCategoryId = group.Add(new VocabularyKey(nameof(OpportunityLineResourceCategoryId), "Opportunity Line Resource Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpportunityLineResourceCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
    }
}