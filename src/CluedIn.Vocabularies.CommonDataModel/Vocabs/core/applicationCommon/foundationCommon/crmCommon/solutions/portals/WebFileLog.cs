using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebFileLogVocabulary : SimpleVocabulary
    {
        public WebFileLogVocabulary()
        {
            VocabularyName = "Web File Log";
            KeyPrefix = "commonDataModel.webfilelog.portals";
            KeySeparator = ".";
            Grouping = "/WebFileLog";

            AddGroup("WebFileLog Details for Portals", group =>
            {
			    WebFileLogId = group.Add(new VocabularyKey(nameof(WebFileLogId), "Web File Log", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IpAddress = group.Add(new VocabularyKey(nameof(IpAddress), "IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebFileLogId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey IpAddress { get; private set; }
    }
}