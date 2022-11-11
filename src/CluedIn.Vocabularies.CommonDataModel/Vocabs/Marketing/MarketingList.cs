using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingListVocabulary : SimpleVocabulary
    {
        public MarketingListVocabulary()
        {
            VocabularyName = "MarketingList";
            KeyPrefix = "commonDataModel.marketinglist";
            KeySeparator = ".";
            Grouping = "/MarketingList";

            AddGroup("MarketingList Details", group =>
            {
                issubscription = group.Add(new VocabularyKey(nameof(issubscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey issubscription { get; private set; }


    }
}