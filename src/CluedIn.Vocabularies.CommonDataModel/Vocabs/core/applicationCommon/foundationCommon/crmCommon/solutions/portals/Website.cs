using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebsiteVocabulary : SimpleVocabulary
    {
        public WebsiteVocabulary()
        {
            VocabularyName = "Website";
            KeyPrefix = "commonDataModel.website.portals";
            KeySeparator = ".";
            Grouping = "/Website";

            AddGroup("Website Details for Portals", group =>
            {
			    WebsiteId = group.Add(new VocabularyKey(nameof(WebsiteId), "Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PrimaryDomainName = group.Add(new VocabularyKey(nameof(PrimaryDomainName), "Primary Domain Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebsiteLanguage = group.Add(new VocabularyKey(nameof(WebsiteLanguage), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebsiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey PrimaryDomainName { get; private set; }
        public VocabularyKey WebsiteLanguage { get; private set; }
    }
}