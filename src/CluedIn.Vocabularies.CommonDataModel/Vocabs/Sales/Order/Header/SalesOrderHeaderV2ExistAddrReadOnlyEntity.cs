using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderHeaderV2ExistAddrReadOnlyEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderHeaderV2ExistAddrReadOnlyEntityVocabulary()
        {
            VocabularyName = "SalesOrderHeaderV2ExistAddrReadOnlyEntity";
            KeyPrefix = "commonDataModel.salesorderheaderv2existaddrreadonlyentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderHeaderV2ExistAddrReadOnlyEntity";

            AddGroup("SalesOrderHeaderV2ExistAddrReadOnlyEntity Details", group =>
            {
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderStatus = group.Add(new VocabularyKey(nameof(SalesOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsBaseDate = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionCustomerGroupId = group.Add(new VocabularyKey(nameof(CommissionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitMandate = group.Add(new VocabularyKey(nameof(DirectDebitMandate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryReasonCode = group.Add(new VocabularyKey(nameof(DeliveryReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportReason = group.Add(new VocabularyKey(nameof(ExportReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDueDate = group.Add(new VocabularyKey(nameof(FixedDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedExchangeRate = group.Add(new VocabularyKey(nameof(FixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicePaymentAttachmentType = group.Add(new VocabularyKey(nameof(InvoicePaymentAttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingSiteId = group.Add(new VocabularyKey(nameof(DefaultShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSalesListCode = group.Add(new VocabularyKey(nameof(EUSalesListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCustomerGroupId = group.Add(new VocabularyKey(nameof(ChargeCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreementNumber = group.Add(new VocabularyKey(nameof(SalesAgreementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesProcessingStopped = group.Add(new VocabularyKey(nameof(IsSalesProcessingStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(MultilineDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeCustomer = group.Add(new VocabularyKey(nameof(IsOneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentMethodName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticInventoryReservationConsiderBatchAttributes = group.Add(new VocabularyKey(nameof(WillAutomaticInventoryReservationConsiderBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRebateCustomerGroupId = group.Add(new VocabularyKey(nameof(SalesRebateCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TMACustomerGroupId = group.Add(new VocabularyKey(nameof(TMACustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPostingProfileId = group.Add(new VocabularyKey(nameof(CustomerPostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationNumber = group.Add(new VocabularyKey(nameof(QuotationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedReceiptDate = group.Add(new VocabularyKey(nameof(ConfirmedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryReservationMethod = group.Add(new VocabularyKey(nameof(InventoryReservationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderName = group.Add(new VocabularyKey(nameof(SalesOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginCode = group.Add(new VocabularyKey(nameof(SalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPoolId = group.Add(new VocabularyKey(nameof(SalesOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitId = group.Add(new VocabularyKey(nameof(SalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTransactionSettlementType = group.Add(new VocabularyKey(nameof(CustomerTransactionSettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaker = group.Add(new VocabularyKey(nameof(SalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignId = group.Add(new VocabularyKey(nameof(CampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsible = group.Add(new VocabularyKey(nameof(SalesResponsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitMandateId = group.Add(new VocabularyKey(nameof(DirectDebitMandateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(OrderResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTakerPersonnelNumber = group.Add(new VocabularyKey(nameof(OrderTakerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEntryCertificateRequired = group.Add(new VocabularyKey(nameof(IsEntryCertificateRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOwnEntryCertificateIssued = group.Add(new VocabularyKey(nameof(IsOwnEntryCertificateIssued), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceType = group.Add(new VocabularyKey(nameof(InvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBrokerId = group.Add(new VocabularyKey(nameof(TransportationBrokerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeId = group.Add(new VocabularyKey(nameof(TransportationModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTemplateId = group.Add(new VocabularyKey(nameof(TransportationTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDelveryAddress = group.Add(new VocabularyKey(nameof(FormattedDelveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsolidatedInvoiceTarget = group.Add(new VocabularyKey(nameof(IsConsolidatedInvoiceTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceDimensionAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceDimensionAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEInvoiceDimensionAccountCodeSpecifiedPerLine = group.Add(new VocabularyKey(nameof(IsEInvoiceDimensionAccountCodeSpecifiedPerLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteReasonCode = group.Add(new VocabularyKey(nameof(CreditNoteReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExportSale = group.Add(new VocabularyKey(nameof(IsExportSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankConstantSymbol = group.Add(new VocabularyKey(nameof(BankConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankSpecificSymbol = group.Add(new VocabularyKey(nameof(BankSpecificSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFPSCode = group.Add(new VocabularyKey(nameof(CFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinalUser = group.Add(new VocabularyKey(nameof(IsFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFineCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeRecId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOperationPresenceType = group.Add(new VocabularyKey(nameof(FiscalOperationPresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPurchOperationTypeRecId = group.Add(new VocabularyKey(nameof(SalesPurchOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceDeliveryAddressBased = group.Add(new VocabularyKey(nameof(IsServiceDeliveryAddressBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceFiscalInformationCode = group.Add(new VocabularyKey(nameof(ServiceFiscalInformationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentOperationTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentOperationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedInvoiceAddress = group.Add(new VocabularyKey(nameof(FormattedInvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceBuildingCompliment = group.Add(new VocabularyKey(nameof(InvoiceBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountyId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDistrictName = group.Add(new VocabularyKey(nameof(InvoiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceAddressPrivate = group.Add(new VocabularyKey(nameof(IsInvoiceAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLatitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLongitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressPostBox = group.Add(new VocabularyKey(nameof(InvoiceAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStateId = group.Add(new VocabularyKey(nameof(InvoiceAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressTimeZone = group.Add(new VocabularyKey(nameof(InvoiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCityInKana = group.Add(new VocabularyKey(nameof(InvoiceAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetInKana = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalAmount = group.Add(new VocabularyKey(nameof(OrderTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalChargesAmount = group.Add(new VocabularyKey(nameof(OrderTotalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalDiscountAmount = group.Add(new VocabularyKey(nameof(OrderTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTotalTaxAmount = group.Add(new VocabularyKey(nameof(OrderTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderHeaderTaxAmount = group.Add(new VocabularyKey(nameof(OrderHeaderTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderProcessingStatus = group.Add(new VocabularyKey(nameof(SalesOrderProcessingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTotalsCalculated = group.Add(new VocabularyKey(nameof(AreTotalsCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidTo = group.Add(new VocabularyKey(nameof(InvoiceValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidFrom = group.Add(new VocabularyKey(nameof(InvoiceValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderCreationDateTime = group.Add(new VocabularyKey(nameof(OrderCreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreateAutoCharges = group.Add(new VocabularyKey(nameof(SkipCreateAutoCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDocumentDate = group.Add(new VocabularyKey(nameof(BaseDocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CIPEcode = group.Add(new VocabularyKey(nameof(CIPEcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDocumentNumber = group.Add(new VocabularyKey(nameof(BaseDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDocumentType = group.Add(new VocabularyKey(nameof(BaseDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDocumentItemNumber = group.Add(new VocabularyKey(nameof(BaseDocumentItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDocumentLineNumber = group.Add(new VocabularyKey(nameof(BaseDocumentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderOrAgreementCode = group.Add(new VocabularyKey(nameof(OrderOrAgreementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderCode = group.Add(new VocabularyKey(nameof(TenderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyFixedExchangeRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyFixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey SalesOrderStatus { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey LineDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey PaymentTermsBaseDate { get; private set; }
        public VocabularyKey CommissionCustomerGroupId { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey SalesOrderPromisingMethod { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DirectDebitMandate { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryReasonCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey TotalDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey ExportReason { get; private set; }
        public VocabularyKey FixedDueDate { get; private set; }
        public VocabularyKey FixedExchangeRate { get; private set; }
        public VocabularyKey InvoicePaymentAttachmentType { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey DefaultShippingWarehouseId { get; private set; }
        public VocabularyKey DefaultShippingSiteId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey EUSalesListCode { get; private set; }
        public VocabularyKey ChargeCustomerGroupId { get; private set; }
        public VocabularyKey SalesAgreementNumber { get; private set; }
        public VocabularyKey IsSalesProcessingStopped { get; private set; }
        public VocabularyKey MultilineDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey NumberSequenceGroupId { get; private set; }
        public VocabularyKey IsOneTimeCustomer { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey CustomerPaymentMethodName { get; private set; }
        public VocabularyKey CustomerPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey WillAutomaticInventoryReservationConsiderBatchAttributes { get; private set; }
        public VocabularyKey SalesRebateCustomerGroupId { get; private set; }
        public VocabularyKey TMACustomerGroupId { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey CustomerPostingProfileId { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey QuotationNumber { get; private set; }
        public VocabularyKey ConfirmedReceiptDate { get; private set; }
        public VocabularyKey RequestedReceiptDate { get; private set; }
        public VocabularyKey InventoryReservationMethod { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey SalesOrderName { get; private set; }
        public VocabularyKey SalesOrderOriginCode { get; private set; }
        public VocabularyKey SalesOrderPoolId { get; private set; }
        public VocabularyKey SalesUnitId { get; private set; }
        public VocabularyKey CustomerTransactionSettlementType { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey SalesTaker { get; private set; }
        public VocabularyKey CampaignId { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey SalesResponsible { get; private set; }
        public VocabularyKey DirectDebitMandateId { get; private set; }
        public VocabularyKey OrderResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey OrderTakerPersonnelNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey IsEntryCertificateRequired { get; private set; }
        public VocabularyKey IsOwnEntryCertificateIssued { get; private set; }
        public VocabularyKey InvoiceType { get; private set; }
        public VocabularyKey TransportationBrokerId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey TransportationModeId { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey TransportationTemplateId { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey FormattedDelveryAddress { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey IsConsolidatedInvoiceTarget { get; private set; }
        public VocabularyKey EInvoiceDimensionAccountCode { get; private set; }
        public VocabularyKey IsEInvoiceDimensionAccountCodeSpecifiedPerLine { get; private set; }
        public VocabularyKey CreditNoteReasonCode { get; private set; }
        public VocabularyKey IsExportSale { get; private set; }
        public VocabularyKey BankConstantSymbol { get; private set; }
        public VocabularyKey BankSpecificSymbol { get; private set; }
        public VocabularyKey CFPSCode { get; private set; }
        public VocabularyKey IsFinalUser { get; private set; }
        public VocabularyKey CustomerPaymentFineCode { get; private set; }
        public VocabularyKey FiscalDocumentTypeRecId { get; private set; }
        public VocabularyKey CustomerPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey FiscalOperationPresenceType { get; private set; }
        public VocabularyKey SalesPurchOperationTypeRecId { get; private set; }
        public VocabularyKey IsServiceDeliveryAddressBased { get; private set; }
        public VocabularyKey ServiceFiscalInformationCode { get; private set; }
        public VocabularyKey FiscalDocumentOperationTypeId { get; private set; }
        public VocabularyKey FiscalDocumentTypeId { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey FormattedInvoiceAddress { get; private set; }
        public VocabularyKey InvoiceBuildingCompliment { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountyId { get; private set; }
        public VocabularyKey InvoiceAddressDistrictName { get; private set; }
        public VocabularyKey IsInvoiceAddressPrivate { get; private set; }
        public VocabularyKey InvoiceAddressLatitude { get; private set; }
        public VocabularyKey InvoiceAddressLongitude { get; private set; }
        public VocabularyKey InvoiceAddressPostBox { get; private set; }
        public VocabularyKey InvoiceAddressStateId { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressTimeZone { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceAddressCityInKana { get; private set; }
        public VocabularyKey InvoiceAddressStreetInKana { get; private set; }
        public VocabularyKey OrderTotalAmount { get; private set; }
        public VocabularyKey OrderTotalChargesAmount { get; private set; }
        public VocabularyKey OrderTotalDiscountAmount { get; private set; }
        public VocabularyKey OrderTotalTaxAmount { get; private set; }
        public VocabularyKey OrderHeaderTaxAmount { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey SalesOrderProcessingStatus { get; private set; }
        public VocabularyKey AreTotalsCalculated { get; private set; }
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey InvoiceValidTo { get; private set; }
        public VocabularyKey InvoiceValidFrom { get; private set; }
        public VocabularyKey OrderCreationDateTime { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey SkipCreateAutoCharges { get; private set; }
        public VocabularyKey BaseDocumentDate { get; private set; }
        public VocabularyKey CIPEcode { get; private set; }
        public VocabularyKey BaseDocumentNumber { get; private set; }
        public VocabularyKey BaseDocumentType { get; private set; }
        public VocabularyKey BaseDocumentItemNumber { get; private set; }
        public VocabularyKey BaseDocumentLineNumber { get; private set; }
        public VocabularyKey OrderOrAgreementCode { get; private set; }
        public VocabularyKey TenderCode { get; private set; }
        public VocabularyKey ReportingCurrencyFixedExchangeRate { get; private set; }


    }
}