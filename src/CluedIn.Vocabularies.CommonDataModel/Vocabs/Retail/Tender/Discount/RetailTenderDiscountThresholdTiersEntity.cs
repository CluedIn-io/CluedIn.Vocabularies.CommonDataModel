using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderDiscountThresholdTiersEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderDiscountThresholdTiersEntityVocabulary()
        {
            VocabularyName = "RetailTenderDiscountThresholdTiersEntity";
            KeyPrefix = "commonDataModel.retailtenderdiscountthresholdtiersentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderDiscountThresholdTiersEntity";

            AddGroup("RetailTenderDiscountThresholdTiersEntity Details", group =>
            {
                DiscountValue = group.Add(new VocabularyKey(nameof(DiscountValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountThreshold = group.Add(new VocabularyKey(nameof(AmountThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DiscountValue { get; private set; }
        public VocabularyKey AmountThreshold { get; private set; }
        public VocabularyKey OfferId { get; private set; }


    }
}