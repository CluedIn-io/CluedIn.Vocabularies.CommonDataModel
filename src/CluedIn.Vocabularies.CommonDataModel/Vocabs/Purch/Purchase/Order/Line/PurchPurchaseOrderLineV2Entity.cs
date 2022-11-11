using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderLineV2EntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderLineV2EntityVocabulary()
        {
            VocabularyName = "PurchPurchaseOrderLineV2Entity";
            KeyPrefix = "commonDataModel.purchpurchaseorderlinev2entity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderLineV2Entity";

            AddGroup("PurchPurchaseOrderLineV2Entity Details", group =>
            {
                PurchaseOrderLineStatus = group.Add(new VocabularyKey(nameof(PurchaseOrderLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplate = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateName = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetValueModelId = group.Add(new VocabularyKey(nameof(FixedAssetValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetTransactionType = group.Add(new VocabularyKey(nameof(FixedAssetTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Barcode = group.Add(new VocabularyKey(nameof(Barcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCodeSetupId = group.Add(new VocabularyKey(nameof(BarCodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLineStopped = group.Add(new VocabularyKey(nameof(IsLineStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPartialDeliveryPrevented = group.Add(new VocabularyKey(nameof(IsPartialDeliveryPrevented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNewFixedAsset = group.Add(new VocabularyKey(nameof(IsNewFixedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTHSTTaxType = group.Add(new VocabularyKey(nameof(GSTHSTTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceMatchingPolicy = group.Add(new VocabularyKey(nameof(VendorInvoiceMatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DIOTOperationType = group.Add(new VocabularyKey(nameof(DIOTOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(OrderedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryRecId = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedPurchaseQuantity = group.Add(new VocabularyKey(nameof(OrderedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRebateVendorGroupId = group.Add(new VocabularyKey(nameof(PurchaseRebateVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Amount = group.Add(new VocabularyKey(nameof(Tax1099Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099StateId = group.Add(new VocabularyKey(nameof(Tax1099StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099StateAmount = group.Add(new VocabularyKey(nameof(Tax1099StateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCommodity = group.Add(new VocabularyKey(nameof(IntrastatCommodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCommodityCode = group.Add(new VocabularyKey(nameof(IntrastatCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntrastatTriangularDeal = group.Add(new VocabularyKey(nameof(IsIntrastatTriangularDeal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginStateId = group.Add(new VocabularyKey(nameof(OriginStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailProductVariantNumber = group.Add(new VocabularyKey(nameof(RetailProductVariantNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDelveryAddress = group.Add(new VocabularyKey(nameof(FormattedDelveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCityInKana = group.Add(new VocabularyKey(nameof(DeliveryCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Fields = group.Add(new VocabularyKey(nameof(Tax1099Fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Type = group.Add(new VocabularyKey(nameof(Tax1099Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxId = group.Add(new VocabularyKey(nameof(Tax1099BoxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GVendorStateId = group.Add(new VocabularyKey(nameof(Tax1099GVendorStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GVendorStateTaxId = group.Add(new VocabularyKey(nameof(Tax1099GVendorStateTaxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GStateTaxWithheldAmount = group.Add(new VocabularyKey(nameof(Tax1099GStateTaxWithheldAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GTaxYear = group.Add(new VocabularyKey(nameof(Tax1099GTaxYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTax1099GTradeOrBusinessIncome = group.Add(new VocabularyKey(nameof(IsTax1099GTradeOrBusinessIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099SClosingDate = group.Add(new VocabularyKey(nameof(Tax1099SClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099SAddressOrLegalDescription = group.Add(new VocabularyKey(nameof(Tax1099SAddressOrLegalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTax1099SPropertyOrServices = group.Add(new VocabularyKey(nameof(IsTax1099SPropertyOrServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099SBuyerPartOfRealEstateTaxAmount = group.Add(new VocabularyKey(nameof(Tax1099SBuyerPartOfRealEstateTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitWeight = group.Add(new VocabularyKey(nameof(UnitWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCodeRecId = group.Add(new VocabularyKey(nameof(NGPCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductReceivingCrossDockProducts = group.Add(new VocabularyKey(nameof(WillProductReceivingCrossDockProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterRecId = group.Add(new VocabularyKey(nameof(RequesterRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterPersonnelNumber = group.Add(new VocabularyKey(nameof(RequesterPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesUnitSymbol = group.Add(new VocabularyKey(nameof(ProjectSalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ProjectWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectPayWhenPaid = group.Add(new VocabularyKey(nameof(IsProjectPayWhenPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticValue = group.Add(new VocabularyKey(nameof(IntrastatStatisticValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatSpecialMovementCode = group.Add(new VocabularyKey(nameof(IntrastatSpecialMovementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderLineCreationMethod = group.Add(new VocabularyKey(nameof(PurchaseOrderLineCreationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceFiscalInformationCode = group.Add(new VocabularyKey(nameof(ServiceFiscalInformationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineRecId = group.Add(new VocabularyKey(nameof(BudgetReservationLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineNumber = group.Add(new VocabularyKey(nameof(BudgetReservationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationDocumentNumber = group.Add(new VocabularyKey(nameof(BudgetReservationDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionId = group.Add(new VocabularyKey(nameof(PurchaseRequisitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreateAutoCharges = group.Add(new VocabularyKey(nameof(SkipCreateAutoCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRetentionTermRuleId = group.Add(new VocabularyKey(nameof(VendorRetentionTermRuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRetentionTermRuleDescription = group.Add(new VocabularyKey(nameof(VendorRetentionTermRuleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseOrderLineStatus { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey AccountingDistributionTemplate { get; private set; }
        public VocabularyKey AccountingDistributionTemplateName { get; private set; }
        public VocabularyKey FixedAssetValueModelId { get; private set; }
        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey FixedAssetTransactionType { get; private set; }
        public VocabularyKey Barcode { get; private set; }
        public VocabularyKey BarCodeSetupId { get; private set; }
        public VocabularyKey IsLineStopped { get; private set; }
        public VocabularyKey IsPartialDeliveryPrevented { get; private set; }
        public VocabularyKey ConfirmedDeliveryDate { get; private set; }
        public VocabularyKey IsNewFixedAsset { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey GSTHSTTaxType { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey VendorInvoiceMatchingPolicy { get; private set; }
        public VocabularyKey MultilineDiscountAmount { get; private set; }
        public VocabularyKey MultilineDiscountPercentage { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey DIOTOperationType { get; private set; }
        public VocabularyKey AllowedOverdeliveryPercentage { get; private set; }
        public VocabularyKey OrderedCatchWeightQuantity { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey ProcurementProductCategoryRecId { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey OrderedPurchaseQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey PurchaseRebateVendorGroupId { get; private set; }
        public VocabularyKey Tax1099Amount { get; private set; }
        public VocabularyKey Tax1099StateId { get; private set; }
        public VocabularyKey Tax1099StateAmount { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey IntrastatCommodity { get; private set; }
        public VocabularyKey IntrastatCommodityCode { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey IsIntrastatTriangularDeal { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey OriginCountryRegionId { get; private set; }
        public VocabularyKey OriginStateId { get; private set; }
        public VocabularyKey AllowedUnderdeliveryPercentage { get; private set; }
        public VocabularyKey RetailProductVariantNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey FormattedDelveryAddress { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
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
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey ReceivingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey Tax1099Fields { get; private set; }
        public VocabularyKey Tax1099Type { get; private set; }
        public VocabularyKey Tax1099BoxId { get; private set; }
        public VocabularyKey Tax1099GVendorStateId { get; private set; }
        public VocabularyKey Tax1099GVendorStateTaxId { get; private set; }
        public VocabularyKey Tax1099GStateTaxWithheldAmount { get; private set; }
        public VocabularyKey Tax1099GTaxYear { get; private set; }
        public VocabularyKey IsTax1099GTradeOrBusinessIncome { get; private set; }
        public VocabularyKey Tax1099SClosingDate { get; private set; }
        public VocabularyKey Tax1099SAddressOrLegalDescription { get; private set; }
        public VocabularyKey IsTax1099SPropertyOrServices { get; private set; }
        public VocabularyKey Tax1099SBuyerPartOfRealEstateTaxAmount { get; private set; }
        public VocabularyKey UnitWeight { get; private set; }
        public VocabularyKey NGPCodeRecId { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey WillProductReceivingCrossDockProducts { get; private set; }
        public VocabularyKey CatchWeightUnitSymbol { get; private set; }
        public VocabularyKey RequesterRecId { get; private set; }
        public VocabularyKey RequesterPersonnelNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
        public VocabularyKey ProjectTaxGroupCode { get; private set; }
        public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
        public VocabularyKey ProjectSalesUnitSymbol { get; private set; }
        public VocabularyKey ProjectWorkerPersonnelNumber { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectSalesPrice { get; private set; }
        public VocabularyKey IsProjectPayWhenPaid { get; private set; }
        public VocabularyKey IntrastatStatisticValue { get; private set; }
        public VocabularyKey IntrastatSpecialMovementCode { get; private set; }
        public VocabularyKey WithholdingTaxGroupCode { get; private set; }
        public VocabularyKey ItemWithholdingTaxGroupCode { get; private set; }
        public VocabularyKey PurchaseOrderLineCreationMethod { get; private set; }
        public VocabularyKey CFOPCode { get; private set; }
        public VocabularyKey CFOPTableRecId { get; private set; }
        public VocabularyKey ServiceFiscalInformationCode { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey BudgetReservationLineRecId { get; private set; }
        public VocabularyKey BudgetReservationLineNumber { get; private set; }
        public VocabularyKey BudgetReservationDocumentNumber { get; private set; }
        public VocabularyKey PurchaseRequisitionId { get; private set; }
        public VocabularyKey SkipCreateAutoCharges { get; private set; }
        public VocabularyKey ReceivingWarehouseLocationId { get; private set; }
        public VocabularyKey VendorRetentionTermRuleId { get; private set; }
        public VocabularyKey VendorRetentionTermRuleDescription { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }


    }
}