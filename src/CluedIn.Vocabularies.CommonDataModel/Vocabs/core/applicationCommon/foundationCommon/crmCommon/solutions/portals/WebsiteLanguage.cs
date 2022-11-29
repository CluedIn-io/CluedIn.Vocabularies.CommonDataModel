using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebsiteLanguageVocabulary : SimpleVocabulary
    {
        public WebsiteLanguageVocabulary()
        {
            VocabularyName = "Website Language";
            KeyPrefix = "commonDataModel.websitelanguage.portals";
            KeySeparator = ".";
            Grouping = "/WebsiteLanguage";

            AddGroup("WebsiteLanguage Details for Portals", group =>
            {
			    WebsiteLanguageId = group.Add(new VocabularyKey(nameof(WebsiteLanguageId), "Website Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebsiteLanguageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}