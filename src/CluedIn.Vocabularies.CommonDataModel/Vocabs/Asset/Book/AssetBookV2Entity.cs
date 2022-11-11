using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetBookV2EntityVocabulary : SimpleVocabulary
    {
        public AssetBookV2EntityVocabulary()
        {
            VocabularyName = "AssetBookV2Entity";
            KeyPrefix = "commonDataModel.assetbookv2entity";
            KeySeparator = ".";
            Grouping = "/AssetBookV2Entity";

            AddGroup("AssetBookV2Entity Details", group =>
            {
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowNetBookValueHigherThanAcquisitionCosts = group.Add(new VocabularyKey(nameof(AllowNetBookValueHigherThanAcquisitionCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowNegativeNetBookValue = group.Add(new VocabularyKey(nameof(AllowNegativeNetBookValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileId = group.Add(new VocabularyKey(nameof(PostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionPrice = group.Add(new VocabularyKey(nameof(AcquisitionPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionMethodId = group.Add(new VocabularyKey(nameof(AcquisitionMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionMethodDescription = group.Add(new VocabularyKey(nameof(AcquisitionMethodDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalDate = group.Add(new VocabularyKey(nameof(DisposalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesValue = group.Add(new VocabularyKey(nameof(SalesValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementDate = group.Add(new VocabularyKey(nameof(ReplacementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevaluationGroupId = group.Add(new VocabularyKey(nameof(RevaluationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FairValue = group.Add(new VocabularyKey(nameof(FairValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProvisionType = group.Add(new VocabularyKey(nameof(ProvisionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowValuePoolTransferId = group.Add(new VocabularyKey(nameof(LowValuePoolTransferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowValuePoolTransferDate = group.Add(new VocabularyKey(nameof(LowValuePoolTransferDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummarizeByMajorType = group.Add(new VocabularyKey(nameof(SummarizeByMajorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraordinaryDepreciationProfileId = group.Add(new VocabularyKey(nameof(ExtraordinaryDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationStartConvention = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationStartConvention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationUnit = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationPeriods = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateDepreciation = group.Add(new VocabularyKey(nameof(CalculateDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationProfileId = group.Add(new VocabularyKey(nameof(DepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlacedInService = group.Add(new VocabularyKey(nameof(PlacedInService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationRunDate = group.Add(new VocabularyKey(nameof(DepreciationRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationLastRunDate = group.Add(new VocabularyKey(nameof(DepreciationLastRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReducingBalanceCheckMaximumPercent = group.Add(new VocabularyKey(nameof(ReducingBalanceCheckMaximumPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReducingBalancePercentageAfterValidation = group.Add(new VocabularyKey(nameof(ReducingBalancePercentageAfterValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeDepreciationProfileId = group.Add(new VocabularyKey(nameof(AlternativeDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLife = group.Add(new VocabularyKey(nameof(ServiceLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationPeriods = group.Add(new VocabularyKey(nameof(DepreciationPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationPeriodsRemaining = group.Add(new VocabularyKey(nameof(DepreciationPeriodsRemaining), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedScrapValue = group.Add(new VocabularyKey(nameof(ExpectedScrapValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquallyDividedStartDate = group.Add(new VocabularyKey(nameof(EquallyDividedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationConvention = group.Add(new VocabularyKey(nameof(DepreciationConvention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowDepreciationWhenPlacedInServiceAndDisposalAreInTheSameFiscalYear = group.Add(new VocabularyKey(nameof(AllowDepreciationWhenPlacedInServiceAndDisposalAreInTheSameFiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDepreciationAdjustmentsWithBasisAdjustments = group.Add(new VocabularyKey(nameof(CreateDepreciationAdjustmentsWithBasisAdjustments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowableLimitForAccumulatedDepreciation = group.Add(new VocabularyKey(nameof(AllowableLimitForAccumulatedDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevisedAcquisitionCost = group.Add(new VocabularyKey(nameof(RevisedAcquisitionCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevisedAcquisitionCostStartDate = group.Add(new VocabularyKey(nameof(RevisedAcquisitionCostStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortenedUsefulLife = group.Add(new VocabularyKey(nameof(ShortenedUsefulLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReductionEntryAllocationStartDate = group.Add(new VocabularyKey(nameof(ReductionEntryAllocationStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReductionEntryAllocationLastRunDate = group.Add(new VocabularyKey(nameof(ReductionEntryAllocationLastRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLifeMonths = group.Add(new VocabularyKey(nameof(ServiceLifeMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLifeYears = group.Add(new VocabularyKey(nameof(ServiceLifeYears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReducingBalanceStraightLineFactor = group.Add(new VocabularyKey(nameof(ReducingBalanceStraightLineFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraordinaryDepreciationLastRunDate = group.Add(new VocabularyKey(nameof(ExtraordinaryDepreciationLastRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationRunDate = group.Add(new VocabularyKey(nameof(SpecialDepreciationRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationLastRunDate = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationLastRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationProfileId = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationLastRunDate = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationLastRunDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionFactorId = group.Add(new VocabularyKey(nameof(ConsumptionFactorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionUnitId = group.Add(new VocabularyKey(nameof(ConsumptionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionUnitDepreciation = group.Add(new VocabularyKey(nameof(ConsumptionUnitDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionEstimated = group.Add(new VocabularyKey(nameof(ConsumptionEstimated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryCalculation = group.Add(new VocabularyKey(nameof(DerogatoryCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryTaxModel = group.Add(new VocabularyKey(nameof(DerogatoryTaxModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoice = group.Add(new VocabularyKey(nameof(VendorInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerInvoice = group.Add(new VocabularyKey(nameof(CustomerInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField1Id = group.Add(new VocabularyKey(nameof(SortField1Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField2Id = group.Add(new VocabularyKey(nameof(SortField2Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField3Id = group.Add(new VocabularyKey(nameof(SortField3Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAssetGroupDepreciation = group.Add(new VocabularyKey(nameof(IsAssetGroupDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationGroupId_W = group.Add(new VocabularyKey(nameof(DepreciationGroupId_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionPriceReportingCurrency = group.Add(new VocabularyKey(nameof(AcquisitionPriceReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedScrapValueReportingCurrency = group.Add(new VocabularyKey(nameof(ExpectedScrapValueReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionUnitDepreciationReportingCurrency = group.Add(new VocabularyKey(nameof(ConsumptionUnitDepreciationReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey BookId { get; private set; }
        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey AllowNetBookValueHigherThanAcquisitionCosts { get; private set; }
        public VocabularyKey AllowNegativeNetBookValue { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey PostingProfileId { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionPrice { get; private set; }
        public VocabularyKey AcquisitionMethodId { get; private set; }
        public VocabularyKey AcquisitionMethodDescription { get; private set; }
        public VocabularyKey DisposalDate { get; private set; }
        public VocabularyKey SalesValue { get; private set; }
        public VocabularyKey ReplacementDate { get; private set; }
        public VocabularyKey RevaluationGroupId { get; private set; }
        public VocabularyKey FairValue { get; private set; }
        public VocabularyKey ProvisionType { get; private set; }
        public VocabularyKey LowValuePoolTransferId { get; private set; }
        public VocabularyKey LowValuePoolTransferDate { get; private set; }
        public VocabularyKey SummarizeByMajorType { get; private set; }
        public VocabularyKey ExtraordinaryDepreciationProfileId { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationStartConvention { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationUnit { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationPeriods { get; private set; }
        public VocabularyKey CalculateDepreciation { get; private set; }
        public VocabularyKey DepreciationProfileId { get; private set; }
        public VocabularyKey PlacedInService { get; private set; }
        public VocabularyKey DepreciationRunDate { get; private set; }
        public VocabularyKey DepreciationLastRunDate { get; private set; }
        public VocabularyKey ReducingBalanceCheckMaximumPercent { get; private set; }
        public VocabularyKey ReducingBalancePercentageAfterValidation { get; private set; }
        public VocabularyKey AlternativeDepreciationProfileId { get; private set; }
        public VocabularyKey ServiceLife { get; private set; }
        public VocabularyKey DepreciationPeriods { get; private set; }
        public VocabularyKey DepreciationPeriodsRemaining { get; private set; }
        public VocabularyKey ExpectedScrapValue { get; private set; }
        public VocabularyKey EquallyDividedStartDate { get; private set; }
        public VocabularyKey DepreciationConvention { get; private set; }
        public VocabularyKey AllowDepreciationWhenPlacedInServiceAndDisposalAreInTheSameFiscalYear { get; private set; }
        public VocabularyKey CreateDepreciationAdjustmentsWithBasisAdjustments { get; private set; }
        public VocabularyKey AllowableLimitForAccumulatedDepreciation { get; private set; }
        public VocabularyKey RevisedAcquisitionCost { get; private set; }
        public VocabularyKey RevisedAcquisitionCostStartDate { get; private set; }
        public VocabularyKey ShortenedUsefulLife { get; private set; }
        public VocabularyKey ReductionEntryAllocationStartDate { get; private set; }
        public VocabularyKey ReductionEntryAllocationLastRunDate { get; private set; }
        public VocabularyKey ServiceLifeMonths { get; private set; }
        public VocabularyKey ServiceLifeYears { get; private set; }
        public VocabularyKey ReducingBalanceStraightLineFactor { get; private set; }
        public VocabularyKey ExtraordinaryDepreciationLastRunDate { get; private set; }
        public VocabularyKey SpecialDepreciationRunDate { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationLastRunDate { get; private set; }
        public VocabularyKey AcceleratedDepreciationProfileId { get; private set; }
        public VocabularyKey AcceleratedDepreciationLastRunDate { get; private set; }
        public VocabularyKey ConsumptionFactorId { get; private set; }
        public VocabularyKey ConsumptionUnitId { get; private set; }
        public VocabularyKey ConsumptionUnitDepreciation { get; private set; }
        public VocabularyKey ConsumptionEstimated { get; private set; }
        public VocabularyKey DerogatoryCalculation { get; private set; }
        public VocabularyKey DerogatoryTaxModel { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey PurchaseOrder { get; private set; }
        public VocabularyKey VendorInvoice { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerInvoice { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey SortField1Id { get; private set; }
        public VocabularyKey SortField2Id { get; private set; }
        public VocabularyKey SortField3Id { get; private set; }
        public VocabularyKey IsAssetGroupDepreciation { get; private set; }
        public VocabularyKey DepreciationGroupId_W { get; private set; }
        public VocabularyKey AcquisitionPriceReportingCurrency { get; private set; }
        public VocabularyKey ExpectedScrapValueReportingCurrency { get; private set; }
        public VocabularyKey ConsumptionUnitDepreciationReportingCurrency { get; private set; }


    }
}