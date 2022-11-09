using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCouponSalesOrderEntityVocabulary : SimpleVocabulary
    {
        public MCRCouponSalesOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRCouponSalesOrderEntity";
            KeyPrefix = "commonDataModel.mcrcouponsalesorderentity";
            KeySeparator = ".";
            Grouping = "/MCRCouponSalesOrderEntity";

            AddGroup("Common Data Model MCRCouponSalesOrderEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CouponId = group.Add(new VocabularyKey(nameof(CouponId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLiabilityDeducted = group.Add(new VocabularyKey(nameof(IsLiabilityDeducted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReissue = group.Add(new VocabularyKey(nameof(IsReissue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey CouponId { get; private set; }
public VocabularyKey IsLiabilityDeducted { get; private set; }
public VocabularyKey IsReissue { get; private set; }
public VocabularyKey SalesId { get; private set; }


    }
}