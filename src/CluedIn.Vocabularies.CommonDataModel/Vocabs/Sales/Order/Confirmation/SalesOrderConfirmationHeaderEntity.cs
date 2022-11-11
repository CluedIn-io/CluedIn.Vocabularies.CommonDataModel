using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderConfirmationHeaderEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderConfirmationHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderConfirmationHeaderEntity";
            KeyPrefix = "commonDataModel.salesorderconfirmationheaderentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderConfirmationHeaderEntity";

            AddGroup("Common Data Model SalesOrderConfirmationHeaderEntity Details", group =>
            {
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalConfirmedAmount = group.Add(new VocabularyKey(nameof(TotalConfirmedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationDate = group.Add(new VocabularyKey(nameof(ConfirmationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationDocumentReference = group.Add(new VocabularyKey(nameof(ConfirmationDocumentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostAmount = group.Add(new VocabularyKey(nameof(TotalCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventorySiteMandatory = group.Add(new VocabularyKey(nameof(IsInventorySiteMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddress = group.Add(new VocabularyKey(nameof(DeliveryPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedExchangeRate = group.Add(new VocabularyKey(nameof(FixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedSecondaryExchangeRate = group.Add(new VocabularyKey(nameof(FixedSecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDueDate = group.Add(new VocabularyKey(nameof(FixedDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalQuantity = group.Add(new VocabularyKey(nameof(TotalQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRoundOffAmount = group.Add(new VocabularyKey(nameof(TotalRoundOffAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubTotalAmount = group.Add(new VocabularyKey(nameof(SubTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineDiscountAmount = group.Add(new VocabularyKey(nameof(TotalLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalChargeAmount = group.Add(new VocabularyKey(nameof(TotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSalesTaxAmount = group.Add(new VocabularyKey(nameof(TotalSalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNetVolume = group.Add(new VocabularyKey(nameof(TotalNetVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNetWeight = group.Add(new VocabularyKey(nameof(TotalNetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerSalesTaker = group.Add(new VocabularyKey(nameof(WorkerSalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTakerPersonnelNumber = group.Add(new VocabularyKey(nameof(OrderTakerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey TotalConfirmedAmount { get; private set; }
        public VocabularyKey ConfirmationDate { get; private set; }
        public VocabularyKey ConfirmationDocumentReference { get; private set; }
        public VocabularyKey ConfirmationNumber { get; private set; }
        public VocabularyKey TotalCostAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
        public VocabularyKey IsInventorySiteMandatory { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryPostalAddress { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey FixedExchangeRate { get; private set; }
        public VocabularyKey FixedSecondaryExchangeRate { get; private set; }
        public VocabularyKey FixedDueDate { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey TotalQuantity { get; private set; }
        public VocabularyKey TotalRoundOffAmount { get; private set; }
        public VocabularyKey SubTotalAmount { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey TotalLineDiscountAmount { get; private set; }
        public VocabularyKey TotalChargeAmount { get; private set; }
        public VocabularyKey TotalSalesTaxAmount { get; private set; }
        public VocabularyKey TotalNetVolume { get; private set; }
        public VocabularyKey TotalNetWeight { get; private set; }
        public VocabularyKey WorkerSalesTaker { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressValidFrom { get; private set; }
        public VocabularyKey DeliveryAddressValidTo { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey OrderTakerPersonnelNumber { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}