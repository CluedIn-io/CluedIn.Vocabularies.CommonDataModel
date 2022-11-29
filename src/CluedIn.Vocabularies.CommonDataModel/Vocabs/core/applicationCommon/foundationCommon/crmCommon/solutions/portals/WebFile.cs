using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebFileVocabulary : SimpleVocabulary
    {
        public WebFileVocabulary()
        {
            VocabularyName = "Web File";
            KeyPrefix = "commonDataModel.webfile.portals";
            KeySeparator = ".";
            Grouping = "/WebFile";

            AddGroup("WebFile Details for Portals", group =>
            {
			    WebFileId = group.Add(new VocabularyKey(nameof(WebFileId), "Web File", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayDate = group.Add(new VocabularyKey(nameof(DisplayDate), "Display Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    HiddenFromSitemap = group.Add(new VocabularyKey(nameof(HiddenFromSitemap), "Hidden From Sitemap", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowOrigin = group.Add(new VocabularyKey(nameof(AllowOrigin), "Allow Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CloudBlobAddress = group.Add(new VocabularyKey(nameof(CloudBlobAddress), "Cloud Blob Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContentDisposition = group.Add(new VocabularyKey(nameof(ContentDisposition), "Content-Disposition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnableTracking = group.Add(new VocabularyKey(nameof(EnableTracking), "Enable Tracking (deprecated)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExcludeFromSearch = group.Add(new VocabularyKey(nameof(ExcludeFromSearch), "Exclude From Search", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebFileId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey DisplayDate { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey HiddenFromSitemap { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey Summary { get; private set; }
        public VocabularyKey AllowOrigin { get; private set; }
        public VocabularyKey CloudBlobAddress { get; private set; }
        public VocabularyKey ContentDisposition { get; private set; }
        public VocabularyKey EnableTracking { get; private set; }
        public VocabularyKey ExcludeFromSearch { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}