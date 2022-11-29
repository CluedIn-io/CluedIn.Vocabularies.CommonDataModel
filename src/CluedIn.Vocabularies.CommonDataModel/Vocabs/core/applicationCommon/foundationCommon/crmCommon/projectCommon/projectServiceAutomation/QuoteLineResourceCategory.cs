using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteLineResourceCategoryVocabulary : SimpleVocabulary
    {
        public QuoteLineResourceCategoryVocabulary()
        {
            VocabularyName = "Quote Line Resource Category";
            KeyPrefix = "commonDataModel.quotelineresourcecategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuoteLineResourceCategory";

            AddGroup("QuoteLineResourceCategory Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineResourceCategoryId = group.Add(new VocabularyKey(nameof(QuoteLineResourceCategoryId), "Quote Line Resource Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuoteLine = group.Add(new VocabularyKey(nameof(QuoteLine), "(Deprecated) Quote Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QuoteLineResourceCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey QuoteLine { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}