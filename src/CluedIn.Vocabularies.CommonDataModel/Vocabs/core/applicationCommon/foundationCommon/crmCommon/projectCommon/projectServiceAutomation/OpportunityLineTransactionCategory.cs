using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityLineTransactionCategoryVocabulary : SimpleVocabulary
    {
        public OpportunityLineTransactionCategoryVocabulary()
        {
            VocabularyName = "Opportunity Line Transaction Category";
            KeyPrefix = "commonDataModel.opportunitylinetransactioncategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OpportunityLineTransactionCategory";

            AddGroup("OpportunityLineTransactionCategory Details for ProjectServiceAutomation", group =>
            {
			    OpportunityLineTransactionCategoryId = group.Add(new VocabularyKey(nameof(OpportunityLineTransactionCategoryId), "Opportunity Line Transaction Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpportunityLineTransactionCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
    }
}