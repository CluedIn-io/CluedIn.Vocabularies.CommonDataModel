using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetDiscountRateEntityVocabulary : SimpleVocabulary
    {
        public AssetDiscountRateEntityVocabulary()
        {
            VocabularyName = "Asset Discount Rate Entity";
            KeyPrefix = "commonDataModel.assetdiscountrateentity";
            KeySeparator = ".";
            Grouping = "/AssetDiscountRateEntity";

            AddGroup("AssetDiscountRateEntity Details", group =>
            {
                MarketDiscountRatePercentage = group.Add(new VocabularyKey(nameof(MarketDiscountRatePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MarketDiscountRatePercentage { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}