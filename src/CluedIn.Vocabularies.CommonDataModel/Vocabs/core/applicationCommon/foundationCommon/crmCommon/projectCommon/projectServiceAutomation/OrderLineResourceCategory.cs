using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OrderLineResourceCategoryVocabulary : SimpleVocabulary
    {
        public OrderLineResourceCategoryVocabulary()
        {
            VocabularyName = "Order Line Resource Category";
            KeyPrefix = "commonDataModel.orderlineresourcecategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OrderLineResourceCategory";

            AddGroup("OrderLineResourceCategory Details for ProjectServiceAutomation", group =>
            {
			    OrderLineResourceCategoryId = group.Add(new VocabularyKey(nameof(OrderLineResourceCategoryId), "Project Contract Line Resource Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderLineResourceCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}