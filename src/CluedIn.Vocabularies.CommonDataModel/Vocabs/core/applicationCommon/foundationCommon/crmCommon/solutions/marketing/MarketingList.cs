using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class MarketingListVocabulary : SimpleVocabulary
    {
        public MarketingListVocabulary()
        {
            VocabularyName = "Marketing List";
            KeyPrefix = "commonDataModel.marketinglist.marketing";
            KeySeparator = ".";
            Grouping = "/MarketingList";

            AddGroup("MarketingList Details for Marketing", group =>
            {
			    Issubscription = group.Add(new VocabularyKey(nameof(Issubscription), "Subscription", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Issubscription { get; private set; }
    }
}