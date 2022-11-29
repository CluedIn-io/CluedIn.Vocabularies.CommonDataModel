using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityLineTransactionClassificationVocabulary : SimpleVocabulary
    {
        public OpportunityLineTransactionClassificationVocabulary()
        {
            VocabularyName = "Opportunity Line Transaction Classification";
            KeyPrefix = "commonDataModel.opportunitylinetransactionclassification.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OpportunityLineTransactionClassification";

            AddGroup("OpportunityLineTransactionClassification Details for ProjectServiceAutomation", group =>
            {
			    OpportunityLineTransactionClassificatioId = group.Add(new VocabularyKey(nameof(OpportunityLineTransactionClassificatioId), "Opportunity Line Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Include = group.Add(new VocabularyKey(nameof(Include), "Map for Costs calculation?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OpportunityLine = group.Add(new VocabularyKey(nameof(OpportunityLine), "Opportunity Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpportunityLineTransactionClassificatioId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey OpportunityLine { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}