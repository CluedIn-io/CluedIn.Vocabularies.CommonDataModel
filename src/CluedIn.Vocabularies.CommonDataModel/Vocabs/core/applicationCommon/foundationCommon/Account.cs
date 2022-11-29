using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for FoundationCommon", group =>
            {
			                 
            });
        }

        
    }
}