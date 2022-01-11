using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltySchemeExcludedAffiliationEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltySchemeExcludedAffiliationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltySchemeExcludedAffiliationEntity";
            KeyPrefix = "commonDataModel.retailloyaltyschemeexcludedaffiliationentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltySchemeExcludedAffiliationEntity";

            AddGroup("Common Data Model RetailLoyaltySchemeExcludedAffiliationEntity Details", group =>
            {
                RetailAffiliationId = group.Add(new VocabularyKey(nameof(RetailAffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltySchemeId = group.Add(new VocabularyKey(nameof(LoyaltySchemeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailAffiliationName = group.Add(new VocabularyKey(nameof(RetailAffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyScheme = group.Add(new VocabularyKey(nameof(LoyaltyScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RetailAffiliationId { get; private set; }
public VocabularyKey LoyaltySchemeId { get; private set; }
public VocabularyKey RetailAffiliationName { get; private set; }
public VocabularyKey LoyaltyScheme { get; private set; }


    }
}