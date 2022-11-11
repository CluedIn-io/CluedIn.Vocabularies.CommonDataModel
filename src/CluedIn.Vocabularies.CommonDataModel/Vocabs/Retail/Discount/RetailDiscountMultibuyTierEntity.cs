using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountMultibuyTierEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountMultibuyTierEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDiscountMultibuyTierEntity";
            KeyPrefix = "commonDataModel.retaildiscountmultibuytierentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountMultibuyTierEntity";

            AddGroup("Common Data Model RetailDiscountMultibuyTierEntity Details", group =>
            {
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceOrDiscountPercentage = group.Add(new VocabularyKey(nameof(PriceOrDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityLowest = group.Add(new VocabularyKey(nameof(QuantityLowest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OfferId { get; private set; }
        public VocabularyKey PriceOrDiscountPercentage { get; private set; }
        public VocabularyKey QuantityLowest { get; private set; }


    }
}