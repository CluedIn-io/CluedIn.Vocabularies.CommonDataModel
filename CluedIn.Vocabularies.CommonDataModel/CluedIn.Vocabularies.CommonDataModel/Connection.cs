using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Common Data Model Connection";
            KeyPrefix = "commonDataModel.connection";
            KeySeparator = ".";
            Grouping = "/Connection";

            AddGroup("Common Data Model Connection Details", group =>
            {
                             
            });
        }

       

    }
}