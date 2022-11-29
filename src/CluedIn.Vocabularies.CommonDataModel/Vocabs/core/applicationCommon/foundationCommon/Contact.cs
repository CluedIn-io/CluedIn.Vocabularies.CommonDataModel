using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for FoundationCommon", group =>
            {
			                 
            });
        }

        
    }
}