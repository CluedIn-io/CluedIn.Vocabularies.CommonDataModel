using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderLineV2EntityVocabulary : SimpleVocabulary
    {
        public SalesOrderLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderLineV2Entity";
            KeyPrefix = "commonDataModel.salesorderlinev2entity";
            KeySeparator = ".";
            Grouping = "/SalesOrderLineV2Entity";

            AddGroup("Common Data Model SalesOrderLineV2Entity Details", group =>
            {
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderLineStatus = group.Add(new VocabularyKey(nameof(SalesOrderLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLineStopped = group.Add(new VocabularyKey(nameof(IsLineStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersLineNumber = group.Add(new VocabularyKey(nameof(CustomersLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsDocumentDate = group.Add(new VocabularyKey(nameof(CustomsDocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsDocumentNumber = group.Add(new VocabularyKey(nameof(CustomsDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsDocumentName = group.Add(new VocabularyKey(nameof(CustomsDocumentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingUnitSymbol = group.Add(new VocabularyKey(nameof(PackingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticInventoryReservationConsiderBatchAttributes = group.Add(new VocabularyKey(nameof(WillAutomaticInventoryReservationConsiderBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRebateCalculationExcludeLine = group.Add(new VocabularyKey(nameof(WillRebateCalculationExcludeLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRebateProductGroupId = group.Add(new VocabularyKey(nameof(SalesRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoicePropertyNumber = group.Add(new VocabularyKey(nameof(EInvoicePropertyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedReceiptDate = group.Add(new VocabularyKey(nameof(ConfirmedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryReservationMethod = group.Add(new VocabularyKey(nameof(InventoryReservationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedSalesQuantity = group.Add(new VocabularyKey(nameof(OrderedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(OrderedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderNumber = group.Add(new VocabularyKey(nameof(ServiceOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntrastatTriangularDeal = group.Add(new VocabularyKey(nameof(IsIntrastatTriangularDeal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderLineReference = group.Add(new VocabularyKey(nameof(OrderLineReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCommodityCode = group.Add(new VocabularyKey(nameof(IntrastatCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceDimensionAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceDimensionAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxCodeGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxCodeGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteReasonCode = group.Add(new VocabularyKey(nameof(CreditNoteReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticValue = group.Add(new VocabularyKey(nameof(IntrastatStatisticValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatSpecialMovementCode = group.Add(new VocabularyKey(nameof(IntrastatSpecialMovementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliverySalesTaxGroupCode = group.Add(new VocabularyKey(nameof(DeliverySalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliverySalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(DeliverySalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCFOPCode = group.Add(new VocabularyKey(nameof(DeliveryCFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCFOPRecId = group.Add(new VocabularyKey(nameof(DeliveryCFOPRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeRecId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuframaDiscountPercentage = group.Add(new VocabularyKey(nameof(SuframaDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceFiscalInformationCode = group.Add(new VocabularyKey(nameof(ServiceFiscalInformationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardBuyerEmail = group.Add(new VocabularyKey(nameof(GiftCardBuyerEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardBuyerName = group.Add(new VocabularyKey(nameof(GiftCardBuyerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardGiftMessage = group.Add(new VocabularyKey(nameof(GiftCardGiftMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardNumber = group.Add(new VocabularyKey(nameof(GiftCardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardRecipientEmail = group.Add(new VocabularyKey(nameof(GiftCardRecipientEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardRecipientName = group.Add(new VocabularyKey(nameof(GiftCardRecipientName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardType = group.Add(new VocabularyKey(nameof(GiftCardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreateAutoCharges = group.Add(new VocabularyKey(nameof(SkipCreateAutoCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductCategoryHierarchyRecId = group.Add(new VocabularyKey(nameof(SalesProductCategoryHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ShippingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedLineDiscountAmount = group.Add(new VocabularyKey(nameof(RetailCalculatedLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedLineDiscountPercentage = group.Add(new VocabularyKey(nameof(RetailCalculatedLineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedManualLineDiscountAmount = group.Add(new VocabularyKey(nameof(RetailCalculatedManualLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedManualLineDiscountPercentage = group.Add(new VocabularyKey(nameof(RetailCalculatedManualLineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedPeriodicDiscountAmount = group.Add(new VocabularyKey(nameof(RetailCalculatedPeriodicDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedPeriodicDiscountPercentage = group.Add(new VocabularyKey(nameof(RetailCalculatedPeriodicDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedTotalDiscountAmount = group.Add(new VocabularyKey(nameof(RetailCalculatedTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedTotalDiscountPercentage = group.Add(new VocabularyKey(nameof(RetailCalculatedTotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedTenderDiscountAmount = group.Add(new VocabularyKey(nameof(RetailCalculatedTenderDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCalculatedTenderDiscountPercentage = group.Add(new VocabularyKey(nameof(RetailCalculatedTenderDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentStatus = group.Add(new VocabularyKey(nameof(FulfillmentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentStoreId = group.Add(new VocabularyKey(nameof(FulfillmentStoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchFrequency = group.Add(new VocabularyKey(nameof(BillSchFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchNumberOfInstallments = group.Add(new VocabularyKey(nameof(BillSchNumberOfInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchProrate = group.Add(new VocabularyKey(nameof(BillSchProrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchIsActualDate = group.Add(new VocabularyKey(nameof(BillSchIsActualDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchRenewalDate = group.Add(new VocabularyKey(nameof(BillSchRenewalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchRenewable = group.Add(new VocabularyKey(nameof(BillSchRenewable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchPercent = group.Add(new VocabularyKey(nameof(BillSchPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductFlavor = group.Add(new VocabularyKey(nameof(ProductFlavor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecRevenueScheduleId = group.Add(new VocabularyKey(nameof(RevRecRevenueScheduleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecOccurrences = group.Add(new VocabularyKey(nameof(RevRecOccurrences), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecContractEndDate = group.Add(new VocabularyKey(nameof(RevRecContractEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecContractStartDate = group.Add(new VocabularyKey(nameof(RevRecContractStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecSalesDeliverNow = group.Add(new VocabularyKey(nameof(RevRecSalesDeliverNow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSchRevRecArrears = group.Add(new VocabularyKey(nameof(BillSchRevRecArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey SalesOrderLineStatus { get; private set; }
        public VocabularyKey IsLineStopped { get; private set; }
        public VocabularyKey CustomersLineNumber { get; private set; }
        public VocabularyKey CustomsDocumentDate { get; private set; }
        public VocabularyKey CustomsDocumentNumber { get; private set; }
        public VocabularyKey CustomsDocumentName { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey SalesOrderPromisingMethod { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsId { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey MultilineDiscountAmount { get; private set; }
        public VocabularyKey MultilineDiscountPercentage { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey AllowedOverdeliveryPercentage { get; private set; }
        public VocabularyKey PackingUnitSymbol { get; private set; }
        public VocabularyKey WillAutomaticInventoryReservationConsiderBatchAttributes { get; private set; }
        public VocabularyKey WillRebateCalculationExcludeLine { get; private set; }
        public VocabularyKey SalesRebateProductGroupId { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey SalesPriceQuantity { get; private set; }
        public VocabularyKey EInvoicePropertyNumber { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey ConfirmedReceiptDate { get; private set; }
        public VocabularyKey RequestedReceiptDate { get; private set; }
        public VocabularyKey InventoryReservationMethod { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey OrderedSalesQuantity { get; private set; }
        public VocabularyKey OrderedCatchWeightQuantity { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey ServiceOrderNumber { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey IsIntrastatTriangularDeal { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey AllowedUnderdeliveryPercentage { get; private set; }
        public VocabularyKey SalesProductCategoryName { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ShippingWarehouseId { get; private set; }
        public VocabularyKey ShippingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey OrderLineReference { get; private set; }
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
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey IntrastatCommodityCode { get; private set; }
        public VocabularyKey EInvoiceDimensionAccountCode { get; private set; }
        public VocabularyKey WithholdingTaxGroupCode { get; private set; }
        public VocabularyKey ItemWithholdingTaxCodeGroupCode { get; private set; }
        public VocabularyKey CreditNoteReasonCode { get; private set; }
        public VocabularyKey IntrastatStatisticValue { get; private set; }
        public VocabularyKey IntrastatSpecialMovementCode { get; private set; }
        public VocabularyKey DeliverySalesTaxGroupCode { get; private set; }
        public VocabularyKey DeliverySalesTaxItemGroupCode { get; private set; }
        public VocabularyKey DeliveryCFOPCode { get; private set; }
        public VocabularyKey DeliveryCFOPRecId { get; private set; }
        public VocabularyKey CFOPCode { get; private set; }
        public VocabularyKey CFOPTableRecId { get; private set; }
        public VocabularyKey FiscalDocumentTypeRecId { get; private set; }
        public VocabularyKey SuframaDiscountPercentage { get; private set; }
        public VocabularyKey ServiceFiscalInformationCode { get; private set; }
        public VocabularyKey FiscalDocumentTypeId { get; private set; }
        public VocabularyKey LineCreationSequenceNumber { get; private set; }
        public VocabularyKey GiftCardBuyerEmail { get; private set; }
        public VocabularyKey GiftCardBuyerName { get; private set; }
        public VocabularyKey GiftCardGiftMessage { get; private set; }
        public VocabularyKey GiftCardNumber { get; private set; }
        public VocabularyKey GiftCardRecipientEmail { get; private set; }
        public VocabularyKey GiftCardRecipientName { get; private set; }
        public VocabularyKey GiftCardType { get; private set; }
        public VocabularyKey SkipCreateAutoCharges { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey SalesProductCategoryHierarchyRecId { get; private set; }
        public VocabularyKey ShippingWarehouseLocationId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey RetailCalculatedLineDiscountAmount { get; private set; }
        public VocabularyKey RetailCalculatedLineDiscountPercentage { get; private set; }
        public VocabularyKey RetailCalculatedManualLineDiscountAmount { get; private set; }
        public VocabularyKey RetailCalculatedManualLineDiscountPercentage { get; private set; }
        public VocabularyKey RetailCalculatedPeriodicDiscountAmount { get; private set; }
        public VocabularyKey RetailCalculatedPeriodicDiscountPercentage { get; private set; }
        public VocabularyKey RetailCalculatedTotalDiscountAmount { get; private set; }
        public VocabularyKey RetailCalculatedTotalDiscountPercentage { get; private set; }
        public VocabularyKey RetailCalculatedTenderDiscountAmount { get; private set; }
        public VocabularyKey RetailCalculatedTenderDiscountPercentage { get; private set; }
        public VocabularyKey FulfillmentStatus { get; private set; }
        public VocabularyKey FulfillmentStoreId { get; private set; }
        public VocabularyKey BillSchFrequency { get; private set; }
        public VocabularyKey BillSchNumberOfInstallments { get; private set; }
        public VocabularyKey BillSchProrate { get; private set; }
        public VocabularyKey BillSchIsActualDate { get; private set; }
        public VocabularyKey BillSchRenewalDate { get; private set; }
        public VocabularyKey BillSchRenewable { get; private set; }
        public VocabularyKey BillSchPercent { get; private set; }
        public VocabularyKey ProductFlavor { get; private set; }
        public VocabularyKey RevRecRevenueScheduleId { get; private set; }
        public VocabularyKey RevRecOccurrences { get; private set; }
        public VocabularyKey RevRecContractEndDate { get; private set; }
        public VocabularyKey RevRecContractStartDate { get; private set; }
        public VocabularyKey RevRecSalesDeliverNow { get; private set; }
        public VocabularyKey BillSchRevRecArrears { get; private set; }


    }
}