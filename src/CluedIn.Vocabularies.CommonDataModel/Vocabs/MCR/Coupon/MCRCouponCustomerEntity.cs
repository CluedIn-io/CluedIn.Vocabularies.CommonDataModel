using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCouponCustomerEntityVocabulary : SimpleVocabulary
    {
        public MCRCouponCustomerEntityVocabulary()
        {
            VocabularyName = "MCRCouponCustomerEntity";
            KeyPrefix = "commonDataModel.mcrcouponcustomerentity";
            KeySeparator = ".";
            Grouping = "/MCRCouponCustomerEntity";

            AddGroup("MCRCouponCustomerEntity Details", group =>
            {
                CustomerCode = group.Add(new VocabularyKey(nameof(CustomerCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendRel = group.Add(new VocabularyKey(nameof(CustVendRel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponId = group.Add(new VocabularyKey(nameof(CouponId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCouponVoided = group.Add(new VocabularyKey(nameof(IsCouponVoided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerCode { get; private set; }
        public VocabularyKey CustVendRel { get; private set; }
        public VocabularyKey CouponId { get; private set; }
        public VocabularyKey IsCouponVoided { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }


    }
}