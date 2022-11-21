using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaLineV2EntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaLineV2EntityVocabulary()
        {
            VocabularyName = "Pmf Formula Line V2 Entity";
            KeyPrefix = "commonDataModel.pmfformulalinev2entity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaLineV2Entity";

            AddGroup("PmfFormulaLineV2Entity Details", group =>
            {
                ConsumptionType = group.Add(new VocabularyKey(nameof(ConsumptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaId = group.Add(new VocabularyKey(nameof(FormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityDenominator = group.Add(new VocabularyKey(nameof(QuantityDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalculationIncludeLine = group.Add(new VocabularyKey(nameof(WillCostCalculationIncludeLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionCalculationConstant = group.Add(new VocabularyKey(nameof(ConsumptionCalculationConstant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalProductDensity = group.Add(new VocabularyKey(nameof(PhysicalProductDensity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalProductDepth = group.Add(new VocabularyKey(nameof(PhysicalProductDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsumedAtOperationComplete = group.Add(new VocabularyKey(nameof(IsConsumedAtOperationComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionCalculationMethod = group.Add(new VocabularyKey(nameof(ConsumptionCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalProductHeight = group.Add(new VocabularyKey(nameof(PhysicalProductHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubBOMId = group.Add(new VocabularyKey(nameof(SubBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubRouteId = group.Add(new VocabularyKey(nameof(SubRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillManufacturedItemInheritBatchAttributes = group.Add(new VocabularyKey(nameof(WillManufacturedItemInheritBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillManufacturedItemInheritShelfLifeDates = group.Add(new VocabularyKey(nameof(WillManufacturedItemInheritShelfLifeDates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionNumber = group.Add(new VocabularyKey(nameof(PositionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlushingPrinciple = group.Add(new VocabularyKey(nameof(FlushingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingUpMethod = group.Add(new VocabularyKey(nameof(RoundingUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityRoundingUpMultiples = group.Add(new VocabularyKey(nameof(QuantityRoundingUpMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantScrapQuantity = group.Add(new VocabularyKey(nameof(ConstantScrapQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariableScrapPercentage = group.Add(new VocabularyKey(nameof(VariableScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalProductWidth = group.Add(new VocabularyKey(nameof(PhysicalProductWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsResourceConsumptionUsed = group.Add(new VocabularyKey(nameof(IsResourceConsumptionUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionSiteId = group.Add(new VocabularyKey(nameof(ConsumptionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionWarehouseId = group.Add(new VocabularyKey(nameof(ConsumptionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaQuantityPercentage = group.Add(new VocabularyKey(nameof(FormulaQuantityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPercentageControlled = group.Add(new VocabularyKey(nameof(IsPercentageControlled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubstitutionGroupId = group.Add(new VocabularyKey(nameof(SubstitutionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubstitutionPriority = group.Add(new VocabularyKey(nameof(SubstitutionPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsScalable = group.Add(new VocabularyKey(nameof(IsScalable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineFormulaId = group.Add(new VocabularyKey(nameof(LineFormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConsumptionType { get; private set; }
        public VocabularyKey FormulaId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey QuantityDenominator { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey WillCostCalculationIncludeLine { get; private set; }
        public VocabularyKey ConsumptionCalculationConstant { get; private set; }
        public VocabularyKey PhysicalProductDensity { get; private set; }
        public VocabularyKey PhysicalProductDepth { get; private set; }
        public VocabularyKey IsConsumedAtOperationComplete { get; private set; }
        public VocabularyKey ConsumptionCalculationMethod { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey PhysicalProductHeight { get; private set; }
        public VocabularyKey SubBOMId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey SubRouteId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RouteOperationNumber { get; private set; }
        public VocabularyKey CatchWeightQuantity { get; private set; }
        public VocabularyKey WillManufacturedItemInheritBatchAttributes { get; private set; }
        public VocabularyKey WillManufacturedItemInheritShelfLifeDates { get; private set; }
        public VocabularyKey PositionNumber { get; private set; }
        public VocabularyKey FlushingPrinciple { get; private set; }
        public VocabularyKey RoundingUpMethod { get; private set; }
        public VocabularyKey QuantityRoundingUpMultiples { get; private set; }
        public VocabularyKey ConstantScrapQuantity { get; private set; }
        public VocabularyKey VariableScrapPercentage { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey PhysicalProductWidth { get; private set; }
        public VocabularyKey IsResourceConsumptionUsed { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ConsumptionSiteId { get; private set; }
        public VocabularyKey ConsumptionWarehouseId { get; private set; }
        public VocabularyKey FormulaQuantityPercentage { get; private set; }
        public VocabularyKey IsPercentageControlled { get; private set; }
        public VocabularyKey SubstitutionGroupId { get; private set; }
        public VocabularyKey SubstitutionPriority { get; private set; }
        public VocabularyKey IsScalable { get; private set; }
        public VocabularyKey LineFormulaId { get; private set; }
        public VocabularyKey LineCreationSequenceNumber { get; private set; }
    }
}