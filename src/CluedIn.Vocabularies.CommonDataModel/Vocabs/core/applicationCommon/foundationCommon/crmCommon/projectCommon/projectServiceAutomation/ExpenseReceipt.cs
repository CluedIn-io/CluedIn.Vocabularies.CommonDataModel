using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ExpenseReceiptVocabulary : SimpleVocabulary
    {
        public ExpenseReceiptVocabulary()
        {
            VocabularyName = "Expense Receipt";
            KeyPrefix = "commonDataModel.expensereceipt.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ExpenseReceipt";

            AddGroup("ExpenseReceipt Details for ProjectServiceAutomation", group =>
            {
			    ExpenseReceiptId = group.Add(new VocabularyKey(nameof(ExpenseReceiptId), "Expense Receipt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExpenseReceiptId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}