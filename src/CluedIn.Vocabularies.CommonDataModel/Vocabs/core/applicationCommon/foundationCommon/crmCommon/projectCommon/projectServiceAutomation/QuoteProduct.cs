using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteProductVocabulary : SimpleVocabulary
    {
        public QuoteProductVocabulary()
        {
            VocabularyName = "Quote Product";
            KeyPrefix = "commonDataModel.quoteproduct.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuoteProduct";

            AddGroup("QuoteProduct Details for ProjectServiceAutomation", group =>
            {
			    BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingStartDate = group.Add(new VocabularyKey(nameof(BillingStartDate), "Billing Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Customer Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "CostAmount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnit = group.Add(new VocabularyKey(nameof(CostPricePerUnit), "Cost Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnitBase = group.Add(new VocabularyKey(nameof(CostPricePerUnitBase), "Cost Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IncludeExpense = group.Add(new VocabularyKey(nameof(IncludeExpense), "Include Expense", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeFee = group.Add(new VocabularyKey(nameof(IncludeFee), "Include Fee", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeMaterial = group.Add(new VocabularyKey(nameof(IncludeMaterial), "Include Material", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeTime = group.Add(new VocabularyKey(nameof(IncludeTime), "Include Time", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LineType = group.Add(new VocabularyKey(nameof(LineType), "Line Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityLine = group.Add(new VocabularyKey(nameof(OpportunityLine), "Opportunity Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuoteLineDescription = group.Add(new VocabularyKey(nameof(QuoteLineDescription), "Quote Line Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey BillingStartDate { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey CostPricePerUnit { get; private set; }
        public VocabularyKey CostPricePerUnitBase { get; private set; }
        public VocabularyKey IncludeExpense { get; private set; }
        public VocabularyKey IncludeFee { get; private set; }
        public VocabularyKey IncludeMaterial { get; private set; }
        public VocabularyKey IncludeTime { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey OpportunityLine { get; private set; }
        public VocabularyKey QuoteLineDescription { get; private set; }
    }
}