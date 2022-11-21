using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscPriceCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscPriceCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Price Disc Price Customer Group Entity";
            KeyPrefix = "commonDataModel.pricediscpricecustomergroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscPriceCustomerGroupEntity";

            AddGroup("PriceDiscPriceCustomerGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingPriority = group.Add(new VocabularyKey(nameof(PricingPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey PricingPriority { get; private set; }
    }
}