using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceContractDetailVocabulary : SimpleVocabulary
    {
        public ServiceContractDetailVocabulary()
        {
            VocabularyName = "Service Contract Detail";
            KeyPrefix = "commonDataModel.servicecontractdetail.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceContractDetail";

            AddGroup("ServiceContractDetail Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualRevenue = group.Add(new VocabularyKey(nameof(ActualRevenue), "Actual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualRevenueBase = group.Add(new VocabularyKey(nameof(ActualRevenueBase), "Actual Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CommissionAmount = group.Add(new VocabularyKey(nameof(CommissionAmount), "Commission Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CommissionAmountBase = group.Add(new VocabularyKey(nameof(CommissionAmountBase), "Commission Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerPrice = group.Add(new VocabularyKey(nameof(CustomerPrice), "Customer Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerPriceBase = group.Add(new VocabularyKey(nameof(CustomerPriceBase), "Customer Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedCost = group.Add(new VocabularyKey(nameof(EstimatedCost), "Estimated Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedCostBase = group.Add(new VocabularyKey(nameof(EstimatedCostBase), "Estimated Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedRevenue = group.Add(new VocabularyKey(nameof(EstimatedRevenue), "Estimated Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedRevenueBase = group.Add(new VocabularyKey(nameof(EstimatedRevenueBase), "Estimated Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RetailPrice = group.Add(new VocabularyKey(nameof(RetailPrice), "Retail Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RetailPriceBase = group.Add(new VocabularyKey(nameof(RetailPriceBase), "Retail Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ServiceContractDetailId = group.Add(new VocabularyKey(nameof(ServiceContractDetailId), "Service Contract Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey ActualRevenue { get; private set; }
        public VocabularyKey ActualRevenueBase { get; private set; }
        public VocabularyKey CommissionAmount { get; private set; }
        public VocabularyKey CommissionAmountBase { get; private set; }
        public VocabularyKey CustomerPrice { get; private set; }
        public VocabularyKey CustomerPriceBase { get; private set; }
        public VocabularyKey EstimatedCost { get; private set; }
        public VocabularyKey EstimatedCostBase { get; private set; }
        public VocabularyKey EstimatedRevenue { get; private set; }
        public VocabularyKey EstimatedRevenueBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RetailPrice { get; private set; }
        public VocabularyKey RetailPriceBase { get; private set; }
        public VocabularyKey ServiceContractDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}