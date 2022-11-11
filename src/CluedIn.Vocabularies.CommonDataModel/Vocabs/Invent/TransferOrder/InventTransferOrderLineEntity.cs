using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventTransferOrderLineEntityVocabulary : SimpleVocabulary
    {
        public InventTransferOrderLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventTransferOrderLineEntity";
            KeyPrefix = "commonDataModel.inventtransferorderlineentity";
            KeySeparator = ".";
            Grouping = "/InventTransferOrderLineEntity";

            AddGroup("Common Data Model InventTransferOrderLineEntity Details", group =>
            {
                IntrastatCostAmount = group.Add(new VocabularyKey(nameof(IntrastatCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPDelayedDemandOffsetDays = group.Add(new VocabularyKey(nameof(ATPDelayedDemandOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPDelayedSupplyOffsetDays = group.Add(new VocabularyKey(nameof(ATPDelayedSupplyOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPBackwardDemandTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPBackwardDemandTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPBackwardSupplyTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPBackwardSupplyTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsATPIncludingPlannedOrders = group.Add(new VocabularyKey(nameof(IsATPIncludingPlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticallyReserved = group.Add(new VocabularyKey(nameof(IsAutomaticallyReserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderPromisingMethod = group.Add(new VocabularyKey(nameof(TransferOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatSpecialMovementCode = group.Add(new VocabularyKey(nameof(IntrastatSpecialMovementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingInventoryLotId = group.Add(new VocabularyKey(nameof(ShippingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingInventoryLotId = group.Add(new VocabularyKey(nameof(ReceivingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapInventoryLotId = group.Add(new VocabularyKey(nameof(ScrapInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingTransitInventoryLotId = group.Add(new VocabularyKey(nameof(ReceivingTransitInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingTransitInventoryLotId = group.Add(new VocabularyKey(nameof(ShippingTransitInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountyId = group.Add(new VocabularyKey(nameof(OriginCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginStateId = group.Add(new VocabularyKey(nameof(OriginStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReceivedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingReceivedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingReceivedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingShippedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingShippedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrappedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ScrappedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ShippedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferCatchWeightQuantity = group.Add(new VocabularyKey(nameof(TransferCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideFEFODateControl = group.Add(new VocabularyKey(nameof(OverrideFEFODateControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedQuantity = group.Add(new VocabularyKey(nameof(ReceivedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingReceivedQuantity = group.Add(new VocabularyKey(nameof(RemainingReceivedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingShippedQuantity = group.Add(new VocabularyKey(nameof(RemainingShippedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrappedQuantity = group.Add(new VocabularyKey(nameof(ScrappedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippedQuantity = group.Add(new VocabularyKey(nameof(ShippedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferQuantity = group.Add(new VocabularyKey(nameof(TransferQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticalValue = group.Add(new VocabularyKey(nameof(IntrastatStatisticalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderNumber = group.Add(new VocabularyKey(nameof(TransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingLedgerDimension = group.Add(new VocabularyKey(nameof(ShippingLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingLedgerDimension = group.Add(new VocabularyKey(nameof(ReceivingLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCommodityCode = group.Add(new VocabularyKey(nameof(IntrastatCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ShippingLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ReceivingLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ShippingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductReceivingCrossDockProducts = group.Add(new VocabularyKey(nameof(WillProductReceivingCrossDockProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiveNowQuantity = group.Add(new VocabularyKey(nameof(ReceiveNowQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipNowQuantity = group.Add(new VocabularyKey(nameof(ShipNowQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiveNowCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReceiveNowCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipNowCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ShipNowCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessableValueTransactionCurrency = group.Add(new VocabularyKey(nameof(AssessableValueTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventCostPriceCalculated = group.Add(new VocabularyKey(nameof(InventCostPriceCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvntCostPrice = group.Add(new VocabularyKey(nameof(InvntCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumRetailPrice = group.Add(new VocabularyKey(nameof(MaximumRetailPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceType = group.Add(new VocabularyKey(nameof(PriceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Retention = group.Add(new VocabularyKey(nameof(Retention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitId = group.Add(new VocabularyKey(nameof(UnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATPriceType = group.Add(new VocabularyKey(nameof(VATPriceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATRetentionCode = group.Add(new VocabularyKey(nameof(VATRetentionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IntrastatCostAmount { get; private set; }
        public VocabularyKey ATPDelayedDemandOffsetDays { get; private set; }
        public VocabularyKey ATPDelayedSupplyOffsetDays { get; private set; }
        public VocabularyKey ATPBackwardDemandTimeFenceDays { get; private set; }
        public VocabularyKey ATPBackwardSupplyTimeFenceDays { get; private set; }
        public VocabularyKey IsATPIncludingPlannedOrders { get; private set; }
        public VocabularyKey ATPTimeFenceDays { get; private set; }
        public VocabularyKey IsAutomaticallyReserved { get; private set; }
        public VocabularyKey TransferOrderPromisingMethod { get; private set; }
        public VocabularyKey IntrastatSpecialMovementCode { get; private set; }
        public VocabularyKey ShippingInventoryLotId { get; private set; }
        public VocabularyKey ReceivingInventoryLotId { get; private set; }
        public VocabularyKey ScrapInventoryLotId { get; private set; }
        public VocabularyKey ReceivingTransitInventoryLotId { get; private set; }
        public VocabularyKey ShippingTransitInventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OriginCountryRegionId { get; private set; }
        public VocabularyKey OriginCountyId { get; private set; }
        public VocabularyKey OriginStateId { get; private set; }
        public VocabularyKey AllowedOverdeliveryPercentage { get; private set; }
        public VocabularyKey ReceivedCatchWeightQuantity { get; private set; }
        public VocabularyKey RemainingReceivedCatchWeightQuantity { get; private set; }
        public VocabularyKey RemainingShippedCatchWeightQuantity { get; private set; }
        public VocabularyKey ScrappedCatchWeightQuantity { get; private set; }
        public VocabularyKey ShippedCatchWeightQuantity { get; private set; }
        public VocabularyKey TransferCatchWeightQuantity { get; private set; }
        public VocabularyKey OverrideFEFODateControl { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey ReceivedQuantity { get; private set; }
        public VocabularyKey RemainingReceivedQuantity { get; private set; }
        public VocabularyKey RemainingShippedQuantity { get; private set; }
        public VocabularyKey ScrappedQuantity { get; private set; }
        public VocabularyKey ShippedQuantity { get; private set; }
        public VocabularyKey TransferQuantity { get; private set; }
        public VocabularyKey RequestedReceiptDate { get; private set; }
        public VocabularyKey LineStatus { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey IntrastatStatisticalValue { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey TransferOrderNumber { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey AllowedUnderdeliveryPercentage { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey ShippingLedgerDimension { get; private set; }
        public VocabularyKey ReceivingLedgerDimension { get; private set; }
        public VocabularyKey IntrastatCommodityCode { get; private set; }
        public VocabularyKey ShippingLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ReceivingLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ShippingWarehouseId { get; private set; }
        public VocabularyKey ShippingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ShippingWarehouseLocationId { get; private set; }
        public VocabularyKey WillProductReceivingCrossDockProducts { get; private set; }
        public VocabularyKey ReceiveNowQuantity { get; private set; }
        public VocabularyKey ShipNowQuantity { get; private set; }
        public VocabularyKey ReceiveNowCatchWeightQuantity { get; private set; }
        public VocabularyKey ShipNowCatchWeightQuantity { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey AssessableValueTransactionCurrency { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey InventCostPriceCalculated { get; private set; }
        public VocabularyKey InvntCostPrice { get; private set; }
        public VocabularyKey MaximumRetailPrice { get; private set; }
        public VocabularyKey NetAmount { get; private set; }
        public VocabularyKey PriceType { get; private set; }
        public VocabularyKey Retention { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey UnitId { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey VATPriceType { get; private set; }
        public VocabularyKey VATRetentionCode { get; private set; }


    }
}