using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaCoProductV2EntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaCoProductV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PmfFormulaCoProductV2Entity";
            KeyPrefix = "commonDataModel.pmfformulacoproductv2entity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaCoProductV2Entity";

            AddGroup("Common Data Model PmfFormulaCoProductV2Entity Details", group =>
            {
                FormulaId = group.Add(new VocabularyKey(nameof(FormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityDenominator = group.Add(new VocabularyKey(nameof(QuantityDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingUpMethod = group.Add(new VocabularyKey(nameof(RoundingUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityRoundingUpMultiples = group.Add(new VocabularyKey(nameof(QuantityRoundingUpMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionSiteId = group.Add(new VocabularyKey(nameof(ConsumptionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionWarehouseId = group.Add(new VocabularyKey(nameof(ConsumptionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVersionActive = group.Add(new VocabularyKey(nameof(IsVersionActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionManufacturedItemNumber = group.Add(new VocabularyKey(nameof(VersionManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionValidFromDate = group.Add(new VocabularyKey(nameof(VersionValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionFromQuantity = group.Add(new VocabularyKey(nameof(VersionFromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductConfigurationId = group.Add(new VocabularyKey(nameof(VersionProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductColorId = group.Add(new VocabularyKey(nameof(VersionProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductionSiteId = group.Add(new VocabularyKey(nameof(VersionProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductSizeId = group.Add(new VocabularyKey(nameof(VersionProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductStyleId = group.Add(new VocabularyKey(nameof(VersionProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductVersionId = group.Add(new VocabularyKey(nameof(VersionProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionRecordId = group.Add(new VocabularyKey(nameof(VersionRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoProductFormulaId = group.Add(new VocabularyKey(nameof(CoProductFormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAllocationMethod = group.Add(new VocabularyKey(nameof(CostAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAllocationPercentage = group.Add(new VocabularyKey(nameof(CostAllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FormulaId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey QuantityDenominator { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CatchWeightQuantity { get; private set; }
        public VocabularyKey RoundingUpMethod { get; private set; }
        public VocabularyKey QuantityRoundingUpMultiples { get; private set; }
        public VocabularyKey ConsumptionSiteId { get; private set; }
        public VocabularyKey ConsumptionWarehouseId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey IsVersionActive { get; private set; }
        public VocabularyKey VersionManufacturedItemNumber { get; private set; }
        public VocabularyKey VersionValidFromDate { get; private set; }
        public VocabularyKey VersionFromQuantity { get; private set; }
        public VocabularyKey VersionProductConfigurationId { get; private set; }
        public VocabularyKey VersionProductColorId { get; private set; }
        public VocabularyKey VersionProductionSiteId { get; private set; }
        public VocabularyKey VersionProductSizeId { get; private set; }
        public VocabularyKey VersionProductStyleId { get; private set; }
        public VocabularyKey VersionProductVersionId { get; private set; }
        public VocabularyKey VersionRecordId { get; private set; }
        public VocabularyKey CoProductFormulaId { get; private set; }
        public VocabularyKey CostAllocationMethod { get; private set; }
        public VocabularyKey CostAllocationPercentage { get; private set; }


    }
}