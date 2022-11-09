using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltySchemeEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltySchemeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltySchemeEntity";
            KeyPrefix = "commonDataModel.retailloyaltyschemeentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltySchemeEntity";

            AddGroup("Common Data Model RetailLoyaltySchemeEntity Details", group =>
            {
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltySchemeId = group.Add(new VocabularyKey(nameof(LoyaltySchemeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Affiliation { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey LoyaltySchemeId { get; private set; }
public VocabularyKey LoyaltyName { get; private set; }


    }
}