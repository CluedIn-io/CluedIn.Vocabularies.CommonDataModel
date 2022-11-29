using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class PassVocabulary : SimpleVocabulary
    {
        public PassVocabulary()
        {
            VocabularyName = "Pass";
            KeyPrefix = "commonDataModel.pass.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Pass";

            AddGroup("Pass Details for EventManagement", group =>
            {
			    PassId = group.Add(new VocabularyKey(nameof(PassId), "Pass", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPerUnit = group.Add(new VocabularyKey(nameof(CostPerUnit), "Cost per unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostPerUnitBase = group.Add(new VocabularyKey(nameof(CostPerUnitBase), "Cost per unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesAllocated = group.Add(new VocabularyKey(nameof(NoOfPassesAllocated), "No of passes allocated", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesSold = group.Add(new VocabularyKey(nameof(NoOfPassesSold), "No of passes sold", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), "Pass Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), "Pass Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesLeft = group.Add(new VocabularyKey(nameof(NoOfPassesLeft), "No of passes left", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), "Total cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalcostBase = group.Add(new VocabularyKey(nameof(TotalcostBase), "Total cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PassId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CostPerUnit { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostPerUnitBase { get; private set; }
        public VocabularyKey NoOfPassesAllocated { get; private set; }
        public VocabularyKey NoOfPassesSold { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
        public VocabularyKey NoOfPassesLeft { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalcostBase { get; private set; }
    }
}