using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class OrderVocabulary : SimpleVocabulary
    {
        public OrderVocabulary()
        {
            VocabularyName = "Order";
            KeyPrefix = "commonDataModel.order.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Order";

            AddGroup("Order Details for ProjectServiceAutomation", group =>
            {
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Order Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PSAState = group.Add(new VocabularyKey(nameof(PSAState), "Contract Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PSAStatusReason = group.Add(new VocabularyKey(nameof(PSAStatusReason), "Contract Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollup), "Total Chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollupBase), "Total Chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollup), "Total Non-chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollupBase), "Total Non-chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey PSAState { get; private set; }
        public VocabularyKey PSAStatusReason { get; private set; }
        public VocabularyKey TotalChargeableCostRollup { get; private set; }
        public VocabularyKey TotalChargeableCostRollupBase { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollup { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollupBase { get; private set; }
    }
}