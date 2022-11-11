using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPricingPriorityEntityVocabulary : SimpleVocabulary
    {
        public RetailPricingPriorityEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPricingPriorityEntity";
            KeyPrefix = "commonDataModel.retailpricingpriorityentity";
            KeySeparator = ".";
            Grouping = "/RetailPricingPriorityEntity";

            AddGroup("Common Data Model RetailPricingPriorityEntity Details", group =>
            {
                PricingPriorityName = group.Add(new VocabularyKey(nameof(PricingPriorityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingPriorityNumber = group.Add(new VocabularyKey(nameof(PricingPriorityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PricingPriorityName { get; private set; }
        public VocabularyKey PricingPriorityNumber { get; private set; }


    }
}