using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMixAndMatchLineGroupSetupEntityVocabulary : SimpleVocabulary
    {
        public RetailMixAndMatchLineGroupSetupEntityVocabulary()
        {
            VocabularyName = "Retail Mix And Match Line Group Setup Entity";
            KeyPrefix = "commonDataModel.retailmixandmatchlinegroupsetupentity";
            KeySeparator = ".";
            Grouping = "/RetailMixAndMatchLineGroupSetupEntity";

            AddGroup("RetailMixAndMatchLineGroupSetupEntity Details", group =>
            {
                DiscountLineColorId = group.Add(new VocabularyKey(nameof(DiscountLineColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchLineGroup = group.Add(new VocabularyKey(nameof(MixAndMatchLineGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfItemsNeeded = group.Add(new VocabularyKey(nameof(NumberOfItemsNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DiscountLineColorId { get; private set; }
        public VocabularyKey MixAndMatchLineGroup { get; private set; }
        public VocabularyKey NumberOfItemsNeeded { get; private set; }
    }
}