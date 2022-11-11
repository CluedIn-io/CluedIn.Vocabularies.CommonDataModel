using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAttributesLegalEntityLookupEntityVocabulary : SimpleVocabulary
    {
        public RetailAttributesLegalEntityLookupEntityVocabulary()
        {
            VocabularyName = "RetailAttributesLegalEntityLookupEntity";
            KeyPrefix = "commonDataModel.retailattributeslegalentitylookupentity";
            KeySeparator = ".";
            Grouping = "/RetailAttributesLegalEntityLookupEntity";

            AddGroup("RetailAttributesLegalEntityLookupEntity Details", group =>
            {
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCodeSetup = group.Add(new VocabularyKey(nameof(BarCodeSetup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupCounting = group.Add(new VocabularyKey(nameof(GroupCounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupCoverage = group.Add(new VocabularyKey(nameof(GroupCoverage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupInventoryModel = group.Add(new VocabularyKey(nameof(GroupInventoryModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupItemGroup = group.Add(new VocabularyKey(nameof(GroupItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemLegalEntity = group.Add(new VocabularyKey(nameof(ItemLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroupPurchase = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroupPurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroupSales = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroupSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentRule = group.Add(new VocabularyKey(nameof(ReplenishmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportItemLabel = group.Add(new VocabularyKey(nameof(ReportItemLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportShelfLabel = group.Add(new VocabularyKey(nameof(ReportShelfLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPriceSales = group.Add(new VocabularyKey(nameof(UnitPriceSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryWarehouse = group.Add(new VocabularyKey(nameof(InventoryWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseWarehouse = group.Add(new VocabularyKey(nameof(PurchaseWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesWarehouse = group.Add(new VocabularyKey(nameof(SalesWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnPolicyNumber = group.Add(new VocabularyKey(nameof(ReturnPolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseComparisonUnitSymbol = group.Add(new VocabularyKey(nameof(BaseComparisonUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfMaterialsUnitSymbol = group.Add(new VocabularyKey(nameof(BillOfMaterialsUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOverdeliveryPct = group.Add(new VocabularyKey(nameof(PurchaseOverdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnderdeliveryPct = group.Add(new VocabularyKey(nameof(PurchaseUnderdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOverdeliveryPct = group.Add(new VocabularyKey(nameof(SalesOverdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnderdeliveryPct = group.Add(new VocabularyKey(nameof(SalesUnderdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOverdeliveryPct = group.Add(new VocabularyKey(nameof(InventoryOverdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnderdeliveryPct = group.Add(new VocabularyKey(nameof(InventoryUnderdeliveryPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchModel = group.Add(new VocabularyKey(nameof(PurchModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostModel = group.Add(new VocabularyKey(nameof(CostModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBuyerGroupId = group.Add(new VocabularyKey(nameof(ItemBuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseInterCompanyBlocked = group.Add(new VocabularyKey(nameof(PurchaseInterCompanyBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemPriceToleranceGroupId = group.Add(new VocabularyKey(nameof(ItemPriceToleranceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryVendorId = group.Add(new VocabularyKey(nameof(PrimaryVendorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceDate = group.Add(new VocabularyKey(nameof(PurchasePriceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseMarkup = group.Add(new VocabularyKey(nameof(PurchaseMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQty = group.Add(new VocabularyKey(nameof(PurchasePriceQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseMarkupGroupId = group.Add(new VocabularyKey(nameof(PurchaseMarkupGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAllocateMarkup = group.Add(new VocabularyKey(nameof(PurchaseAllocateMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseLineDisc = group.Add(new VocabularyKey(nameof(PurchaseLineDisc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseMultiLineDisc = group.Add(new VocabularyKey(nameof(PurchaseMultiLineDisc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseEndDisc = group.Add(new VocabularyKey(nameof(PurchaseEndDisc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseSuppItemGroupId = group.Add(new VocabularyKey(nameof(PurchaseSuppItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePDSPricingPrecision = group.Add(new VocabularyKey(nameof(PurchasePDSPricingPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemVendRebateGroupId = group.Add(new VocabularyKey(nameof(ItemVendRebateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PdsVendorCheckItem = group.Add(new VocabularyKey(nameof(PdsVendorCheckItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetWeight = group.Add(new VocabularyKey(nameof(NetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaraWeight = group.Add(new VocabularyKey(nameof(TaraWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossDepth = group.Add(new VocabularyKey(nameof(GrossDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossWidth = group.Add(new VocabularyKey(nameof(GrossWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossHeight = group.Add(new VocabularyKey(nameof(GrossHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitVolume = group.Add(new VocabularyKey(nameof(UnitVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchNumGroupId = group.Add(new VocabularyKey(nameof(BatchNumGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerialNumGroupId = group.Add(new VocabularyKey(nameof(SerialNumGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WMSArrivalHandlingTime = group.Add(new VocabularyKey(nameof(WMSArrivalHandlingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortCode = group.Add(new VocabularyKey(nameof(SortCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackagingGroupId = group.Add(new VocabularyKey(nameof(PackagingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPackagingQty = group.Add(new VocabularyKey(nameof(TaxPackagingQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPriceDate = group.Add(new VocabularyKey(nameof(InventoryPriceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPrice = group.Add(new VocabularyKey(nameof(InventoryPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPriceUnit = group.Add(new VocabularyKey(nameof(InventoryPriceUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryMarkup = group.Add(new VocabularyKey(nameof(InventoryMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPriceQty = group.Add(new VocabularyKey(nameof(InventoryPriceQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAllocateMarkup = group.Add(new VocabularyKey(nameof(InventoryAllocateMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABCValue = group.Add(new VocabularyKey(nameof(ABCValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABCContributionMargin = group.Add(new VocabularyKey(nameof(ABCContributionMargin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABCRevenue = group.Add(new VocabularyKey(nameof(ABCRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABCTieUp = group.Add(new VocabularyKey(nameof(ABCTieUp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesInterCompanyBlocked = group.Add(new VocabularyKey(nameof(SalesInterCompanyBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCommisionGroupId = group.Add(new VocabularyKey(nameof(SalesCommisionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceModel = group.Add(new VocabularyKey(nameof(SalesPriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesBasePriceModel = group.Add(new VocabularyKey(nameof(SalesBasePriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesContributionRatio = group.Add(new VocabularyKey(nameof(SalesContributionRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPercentMarkup = group.Add(new VocabularyKey(nameof(SalesPercentMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceDate = group.Add(new VocabularyKey(nameof(SalesPriceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceMarkup = group.Add(new VocabularyKey(nameof(SalesPriceMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceMarkupQuantity = group.Add(new VocabularyKey(nameof(SalesPriceMarkupQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesMarkupGroupId = group.Add(new VocabularyKey(nameof(SalesMarkupGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAllocateMarkup = group.Add(new VocabularyKey(nameof(SalesAllocateMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLineDiscount = group.Add(new VocabularyKey(nameof(SalesLineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesMultiLineDiscount = group.Add(new VocabularyKey(nameof(SalesMultiLineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTotalDiscount = group.Add(new VocabularyKey(nameof(SalesTotalDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSuppItemGroupId = group.Add(new VocabularyKey(nameof(SalesSuppItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUseAltItemId = group.Add(new VocabularyKey(nameof(SalesUseAltItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAltItemId = group.Add(new VocabularyKey(nameof(SalesAltItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAltConfigId = group.Add(new VocabularyKey(nameof(SalesAltConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAltInventSizeId = group.Add(new VocabularyKey(nameof(SalesAltInventSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAltInventColorId = group.Add(new VocabularyKey(nameof(SalesAltInventColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAltInventStyleId = group.Add(new VocabularyKey(nameof(SalesAltInventStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesInstallmentEligible = group.Add(new VocabularyKey(nameof(SalesInstallmentEligible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPDSPricingPrecision = group.Add(new VocabularyKey(nameof(SalesPDSPricingPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesFTCExempt = group.Add(new VocabularyKey(nameof(SalesFTCExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAllowPriceAdjust = group.Add(new VocabularyKey(nameof(SalesAllowPriceAdjust), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesContinuityScheduleId = group.Add(new VocabularyKey(nameof(SalesContinuityScheduleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesStartDate = group.Add(new VocabularyKey(nameof(SalesStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesEndDate = group.Add(new VocabularyKey(nameof(SalesEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPdsItemRebateGroupId = group.Add(new VocabularyKey(nameof(SalesPdsItemRebateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPdsFreightAllocationGroupId = group.Add(new VocabularyKey(nameof(SalesPdsFreightAllocationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailBarCodeUseEANStandard = group.Add(new VocabularyKey(nameof(RetailBarCodeUseEANStandard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailBlockedAtRegister = group.Add(new VocabularyKey(nameof(RetailBlockedAtRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailDateBlocked = group.Add(new VocabularyKey(nameof(RetailDateBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailDateToActivateItem = group.Add(new VocabularyKey(nameof(RetailDateToActivateItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailDateToBeBlocked = group.Add(new VocabularyKey(nameof(RetailDateToBeBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSAllowNegativeQuantity = group.Add(new VocabularyKey(nameof(RetailPOSAllowNegativeQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSDisallowDiscount = group.Add(new VocabularyKey(nameof(RetailPOSDisallowDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSIsScaleItem = group.Add(new VocabularyKey(nameof(RetailPOSIsScaleItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSIsZeroPriceValid = group.Add(new VocabularyKey(nameof(RetailPOSIsZeroPriceValid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSKeyingInPrice = group.Add(new VocabularyKey(nameof(RetailPOSKeyingInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSKeyingInQuantity = group.Add(new VocabularyKey(nameof(RetailPOSKeyingInQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSMustKeyInComment = group.Add(new VocabularyKey(nameof(RetailPOSMustKeyInComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPOSDisallowManualDiscount = group.Add(new VocabularyKey(nameof(RetailPOSDisallowManualDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPrintVariantsShelfLabels = group.Add(new VocabularyKey(nameof(RetailPrintVariantsShelfLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailSeasonCode = group.Add(new VocabularyKey(nameof(RetailSeasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLifeFrom = group.Add(new VocabularyKey(nameof(RetailLifeFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLifeTo = group.Add(new VocabularyKey(nameof(RetailLifeTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRetailInventoryAvailabilityBuffer = group.Add(new VocabularyKey(nameof(SalesRetailInventoryAvailabilityBuffer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRetailInventoryAvailabilityLevelProfile = group.Add(new VocabularyKey(nameof(SalesRetailInventoryAvailabilityLevelProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey BarCodeSetup { get; private set; }
        public VocabularyKey GroupCounting { get; private set; }
        public VocabularyKey GroupCoverage { get; private set; }
        public VocabularyKey GroupInventoryModel { get; private set; }
        public VocabularyKey GroupItemGroup { get; private set; }
        public VocabularyKey ItemLegalEntity { get; private set; }
        public VocabularyKey ItemSalesTaxGroupPurchase { get; private set; }
        public VocabularyKey ItemSalesTaxGroupSales { get; private set; }
        public VocabularyKey ReplenishmentRule { get; private set; }
        public VocabularyKey ReportItemLabel { get; private set; }
        public VocabularyKey ReportShelfLabel { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey UnitPriceSales { get; private set; }
        public VocabularyKey InventoryWarehouse { get; private set; }
        public VocabularyKey PurchaseWarehouse { get; private set; }
        public VocabularyKey SalesWarehouse { get; private set; }
        public VocabularyKey ReturnPolicyNumber { get; private set; }
        public VocabularyKey BaseComparisonUnitSymbol { get; private set; }
        public VocabularyKey BillOfMaterialsUnitSymbol { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey PurchaseOverdeliveryPct { get; private set; }
        public VocabularyKey PurchaseUnderdeliveryPct { get; private set; }
        public VocabularyKey SalesOverdeliveryPct { get; private set; }
        public VocabularyKey SalesUnderdeliveryPct { get; private set; }
        public VocabularyKey InventoryOverdeliveryPct { get; private set; }
        public VocabularyKey InventoryUnderdeliveryPct { get; private set; }
        public VocabularyKey PurchModel { get; private set; }
        public VocabularyKey CostModel { get; private set; }
        public VocabularyKey ItemBuyerGroupId { get; private set; }
        public VocabularyKey PurchaseInterCompanyBlocked { get; private set; }
        public VocabularyKey ItemPriceToleranceGroupId { get; private set; }
        public VocabularyKey PrimaryVendorId { get; private set; }
        public VocabularyKey PurchasePriceDate { get; private set; }
        public VocabularyKey PurchasePrice { get; private set; }
        public VocabularyKey PurchaseMarkup { get; private set; }
        public VocabularyKey PurchasePriceQty { get; private set; }
        public VocabularyKey PurchaseMarkupGroupId { get; private set; }
        public VocabularyKey PurchaseAllocateMarkup { get; private set; }
        public VocabularyKey PurchaseLineDisc { get; private set; }
        public VocabularyKey PurchaseMultiLineDisc { get; private set; }
        public VocabularyKey PurchaseEndDisc { get; private set; }
        public VocabularyKey PurchaseSuppItemGroupId { get; private set; }
        public VocabularyKey PurchasePDSPricingPrecision { get; private set; }
        public VocabularyKey ItemVendRebateGroupId { get; private set; }
        public VocabularyKey PdsVendorCheckItem { get; private set; }
        public VocabularyKey NetWeight { get; private set; }
        public VocabularyKey TaraWeight { get; private set; }
        public VocabularyKey GrossDepth { get; private set; }
        public VocabularyKey GrossWidth { get; private set; }
        public VocabularyKey GrossHeight { get; private set; }
        public VocabularyKey UnitVolume { get; private set; }
        public VocabularyKey BatchNumGroupId { get; private set; }
        public VocabularyKey SerialNumGroupId { get; private set; }
        public VocabularyKey WMSArrivalHandlingTime { get; private set; }
        public VocabularyKey SortCode { get; private set; }
        public VocabularyKey PackagingGroupId { get; private set; }
        public VocabularyKey TaxPackagingQty { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey InventoryPriceDate { get; private set; }
        public VocabularyKey InventoryPrice { get; private set; }
        public VocabularyKey InventoryPriceUnit { get; private set; }
        public VocabularyKey InventoryMarkup { get; private set; }
        public VocabularyKey InventoryPriceQty { get; private set; }
        public VocabularyKey InventoryAllocateMarkup { get; private set; }
        public VocabularyKey ABCValue { get; private set; }
        public VocabularyKey ABCContributionMargin { get; private set; }
        public VocabularyKey ABCRevenue { get; private set; }
        public VocabularyKey ABCTieUp { get; private set; }
        public VocabularyKey SalesInterCompanyBlocked { get; private set; }
        public VocabularyKey SalesCommisionGroupId { get; private set; }
        public VocabularyKey SalesPriceModel { get; private set; }
        public VocabularyKey SalesBasePriceModel { get; private set; }
        public VocabularyKey SalesContributionRatio { get; private set; }
        public VocabularyKey SalesPercentMarkup { get; private set; }
        public VocabularyKey SalesPriceDate { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceMarkup { get; private set; }
        public VocabularyKey SalesPriceMarkupQuantity { get; private set; }
        public VocabularyKey SalesMarkupGroupId { get; private set; }
        public VocabularyKey SalesAllocateMarkup { get; private set; }
        public VocabularyKey SalesLineDiscount { get; private set; }
        public VocabularyKey SalesMultiLineDiscount { get; private set; }
        public VocabularyKey SalesTotalDiscount { get; private set; }
        public VocabularyKey SalesSuppItemGroupId { get; private set; }
        public VocabularyKey SalesUseAltItemId { get; private set; }
        public VocabularyKey SalesAltItemId { get; private set; }
        public VocabularyKey SalesAltConfigId { get; private set; }
        public VocabularyKey SalesAltInventSizeId { get; private set; }
        public VocabularyKey SalesAltInventColorId { get; private set; }
        public VocabularyKey SalesAltInventStyleId { get; private set; }
        public VocabularyKey SalesInstallmentEligible { get; private set; }
        public VocabularyKey SalesPDSPricingPrecision { get; private set; }
        public VocabularyKey SalesFTCExempt { get; private set; }
        public VocabularyKey SalesAllowPriceAdjust { get; private set; }
        public VocabularyKey SalesContinuityScheduleId { get; private set; }
        public VocabularyKey SalesStartDate { get; private set; }
        public VocabularyKey SalesEndDate { get; private set; }
        public VocabularyKey SalesPdsItemRebateGroupId { get; private set; }
        public VocabularyKey SalesPdsFreightAllocationGroupId { get; private set; }
        public VocabularyKey RetailBarCodeUseEANStandard { get; private set; }
        public VocabularyKey RetailBlockedAtRegister { get; private set; }
        public VocabularyKey RetailDateBlocked { get; private set; }
        public VocabularyKey RetailDateToActivateItem { get; private set; }
        public VocabularyKey RetailDateToBeBlocked { get; private set; }
        public VocabularyKey RetailPOSAllowNegativeQuantity { get; private set; }
        public VocabularyKey RetailPOSDisallowDiscount { get; private set; }
        public VocabularyKey RetailPOSIsScaleItem { get; private set; }
        public VocabularyKey RetailPOSIsZeroPriceValid { get; private set; }
        public VocabularyKey RetailPOSKeyingInPrice { get; private set; }
        public VocabularyKey RetailPOSKeyingInQuantity { get; private set; }
        public VocabularyKey RetailPOSMustKeyInComment { get; private set; }
        public VocabularyKey RetailPOSDisallowManualDiscount { get; private set; }
        public VocabularyKey RetailPrintVariantsShelfLabels { get; private set; }
        public VocabularyKey RetailSeasonCode { get; private set; }
        public VocabularyKey RetailLifeFrom { get; private set; }
        public VocabularyKey RetailLifeTo { get; private set; }
        public VocabularyKey SalesRetailInventoryAvailabilityBuffer { get; private set; }
        public VocabularyKey SalesRetailInventoryAvailabilityLevelProfile { get; private set; }


    }
}