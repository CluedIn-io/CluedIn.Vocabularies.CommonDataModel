using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjForecastSalesEntityVocabulary : SimpleVocabulary
    {
        public ProjForecastSalesEntityVocabulary()
        {
            VocabularyName = "ProjForecastSalesEntity";
            KeyPrefix = "commonDataModel.projforecastsalesentity";
            KeySeparator = ".";
            Grouping = "/ProjForecastSalesEntity";

            AddGroup("ProjForecastSalesEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocateMethod = group.Add(new VocabularyKey(nameof(AllocateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetComment = group.Add(new VocabularyKey(nameof(BudgetComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowForecast = group.Add(new VocabularyKey(nameof(CashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountId = group.Add(new VocabularyKey(nameof(CustomerAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercent = group.Add(new VocabularyKey(nameof(DiscountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Periods = group.Add(new VocabularyKey(nameof(Periods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimensionId = group.Add(new VocabularyKey(nameof(InventDimensionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventQuantity = group.Add(new VocabularyKey(nameof(InventQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemAllocateId = group.Add(new VocabularyKey(nameof(ItemAllocateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBOMId = group.Add(new VocabularyKey(nameof(ItemBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemGroupId = group.Add(new VocabularyKey(nameof(ItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRouteId = group.Add(new VocabularyKey(nameof(ItemRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodKeyId = group.Add(new VocabularyKey(nameof(PeriodKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelId = group.Add(new VocabularyKey(nameof(ModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWQuantity = group.Add(new VocabularyKey(nameof(CWQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWUnitId = group.Add(new VocabularyKey(nameof(CWUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceUnit = group.Add(new VocabularyKey(nameof(PriceUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectForecastBudgetType = group.Add(new VocabularyKey(nameof(ProjectForecastBudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectForecastCostPaymentDate = group.Add(new VocabularyKey(nameof(ProjectForecastCostPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectForecastEliminationDate = group.Add(new VocabularyKey(nameof(ProjectForecastEliminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectForecastInvoiceDate = group.Add(new VocabularyKey(nameof(ProjectForecastInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectForecastSalesPaymentDate = group.Add(new VocabularyKey(nameof(ProjectForecastSalesPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectFundingSource = group.Add(new VocabularyKey(nameof(ProjectFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Report = group.Add(new VocabularyKey(nameof(Report), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesMarkup = group.Add(new VocabularyKey(nameof(SalesMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuantity = group.Add(new VocabularyKey(nameof(SalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitId = group.Add(new VocabularyKey(nameof(SalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroupId = group.Add(new VocabularyKey(nameof(TaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceID = group.Add(new VocabularyKey(nameof(FundingSourceID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageSiteId = group.Add(new VocabularyKey(nameof(StorageSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageWarehouseId = group.Add(new VocabularyKey(nameof(StorageWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageLocationId = group.Add(new VocabularyKey(nameof(StorageLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CovStatus = group.Add(new VocabularyKey(nameof(CovStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey AllocateMethod { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey BudgetComment { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey CashFlowForecast { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CustomerAccountId { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountPercent { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Periods { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey InventDimensionId { get; private set; }
        public VocabularyKey InventQuantity { get; private set; }
        public VocabularyKey ItemAllocateId { get; private set; }
        public VocabularyKey ItemBOMId { get; private set; }
        public VocabularyKey ItemGroupId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey ItemRouteId { get; private set; }
        public VocabularyKey PeriodKeyId { get; private set; }
        public VocabularyKey ModelId { get; private set; }
        public VocabularyKey CWQuantity { get; private set; }
        public VocabularyKey CWUnitId { get; private set; }
        public VocabularyKey PriceUnit { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectForecastBudgetType { get; private set; }
        public VocabularyKey ProjectForecastCostPaymentDate { get; private set; }
        public VocabularyKey ProjectForecastEliminationDate { get; private set; }
        public VocabularyKey ProjectForecastInvoiceDate { get; private set; }
        public VocabularyKey ProjectForecastSalesPaymentDate { get; private set; }
        public VocabularyKey ProjectFundingSource { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectTransactionId { get; private set; }
        public VocabularyKey Report { get; private set; }
        public VocabularyKey SalesMarkup { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesQuantity { get; private set; }
        public VocabularyKey SalesUnitId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TaxGroupId { get; private set; }
        public VocabularyKey TaxItemGroupId { get; private set; }
        public VocabularyKey FundingSourceID { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey StorageSiteId { get; private set; }
        public VocabularyKey StorageWarehouseId { get; private set; }
        public VocabularyKey StorageLocationId { get; private set; }
        public VocabularyKey CovStatus { get; private set; }


    }
}