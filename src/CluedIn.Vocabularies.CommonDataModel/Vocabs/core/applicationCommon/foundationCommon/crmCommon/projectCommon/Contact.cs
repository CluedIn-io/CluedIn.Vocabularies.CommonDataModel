using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.projectcommon";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for ProjectCommon", group =>
            {
			    GDPROptOut = group.Add(new VocabularyKey(nameof(GDPROptOut), "GDPR Optout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GDPROptOut { get; private set; }
    }
}