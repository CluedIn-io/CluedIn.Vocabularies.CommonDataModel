using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCouponDiscountEntityVocabulary : SimpleVocabulary
    {
        public MCRCouponDiscountEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRCouponDiscountEntity";
            KeyPrefix = "commonDataModel.mcrcoupondiscountentity";
            KeySeparator = ".";
            Grouping = "/MCRCouponDiscountEntity";

            AddGroup("Common Data Model MCRCouponDiscountEntity Details", group =>
            {
                CouponAmount = group.Add(new VocabularyKey(nameof(CouponAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CouponDiscountType = group.Add(new VocabularyKey(nameof(CouponDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CouponId = group.Add(new VocabularyKey(nameof(CouponId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CouponValue = group.Add(new VocabularyKey(nameof(CouponValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CouponAmount { get; private set; }
public VocabularyKey CouponDiscountType { get; private set; }
public VocabularyKey CouponId { get; private set; }
public VocabularyKey CouponValue { get; private set; }


    }
}