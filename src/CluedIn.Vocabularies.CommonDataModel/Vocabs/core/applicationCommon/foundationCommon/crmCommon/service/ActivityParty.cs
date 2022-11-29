using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class ActivityPartyVocabulary : SimpleVocabulary
    {
        public ActivityPartyVocabulary()
        {
            VocabularyName = "Activity Party";
            KeyPrefix = "commonDataModel.activityparty.service";
            KeySeparator = ".";
            Grouping = "/ActivityParty";

            AddGroup("ActivityParty Details for Service", group =>
            {
			                 
            });
        }

        
    }
}