using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingListVocabulary : SimpleVocabulary
    {
        public MarketingListVocabulary()
        {
            VocabularyName = "Marketing List";
            KeyPrefix = "commonDataModel.marketinglist";
            KeySeparator = ".";
            Grouping = "/MarketingList";

            AddGroup("MarketingList Details", group =>
            {
                Issubscription = group.Add(new VocabularyKey(nameof(Issubscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Issubscription { get; private set; }
    }
}