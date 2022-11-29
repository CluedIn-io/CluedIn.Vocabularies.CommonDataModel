using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OrderLineTransactionCategoryVocabulary : SimpleVocabulary
    {
        public OrderLineTransactionCategoryVocabulary()
        {
            VocabularyName = "Order Line Transaction Category";
            KeyPrefix = "commonDataModel.orderlinetransactioncategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OrderLineTransactionCategory";

            AddGroup("OrderLineTransactionCategory Details for ProjectServiceAutomation", group =>
            {
			    OrderLineTransactionCategoryId = group.Add(new VocabularyKey(nameof(OrderLineTransactionCategoryId), "Project Contract Line Transaction Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderLineTransactionCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}