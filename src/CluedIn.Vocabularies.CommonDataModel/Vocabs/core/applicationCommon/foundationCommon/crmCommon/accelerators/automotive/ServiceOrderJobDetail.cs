using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceOrderJobDetailVocabulary : SimpleVocabulary
    {
        public ServiceOrderJobDetailVocabulary()
        {
            VocabularyName = "Service Order Job Detail";
            KeyPrefix = "commonDataModel.serviceorderjobdetail.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceOrderJobDetail";

            AddGroup("ServiceOrderJobDetail Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualQuantity = group.Add(new VocabularyKey(nameof(ActualQuantity), "Actual Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Discount = group.Add(new VocabularyKey(nameof(Discount), "Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DiscountBase = group.Add(new VocabularyKey(nameof(DiscountBase), "Discount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmount = group.Add(new VocabularyKey(nameof(EstimatedAmount), "Estimated Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmountBase = group.Add(new VocabularyKey(nameof(EstimatedAmountBase), "Estimated Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedQuantity = group.Add(new VocabularyKey(nameof(ExpectedQuantity), "Expected Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ItemName = group.Add(new VocabularyKey(nameof(ItemName), "Item Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaySubtype = group.Add(new VocabularyKey(nameof(PaySubtype), "Pay Subtype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PayType = group.Add(new VocabularyKey(nameof(PayType), "Pay Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), "Project Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), "Sales Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesPriceBase = group.Add(new VocabularyKey(nameof(SalesPriceBase), "Sales Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ServiceOrderJobDetailId = group.Add(new VocabularyKey(nameof(ServiceOrderJobDetailId), "Service Order Job Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubcontractorPurchaseOrder = group.Add(new VocabularyKey(nameof(SubcontractorPurchaseOrder), "Subcontractor Purchase Order", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualQuantity { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Discount { get; private set; }
        public VocabularyKey DiscountBase { get; private set; }
        public VocabularyKey EstimatedAmount { get; private set; }
        public VocabularyKey EstimatedAmountBase { get; private set; }
        public VocabularyKey ExpectedQuantity { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaySubtype { get; private set; }
        public VocabularyKey PayType { get; private set; }
        public VocabularyKey ProjectName { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceBase { get; private set; }
        public VocabularyKey ServiceOrderJobDetailId { get; private set; }
        public VocabularyKey SubcontractorPurchaseOrder { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}