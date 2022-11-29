using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class SLAKPIInstanceVocabulary : SimpleVocabulary
    {
        public SLAKPIInstanceVocabulary()
        {
            VocabularyName = "SLAKPI Instance";
            KeyPrefix = "commonDataModel.slakpiinstance.service";
            KeySeparator = ".";
            Grouping = "/SLAKPIInstance";

            AddGroup("SLAKPIInstance Details for Service", group =>
            {
			                 
            });
        }

        
    }
}