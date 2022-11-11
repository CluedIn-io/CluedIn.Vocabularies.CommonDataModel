using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedDistinctProductV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedDistinctProductV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResReleasedDistinctProductV2Entity";
            KeyPrefix = "commonDataModel.ecoresreleaseddistinctproductv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedDistinctProductV2Entity";

            AddGroup("Common Data Model EcoResReleasedDistinctProductV2Entity Details", group =>
            {
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemModelGroupId = group.Add(new VocabularyKey(nameof(ItemModelGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupName = group.Add(new VocabularyKey(nameof(StorageDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupName = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryReservationHierarchyName = group.Add(new VocabularyKey(nameof(InventoryReservationHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOrderType = group.Add(new VocabularyKey(nameof(DefaultOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarginABCCode = group.Add(new VocabularyKey(nameof(MarginABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueABCCode = group.Add(new VocabularyKey(nameof(RevenueABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarryingCostABCCode = group.Add(new VocabularyKey(nameof(CarryingCostABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueABCCode = group.Add(new VocabularyKey(nameof(ValueABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductUsageCondition = group.Add(new VocabularyKey(nameof(AlternativeProductUsageCondition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductConfigurationId = group.Add(new VocabularyKey(nameof(AlternativeProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductColorId = group.Add(new VocabularyKey(nameof(AlternativeProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductSizeId = group.Add(new VocabularyKey(nameof(AlternativeProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductStyleId = group.Add(new VocabularyKey(nameof(AlternativeProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeProductVersionId = group.Add(new VocabularyKey(nameof(AlternativeProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeItemNumber = group.Add(new VocabularyKey(nameof(AlternativeItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryIssueAutomaticallyReportAsFinished = group.Add(new VocabularyKey(nameof(WillInventoryIssueAutomaticallyReportAsFinished), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchMergeDateCalculationMethod = group.Add(new VocabularyKey(nameof(BatchMergeDateCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchNumberGroupCode = group.Add(new VocabularyKey(nameof(BatchNumberGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCalculationGroupId = group.Add(new VocabularyKey(nameof(CostCalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMLevel = group.Add(new VocabularyKey(nameof(BOMLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMUnitSymbol = group.Add(new VocabularyKey(nameof(BOMUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlushingPrinciple = group.Add(new VocabularyKey(nameof(FlushingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryReceiptIgnoreFlushingPrinciple = group.Add(new VocabularyKey(nameof(WillInventoryReceiptIgnoreFlushingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionProductGroupId = group.Add(new VocabularyKey(nameof(CommissionProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUnitCostAutomaticallyUpdated = group.Add(new VocabularyKey(nameof(IsUnitCostAutomaticallyUpdated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionConsumptionDensityConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionDensityConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionConsumptionDepthConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionDepthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionConsumptionWidthConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionWidthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionConsumptionHeightConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionHeightConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossDepth = group.Add(new VocabularyKey(nameof(GrossDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossProductHeight = group.Add(new VocabularyKey(nameof(GrossProductHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossProductWidth = group.Add(new VocabularyKey(nameof(GrossProductWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVolume = group.Add(new VocabularyKey(nameof(ProductVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetProductWeight = group.Add(new VocabularyKey(nameof(NetProductWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceToleranceGroupId = group.Add(new VocabularyKey(nameof(PurchasePriceToleranceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceLineMatchingPolicy = group.Add(new VocabularyKey(nameof(VendorInvoiceLineMatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingMaterialGroupId = group.Add(new VocabularyKey(nameof(PackingMaterialGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BestBeforePeriodDays = group.Add(new VocabularyKey(nameof(BestBeforePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightAllocationGroupId = group.Add(new VocabularyKey(nameof(FreightAllocationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRebateProductGroupId = group.Add(new VocabularyKey(nameof(SalesRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PotencyBaseAttributeValueEntryEvent = group.Add(new VocabularyKey(nameof(PotencyBaseAttributeValueEntryEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShelfAdvicePeriodDays = group.Add(new VocabularyKey(nameof(ShelfAdvicePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShelfLifePeriodDays = group.Add(new VocabularyKey(nameof(ShelfLifePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PotencyBaseAttibuteTargetValue = group.Add(new VocabularyKey(nameof(PotencyBaseAttibuteTargetValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedVendorCheckMethod = group.Add(new VocabularyKey(nameof(ApprovedVendorCheckMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhantom = group.Add(new VocabularyKey(nameof(IsPhantom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanningFormulaItemNumber = group.Add(new VocabularyKey(nameof(PlanningFormulaItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionType = group.Add(new VocabularyKey(nameof(ProductionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YieldPercentage = group.Add(new VocabularyKey(nameof(YieldPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryVendorAccountNumber = group.Add(new VocabularyKey(nameof(PrimaryVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionGroupId = group.Add(new VocabularyKey(nameof(ProductionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPoolId = group.Add(new VocabularyKey(nameof(ProductionPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NecessaryProductionWorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(NecessaryProductionWorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchasePriceAutomaticallyUpdated = group.Add(new VocabularyKey(nameof(IsPurchasePriceAutomaticallyUpdated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCoverageGroupId = group.Add(new VocabularyKey(nameof(ProductCoverageGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceCalculationModel = group.Add(new VocabularyKey(nameof(SalesPriceCalculationModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseSalesPriceSource = group.Add(new VocabularyKey(nameof(BaseSalesPriceSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceCalculationContributionRatio = group.Add(new VocabularyKey(nameof(SalesPriceCalculationContributionRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceCalculationChargesPercentage = group.Add(new VocabularyKey(nameof(SalesPriceCalculationChargesPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantScrapQuantity = group.Add(new VocabularyKey(nameof(ConstantScrapQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariableScrapPercentage = group.Add(new VocabularyKey(nameof(VariableScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerialNumberGroupCode = group.Add(new VocabularyKey(nameof(SerialNumberGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAndReceivingSortOrderCode = group.Add(new VocabularyKey(nameof(ShippingAndReceivingSortOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TareProductWeight = group.Add(new VocabularyKey(nameof(TareProductWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingDutyQuantity = group.Add(new VocabularyKey(nameof(PackingDutyQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrivalHandlingTime = group.Add(new VocabularyKey(nameof(ArrivalHandlingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPickQuantity = group.Add(new VocabularyKey(nameof(MaximumPickQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackageClassId = group.Add(new VocabularyKey(nameof(PackageClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackSizeCategoryId = group.Add(new VocabularyKey(nameof(PackSizeCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalDimensionGroupId = group.Add(new VocabularyKey(nameof(PhysicalDimensionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWorkCenterPickingAllowNegativeInventory = group.Add(new VocabularyKey(nameof(WillWorkCenterPickingAllowNegativeInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingQuantity = group.Add(new VocabularyKey(nameof(DefaultReceivingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceDescriptionLine1 = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceDescriptionLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceDescriptionLine2 = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceDescriptionLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitConversionSequenceGroupId = group.Add(new VocabularyKey(nameof(UnitConversionSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RawMaterialPickingPrinciple = group.Add(new VocabularyKey(nameof(RawMaterialPickingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumCatchWeightQuantity = group.Add(new VocabularyKey(nameof(MaximumCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumCatchWeightQuantity = group.Add(new VocabularyKey(nameof(MinimumCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesPriceAdjustmentAllowed = group.Add(new VocabularyKey(nameof(IsSalesPriceAdjustmentAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContinuityEventDuration = group.Add(new VocabularyKey(nameof(ContinuityEventDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContinuityScheduleId = group.Add(new VocabularyKey(nameof(ContinuityScheduleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRestrictedForCoupons = group.Add(new VocabularyKey(nameof(IsRestrictedForCoupons), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDirectDeliveryWarehouse = group.Add(new VocabularyKey(nameof(DefaultDirectDeliveryWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveredDirectly = group.Add(new VocabularyKey(nameof(IsDeliveredDirectly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromAutomaticNotificationAndCancellation = group.Add(new VocabularyKey(nameof(IsExemptFromAutomaticNotificationAndCancellation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInstallmentEligible = group.Add(new VocabularyKey(nameof(IsInstallmentEligible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPickingWorkbenchApplyBoxingLogic = group.Add(new VocabularyKey(nameof(WillPickingWorkbenchApplyBoxingLogic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRebateProductGroupId = group.Add(new VocabularyKey(nameof(PurchaseRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SellEndDate = group.Add(new VocabularyKey(nameof(SellEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SellStartDate = group.Add(new VocabularyKey(nameof(SellStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShipAloneEnabled = group.Add(new VocabularyKey(nameof(IsShipAloneEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipStartDate = group.Add(new VocabularyKey(nameof(ShipStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeSetupId = group.Add(new VocabularyKey(nameof(BarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparisonPriceBaseUnitSymbol = group.Add(new VocabularyKey(nameof(ComparisonPriceBaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsScaleProduct = group.Add(new VocabularyKey(nameof(IsScaleProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPOSRegistrationBlocked = group.Add(new VocabularyKey(nameof(IsPOSRegistrationBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                POSRegistrationBlockedDate = group.Add(new VocabularyKey(nameof(POSRegistrationBlockedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                POSRegistrationPlannedBlockedDate = group.Add(new VocabularyKey(nameof(POSRegistrationPlannedBlockedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                POSRegistrationActivationDate = group.Add(new VocabularyKey(nameof(POSRegistrationActivationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyInPriceRequirementsAtPOSRegister = group.Add(new VocabularyKey(nameof(KeyInPriceRequirementsAtPOSRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyInQuantityRequirementsAtPOSRegister = group.Add(new VocabularyKey(nameof(KeyInQuantityRequirementsAtPOSRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MustKeyInCommentAtPOSRegister = group.Add(new VocabularyKey(nameof(MustKeyInCommentAtPOSRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsZeroPricePOSRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsZeroPricePOSRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDiscountPOSRegistrationProhibited = group.Add(new VocabularyKey(nameof(IsDiscountPOSRegistrationProhibited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPOSRegistrationQuantityNegative = group.Add(new VocabularyKey(nameof(IsPOSRegistrationQuantityNegative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductLifeCycleSeasonCode = group.Add(new VocabularyKey(nameof(ProductLifeCycleSeasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductLifeCycleValidFromDate = group.Add(new VocabularyKey(nameof(ProductLifeCycleValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductLifeCycleValidToDate = group.Add(new VocabularyKey(nameof(ProductLifeCycleValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVariantShelfLabelsPrintingEnabled = group.Add(new VocabularyKey(nameof(IsVariantShelfLabelsPrintingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(TransferOrderOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(TransferOrderUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCostDate = group.Add(new VocabularyKey(nameof(UnitCostDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCostQuantity = group.Add(new VocabularyKey(nameof(UnitCostQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUnitCostIncludingCharges = group.Add(new VocabularyKey(nameof(IsUnitCostIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedCostCharges = group.Add(new VocabularyKey(nameof(FixedCostCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostChargesQuantity = group.Add(new VocabularyKey(nameof(CostChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesUsageBlocked = group.Add(new VocabularyKey(nameof(IsIntercompanySalesUsageBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTotalSalesDiscountCalculationIncludeProduct = group.Add(new VocabularyKey(nameof(WillTotalSalesDiscountCalculationIncludeProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(SalesLineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesMultilineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(SalesMultilineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSupplementaryProductProductGroupId = group.Add(new VocabularyKey(nameof(SalesSupplementaryProductProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesChargeProductGroupId = group.Add(new VocabularyKey(nameof(SalesChargeProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(SalesOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(SalesUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPricingPrecision = group.Add(new VocabularyKey(nameof(SalesPricingPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceDate = group.Add(new VocabularyKey(nameof(SalesPriceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesPriceIncludingCharges = group.Add(new VocabularyKey(nameof(IsSalesPriceIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedSalesPriceCharges = group.Add(new VocabularyKey(nameof(FixedSalesPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesChargesQuantity = group.Add(new VocabularyKey(nameof(SalesChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(PurchaseSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyPurchaseUsageBlocked = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseUsageBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseLineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(PurchaseLineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseMultilineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(PurchaseMultilineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTotalPurchaseDiscountCalculationIncludeProduct = group.Add(new VocabularyKey(nameof(WillTotalPurchaseDiscountCalculationIncludeProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseSupplementaryProductProductGroupId = group.Add(new VocabularyKey(nameof(PurchaseSupplementaryProductProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(PurchaseOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(PurchaseUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePricingPrecision = group.Add(new VocabularyKey(nameof(PurchasePricingPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceDate = group.Add(new VocabularyKey(nameof(PurchasePriceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseChargeProductGroupId = group.Add(new VocabularyKey(nameof(PurchaseChargeProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchasePriceIncludingCharges = group.Add(new VocabularyKey(nameof(IsPurchasePriceIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPurchasePriceCharges = group.Add(new VocabularyKey(nameof(FixedPurchasePriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseChargesQuantity = group.Add(new VocabularyKey(nameof(PurchaseChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTransportationManagementProcessesEnabled = group.Add(new VocabularyKey(nameof(AreTransportationManagementProcessesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCommodityCode = group.Add(new VocabularyKey(nameof(IntrastatCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatChargePercentage = group.Add(new VocabularyKey(nameof(IntrastatChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginStateId = group.Add(new VocabularyKey(nameof(OriginStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproximateSalesTaxPercentage = group.Add(new VocabularyKey(nameof(ApproximateSalesTaxPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemFiscalClassificationExceptionCode = group.Add(new VocabularyKey(nameof(ItemFiscalClassificationExceptionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductFiscalInformationType = group.Add(new VocabularyKey(nameof(ProductFiscalInformationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsICMSTaxAppliedOnService = group.Add(new VocabularyKey(nameof(IsICMSTaxAppliedOnService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductTaxationOrigin = group.Add(new VocabularyKey(nameof(ProductTaxationOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemFiscalClassificationCode = group.Add(new VocabularyKey(nameof(ItemFiscalClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceFiscalInformationCode = group.Add(new VocabularyKey(nameof(ServiceFiscalInformationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesWithholdingTaxCalculated = group.Add(new VocabularyKey(nameof(IsSalesWithholdingTaxCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseWithholdingTaxCalculated = group.Add(new VocabularyKey(nameof(IsPurchaseWithholdingTaxCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseItemWithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(PurchaseItemWithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesGSTReliefCategoryCode = group.Add(new VocabularyKey(nameof(SalesGSTReliefCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseGSTReliefCategoryCode = group.Add(new VocabularyKey(nameof(PurchaseGSTReliefCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryGSTReliefCategoryCode = group.Add(new VocabularyKey(nameof(InventoryGSTReliefCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceType = group.Add(new VocabularyKey(nameof(ServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantablePriceRangeBaseType = group.Add(new VocabularyKey(nameof(WarrantablePriceRangeBaseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(LowerWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(UpperWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTime = group.Add(new VocabularyKey(nameof(WarrantyDurationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTimeUnit = group.Add(new VocabularyKey(nameof(WarrantyDurationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCalculationBOMLevel = group.Add(new VocabularyKey(nameof(CostCalculationBOMLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemModelGroupId { get; private set; }
        public VocabularyKey StorageDimensionGroupName { get; private set; }
        public VocabularyKey TrackingDimensionGroupName { get; private set; }
        public VocabularyKey InventoryReservationHierarchyName { get; private set; }
        public VocabularyKey DefaultOrderType { get; private set; }
        public VocabularyKey MarginABCCode { get; private set; }
        public VocabularyKey RevenueABCCode { get; private set; }
        public VocabularyKey CarryingCostABCCode { get; private set; }
        public VocabularyKey ValueABCCode { get; private set; }
        public VocabularyKey AlternativeProductUsageCondition { get; private set; }
        public VocabularyKey AlternativeProductConfigurationId { get; private set; }
        public VocabularyKey AlternativeProductColorId { get; private set; }
        public VocabularyKey AlternativeProductSizeId { get; private set; }
        public VocabularyKey AlternativeProductStyleId { get; private set; }
        public VocabularyKey AlternativeProductVersionId { get; private set; }
        public VocabularyKey AlternativeItemNumber { get; private set; }
        public VocabularyKey WillInventoryIssueAutomaticallyReportAsFinished { get; private set; }
        public VocabularyKey BatchMergeDateCalculationMethod { get; private set; }
        public VocabularyKey BatchNumberGroupCode { get; private set; }
        public VocabularyKey CostCalculationGroupId { get; private set; }
        public VocabularyKey BOMLevel { get; private set; }
        public VocabularyKey BOMUnitSymbol { get; private set; }
        public VocabularyKey FlushingPrinciple { get; private set; }
        public VocabularyKey WillInventoryReceiptIgnoreFlushingPrinciple { get; private set; }
        public VocabularyKey CommissionProductGroupId { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey IsUnitCostAutomaticallyUpdated { get; private set; }
        public VocabularyKey ProductionConsumptionDensityConversionFactor { get; private set; }
        public VocabularyKey ProductionConsumptionDepthConversionFactor { get; private set; }
        public VocabularyKey ProductionConsumptionWidthConversionFactor { get; private set; }
        public VocabularyKey ProductionConsumptionHeightConversionFactor { get; private set; }
        public VocabularyKey GrossDepth { get; private set; }
        public VocabularyKey GrossProductHeight { get; private set; }
        public VocabularyKey GrossProductWidth { get; private set; }
        public VocabularyKey ProductVolume { get; private set; }
        public VocabularyKey NetProductWeight { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey PurchasePriceToleranceGroupId { get; private set; }
        public VocabularyKey VendorInvoiceLineMatchingPolicy { get; private set; }
        public VocabularyKey PackingMaterialGroupId { get; private set; }
        public VocabularyKey BestBeforePeriodDays { get; private set; }
        public VocabularyKey FreightAllocationGroupId { get; private set; }
        public VocabularyKey SalesRebateProductGroupId { get; private set; }
        public VocabularyKey PotencyBaseAttributeValueEntryEvent { get; private set; }
        public VocabularyKey ShelfAdvicePeriodDays { get; private set; }
        public VocabularyKey ShelfLifePeriodDays { get; private set; }
        public VocabularyKey PotencyBaseAttibuteTargetValue { get; private set; }
        public VocabularyKey ApprovedVendorCheckMethod { get; private set; }
        public VocabularyKey IsPhantom { get; private set; }
        public VocabularyKey PlanningFormulaItemNumber { get; private set; }
        public VocabularyKey ProductionType { get; private set; }
        public VocabularyKey YieldPercentage { get; private set; }
        public VocabularyKey PrimaryVendorAccountNumber { get; private set; }
        public VocabularyKey ProductionGroupId { get; private set; }
        public VocabularyKey ProductionPoolId { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey NecessaryProductionWorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey IsPurchasePriceAutomaticallyUpdated { get; private set; }
        public VocabularyKey ProductCoverageGroupId { get; private set; }
        public VocabularyKey SalesPriceCalculationModel { get; private set; }
        public VocabularyKey BaseSalesPriceSource { get; private set; }
        public VocabularyKey SalesPriceCalculationContributionRatio { get; private set; }
        public VocabularyKey SalesPriceCalculationChargesPercentage { get; private set; }
        public VocabularyKey ConstantScrapQuantity { get; private set; }
        public VocabularyKey VariableScrapPercentage { get; private set; }
        public VocabularyKey SerialNumberGroupCode { get; private set; }
        public VocabularyKey ShippingAndReceivingSortOrderCode { get; private set; }
        public VocabularyKey TareProductWeight { get; private set; }
        public VocabularyKey PackingDutyQuantity { get; private set; }
        public VocabularyKey ArrivalHandlingTime { get; private set; }
        public VocabularyKey MaximumPickQuantity { get; private set; }
        public VocabularyKey PackageClassId { get; private set; }
        public VocabularyKey PackSizeCategoryId { get; private set; }
        public VocabularyKey PhysicalDimensionGroupId { get; private set; }
        public VocabularyKey WillWorkCenterPickingAllowNegativeInventory { get; private set; }
        public VocabularyKey DefaultReceivingQuantity { get; private set; }
        public VocabularyKey WarehouseMobileDeviceDescriptionLine1 { get; private set; }
        public VocabularyKey WarehouseMobileDeviceDescriptionLine2 { get; private set; }
        public VocabularyKey UnitConversionSequenceGroupId { get; private set; }
        public VocabularyKey RawMaterialPickingPrinciple { get; private set; }
        public VocabularyKey CatchWeightUnitSymbol { get; private set; }
        public VocabularyKey MaximumCatchWeightQuantity { get; private set; }
        public VocabularyKey MinimumCatchWeightQuantity { get; private set; }
        public VocabularyKey IsSalesPriceAdjustmentAllowed { get; private set; }
        public VocabularyKey ContinuityEventDuration { get; private set; }
        public VocabularyKey ContinuityScheduleId { get; private set; }
        public VocabularyKey IsRestrictedForCoupons { get; private set; }
        public VocabularyKey DefaultDirectDeliveryWarehouse { get; private set; }
        public VocabularyKey IsDeliveredDirectly { get; private set; }
        public VocabularyKey IsExemptFromAutomaticNotificationAndCancellation { get; private set; }
        public VocabularyKey IsInstallmentEligible { get; private set; }
        public VocabularyKey WillPickingWorkbenchApplyBoxingLogic { get; private set; }
        public VocabularyKey PurchaseRebateProductGroupId { get; private set; }
        public VocabularyKey SellEndDate { get; private set; }
        public VocabularyKey SellStartDate { get; private set; }
        public VocabularyKey IsShipAloneEnabled { get; private set; }
        public VocabularyKey ShipStartDate { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey BarcodeSetupId { get; private set; }
        public VocabularyKey ComparisonPriceBaseUnitSymbol { get; private set; }
        public VocabularyKey IsScaleProduct { get; private set; }
        public VocabularyKey IsPOSRegistrationBlocked { get; private set; }
        public VocabularyKey POSRegistrationBlockedDate { get; private set; }
        public VocabularyKey POSRegistrationPlannedBlockedDate { get; private set; }
        public VocabularyKey POSRegistrationActivationDate { get; private set; }
        public VocabularyKey KeyInPriceRequirementsAtPOSRegister { get; private set; }
        public VocabularyKey KeyInQuantityRequirementsAtPOSRegister { get; private set; }
        public VocabularyKey MustKeyInCommentAtPOSRegister { get; private set; }
        public VocabularyKey IsZeroPricePOSRegistrationAllowed { get; private set; }
        public VocabularyKey IsDiscountPOSRegistrationProhibited { get; private set; }
        public VocabularyKey IsPOSRegistrationQuantityNegative { get; private set; }
        public VocabularyKey ProductLifeCycleSeasonCode { get; private set; }
        public VocabularyKey ProductLifeCycleValidFromDate { get; private set; }
        public VocabularyKey ProductLifeCycleValidToDate { get; private set; }
        public VocabularyKey IsVariantShelfLabelsPrintingEnabled { get; private set; }
        public VocabularyKey TransferOrderOverdeliveryPercentage { get; private set; }
        public VocabularyKey TransferOrderUnderdeliveryPercentage { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey UnitCostDate { get; private set; }
        public VocabularyKey UnitCostQuantity { get; private set; }
        public VocabularyKey IsUnitCostIncludingCharges { get; private set; }
        public VocabularyKey FixedCostCharges { get; private set; }
        public VocabularyKey CostChargesQuantity { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey IsIntercompanySalesUsageBlocked { get; private set; }
        public VocabularyKey SalesSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey WillTotalSalesDiscountCalculationIncludeProduct { get; private set; }
        public VocabularyKey SalesLineDiscountProductGroupCode { get; private set; }
        public VocabularyKey SalesMultilineDiscountProductGroupCode { get; private set; }
        public VocabularyKey SalesSupplementaryProductProductGroupId { get; private set; }
        public VocabularyKey SalesChargeProductGroupId { get; private set; }
        public VocabularyKey SalesOverdeliveryPercentage { get; private set; }
        public VocabularyKey SalesUnderdeliveryPercentage { get; private set; }
        public VocabularyKey SalesPricingPrecision { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceDate { get; private set; }
        public VocabularyKey SalesPriceQuantity { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey IsSalesPriceIncludingCharges { get; private set; }
        public VocabularyKey FixedSalesPriceCharges { get; private set; }
        public VocabularyKey SalesChargesQuantity { get; private set; }
        public VocabularyKey PurchaseSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey IsIntercompanyPurchaseUsageBlocked { get; private set; }
        public VocabularyKey PurchaseLineDiscountProductGroupCode { get; private set; }
        public VocabularyKey PurchaseMultilineDiscountProductGroupCode { get; private set; }
        public VocabularyKey WillTotalPurchaseDiscountCalculationIncludeProduct { get; private set; }
        public VocabularyKey PurchaseSupplementaryProductProductGroupId { get; private set; }
        public VocabularyKey PurchaseOverdeliveryPercentage { get; private set; }
        public VocabularyKey PurchaseUnderdeliveryPercentage { get; private set; }
        public VocabularyKey PurchasePricingPrecision { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey PurchasePriceDate { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey PurchaseChargeProductGroupId { get; private set; }
        public VocabularyKey IsPurchasePriceIncludingCharges { get; private set; }
        public VocabularyKey FixedPurchasePriceCharges { get; private set; }
        public VocabularyKey PurchaseChargesQuantity { get; private set; }
        public VocabularyKey AreTransportationManagementProcessesEnabled { get; private set; }
        public VocabularyKey IntrastatCommodityCode { get; private set; }
        public VocabularyKey IntrastatChargePercentage { get; private set; }
        public VocabularyKey OriginCountryRegionId { get; private set; }
        public VocabularyKey OriginStateId { get; private set; }
        public VocabularyKey ApproximateSalesTaxPercentage { get; private set; }
        public VocabularyKey ItemFiscalClassificationExceptionCode { get; private set; }
        public VocabularyKey ProductFiscalInformationType { get; private set; }
        public VocabularyKey IsICMSTaxAppliedOnService { get; private set; }
        public VocabularyKey ProductTaxationOrigin { get; private set; }
        public VocabularyKey ItemFiscalClassificationCode { get; private set; }
        public VocabularyKey ServiceFiscalInformationCode { get; private set; }
        public VocabularyKey IsSalesWithholdingTaxCalculated { get; private set; }
        public VocabularyKey SalesItemWithholdingTaxGroupCode { get; private set; }
        public VocabularyKey IsPurchaseWithholdingTaxCalculated { get; private set; }
        public VocabularyKey PurchaseItemWithholdingTaxGroupCode { get; private set; }
        public VocabularyKey SalesGSTReliefCategoryCode { get; private set; }
        public VocabularyKey PurchaseGSTReliefCategoryCode { get; private set; }
        public VocabularyKey InventoryGSTReliefCategoryCode { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey ServiceType { get; private set; }
        public VocabularyKey WarrantablePriceRangeBaseType { get; private set; }
        public VocabularyKey LowerWarrantablePriceRangeLimit { get; private set; }
        public VocabularyKey UpperWarrantablePriceRangeLimit { get; private set; }
        public VocabularyKey WarrantyDurationTime { get; private set; }
        public VocabularyKey WarrantyDurationTimeUnit { get; private set; }
        public VocabularyKey CostCalculationBOMLevel { get; private set; }


    }
}