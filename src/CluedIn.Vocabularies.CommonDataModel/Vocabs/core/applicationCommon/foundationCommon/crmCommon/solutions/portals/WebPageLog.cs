using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebPageLogVocabulary : SimpleVocabulary
    {
        public WebPageLogVocabulary()
        {
            VocabularyName = "Web Page Log";
            KeyPrefix = "commonDataModel.webpagelog.portals";
            KeySeparator = ".";
            Grouping = "/WebPageLog";

            AddGroup("WebPageLog Details for Portals", group =>
            {
			    WebpagelogId = group.Add(new VocabularyKey(nameof(WebpagelogId), "Webpage Log", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IpAddress = group.Add(new VocabularyKey(nameof(IpAddress), "IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebpagelogId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey IpAddress { get; private set; }
    }
}