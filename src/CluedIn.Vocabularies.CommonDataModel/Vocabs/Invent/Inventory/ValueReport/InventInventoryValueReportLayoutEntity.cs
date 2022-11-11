using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryValueReportLayoutEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryValueReportLayoutEntityVocabulary()
        {
            VocabularyName = "InventInventoryValueReportLayoutEntity";
            KeyPrefix = "commonDataModel.inventinventoryvaluereportlayoutentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryValueReportLayoutEntity";

            AddGroup("InventInventoryValueReportLayoutEntity Details", group =>
            {
                ReportId = group.Add(new VocabularyKey(nameof(ReportId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportName = group.Add(new VocabularyKey(nameof(ReportName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateIntervalCode = group.Add(new VocabularyKey(nameof(DateIntervalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FilterOnDateField = group.Add(new VocabularyKey(nameof(FilterOnDateField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionSet = group.Add(new VocabularyKey(nameof(DimensionSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionSetName = group.Add(new VocabularyKey(nameof(FinancialDimensionSetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWIPDisplayed = group.Add(new VocabularyKey(nameof(IsWIPDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeferredCOGSDisplayed = group.Add(new VocabularyKey(nameof(IsDeferredCOGSDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCOGSDisplayed = group.Add(new VocabularyKey(nameof(IsCOGSDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProfitLossDisplayed = group.Add(new VocabularyKey(nameof(IsProfitLossDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationTotalDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductColorTotalDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductColorDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeTotalDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleTotalDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionTotalDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventorySiteTotalDisplayed = group.Add(new VocabularyKey(nameof(IsInventorySiteTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventorySiteDisplayed = group.Add(new VocabularyKey(nameof(IsInventorySiteDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryWarehouseTotalDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryWarehouseTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryWarehouseDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryWarehouseDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationTotalDisplayed = group.Add(new VocabularyKey(nameof(IsWarehouseLocationTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationDisplayed = group.Add(new VocabularyKey(nameof(IsWarehouseLocationDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchNumberTotalDisplayed = group.Add(new VocabularyKey(nameof(IsBatchNumberTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchNumberDisplayed = group.Add(new VocabularyKey(nameof(IsBatchNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberTotalDisplayed = group.Add(new VocabularyKey(nameof(IsSerialNumberTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberDisplayed = group.Add(new VocabularyKey(nameof(IsSerialNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryStatusTotalDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryStatusDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLicensePlateTotalDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLicensePlateDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceIdDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceIdTotalDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceIdTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceGroupDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceGroupDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceGroupTotalDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceGroupTotalDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSubLedgerAndGeneralLedgerReconciled = group.Add(new VocabularyKey(nameof(IsSubLedgerAndGeneralLedgerReconciled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledInventoryMainAccountId = group.Add(new VocabularyKey(nameof(ReconciledInventoryMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledInventoryMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ReconciledInventoryMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledWIPMainAccountId = group.Add(new VocabularyKey(nameof(ReconciledWIPMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledWIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ReconciledWIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledDeferredCOGSMainAccountId = group.Add(new VocabularyKey(nameof(ReconciledDeferredCOGSMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledDeferredCOGSMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ReconciledDeferredCOGSMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledCOGSMainAccountId = group.Add(new VocabularyKey(nameof(ReconciledCOGSMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciledCOGSMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ReconciledCOGSMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePhysicalAndFinancialValuesSummarized = group.Add(new VocabularyKey(nameof(ArePhysicalAndFinancialValuesSummarized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreNonePostedSubLedgerValuesIncluded = group.Add(new VocabularyKey(nameof(AreNonePostedSubLedgerValuesIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAverageUnitCostDisplayed = group.Add(new VocabularyKey(nameof(IsAverageUnitCostDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTotalQuantityAndValueDisplayed = group.Add(new VocabularyKey(nameof(IsTotalQuantityAndValueDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceTypeLaborDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceTypeLaborDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceTypeIndirectCostDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceTypeIndirectCostDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCostResourceTypeDirectOutsourcingDisplayed = group.Add(new VocabularyKey(nameof(IsCostResourceTypeDirectOutsourcingDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportDetailLevel = group.Add(new VocabularyKey(nameof(ReportDetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSubLedgerBeginningBalanceIncluded = group.Add(new VocabularyKey(nameof(IsSubLedgerBeginningBalanceIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReportId { get; private set; }
        public VocabularyKey ReportName { get; private set; }
        public VocabularyKey DateIntervalCode { get; private set; }
        public VocabularyKey FilterOnDateField { get; private set; }
        public VocabularyKey DimensionSet { get; private set; }
        public VocabularyKey FinancialDimensionSetName { get; private set; }
        public VocabularyKey IsInventoryDisplayed { get; private set; }
        public VocabularyKey IsWIPDisplayed { get; private set; }
        public VocabularyKey IsDeferredCOGSDisplayed { get; private set; }
        public VocabularyKey IsCOGSDisplayed { get; private set; }
        public VocabularyKey IsProfitLossDisplayed { get; private set; }
        public VocabularyKey IsProductConfigurationTotalDisplayed { get; private set; }
        public VocabularyKey IsProductConfigurationDisplayed { get; private set; }
        public VocabularyKey IsProductColorTotalDisplayed { get; private set; }
        public VocabularyKey IsProductColorDisplayed { get; private set; }
        public VocabularyKey IsProductSizeTotalDisplayed { get; private set; }
        public VocabularyKey IsProductSizeDisplayed { get; private set; }
        public VocabularyKey IsProductStyleTotalDisplayed { get; private set; }
        public VocabularyKey IsProductVersionTotalDisplayed { get; private set; }
        public VocabularyKey IsProductStyleDisplayed { get; private set; }
        public VocabularyKey IsProductVersionDisplayed { get; private set; }
        public VocabularyKey IsInventorySiteTotalDisplayed { get; private set; }
        public VocabularyKey IsInventorySiteDisplayed { get; private set; }
        public VocabularyKey IsInventoryWarehouseTotalDisplayed { get; private set; }
        public VocabularyKey IsInventoryWarehouseDisplayed { get; private set; }
        public VocabularyKey IsWarehouseLocationTotalDisplayed { get; private set; }
        public VocabularyKey IsWarehouseLocationDisplayed { get; private set; }
        public VocabularyKey IsBatchNumberTotalDisplayed { get; private set; }
        public VocabularyKey IsBatchNumberDisplayed { get; private set; }
        public VocabularyKey IsSerialNumberTotalDisplayed { get; private set; }
        public VocabularyKey IsSerialNumberDisplayed { get; private set; }
        public VocabularyKey IsInventoryStatusTotalDisplayed { get; private set; }
        public VocabularyKey IsInventoryStatusDisplayed { get; private set; }
        public VocabularyKey IsLicensePlateTotalDisplayed { get; private set; }
        public VocabularyKey IsLicensePlateDisplayed { get; private set; }
        public VocabularyKey IsCostResourceIdDisplayed { get; private set; }
        public VocabularyKey IsCostResourceIdTotalDisplayed { get; private set; }
        public VocabularyKey IsCostResourceGroupDisplayed { get; private set; }
        public VocabularyKey IsCostResourceGroupTotalDisplayed { get; private set; }
        public VocabularyKey IsSubLedgerAndGeneralLedgerReconciled { get; private set; }
        public VocabularyKey ReconciledInventoryMainAccountId { get; private set; }
        public VocabularyKey ReconciledInventoryMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ReconciledWIPMainAccountId { get; private set; }
        public VocabularyKey ReconciledWIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ReconciledDeferredCOGSMainAccountId { get; private set; }
        public VocabularyKey ReconciledDeferredCOGSMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ReconciledCOGSMainAccountId { get; private set; }
        public VocabularyKey ReconciledCOGSMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ArePhysicalAndFinancialValuesSummarized { get; private set; }
        public VocabularyKey AreNonePostedSubLedgerValuesIncluded { get; private set; }
        public VocabularyKey IsAverageUnitCostDisplayed { get; private set; }
        public VocabularyKey IsTotalQuantityAndValueDisplayed { get; private set; }
        public VocabularyKey IsCostResourceTypeLaborDisplayed { get; private set; }
        public VocabularyKey IsCostResourceTypeIndirectCostDisplayed { get; private set; }
        public VocabularyKey IsCostResourceTypeDirectOutsourcingDisplayed { get; private set; }
        public VocabularyKey ReportDetailLevel { get; private set; }
        public VocabularyKey IsSubLedgerBeginningBalanceIncluded { get; private set; }


    }
}