using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyVocabulary : SimpleVocabulary
    {
        public CustomerJourneyVocabulary()
        {
            VocabularyName = "Customer Journey";
            KeyPrefix = "commonDataModel.customerjourney";
            KeySeparator = ".";
            Grouping = "/CustomerJourney";

            AddGroup("CustomerJourney Details", group =>
            {
                Requiredconsent = group.Add(new VocabularyKey(nameof(Requiredconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Requiredconsent { get; private set; }
    }
}