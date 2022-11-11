using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDiscountPriceGroupEntity";
            KeyPrefix = "commonDataModel.retaildiscountpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountPriceGroupEntity";

            AddGroup("Common Data Model RetailDiscountPriceGroupEntity Details", group =>
            {
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceDiscGroup = group.Add(new VocabularyKey(nameof(PriceDiscGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OfferId { get; private set; }
        public VocabularyKey PriceDiscGroup { get; private set; }
        public VocabularyKey PriceGroupId { get; private set; }


    }
}