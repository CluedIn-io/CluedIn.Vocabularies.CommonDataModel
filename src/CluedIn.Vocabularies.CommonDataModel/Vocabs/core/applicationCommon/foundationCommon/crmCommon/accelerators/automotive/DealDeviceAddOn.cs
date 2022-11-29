using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DealDeviceAddOnVocabulary : SimpleVocabulary
    {
        public DealDeviceAddOnVocabulary()
        {
            VocabularyName = "Deal Device Add On";
            KeyPrefix = "commonDataModel.dealdeviceaddon.automotive";
            KeySeparator = ".";
            Grouping = "/DealDeviceAddOn";

            AddGroup("DealDeviceAddOn Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerPrice = group.Add(new VocabularyKey(nameof(CustomerPrice), "Customer Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerPriceBase = group.Add(new VocabularyKey(nameof(CustomerPriceBase), "Customer Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DealDeviceAddOnId = group.Add(new VocabularyKey(nameof(DealDeviceAddOnId), "Deal Device Add On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), "Item Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RetailPrice = group.Add(new VocabularyKey(nameof(RetailPrice), "Retail Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RetailPriceBase = group.Add(new VocabularyKey(nameof(RetailPriceBase), "Retail Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey CustomerPrice { get; private set; }
        public VocabularyKey CustomerPriceBase { get; private set; }
        public VocabularyKey DealDeviceAddOnId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RetailPrice { get; private set; }
        public VocabularyKey RetailPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}