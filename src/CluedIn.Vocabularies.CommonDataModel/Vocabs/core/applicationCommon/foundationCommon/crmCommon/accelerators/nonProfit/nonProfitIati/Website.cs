using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class WebsiteVocabulary : SimpleVocabulary
    {
        public WebsiteVocabulary()
        {
            VocabularyName = "Website";
            KeyPrefix = "commonDataModel.website.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Website";

            AddGroup("Website Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Url = group.Add(new VocabularyKey(nameof(Url), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WebsiteId = group.Add(new VocabularyKey(nameof(WebsiteId), "Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey WebsiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}