using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.crmcommon";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for CrmCommon", group =>
            {
			                 
            });
        }

        
    }
}