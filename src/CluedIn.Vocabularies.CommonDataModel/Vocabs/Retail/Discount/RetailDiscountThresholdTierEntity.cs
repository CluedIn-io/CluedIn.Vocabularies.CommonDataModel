using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountThresholdTierEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountThresholdTierEntityVocabulary()
        {
            VocabularyName = "RetailDiscountThresholdTierEntity";
            KeyPrefix = "commonDataModel.retaildiscountthresholdtierentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountThresholdTierEntity";

            AddGroup("RetailDiscountThresholdTierEntity Details", group =>
            {
                AmountThreshold = group.Add(new VocabularyKey(nameof(AmountThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountMethod = group.Add(new VocabularyKey(nameof(DiscountMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountValue = group.Add(new VocabularyKey(nameof(DiscountValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountThreshold { get; private set; }
        public VocabularyKey DiscountMethod { get; private set; }
        public VocabularyKey DiscountValue { get; private set; }
        public VocabularyKey OfferId { get; private set; }


    }
}