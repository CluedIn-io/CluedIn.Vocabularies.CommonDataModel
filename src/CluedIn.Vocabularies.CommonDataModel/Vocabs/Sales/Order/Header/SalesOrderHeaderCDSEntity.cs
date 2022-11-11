using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderHeaderCDSEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderHeaderCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderHeaderCDSEntity";
            KeyPrefix = "commonDataModel.salesorderheadercdsentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderHeaderCDSEntity";

            AddGroup("Common Data Model SalesOrderHeaderCDSEntity Details", group =>
            {
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedReceiptDate = group.Add(new VocabularyKey(nameof(ConfirmedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDelveryAddress = group.Add(new VocabularyKey(nameof(FormattedDelveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedInvoiceAddress = group.Add(new VocabularyKey(nameof(FormattedInvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountyId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDistrictName = group.Add(new VocabularyKey(nameof(InvoiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLatitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLongitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressPostBox = group.Add(new VocabularyKey(nameof(InvoiceAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStateId = group.Add(new VocabularyKey(nameof(InvoiceAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressTimeZone = group.Add(new VocabularyKey(nameof(InvoiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceBuildingCompliment = group.Add(new VocabularyKey(nameof(InvoiceBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerIsExternallyMaintained = group.Add(new VocabularyKey(nameof(InvoiceCustomerIsExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidFrom = group.Add(new VocabularyKey(nameof(InvoiceValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidTo = group.Add(new VocabularyKey(nameof(InvoiceValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceAddressPrivate = group.Add(new VocabularyKey(nameof(IsInvoiceAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeCustomer = group.Add(new VocabularyKey(nameof(IsOneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesProcessingStopped = group.Add(new VocabularyKey(nameof(IsSalesProcessingStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderCreationDateTime = group.Add(new VocabularyKey(nameof(OrderCreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerIsExternallyMaintained = group.Add(new VocabularyKey(nameof(OrderingCustomerIsExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(OrderResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTakerPersonnelNumber = group.Add(new VocabularyKey(nameof(OrderTakerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalAmount = group.Add(new VocabularyKey(nameof(OrderTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalChargesAmount = group.Add(new VocabularyKey(nameof(OrderTotalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalDiscountAmount = group.Add(new VocabularyKey(nameof(OrderTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalTaxAmount = group.Add(new VocabularyKey(nameof(OrderTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderHeaderTaxAmount = group.Add(new VocabularyKey(nameof(OrderHeaderTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsBaseDate = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationNumber = group.Add(new VocabularyKey(nameof(QuotationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderName = group.Add(new VocabularyKey(nameof(SalesOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginCode = group.Add(new VocabularyKey(nameof(SalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderProcessingStatus = group.Add(new VocabularyKey(nameof(SalesOrderProcessingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderStatus = group.Add(new VocabularyKey(nameof(SalesOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsible = group.Add(new VocabularyKey(nameof(SalesResponsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaker = group.Add(new VocabularyKey(nameof(SalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTotalsUpdated = group.Add(new VocabularyKey(nameof(AreTotalsUpdated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginType = group.Add(new VocabularyKey(nameof(SalesOrderOriginType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalWorkOrderStatus = group.Add(new VocabularyKey(nameof(ExternalWorkOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ConfirmedReceiptDate { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
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
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FormattedDelveryAddress { get; private set; }
        public VocabularyKey FormattedInvoiceAddress { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountyId { get; private set; }
        public VocabularyKey InvoiceAddressDistrictName { get; private set; }
        public VocabularyKey InvoiceAddressLatitude { get; private set; }
        public VocabularyKey InvoiceAddressLongitude { get; private set; }
        public VocabularyKey InvoiceAddressPostBox { get; private set; }
        public VocabularyKey InvoiceAddressStateId { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressTimeZone { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceBuildingCompliment { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerIsExternallyMaintained { get; private set; }
        public VocabularyKey InvoiceValidFrom { get; private set; }
        public VocabularyKey InvoiceValidTo { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey IsInvoiceAddressPrivate { get; private set; }
        public VocabularyKey IsOneTimeCustomer { get; private set; }
        public VocabularyKey IsSalesProcessingStopped { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey OrderCreationDateTime { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey OrderingCustomerIsExternallyMaintained { get; private set; }
        public VocabularyKey OrderResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey OrderTakerPersonnelNumber { get; private set; }
        public VocabularyKey OrderTotalAmount { get; private set; }
        public VocabularyKey OrderTotalChargesAmount { get; private set; }
        public VocabularyKey OrderTotalDiscountAmount { get; private set; }
        public VocabularyKey OrderTotalTaxAmount { get; private set; }
        public VocabularyKey OrderHeaderTaxAmount { get; private set; }
        public VocabularyKey PaymentTermsBaseDate { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey QuotationNumber { get; private set; }
        public VocabularyKey RequestedReceiptDate { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey SalesOrderName { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey SalesOrderOriginCode { get; private set; }
        public VocabularyKey SalesOrderProcessingStatus { get; private set; }
        public VocabularyKey SalesOrderPromisingMethod { get; private set; }
        public VocabularyKey SalesOrderStatus { get; private set; }
        public VocabularyKey SalesResponsible { get; private set; }
        public VocabularyKey SalesTaker { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey AreTotalsUpdated { get; private set; }
        public VocabularyKey SalesOrderOriginType { get; private set; }
        public VocabularyKey ExternalWorkOrderStatus { get; private set; }
        public VocabularyKey ProjectId { get; private set; }


    }
}