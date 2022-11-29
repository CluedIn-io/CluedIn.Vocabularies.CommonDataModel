using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class PreferenceVocabulary : SimpleVocabulary
    {
        public PreferenceVocabulary()
        {
            VocabularyName = "Preference";
            KeyPrefix = "commonDataModel.preference.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Preference";

            AddGroup("Preference Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}