using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscTotalDiscountCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscTotalDiscountCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Price Disc Total Discount Customer Group Entity";
            KeyPrefix = "commonDataModel.pricedisctotaldiscountcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscTotalDiscountCustomerGroupEntity";

            AddGroup("PriceDiscTotalDiscountCustomerGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }
    }
}