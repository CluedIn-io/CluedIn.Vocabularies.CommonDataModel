using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountEntityVocabulary()
        {
            VocabularyName = "RetailDiscountEntity";
            KeyPrefix = "commonDataModel.retaildiscountentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountEntity";

            AddGroup("RetailDiscountEntity Details", group =>
            {
                ConcurrencyMode = group.Add(new VocabularyKey(nameof(ConcurrencyMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateValidationType = group.Add(new VocabularyKey(nameof(DateValidationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Disclaimer = group.Add(new VocabularyKey(nameof(Disclaimer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentValue = group.Add(new VocabularyKey(nameof(DiscountPercentValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDiscountCodeRequired = group.Add(new VocabularyKey(nameof(IsDiscountCodeRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodicDiscountType = group.Add(new VocabularyKey(nameof(PeriodicDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationPeriodId = group.Add(new VocabularyKey(nameof(ValidationPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultibuyDiscountType = group.Add(new VocabularyKey(nameof(MultibuyDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdCountNonDiscountItems = group.Add(new VocabularyKey(nameof(ThresholdCountNonDiscountItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchDealPrice = group.Add(new VocabularyKey(nameof(MixAndMatchDealPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchDiscountAmount = group.Add(new VocabularyKey(nameof(MixAndMatchDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchDiscountType = group.Add(new VocabularyKey(nameof(MixAndMatchDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchNoOfLeastExpensiveLines = group.Add(new VocabularyKey(nameof(MixAndMatchNoOfLeastExpensiveLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchNumberOfTimesApplicable = group.Add(new VocabularyKey(nameof(MixAndMatchNumberOfTimesApplicable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchLeastExpensiveMode = group.Add(new VocabularyKey(nameof(MixAndMatchLeastExpensiveMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCode = group.Add(new VocabularyKey(nameof(DiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCode = group.Add(new VocabularyKey(nameof(BarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCodeId = group.Add(new VocabularyKey(nameof(DiscountCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DiscountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountLedgerDimension = group.Add(new VocabularyKey(nameof(DiscountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountRecordId = group.Add(new VocabularyKey(nameof(DiscountRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferQuantityLimit = group.Add(new VocabularyKey(nameof(OfferQuantityLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintDescriptionOnFiscalReceipt = group.Add(new VocabularyKey(nameof(PrintDescriptionOnFiscalReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingPriorityNumber = group.Add(new VocabularyKey(nameof(PricingPriorityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConcurrencyMode { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DateValidationType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Disclaimer { get; private set; }
        public VocabularyKey DiscountPercentValue { get; private set; }
        public VocabularyKey IsDiscountCodeRequired { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfferId { get; private set; }
        public VocabularyKey PeriodicDiscountType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ValidationPeriodId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey MultibuyDiscountType { get; private set; }
        public VocabularyKey ThresholdCountNonDiscountItems { get; private set; }
        public VocabularyKey MixAndMatchDealPrice { get; private set; }
        public VocabularyKey MixAndMatchDiscountAmount { get; private set; }
        public VocabularyKey MixAndMatchDiscountType { get; private set; }
        public VocabularyKey MixAndMatchNoOfLeastExpensiveLines { get; private set; }
        public VocabularyKey MixAndMatchNumberOfTimesApplicable { get; private set; }
        public VocabularyKey MixAndMatchLeastExpensiveMode { get; private set; }
        public VocabularyKey DiscountCode { get; private set; }
        public VocabularyKey BarCode { get; private set; }
        public VocabularyKey DiscountCodeId { get; private set; }
        public VocabularyKey DiscountLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DiscountLedgerDimension { get; private set; }
        public VocabularyKey DiscountRecordId { get; private set; }
        public VocabularyKey OfferQuantityLimit { get; private set; }
        public VocabularyKey PrintDescriptionOnFiscalReceipt { get; private set; }
        public VocabularyKey PricingPriorityNumber { get; private set; }


    }
}