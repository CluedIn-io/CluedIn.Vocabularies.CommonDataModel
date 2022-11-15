using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCouponCodeEntityVocabulary : SimpleVocabulary
    {
        public RetailCouponCodeEntityVocabulary()
        {
            VocabularyName = "Retail Coupon Code Entity";
            KeyPrefix = "commonDataModel.retailcouponcodeentity";
            KeySeparator = ".";
            Grouping = "/RetailCouponCodeEntity";

            AddGroup("RetailCouponCodeEntity Details", group =>
            {
                CouponCodeId = group.Add(new VocabularyKey(nameof(CouponCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponNumber = group.Add(new VocabularyKey(nameof(CouponNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponCode = group.Add(new VocabularyKey(nameof(CouponCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Barcode = group.Add(new VocabularyKey(nameof(Barcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CouponCodeId { get; private set; }
        public VocabularyKey CouponNumber { get; private set; }
        public VocabularyKey CouponCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Barcode { get; private set; }
    }
}