using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class InvoiceVocabulary : SimpleVocabulary
    {
        public InvoiceVocabulary()
        {
            VocabularyName = "Invoice";
            KeyPrefix = "commonDataModel.invoice.sales";
            KeySeparator = ".";
            Grouping = "/Invoice";

            AddGroup("Invoice Details for Sales", group =>
            {
			    InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), "Invoice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToCity = group.Add(new VocabularyKey(nameof(BillToCity), "Bill To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToComposite = group.Add(new VocabularyKey(nameof(BillToComposite), "Bill To Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToCountry = group.Add(new VocabularyKey(nameof(BillToCountry), "Bill To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    BillToFax = group.Add(new VocabularyKey(nameof(BillToFax), "Bill To Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToLine1 = group.Add(new VocabularyKey(nameof(BillToLine1), "Bill To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToLine2 = group.Add(new VocabularyKey(nameof(BillToLine2), "Bill To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToLine3 = group.Add(new VocabularyKey(nameof(BillToLine3), "Bill To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToName = group.Add(new VocabularyKey(nameof(BillToName), "Bill To Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToPostalCode = group.Add(new VocabularyKey(nameof(BillToPostalCode), "Bill To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToStateOrProvince = group.Add(new VocabularyKey(nameof(BillToStateOrProvince), "Bill To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToTelephone = group.Add(new VocabularyKey(nameof(BillToTelephone), "Bill To Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    DateDelivered = group.Add(new VocabularyKey(nameof(DateDelivered), "Date Delivered", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), "Invoice Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DiscountAmountBase = group.Add(new VocabularyKey(nameof(DiscountAmountBase), "Invoice Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), "Invoice Discount (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FreightAmount = group.Add(new VocabularyKey(nameof(FreightAmount), "Freight Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    FreightAmountBase = group.Add(new VocabularyKey(nameof(FreightAmountBase), "Freight Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), "Invoice ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPriceLocked = group.Add(new VocabularyKey(nameof(IsPriceLocked), "Prices Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastBackofficeSubmit = group.Add(new VocabularyKey(nameof(LastBackofficeSubmit), "Last Submitted to Back Office", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentTermsCode = group.Add(new VocabularyKey(nameof(PaymentTermsCode), "Payment Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToCity = group.Add(new VocabularyKey(nameof(ShipToCity), "Ship To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToComposite = group.Add(new VocabularyKey(nameof(ShipToComposite), "Ship To Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToCountry = group.Add(new VocabularyKey(nameof(ShipToCountry), "Ship To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    ShipToFax = group.Add(new VocabularyKey(nameof(ShipToFax), "Ship To Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToFreightTermsCode = group.Add(new VocabularyKey(nameof(ShipToFreightTermsCode), "Ship To Freight Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine1 = group.Add(new VocabularyKey(nameof(ShipToLine1), "Ship To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine2 = group.Add(new VocabularyKey(nameof(ShipToLine2), "Ship To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToLine3 = group.Add(new VocabularyKey(nameof(ShipToLine3), "Ship To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToName = group.Add(new VocabularyKey(nameof(ShipToName), "Ship To Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToPostalCode = group.Add(new VocabularyKey(nameof(ShipToPostalCode), "Ship To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToStateOrProvince = group.Add(new VocabularyKey(nameof(ShipToStateOrProvince), "Ship To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShipToTelephone = group.Add(new VocabularyKey(nameof(ShipToTelephone), "Ship To Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAmountLessFreight = group.Add(new VocabularyKey(nameof(TotalAmountLessFreight), "Total Pre-Freight Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountLessFreightBase = group.Add(new VocabularyKey(nameof(TotalAmountLessFreightBase), "Total Pre-Freight Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), "Total Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDiscountAmountBase = group.Add(new VocabularyKey(nameof(TotalDiscountAmountBase), "Total Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalLineItemAmount = group.Add(new VocabularyKey(nameof(TotalLineItemAmount), "Total Detail Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLineItemAmountBase = group.Add(new VocabularyKey(nameof(TotalLineItemAmountBase), "Total Detail Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalLineItemDiscountAmount = group.Add(new VocabularyKey(nameof(TotalLineItemDiscountAmount), "Total Line Item Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLineItemDiscountAmountBase = group.Add(new VocabularyKey(nameof(TotalLineItemDiscountAmountBase), "Total Line Item Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalTax = group.Add(new VocabularyKey(nameof(TotalTax), "Total Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTaxBase = group.Add(new VocabularyKey(nameof(TotalTaxBase), "Total Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WillCall = group.Add(new VocabularyKey(nameof(WillCall), "Ship To", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey BillToCity { get; private set; }
        public VocabularyKey BillToComposite { get; private set; }
        public VocabularyKey BillToCountry { get; private set; }
        public VocabularyKey BillToFax { get; private set; }
        public VocabularyKey BillToLine1 { get; private set; }
        public VocabularyKey BillToLine2 { get; private set; }
        public VocabularyKey BillToLine3 { get; private set; }
        public VocabularyKey BillToName { get; private set; }
        public VocabularyKey BillToPostalCode { get; private set; }
        public VocabularyKey BillToStateOrProvince { get; private set; }
        public VocabularyKey BillToTelephone { get; private set; }
        public VocabularyKey DateDelivered { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey DiscountAmountBase { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey FreightAmount { get; private set; }
        public VocabularyKey FreightAmountBase { get; private set; }
        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey IsPriceLocked { get; private set; }
        public VocabularyKey LastBackofficeSubmit { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey ShipToCity { get; private set; }
        public VocabularyKey ShipToComposite { get; private set; }
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
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
        public VocabularyKey TotalAmountLessFreight { get; private set; }
        public VocabularyKey TotalAmountLessFreightBase { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey TotalDiscountAmountBase { get; private set; }
        public VocabularyKey TotalLineItemAmount { get; private set; }
        public VocabularyKey TotalLineItemAmountBase { get; private set; }
        public VocabularyKey TotalLineItemDiscountAmount { get; private set; }
        public VocabularyKey TotalLineItemDiscountAmountBase { get; private set; }
        public VocabularyKey TotalTax { get; private set; }
        public VocabularyKey TotalTaxBase { get; private set; }
        public VocabularyKey WillCall { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
    }
}