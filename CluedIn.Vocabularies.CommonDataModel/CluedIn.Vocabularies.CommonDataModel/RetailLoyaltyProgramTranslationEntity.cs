using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyProgramTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyProgramTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyProgramTranslationEntity";
            KeyPrefix = "commonDataModel.retailloyaltyprogramtranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyProgramTranslationEntity";

            AddGroup("Common Data Model RetailLoyaltyProgramTranslationEntity Details", group =>
            {
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Affiliation { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey LoyaltyProgramName { get; private set; }


    }
}