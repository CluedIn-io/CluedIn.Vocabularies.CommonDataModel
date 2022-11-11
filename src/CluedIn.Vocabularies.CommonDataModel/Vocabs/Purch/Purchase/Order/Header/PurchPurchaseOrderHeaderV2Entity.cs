using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderHeaderV2Entity";
            KeyPrefix = "commonDataModel.purchpurchaseorderheaderv2entity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderHeaderV2Entity";

            AddGroup("Common Data Model PurchPurchaseOrderHeaderV2Entity Details", group =>
            {
                PurchaseOrderStatus = group.Add(new VocabularyKey(nameof(PurchaseOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankDocumentType = group.Add(new VocabularyKey(nameof(BankDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsChangeManagementActive = group.Add(new VocabularyKey(nameof(IsChangeManagementActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateRecId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateName = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsolidatedInvoiceTarget = group.Add(new VocabularyKey(nameof(IsConsolidatedInvoiceTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeId = group.Add(new VocabularyKey(nameof(DeliveryModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDueDate = group.Add(new VocabularyKey(nameof(FixedDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingSiteId = group.Add(new VocabularyKey(nameof(DefaultReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveredDirectly = group.Add(new VocabularyKey(nameof(IsDeliveredDirectly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                ReplenishmentWarehouseId = group.Add(new VocabularyKey(nameof(ReplenishmentWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentServiceCategoryId = group.Add(new VocabularyKey(nameof(ReplenishmentServiceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttentionInformation = group.Add(new VocabularyKey(nameof(AttentionInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorTransactionSettlementType = group.Add(new VocabularyKey(nameof(VendorTransactionSettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRebateVendorGroupId = group.Add(new VocabularyKey(nameof(PurchaseRebateVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSalesListCode = group.Add(new VocabularyKey(nameof(EUSalesListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorOrderReference = group.Add(new VocabularyKey(nameof(VendorOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPurchaseOrderCodeRecId = group.Add(new VocabularyKey(nameof(ConfirmingPurchaseOrderCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPurchaseOrderCode = group.Add(new VocabularyKey(nameof(ConfirmingPurchaseOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPurchaseOrderCodeLanguageId = group.Add(new VocabularyKey(nameof(ConfirmingPurchaseOrderCodeLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceDeclarationClassifierRecId = group.Add(new VocabularyKey(nameof(VendorInvoiceDeclarationClassifierRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceDeclarationId = group.Add(new VocabularyKey(nameof(VendorInvoiceDeclarationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCityInKana = group.Add(new VocabularyKey(nameof(DeliveryCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DeliveryStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedStoreAvailableSalesDate = group.Add(new VocabularyKey(nameof(ExpectedStoreAvailableSalesDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedCrossDockingDate = group.Add(new VocabularyKey(nameof(ExpectedCrossDockingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedStoreReceiptDate = group.Add(new VocabularyKey(nameof(ExpectedStoreReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationNumber = group.Add(new VocabularyKey(nameof(ImportDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTemplateId = group.Add(new VocabularyKey(nameof(TransportationTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeId = group.Add(new VocabularyKey(nameof(TransportationModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceType = group.Add(new VocabularyKey(nameof(InvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrdererRecId = group.Add(new VocabularyKey(nameof(OrdererRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrdererPersonnelNumber = group.Add(new VocabularyKey(nameof(OrdererPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterRecId = group.Add(new VocabularyKey(nameof(RequesterRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterPersonnelNumber = group.Add(new VocabularyKey(nameof(RequesterPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatContractNumber = group.Add(new VocabularyKey(nameof(ZakatContractNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTSelfBilledInvoiceApprovalNumber = group.Add(new VocabularyKey(nameof(GSTSelfBilledInvoiceApprovalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressState = group.Add(new VocabularyKey(nameof(InvoiceAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCounty = group.Add(new VocabularyKey(nameof(InvoiceAddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicePostalAddress = group.Add(new VocabularyKey(nameof(InvoicePostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderHeaderCreationMethod = group.Add(new VocabularyKey(nameof(PurchaseOrderHeaderCreationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentApprovalStatus = group.Add(new VocabularyKey(nameof(DocumentApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedInvoiceAddress = group.Add(new VocabularyKey(nameof(FormattedInvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseOrderStatus { get; private set; }
        public VocabularyKey BankDocumentType { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey IsChangeManagementActive { get; private set; }
        public VocabularyKey OrderVendorAccountNumber { get; private set; }
        public VocabularyKey LineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey AccountingDistributionTemplateRecId { get; private set; }
        public VocabularyKey AccountingDistributionTemplateName { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ConfirmedDeliveryDate { get; private set; }
        public VocabularyKey IsConsolidatedInvoiceTarget { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey DeliveryModeId { get; private set; }
        public VocabularyKey DeliveryTermsId { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey TotalDiscountVendorGroupCode { get; private set; }
        public VocabularyKey FixedDueDate { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey DefaultReceivingWarehouseId { get; private set; }
        public VocabularyKey DefaultReceivingSiteId { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ChargeVendorGroupId { get; private set; }
        public VocabularyKey IsDeliveredDirectly { get; private set; }
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
        public VocabularyKey ReplenishmentWarehouseId { get; private set; }
        public VocabularyKey ReplenishmentServiceCategoryId { get; private set; }
        public VocabularyKey AttentionInformation { get; private set; }
        public VocabularyKey VendorTransactionSettlementType { get; private set; }
        public VocabularyKey PurchaseRebateVendorGroupId { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey EUSalesListCode { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey VendorOrderReference { get; private set; }
        public VocabularyKey ConfirmingPurchaseOrderCodeRecId { get; private set; }
        public VocabularyKey ConfirmingPurchaseOrderCode { get; private set; }
        public VocabularyKey ConfirmingPurchaseOrderCodeLanguageId { get; private set; }
        public VocabularyKey VendorInvoiceDeclarationClassifierRecId { get; private set; }
        public VocabularyKey VendorInvoiceDeclarationId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonComment { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryCityInKana { get; private set; }
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
        public VocabularyKey DeliveryStreetInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey ExpectedStoreAvailableSalesDate { get; private set; }
        public VocabularyKey ExpectedCrossDockingDate { get; private set; }
        public VocabularyKey ExpectedStoreReceiptDate { get; private set; }
        public VocabularyKey ImportDeclarationNumber { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey TransportationTemplateId { get; private set; }
        public VocabularyKey TransportationModeId { get; private set; }
        public VocabularyKey InvoiceType { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey OrdererRecId { get; private set; }
        public VocabularyKey OrdererPersonnelNumber { get; private set; }
        public VocabularyKey RequesterRecId { get; private set; }
        public VocabularyKey RequesterPersonnelNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ZakatContractNumber { get; private set; }
        public VocabularyKey GSTSelfBilledInvoiceApprovalNumber { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressState { get; private set; }
        public VocabularyKey InvoiceAddressCounty { get; private set; }
        public VocabularyKey InvoicePostalAddress { get; private set; }
        public VocabularyKey PurchaseOrderHeaderCreationMethod { get; private set; }
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey DocumentApprovalStatus { get; private set; }
        public VocabularyKey FormattedInvoiceAddress { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }


    }
}