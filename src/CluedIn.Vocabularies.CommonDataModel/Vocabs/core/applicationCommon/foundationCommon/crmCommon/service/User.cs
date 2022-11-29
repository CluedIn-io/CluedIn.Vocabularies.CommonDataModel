using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class UserVocabulary : SimpleVocabulary
    {
        public UserVocabulary()
        {
            VocabularyName = "User";
            KeyPrefix = "commonDataModel.user.service";
            KeySeparator = ".";
            Grouping = "/User";

            AddGroup("User Details for Service", group =>
            {
			                 
            });
        }

        
    }
}