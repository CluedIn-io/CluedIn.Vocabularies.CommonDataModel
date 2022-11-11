using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderConfirmationHeaderEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderConfirmationHeaderEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseOrderConfirmationHeaderEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderconfirmationheaderentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderConfirmationHeaderEntity";

            AddGroup("PurchPurchaseOrderConfirmationHeaderEntity Details", group =>
            {
                PurchaseOrderStatus = group.Add(new VocabularyKey(nameof(PurchaseOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankDocumentType = group.Add(new VocabularyKey(nameof(BankDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateName = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeId = group.Add(new VocabularyKey(nameof(DeliveryModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDueDate = group.Add(new VocabularyKey(nameof(FixedDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingSiteId = group.Add(new VocabularyKey(nameof(DefaultReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(MultilineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeVendor = group.Add(new VocabularyKey(nameof(IsOneTimeVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPostingProfileId = group.Add(new VocabularyKey(nameof(VendorPostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceVendorGroupCode = group.Add(new VocabularyKey(nameof(PriceVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderName = group.Add(new VocabularyKey(nameof(PurchaseOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderPoolId = group.Add(new VocabularyKey(nameof(PurchaseOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttentionInformation = group.Add(new VocabularyKey(nameof(AttentionInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorTransactionSettlementType = group.Add(new VocabularyKey(nameof(VendorTransactionSettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSalesListCode = group.Add(new VocabularyKey(nameof(EUSalesListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorOrderReference = group.Add(new VocabularyKey(nameof(VendorOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPurchaseOrderCode = group.Add(new VocabularyKey(nameof(ConfirmingPurchaseOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPurchaseOrderCodeLanguageId = group.Add(new VocabularyKey(nameof(ConfirmingPurchaseOrderCodeLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceDeclarationId = group.Add(new VocabularyKey(nameof(VendorInvoiceDeclarationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrdererPersonnelNumber = group.Add(new VocabularyKey(nameof(OrdererPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterPersonnelNumber = group.Add(new VocabularyKey(nameof(RequesterPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderHeaderCreationMethod = group.Add(new VocabularyKey(nameof(PurchaseOrderHeaderCreationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentApprovalStatus = group.Add(new VocabularyKey(nameof(DocumentApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalConfirmedAmount = group.Add(new VocabularyKey(nameof(TotalConfirmedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentAmount = group.Add(new VocabularyKey(nameof(PrepaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedExchangeRate = group.Add(new VocabularyKey(nameof(FixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedSecondaryExchangeRate = group.Add(new VocabularyKey(nameof(FixedSecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrepayment = group.Add(new VocabularyKey(nameof(IsPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationVoucherNumber = group.Add(new VocabularyKey(nameof(ConfirmationVoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationDate = group.Add(new VocabularyKey(nameof(ConfirmationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderDocumentReference = group.Add(new VocabularyKey(nameof(PurchaseOrderDocumentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalQuantity = group.Add(new VocabularyKey(nameof(TotalQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRoundOffAmount = group.Add(new VocabularyKey(nameof(TotalRoundOffAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubTotalAmount = group.Add(new VocabularyKey(nameof(SubTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineDiscountAmount = group.Add(new VocabularyKey(nameof(TotalLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalChargeAmount = group.Add(new VocabularyKey(nameof(TotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNetVolume = group.Add(new VocabularyKey(nameof(TotalNetVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNetWeight = group.Add(new VocabularyKey(nameof(TotalNetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseOrderStatus { get; private set; }
        public VocabularyKey BankDocumentType { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey OrderVendorAccountNumber { get; private set; }
        public VocabularyKey LineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey AccountingDistributionTemplateName { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey DeliveryModeId { get; private set; }
        public VocabularyKey DeliveryTermsId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey TotalDiscountVendorGroupCode { get; private set; }
        public VocabularyKey FixedDueDate { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey DefaultReceivingWarehouseId { get; private set; }
        public VocabularyKey DefaultReceivingSiteId { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ChargeVendorGroupId { get; private set; }
        public VocabularyKey MultilineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey NumberSequenceGroupId { get; private set; }
        public VocabularyKey IsOneTimeVendor { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey VendorPaymentMethodName { get; private set; }
        public VocabularyKey VendorPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey VendorPostingProfileId { get; private set; }
        public VocabularyKey PriceVendorGroupCode { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey PurchaseOrderName { get; private set; }
        public VocabularyKey PurchaseOrderPoolId { get; private set; }
        public VocabularyKey AttentionInformation { get; private set; }
        public VocabularyKey VendorTransactionSettlementType { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey EUSalesListCode { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey VendorOrderReference { get; private set; }
        public VocabularyKey ConfirmingPurchaseOrderCode { get; private set; }
        public VocabularyKey ConfirmingPurchaseOrderCodeLanguageId { get; private set; }
        public VocabularyKey VendorInvoiceDeclarationId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonComment { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
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
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey OrdererPersonnelNumber { get; private set; }
        public VocabularyKey RequesterPersonnelNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey PurchaseOrderHeaderCreationMethod { get; private set; }
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey DocumentApprovalStatus { get; private set; }
        public VocabularyKey TotalConfirmedAmount { get; private set; }
        public VocabularyKey PrepaymentAmount { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey FixedExchangeRate { get; private set; }
        public VocabularyKey FixedSecondaryExchangeRate { get; private set; }
        public VocabularyKey IsPrepayment { get; private set; }
        public VocabularyKey ConfirmationNumber { get; private set; }
        public VocabularyKey ConfirmationVoucherNumber { get; private set; }
        public VocabularyKey ConfirmationDate { get; private set; }
        public VocabularyKey PurchaseOrderDocumentReference { get; private set; }
        public VocabularyKey TotalQuantity { get; private set; }
        public VocabularyKey TotalRoundOffAmount { get; private set; }
        public VocabularyKey SubTotalAmount { get; private set; }
        public VocabularyKey TotalLineDiscountAmount { get; private set; }
        public VocabularyKey TotalChargeAmount { get; private set; }
        public VocabularyKey TotalTaxAmount { get; private set; }
        public VocabularyKey TotalNetVolume { get; private set; }
        public VocabularyKey TotalNetWeight { get; private set; }


    }
}