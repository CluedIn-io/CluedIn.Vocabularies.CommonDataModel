using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCouponEntityVocabulary : SimpleVocabulary
    {
        public RetailCouponEntityVocabulary()
        {
            VocabularyName = "Retail Coupon Entity";
            KeyPrefix = "commonDataModel.retailcouponentity";
            KeySeparator = ".";
            Grouping = "/RetailCouponEntity";

            AddGroup("RetailCouponEntity Details", group =>
            {
                CouponNumber = group.Add(new VocabularyKey(nameof(CouponNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageLimit = group.Add(new VocabularyKey(nameof(UsageLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageLimitType = group.Add(new VocabularyKey(nameof(UsageLimitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomerRequired = group.Add(new VocabularyKey(nameof(IsCustomerRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExclusive = group.Add(new VocabularyKey(nameof(IsExclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountOfferId = group.Add(new VocabularyKey(nameof(DiscountOfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyWithoutCouponCode = group.Add(new VocabularyKey(nameof(ApplyWithoutCouponCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CouponNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey UsageLimit { get; private set; }
        public VocabularyKey UsageLimitType { get; private set; }
        public VocabularyKey IsCustomerRequired { get; private set; }
        public VocabularyKey IsExclusive { get; private set; }
        public VocabularyKey DiscountOfferId { get; private set; }
        public VocabularyKey ApplyWithoutCouponCode { get; private set; }
    }
}