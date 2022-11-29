using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Connection";
            KeyPrefix = "commonDataModel.connection.marketing";
            KeySeparator = ".";
            Grouping = "/Connection";

            AddGroup("Connection Details for Marketing", group =>
            {
			                 
            });
        }

        
    }
}