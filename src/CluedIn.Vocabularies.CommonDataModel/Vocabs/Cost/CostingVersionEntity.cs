using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostingVersionEntityVocabulary : SimpleVocabulary
    {
        public CostingVersionEntityVocabulary()
        {
            VocabularyName = "CostingVersionEntity";
            KeyPrefix = "commonDataModel.costingversionentity";
            KeySeparator = ".";
            Grouping = "/CostingVersionEntity";

            AddGroup("CostingVersionEntity Details", group =>
            {
                AreCostPricesAllowed = group.Add(new VocabularyKey(nameof(AreCostPricesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchasePricesAllowed = group.Add(new VocabularyKey(nameof(ArePurchasePricesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesPricesAllowed = group.Add(new VocabularyKey(nameof(AreSalesPricesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivationBlocked = group.Add(new VocabularyKey(nameof(IsActivationBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVersionBlocked = group.Add(new VocabularyKey(nameof(IsVersionBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExplosionMode = group.Add(new VocabularyKey(nameof(ExplosionMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackPrinciple = group.Add(new VocabularyKey(nameof(FallbackPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictCalculation = group.Add(new VocabularyKey(nameof(RestrictCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionProcurementModePriceCalculationAllowed = group.Add(new VocabularyKey(nameof(IsProductionProcurementModePriceCalculationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPriceModel = group.Add(new VocabularyKey(nameof(CostPriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitSetting = group.Add(new VocabularyKey(nameof(ProfitSetting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackCostingVersionId = group.Add(new VocabularyKey(nameof(FallbackCostingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingType = group.Add(new VocabularyKey(nameof(CostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFromDate = group.Add(new VocabularyKey(nameof(DefaultFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictingPriceSiteId = group.Add(new VocabularyKey(nameof(RestrictingPriceSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastActivationDate = group.Add(new VocabularyKey(nameof(LastActivationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastUpdateDate = group.Add(new VocabularyKey(nameof(LastUpdateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionName = group.Add(new VocabularyKey(nameof(VersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUnitPriceIncludingCharge = group.Add(new VocabularyKey(nameof(IsUnitPriceIncludingCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePriceCalculationsUsingPurchaseProcurementModeAllowed = group.Add(new VocabularyKey(nameof(ArePriceCalculationsUsingPurchaseProcurementModeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceModel = group.Add(new VocabularyKey(nameof(PurchasePriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordingRestriction = group.Add(new VocabularyKey(nameof(RecordingRestriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOffCalculation = group.Add(new VocabularyKey(nameof(RoundOffCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionId = group.Add(new VocabularyKey(nameof(VersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AreCostPricesAllowed { get; private set; }
        public VocabularyKey ArePurchasePricesAllowed { get; private set; }
        public VocabularyKey AreSalesPricesAllowed { get; private set; }
        public VocabularyKey IsActivationBlocked { get; private set; }
        public VocabularyKey IsVersionBlocked { get; private set; }
        public VocabularyKey ExplosionMode { get; private set; }
        public VocabularyKey FallbackPrinciple { get; private set; }
        public VocabularyKey RestrictCalculation { get; private set; }
        public VocabularyKey IsProductionProcurementModePriceCalculationAllowed { get; private set; }
        public VocabularyKey CostPriceModel { get; private set; }
        public VocabularyKey ProfitSetting { get; private set; }
        public VocabularyKey FallbackCostingVersionId { get; private set; }
        public VocabularyKey CostingType { get; private set; }
        public VocabularyKey DefaultFromDate { get; private set; }
        public VocabularyKey RestrictingPriceSiteId { get; private set; }
        public VocabularyKey LastActivationDate { get; private set; }
        public VocabularyKey LastUpdateDate { get; private set; }
        public VocabularyKey VersionName { get; private set; }
        public VocabularyKey IsUnitPriceIncludingCharge { get; private set; }
        public VocabularyKey ArePriceCalculationsUsingPurchaseProcurementModeAllowed { get; private set; }
        public VocabularyKey PurchasePriceModel { get; private set; }
        public VocabularyKey RecordingRestriction { get; private set; }
        public VocabularyKey RoundOffCalculation { get; private set; }
        public VocabularyKey VersionId { get; private set; }


    }
}