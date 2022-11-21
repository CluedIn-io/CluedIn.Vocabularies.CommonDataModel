using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCouponUsageEntityVocabulary : SimpleVocabulary
    {
        public RetailCouponUsageEntityVocabulary()
        {
            VocabularyName = "Retail Coupon Usage Entity";
            KeyPrefix = "commonDataModel.retailcouponusageentity";
            KeySeparator = ".";
            Grouping = "/RetailCouponUsageEntity";

            AddGroup("RetailCouponUsageEntity Details", group =>
            {
                UsageId = group.Add(new VocabularyKey(nameof(UsageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponCodeId = group.Add(new VocabularyKey(nameof(CouponCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptId = group.Add(new VocabularyKey(nameof(ReceiptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UsageId { get; private set; }
        public VocabularyKey CouponCodeId { get; private set; }
        public VocabularyKey SalesId { get; private set; }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey ReceiptId { get; private set; }
    }
}