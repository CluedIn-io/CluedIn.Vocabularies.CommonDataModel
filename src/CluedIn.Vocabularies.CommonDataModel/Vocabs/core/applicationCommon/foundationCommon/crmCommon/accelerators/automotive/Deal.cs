using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DealVocabulary : SimpleVocabulary
    {
        public DealVocabulary()
        {
            VocabularyName = "Deal";
            KeyPrefix = "commonDataModel.deal.automotive";
            KeySeparator = ".";
            Grouping = "/Deal";

            AddGroup("Deal Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualRevenue = group.Add(new VocabularyKey(nameof(ActualRevenue), "Actual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Actualrevenue_Base = group.Add(new VocabularyKey(nameof(Actualrevenue_Base), "Actual Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CommissionAmount = group.Add(new VocabularyKey(nameof(CommissionAmount), "Commission Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CommissionAmountBase = group.Add(new VocabularyKey(nameof(CommissionAmountBase), "Commission Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DealId = group.Add(new VocabularyKey(nameof(DealId), "Deal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DealNumber = group.Add(new VocabularyKey(nameof(DealNumber), "Deal Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DealStatus = group.Add(new VocabularyKey(nameof(DealStatus), "Deal Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedCost = group.Add(new VocabularyKey(nameof(EstimatedCost), "Estimated Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedCostBase = group.Add(new VocabularyKey(nameof(EstimatedCostBase), "Estimated Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedRevenue = group.Add(new VocabularyKey(nameof(EstimatedRevenue), "Estimated Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedRevenueBase = group.Add(new VocabularyKey(nameof(EstimatedRevenueBase), "Estimated Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey ActualRevenue { get; private set; }
        public VocabularyKey Actualrevenue_Base { get; private set; }
        public VocabularyKey CommissionAmount { get; private set; }
        public VocabularyKey CommissionAmountBase { get; private set; }
        public VocabularyKey DealId { get; private set; }
        public VocabularyKey DealNumber { get; private set; }
        public VocabularyKey DealStatus { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EstimatedCost { get; private set; }
        public VocabularyKey EstimatedCostBase { get; private set; }
        public VocabularyKey EstimatedRevenue { get; private set; }
        public VocabularyKey EstimatedRevenueBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}