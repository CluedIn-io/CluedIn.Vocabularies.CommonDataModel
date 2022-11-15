using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetParametersEntityVocabulary : SimpleVocabulary
    {
        public AssetParametersEntityVocabulary()
        {
            VocabularyName = "Asset Parameters Entity";
            KeyPrefix = "commonDataModel.assetparametersentity";
            KeySeparator = ".";
            Grouping = "/AssetParametersEntity";

            AddGroup("AssetParametersEntity Details", group =>
            {
                AccountForUntransferredReserves = group.Add(new VocabularyKey(nameof(AccountForUntransferredReserves), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountForUntransferredReservesDisplayValue = group.Add(new VocabularyKey(nameof(AccountForUntransferredReservesDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Acquisition = group.Add(new VocabularyKey(nameof(Acquisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionAdjustment = group.Add(new VocabularyKey(nameof(AcquisitionAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowAcquisitionFromPurchasing = group.Add(new VocabularyKey(nameof(AllowAcquisitionFromPurchasing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMultipleAcquisitions = group.Add(new VocabularyKey(nameof(AllowMultipleAcquisitions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoNumberAssets = group.Add(new VocabularyKey(nameof(AutoNumberAssets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCodeEqualsFixedAssetNumber = group.Add(new VocabularyKey(nameof(BarCodeEqualsFixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateProratedDepreciation = group.Add(new VocabularyKey(nameof(CalculateProratedDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapitalizationThreshold = group.Add(new VocabularyKey(nameof(CapitalizationThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckForAssetCreationDuringLineEntry = group.Add(new VocabularyKey(nameof(CheckForAssetCreationDuringLineEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsiderCapitalizationThreshold = group.Add(new VocabularyKey(nameof(ConsiderCapitalizationThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateAssetDuringReceiptOrInvoicePosting = group.Add(new VocabularyKey(nameof(CreateAssetDuringReceiptOrInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductCashDiscount = group.Add(new VocabularyKey(nameof(DeductCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultValueModelId = group.Add(new VocabularyKey(nameof(DefaultValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Depreciation = group.Add(new VocabularyKey(nameof(Depreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationAdjustment = group.Add(new VocabularyKey(nameof(DepreciationAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDepreciationAdjustmentsWithDisposal = group.Add(new VocabularyKey(nameof(CreateDepreciationAdjustmentsWithDisposal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryDecrease = group.Add(new VocabularyKey(nameof(DerogatoryDecrease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryIncrease = group.Add(new VocabularyKey(nameof(DerogatoryIncrease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalSale = group.Add(new VocabularyKey(nameof(DisposalSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalScrap = group.Add(new VocabularyKey(nameof(DisposalScrap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraOrdinaryDepreciation = group.Add(new VocabularyKey(nameof(ExtraOrdinaryDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryJournalId = group.Add(new VocabularyKey(nameof(InventoryJournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumDepreciationAmount = group.Add(new VocabularyKey(nameof(MinimumDepreciationAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileId = group.Add(new VocabularyKey(nameof(PostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProvisionForReserve = group.Add(new VocabularyKey(nameof(ProvisionForReserve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireReasonsForAssetChanges = group.Add(new VocabularyKey(nameof(RequireReasonsForAssetChanges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictAssetAcquisitionPostingToUserGroupId = group.Add(new VocabularyKey(nameof(RestrictAssetAcquisitionPostingToUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Revaluation = group.Add(new VocabularyKey(nameof(Revaluation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferFromReserve = group.Add(new VocabularyKey(nameof(TransferFromReserve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteDownAdjustment = group.Add(new VocabularyKey(nameof(WriteDownAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteUpAdjustment = group.Add(new VocabularyKey(nameof(WriteUpAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingStandard = group.Add(new VocabularyKey(nameof(AccountingStandard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationCalculationMethod = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationRateFactor = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationRateFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationRateThreshold = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationRateThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowLocationTransfer = group.Add(new VocabularyKey(nameof(AllowLocationTransfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowTheDepreciationMethodToBeManuallyChanged = group.Add(new VocabularyKey(nameof(AllowTheDepreciationMethodToBeManuallyChanged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssemblingReservationType = group.Add(new VocabularyKey(nameof(AssemblingReservationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckMaximumPercentageForReducingBalance = group.Add(new VocabularyKey(nameof(CheckMaximumPercentageForReducingBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationCatchUpInterval = group.Add(new VocabularyKey(nameof(DepreciationCatchUpInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentWarningPeriod = group.Add(new VocabularyKey(nameof(ImpairmentWarningPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAssembleAndDisassemble = group.Add(new VocabularyKey(nameof(InventoryAssembleAndDisassemble), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseCatchUpMethod = group.Add(new VocabularyKey(nameof(UseCatchUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSCreditInstallments = group.Add(new VocabularyKey(nameof(ICMSCreditInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSpecialDepreciationBalance = group.Add(new VocabularyKey(nameof(UseSpecialDepreciationBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationThresholdPercentage = group.Add(new VocabularyKey(nameof(DepreciationThresholdPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxAcquisitionValueToAvailFullDepreciation = group.Add(new VocabularyKey(nameof(MaxAcquisitionValueToAvailFullDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinWorkingDaysForNonSeasonalIndustries = group.Add(new VocabularyKey(nameof(MinWorkingDaysForNonSeasonalIndustries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinWorkingDaysForSeasonalIndustries = group.Add(new VocabularyKey(nameof(MinWorkingDaysForSeasonalIndustries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCompaniesActDepreciation = group.Add(new VocabularyKey(nameof(IsCompaniesActDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIncomeTaxActDepreciation = group.Add(new VocabularyKey(nameof(IsIncomeTaxActDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetGroupDepreciationThreshold = group.Add(new VocabularyKey(nameof(AssetGroupDepreciationThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetSaleBasis = group.Add(new VocabularyKey(nameof(AssetSaleBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDepreciationMethodsEnabled = group.Add(new VocabularyKey(nameof(AreDepreciationMethodsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDepreciationPolicyEnabled = group.Add(new VocabularyKey(nameof(IsDepreciationPolicyEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumDepreciationAmountReportingCurrency = group.Add(new VocabularyKey(nameof(MinimumDepreciationAmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountForUntransferredReserves { get; private set; }
        public VocabularyKey AccountForUntransferredReservesDisplayValue { get; private set; }
        public VocabularyKey Acquisition { get; private set; }
        public VocabularyKey AcquisitionAdjustment { get; private set; }
        public VocabularyKey AllowAcquisitionFromPurchasing { get; private set; }
        public VocabularyKey AllowMultipleAcquisitions { get; private set; }
        public VocabularyKey AutoNumberAssets { get; private set; }
        public VocabularyKey BarCodeEqualsFixedAssetNumber { get; private set; }
        public VocabularyKey CalculateProratedDepreciation { get; private set; }
        public VocabularyKey CapitalizationThreshold { get; private set; }
        public VocabularyKey CheckForAssetCreationDuringLineEntry { get; private set; }
        public VocabularyKey ConsiderCapitalizationThreshold { get; private set; }
        public VocabularyKey CreateAssetDuringReceiptOrInvoicePosting { get; private set; }
        public VocabularyKey DeductCashDiscount { get; private set; }
        public VocabularyKey DefaultValueModelId { get; private set; }
        public VocabularyKey Depreciation { get; private set; }
        public VocabularyKey DepreciationAdjustment { get; private set; }
        public VocabularyKey CreateDepreciationAdjustmentsWithDisposal { get; private set; }
        public VocabularyKey DerogatoryDecrease { get; private set; }
        public VocabularyKey DerogatoryIncrease { get; private set; }
        public VocabularyKey DisposalSale { get; private set; }
        public VocabularyKey DisposalScrap { get; private set; }
        public VocabularyKey ExtraOrdinaryDepreciation { get; private set; }
        public VocabularyKey InventoryJournalId { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey MinimumDepreciationAmount { get; private set; }
        public VocabularyKey PostingProfileId { get; private set; }
        public VocabularyKey ProvisionForReserve { get; private set; }
        public VocabularyKey RequireReasonsForAssetChanges { get; private set; }
        public VocabularyKey RestrictAssetAcquisitionPostingToUserGroupId { get; private set; }
        public VocabularyKey Revaluation { get; private set; }
        public VocabularyKey TransferFromReserve { get; private set; }
        public VocabularyKey WriteDownAdjustment { get; private set; }
        public VocabularyKey WriteUpAdjustment { get; private set; }
        public VocabularyKey AccountingStandard { get; private set; }
        public VocabularyKey AcceleratedDepreciationCalculationMethod { get; private set; }
        public VocabularyKey AcceleratedDepreciationRateFactor { get; private set; }
        public VocabularyKey AcceleratedDepreciationRateThreshold { get; private set; }
        public VocabularyKey AllowLocationTransfer { get; private set; }
        public VocabularyKey AllowTheDepreciationMethodToBeManuallyChanged { get; private set; }
        public VocabularyKey AssemblingReservationType { get; private set; }
        public VocabularyKey CheckMaximumPercentageForReducingBalance { get; private set; }
        public VocabularyKey DepreciationCatchUpInterval { get; private set; }
        public VocabularyKey ImpairmentWarningPeriod { get; private set; }
        public VocabularyKey InventoryAssembleAndDisassemble { get; private set; }
        public VocabularyKey UseCatchUpMethod { get; private set; }
        public VocabularyKey ICMSCreditInstallments { get; private set; }
        public VocabularyKey UseSpecialDepreciationBalance { get; private set; }
        public VocabularyKey DepreciationThresholdPercentage { get; private set; }
        public VocabularyKey MaxAcquisitionValueToAvailFullDepreciation { get; private set; }
        public VocabularyKey MinWorkingDaysForNonSeasonalIndustries { get; private set; }
        public VocabularyKey MinWorkingDaysForSeasonalIndustries { get; private set; }
        public VocabularyKey IsCompaniesActDepreciation { get; private set; }
        public VocabularyKey IsIncomeTaxActDepreciation { get; private set; }
        public VocabularyKey AssetGroupDepreciationThreshold { get; private set; }
        public VocabularyKey AssetSaleBasis { get; private set; }
        public VocabularyKey AreDepreciationMethodsEnabled { get; private set; }
        public VocabularyKey IsDepreciationPolicyEnabled { get; private set; }
        public VocabularyKey MinimumDepreciationAmountReportingCurrency { get; private set; }
    }
}