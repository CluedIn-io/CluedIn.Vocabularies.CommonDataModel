using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCouponItemEntityVocabulary : SimpleVocabulary
    {
        public MCRCouponItemEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRCouponItemEntity";
            KeyPrefix = "commonDataModel.mcrcouponitementity";
            KeySeparator = ".";
            Grouping = "/MCRCouponItemEntity";

            AddGroup("Common Data Model MCRCouponItemEntity Details", group =>
            {
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponId = group.Add(new VocabularyKey(nameof(CouponId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemGroupId = group.Add(new VocabularyKey(nameof(ItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey CouponId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemGroupId { get; private set; }


    }
}