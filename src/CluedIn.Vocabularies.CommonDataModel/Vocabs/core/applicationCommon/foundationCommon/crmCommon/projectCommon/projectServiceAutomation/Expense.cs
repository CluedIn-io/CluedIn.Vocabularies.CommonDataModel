using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ExpenseVocabulary : SimpleVocabulary
    {
        public ExpenseVocabulary()
        {
            VocabularyName = "Expense";
            KeyPrefix = "commonDataModel.expense.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Expense";

            AddGroup("Expense Details for ProjectServiceAutomation", group =>
            {
			    ExpenseId = group.Add(new VocabularyKey(nameof(ExpenseId), "Expense", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpensePurpose = group.Add(new VocabularyKey(nameof(ExpensePurpose), "Expense Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpenseStatus = group.Add(new VocabularyKey(nameof(ExpenseStatus), "Expense Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalComments = group.Add(new VocabularyKey(nameof(ExternalComments), "External Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesTaxAmount = group.Add(new VocabularyKey(nameof(SalesTaxAmount), "Sales tax amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesTaxAmountBase = group.Add(new VocabularyKey(nameof(SalesTaxAmountBase), "Sales tax amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetExpenseStatus = group.Add(new VocabularyKey(nameof(TargetExpenseStatus), "Target Expense Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), "Transaction Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExpenseId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExpensePurpose { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey ExpenseStatus { get; private set; }
        public VocabularyKey ExternalComments { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SalesTaxAmount { get; private set; }
        public VocabularyKey SalesTaxAmountBase { get; private set; }
        public VocabularyKey TargetExpenseStatus { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
    }
}