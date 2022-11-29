using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OpportunityProductVocabulary : SimpleVocabulary
    {
        public OpportunityProductVocabulary()
        {
            VocabularyName = "Opportunity Product";
            KeyPrefix = "commonDataModel.opportunityproduct.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/OpportunityProduct";

            AddGroup("OpportunityProduct Details for ProjectServiceAutomation", group =>
            {
			    BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Budget Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnit = group.Add(new VocabularyKey(nameof(CostPricePerUnit), "Cost Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnitBase = group.Add(new VocabularyKey(nameof(CostPricePerUnitBase), "Cost Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LineType = group.Add(new VocabularyKey(nameof(LineType), "Line Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey CostPricePerUnit { get; private set; }
        public VocabularyKey CostPricePerUnitBase { get; private set; }
        public VocabularyKey LineType { get; private set; }
    }
}