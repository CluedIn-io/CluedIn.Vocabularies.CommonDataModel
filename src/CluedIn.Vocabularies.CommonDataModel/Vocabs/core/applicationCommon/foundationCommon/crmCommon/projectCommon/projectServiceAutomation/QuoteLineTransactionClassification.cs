using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteLineTransactionClassificationVocabulary : SimpleVocabulary
    {
        public QuoteLineTransactionClassificationVocabulary()
        {
            VocabularyName = "Quote Line Transaction Classification";
            KeyPrefix = "commonDataModel.quotelinetransactionclassification.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuoteLineTransactionClassification";

            AddGroup("QuoteLineTransactionClassification Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineTransactionClassificationId = group.Add(new VocabularyKey(nameof(QuoteLineTransactionClassificationId), "Quote Line Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Include = group.Add(new VocabularyKey(nameof(Include), "Include", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    QuoteLine = group.Add(new VocabularyKey(nameof(QuoteLine), "(Deprecated) Quote Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QuoteLineTransactionClassificationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey QuoteLine { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}