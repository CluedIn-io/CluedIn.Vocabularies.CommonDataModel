using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class OpportunityProductVocabulary : SimpleVocabulary
    {
        public OpportunityProductVocabulary()
        {
            VocabularyName = "Opportunity Product";
            KeyPrefix = "commonDataModel.opportunityproduct.sales";
            KeySeparator = ".";
            Grouping = "/OpportunityProduct";

            AddGroup("OpportunityProduct Details for Sales", group =>
            {
			    OpportunityProductId = group.Add(new VocabularyKey(nameof(OpportunityProductId), "Opportunity Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BaseAmount = group.Add(new VocabularyKey(nameof(BaseAmount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BaseAmountBase = group.Add(new VocabularyKey(nameof(BaseAmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtendedAmount = group.Add(new VocabularyKey(nameof(ExtendedAmount), "Extended Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExtendedAmountBase = group.Add(new VocabularyKey(nameof(ExtendedAmountBase), "Extended Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPriceOverridden = group.Add(new VocabularyKey(nameof(IsPriceOverridden), "Price Overridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsProductOverridden = group.Add(new VocabularyKey(nameof(IsProductOverridden), "Select Product", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LineItemNumber = group.Add(new VocabularyKey(nameof(LineItemNumber), "Line Item Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ManualDiscountAmount = group.Add(new VocabularyKey(nameof(ManualDiscountAmount), "Manual Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ManualDiscountAmountBase = group.Add(new VocabularyKey(nameof(ManualDiscountAmountBase), "Manual Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityStateCode = group.Add(new VocabularyKey(nameof(OpportunityStateCode), "Opportunity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductTypeCode = group.Add(new VocabularyKey(nameof(ProductTypeCode), "Product type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PricePerUnit = group.Add(new VocabularyKey(nameof(PricePerUnit), "Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PricePerUnitBase = group.Add(new VocabularyKey(nameof(PricePerUnitBase), "Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), "Write-In Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductName = group.Add(new VocabularyKey(nameof(ProductName), "Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Tax = group.Add(new VocabularyKey(nameof(Tax), "Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VolumeDiscountAmount = group.Add(new VocabularyKey(nameof(VolumeDiscountAmount), "Volume Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    VolumeDiscountAmountBase = group.Add(new VocabularyKey(nameof(VolumeDiscountAmountBase), "Volume Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PropertyConfigurationStatus = group.Add(new VocabularyKey(nameof(PropertyConfigurationStatus), "Property Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OpportunityProductName = group.Add(new VocabularyKey(nameof(OpportunityProductName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpportunityProductId { get; private set; }
        public VocabularyKey BaseAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey BaseAmountBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExtendedAmount { get; private set; }
        public VocabularyKey ExtendedAmountBase { get; private set; }
        public VocabularyKey IsPriceOverridden { get; private set; }
        public VocabularyKey IsProductOverridden { get; private set; }
        public VocabularyKey LineItemNumber { get; private set; }
        public VocabularyKey ManualDiscountAmount { get; private set; }
        public VocabularyKey ManualDiscountAmountBase { get; private set; }
        public VocabularyKey OpportunityStateCode { get; private set; }
        public VocabularyKey ProductTypeCode { get; private set; }
        public VocabularyKey PricePerUnit { get; private set; }
        public VocabularyKey PricePerUnitBase { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey VolumeDiscountAmount { get; private set; }
        public VocabularyKey VolumeDiscountAmountBase { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey PropertyConfigurationStatus { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey OpportunityProductName { get; private set; }
    }
}