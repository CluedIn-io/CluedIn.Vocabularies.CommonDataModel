using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class InvoiceProductVocabulary : SimpleVocabulary
    {
        public InvoiceProductVocabulary()
        {
            VocabularyName = "Invoice Product";
            KeyPrefix = "commonDataModel.invoiceproduct.sales";
            KeySeparator = ".";
            Grouping = "/InvoiceProduct";

            AddGroup("InvoiceProduct Details for Sales", group =>
            {
			    InvoiceDetailId = group.Add(new VocabularyKey(nameof(InvoiceDetailId), "Invoice Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDeliveryOn = group.Add(new VocabularyKey(nameof(ActualDeliveryOn), "Delivered On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BaseAmount = group.Add(new VocabularyKey(nameof(BaseAmount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BaseAmountBase = group.Add(new VocabularyKey(nameof(BaseAmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtendedAmount = group.Add(new VocabularyKey(nameof(ExtendedAmount), "Extended Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExtendedAmountBase = group.Add(new VocabularyKey(nameof(ExtendedAmountBase), "Extended Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceIsPriceLocked = group.Add(new VocabularyKey(nameof(InvoiceIsPriceLocked), "Invoice Is Price Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    InvoiceStateCode = group.Add(new VocabularyKey(nameof(InvoiceStateCode), "Invoice Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCopied = group.Add(new VocabularyKey(nameof(IsCopied), "Copied", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsPriceOverridden = group.Add(new VocabularyKey(nameof(IsPriceOverridden), "Pricing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsProductOverridden = group.Add(new VocabularyKey(nameof(IsProductOverridden), "Select Product", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LineItemNumber = group.Add(new VocabularyKey(nameof(LineItemNumber), "Line Item Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ManualDiscountAmount = group.Add(new VocabularyKey(nameof(ManualDiscountAmount), "Manual Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ManualDiscountAmountBase = group.Add(new VocabularyKey(nameof(ManualDiscountAmountBase), "Manual Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductTypeCode = group.Add(new VocabularyKey(nameof(ProductTypeCode), "Product type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PricePerUnit = group.Add(new VocabularyKey(nameof(PricePerUnit), "Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PricePerUnitBase = group.Add(new VocabularyKey(nameof(PricePerUnitBase), "Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), "Write-In Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductName = group.Add(new VocabularyKey(nameof(ProductName), "Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    QuantityBackordered = group.Add(new VocabularyKey(nameof(QuantityBackordered), "Quantity Back Ordered", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    QuantityCancelled = group.Add(new VocabularyKey(nameof(QuantityCancelled), "Quantity Canceled", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    QuantityShipped = group.Add(new VocabularyKey(nameof(QuantityShipped), "Quantity Shipped", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ShippingTrackingNumber = group.Add(new VocabularyKey(nameof(ShippingTrackingNumber), "Shipment Tracking Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToCity = group.Add(new VocabularyKey(nameof(ShipToCity), "Ship To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToCountry = group.Add(new VocabularyKey(nameof(ShipToCountry), "Ship To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    ShipToFax = group.Add(new VocabularyKey(nameof(ShipToFax), "Ship To Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToFreightTermsCode = group.Add(new VocabularyKey(nameof(ShipToFreightTermsCode), "Freight Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine1 = group.Add(new VocabularyKey(nameof(ShipToLine1), "Ship To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine2 = group.Add(new VocabularyKey(nameof(ShipToLine2), "Ship To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine3 = group.Add(new VocabularyKey(nameof(ShipToLine3), "Ship To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToName = group.Add(new VocabularyKey(nameof(ShipToName), "Ship To Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToPostalCode = group.Add(new VocabularyKey(nameof(ShipToPostalCode), "Ship To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToStateOrProvince = group.Add(new VocabularyKey(nameof(ShipToStateOrProvince), "Ship To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToTelephone = group.Add(new VocabularyKey(nameof(ShipToTelephone), "Ship To Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Tax = group.Add(new VocabularyKey(nameof(Tax), "Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VolumeDiscountAmount = group.Add(new VocabularyKey(nameof(VolumeDiscountAmount), "Volume Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    VolumeDiscountAmountBase = group.Add(new VocabularyKey(nameof(VolumeDiscountAmountBase), "Volume Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WillCall = group.Add(new VocabularyKey(nameof(WillCall), "Ship To", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PropertyConfigurationStatus = group.Add(new VocabularyKey(nameof(PropertyConfigurationStatus), "Property Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceDetailName = group.Add(new VocabularyKey(nameof(InvoiceDetailName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InvoiceDetailId { get; private set; }
        public VocabularyKey ActualDeliveryOn { get; private set; }
        public VocabularyKey BaseAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey BaseAmountBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExtendedAmount { get; private set; }
        public VocabularyKey ExtendedAmountBase { get; private set; }
        public VocabularyKey InvoiceIsPriceLocked { get; private set; }
        public VocabularyKey InvoiceStateCode { get; private set; }
        public VocabularyKey IsCopied { get; private set; }
        public VocabularyKey IsPriceOverridden { get; private set; }
        public VocabularyKey IsProductOverridden { get; private set; }
        public VocabularyKey LineItemNumber { get; private set; }
        public VocabularyKey ManualDiscountAmount { get; private set; }
        public VocabularyKey ManualDiscountAmountBase { get; private set; }
        public VocabularyKey ProductTypeCode { get; private set; }
        public VocabularyKey PricePerUnit { get; private set; }
        public VocabularyKey PricePerUnitBase { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey QuantityBackordered { get; private set; }
        public VocabularyKey QuantityCancelled { get; private set; }
        public VocabularyKey QuantityShipped { get; private set; }
        public VocabularyKey ShippingTrackingNumber { get; private set; }
        public VocabularyKey ShipToCity { get; private set; }
        public VocabularyKey ShipToCountry { get; private set; }
        public VocabularyKey ShipToFax { get; private set; }
        public VocabularyKey ShipToFreightTermsCode { get; private set; }
        public VocabularyKey ShipToLine1 { get; private set; }
        public VocabularyKey ShipToLine2 { get; private set; }
        public VocabularyKey ShipToLine3 { get; private set; }
        public VocabularyKey ShipToName { get; private set; }
        public VocabularyKey ShipToPostalCode { get; private set; }
        public VocabularyKey ShipToStateOrProvince { get; private set; }
        public VocabularyKey ShipToTelephone { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey VolumeDiscountAmount { get; private set; }
        public VocabularyKey VolumeDiscountAmountBase { get; private set; }
        public VocabularyKey WillCall { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey PropertyConfigurationStatus { get; private set; }
        public VocabularyKey InvoiceDetailName { get; private set; }
    }
}