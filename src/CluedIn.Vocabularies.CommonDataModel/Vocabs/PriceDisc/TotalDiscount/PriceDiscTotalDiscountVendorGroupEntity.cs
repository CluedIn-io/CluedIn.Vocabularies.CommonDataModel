using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscTotalDiscountVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscTotalDiscountVendorGroupEntityVocabulary()
        {
            VocabularyName = "PriceDiscTotalDiscountVendorGroupEntity";
            KeyPrefix = "commonDataModel.pricedisctotaldiscountvendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscTotalDiscountVendorGroupEntity";

            AddGroup("PriceDiscTotalDiscountVendorGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}