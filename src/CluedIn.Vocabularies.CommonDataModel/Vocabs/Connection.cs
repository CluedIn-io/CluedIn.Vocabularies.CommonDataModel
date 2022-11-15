using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Connection";
            KeyPrefix = "commonDataModel.connection";
            KeySeparator = ".";
            Grouping = "/Connection";

            AddGroup("Connection Details", group =>
            {
            });
        }
    }
}