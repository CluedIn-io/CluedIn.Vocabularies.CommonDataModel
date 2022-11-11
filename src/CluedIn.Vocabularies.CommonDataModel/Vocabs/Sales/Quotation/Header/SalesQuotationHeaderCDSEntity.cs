using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationHeaderCDSEntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationHeaderCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesQuotationHeaderCDSEntity";
            KeyPrefix = "commonDataModel.salesquotationheadercdsentity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationHeaderCDSEntity";

            AddGroup("Common Data Model SalesQuotationHeaderCDSEntity Details", group =>
            {
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTotalsCalculated = group.Add(new VocabularyKey(nameof(AreTotalsCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersReference = group.Add(new VocabularyKey(nameof(CustomersReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingSiteId = group.Add(new VocabularyKey(nameof(DefaultShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedInvoiceAddress = group.Add(new VocabularyKey(nameof(FormattedInvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedSalesOrderNumber = group.Add(new VocabularyKey(nameof(GeneratedSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountyId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDistrictName = group.Add(new VocabularyKey(nameof(InvoiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLatitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLongitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressPostBox = group.Add(new VocabularyKey(nameof(InvoiceAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStateId = group.Add(new VocabularyKey(nameof(InvoiceAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressTimeZone = group.Add(new VocabularyKey(nameof(InvoiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceBuildingCompliment = group.Add(new VocabularyKey(nameof(InvoiceBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidFrom = group.Add(new VocabularyKey(nameof(InvoiceValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidTo = group.Add(new VocabularyKey(nameof(InvoiceValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceAddressPrivate = group.Add(new VocabularyKey(nameof(IsInvoiceAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityId = group.Add(new VocabularyKey(nameof(OpportunityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProspectId = group.Add(new VocabularyKey(nameof(ProspectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(QuotationResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTakerPersonnelNumber = group.Add(new VocabularyKey(nameof(QuotationTakerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalAmount = group.Add(new VocabularyKey(nameof(QuotationTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalChargesAmount = group.Add(new VocabularyKey(nameof(QuotationTotalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalDiscountAmount = group.Add(new VocabularyKey(nameof(QuotationTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalTaxAmount = group.Add(new VocabularyKey(nameof(QuotationTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationHeaderTaxAmount = group.Add(new VocabularyKey(nameof(QuotationHeaderTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDateRequested = group.Add(new VocabularyKey(nameof(ReceiptDateRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(RequestingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginCode = group.Add(new VocabularyKey(nameof(SalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationName = group.Add(new VocabularyKey(nameof(SalesQuotationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationNumber = group.Add(new VocabularyKey(nameof(SalesQuotationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationStatus = group.Add(new VocabularyKey(nameof(SalesQuotationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationExpiryDate = group.Add(new VocabularyKey(nameof(SalesQuotationExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationConfirmationDate = group.Add(new VocabularyKey(nameof(SalesQuotationConfirmationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationFollowUpDate = group.Add(new VocabularyKey(nameof(SalesQuotationFollowUpDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationCalculatedTotalsRecId = group.Add(new VocabularyKey(nameof(SalesQuotationCalculatedTotalsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey AreTotalsCalculated { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomersReference { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey DefaultShippingSiteId { get; private set; }
        public VocabularyKey DefaultShippingWarehouseId { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey FormattedInvoiceAddress { get; private set; }
        public VocabularyKey GeneratedSalesOrderNumber { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey InvoiceAddressCountyId { get; private set; }
        public VocabularyKey InvoiceAddressDistrictName { get; private set; }
        public VocabularyKey InvoiceAddressLatitude { get; private set; }
        public VocabularyKey InvoiceAddressLongitude { get; private set; }
        public VocabularyKey InvoiceAddressPostBox { get; private set; }
        public VocabularyKey InvoiceAddressStateId { get; private set; }
        public VocabularyKey InvoiceAddressTimeZone { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceBuildingCompliment { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceValidFrom { get; private set; }
        public VocabularyKey InvoiceValidTo { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey IsInvoiceAddressPrivate { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey OpportunityId { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey ProspectId { get; private set; }
        public VocabularyKey QuotationResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey QuotationTakerPersonnelNumber { get; private set; }
        public VocabularyKey QuotationTotalAmount { get; private set; }
        public VocabularyKey QuotationTotalChargesAmount { get; private set; }
        public VocabularyKey QuotationTotalDiscountAmount { get; private set; }
        public VocabularyKey QuotationTotalTaxAmount { get; private set; }
        public VocabularyKey QuotationHeaderTaxAmount { get; private set; }
        public VocabularyKey ReceiptDateRequested { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey RequestingCustomerAccountNumber { get; private set; }
        public VocabularyKey SalesOrderOriginCode { get; private set; }
        public VocabularyKey SalesOrderPromisingMethod { get; private set; }
        public VocabularyKey SalesQuotationName { get; private set; }
        public VocabularyKey SalesQuotationNumber { get; private set; }
        public VocabularyKey SalesQuotationStatus { get; private set; }
        public VocabularyKey SalesQuotationExpiryDate { get; private set; }
        public VocabularyKey SalesQuotationConfirmationDate { get; private set; }
        public VocabularyKey SalesQuotationFollowUpDate { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey SalesQuotationCalculatedTotalsRecId { get; private set; }


    }
}