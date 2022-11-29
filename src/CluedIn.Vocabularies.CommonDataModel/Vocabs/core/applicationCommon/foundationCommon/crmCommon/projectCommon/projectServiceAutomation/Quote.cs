using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteVocabulary : SimpleVocabulary
    {
        public QuoteVocabulary()
        {
            VocabularyName = "Quote";
            KeyPrefix = "commonDataModel.quote.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Quote";

            AddGroup("Quote Details for ProjectServiceAutomation", group =>
            {
			    Feasible = group.Add(new VocabularyKey(nameof(Feasible), "Feasibility", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustedGrossMargin = group.Add(new VocabularyKey(nameof(AdjustedGrossMargin), "Adjusted Gross Margin (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Competitive = group.Add(new VocabularyKey(nameof(Competitive), "Competitive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerBudgetRollUp = group.Add(new VocabularyKey(nameof(CustomerBudgetRollUp), "Customer Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerBudgetRollupBase = group.Add(new VocabularyKey(nameof(CustomerBudgetRollupBase), "Customer Budget (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedBudget = group.Add(new VocabularyKey(nameof(EstimatedBudget), "Estimated Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedCompletionRollUp = group.Add(new VocabularyKey(nameof(EstimatedCompletionRollUp), "Estimated Completion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedSchedule = group.Add(new VocabularyKey(nameof(EstimatedSchedule), "Estimated Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GrossMargin = group.Add(new VocabularyKey(nameof(GrossMargin), "Gross Margin (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Profitability = group.Add(new VocabularyKey(nameof(Profitability), "Profitability", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollup), "Total Chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollupBase), "Total Chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollup), "Total Non-chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollupBase), "Total Non-chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Feasible { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey AdjustedGrossMargin { get; private set; }
        public VocabularyKey Competitive { get; private set; }
        public VocabularyKey CustomerBudgetRollUp { get; private set; }
        public VocabularyKey CustomerBudgetRollupBase { get; private set; }
        public VocabularyKey EstimatedBudget { get; private set; }
        public VocabularyKey EstimatedCompletionRollUp { get; private set; }
        public VocabularyKey EstimatedSchedule { get; private set; }
        public VocabularyKey GrossMargin { get; private set; }
        public VocabularyKey Profitability { get; private set; }
        public VocabularyKey TotalChargeableCostRollup { get; private set; }
        public VocabularyKey TotalChargeableCostRollupBase { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollup { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollupBase { get; private set; }
    }
}