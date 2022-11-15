using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemPriceComparisonStorageEntityVocabulary : SimpleVocabulary
    {
        public InventItemPriceComparisonStorageEntityVocabulary()
        {
            VocabularyName = "Invent Item Price Comparison Storage Entity";
            KeyPrefix = "commonDataModel.inventitempricecomparisonstorageentity";
            KeySeparator = ".";
            Grouping = "/InventItemPriceComparisonStorageEntity";

            AddGroup("InventItemPriceComparisonStorageEntity Details", group =>
            {
                ExecutionName = group.Add(new VocabularyKey(nameof(ExecutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionTime = group.Add(new VocabularyKey(nameof(ExecutionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandQuantity = group.Add(new VocabularyKey(nameof(OnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupType = group.Add(new VocabularyKey(nameof(CostGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostLevel = group.Add(new VocabularyKey(nameof(CostLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOrderType = group.Add(new VocabularyKey(nameof(DefaultOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareCostCalculationMethod = group.Add(new VocabularyKey(nameof(CompareCostCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareFromDate = group.Add(new VocabularyKey(nameof(CompareFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparePriceCharges = group.Add(new VocabularyKey(nameof(ComparePriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareOnhandValue = group.Add(new VocabularyKey(nameof(CompareOnhandValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparePrice = group.Add(new VocabularyKey(nameof(ComparePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparePriceIsPriceIncludingCharges = group.Add(new VocabularyKey(nameof(ComparePriceIsPriceIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareChargesQuantity = group.Add(new VocabularyKey(nameof(CompareChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparePriceQuantity = group.Add(new VocabularyKey(nameof(ComparePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareUnitSymbol = group.Add(new VocabularyKey(nameof(CompareUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareUnitPrice = group.Add(new VocabularyKey(nameof(CompareUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToCostCalculationMethod = group.Add(new VocabularyKey(nameof(CompareToCostCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToFromDate = group.Add(new VocabularyKey(nameof(CompareToFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToPriceCharges = group.Add(new VocabularyKey(nameof(CompareToPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToOnhandValue = group.Add(new VocabularyKey(nameof(CompareToOnhandValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToPrice = group.Add(new VocabularyKey(nameof(CompareToPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToIsPriceIncludingCharges = group.Add(new VocabularyKey(nameof(CompareToIsPriceIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToChargesQuantity = group.Add(new VocabularyKey(nameof(CompareToChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToPriceQuantity = group.Add(new VocabularyKey(nameof(CompareToPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToUnitSymbol = group.Add(new VocabularyKey(nameof(CompareToUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareToUnitPrice = group.Add(new VocabularyKey(nameof(CompareToUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetChangeUnitPrice = group.Add(new VocabularyKey(nameof(NetChangeUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetChangeOnhandValue = group.Add(new VocabularyKey(nameof(NetChangeOnhandValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExecutionName { get; private set; }
        public VocabularyKey ExecutionTime { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey OnHandQuantity { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey CostGroupType { get; private set; }
        public VocabularyKey CostLevel { get; private set; }
        public VocabularyKey DefaultOrderType { get; private set; }
        public VocabularyKey CompareCostCalculationMethod { get; private set; }
        public VocabularyKey CompareFromDate { get; private set; }
        public VocabularyKey ComparePriceCharges { get; private set; }
        public VocabularyKey CompareOnhandValue { get; private set; }
        public VocabularyKey ComparePrice { get; private set; }
        public VocabularyKey ComparePriceIsPriceIncludingCharges { get; private set; }
        public VocabularyKey CompareChargesQuantity { get; private set; }
        public VocabularyKey ComparePriceQuantity { get; private set; }
        public VocabularyKey CompareUnitSymbol { get; private set; }
        public VocabularyKey CompareUnitPrice { get; private set; }
        public VocabularyKey CompareToCostCalculationMethod { get; private set; }
        public VocabularyKey CompareToFromDate { get; private set; }
        public VocabularyKey CompareToPriceCharges { get; private set; }
        public VocabularyKey CompareToOnhandValue { get; private set; }
        public VocabularyKey CompareToPrice { get; private set; }
        public VocabularyKey CompareToIsPriceIncludingCharges { get; private set; }
        public VocabularyKey CompareToChargesQuantity { get; private set; }
        public VocabularyKey CompareToPriceQuantity { get; private set; }
        public VocabularyKey CompareToUnitSymbol { get; private set; }
        public VocabularyKey CompareToUnitPrice { get; private set; }
        public VocabularyKey NetChangeUnitPrice { get; private set; }
        public VocabularyKey NetChangeOnhandValue { get; private set; }
    }
}