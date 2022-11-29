using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OrderLineTransactionClassificationVocabulary : SimpleVocabulary
    {
        public OrderLineTransactionClassificationVocabulary()
        {
            VocabularyName = "Order Line Transaction Classification";
            KeyPrefix = "commonDataModel.orderlinetransactionclassification.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OrderLineTransactionClassification";

            AddGroup("OrderLineTransactionClassification Details for ProjectServiceAutomation", group =>
            {
			    OrderLineTransactionClassificationId = group.Add(new VocabularyKey(nameof(OrderLineTransactionClassificationId), "Project Contract Line Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Include = group.Add(new VocabularyKey(nameof(Include), "Map for Costs calculation?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderLineTransactionClassificationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}