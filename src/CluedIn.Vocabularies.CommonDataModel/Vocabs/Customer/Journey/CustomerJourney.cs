using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyVocabulary : SimpleVocabulary
    {
        public CustomerJourneyVocabulary()
        {
            VocabularyName = "Common Data Model CustomerJourney";
            KeyPrefix = "commonDataModel.customerjourney";
            KeySeparator = ".";
            Grouping = "/CustomerJourney";

            AddGroup("Common Data Model CustomerJourney Details", group =>
            {
                requiredconsent = group.Add(new VocabularyKey(nameof(requiredconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey requiredconsent { get; private set; }


    }
}