using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebPageVocabulary : SimpleVocabulary
    {
        public WebPageVocabulary()
        {
            VocabularyName = "Web Page";
            KeyPrefix = "commonDataModel.webpage.portals";
            KeySeparator = ".";
            Grouping = "/WebPage";

            AddGroup("WebPage Details for Portals", group =>
            {
			    WebpageId = group.Add(new VocabularyKey(nameof(WebpageId), "Web Page", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Category = group.Add(new VocabularyKey(nameof(Category), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowOrigin = group.Add(new VocabularyKey(nameof(AllowOrigin), "Allow Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomCSS = group.Add(new VocabularyKey(nameof(CustomCSS), "Custom CSS", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomJavaScript = group.Add(new VocabularyKey(nameof(CustomJavaScript), "Custom JavaScript", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EditorialComments = group.Add(new VocabularyKey(nameof(EditorialComments), "Editorial Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Enabletracking = group.Add(new VocabularyKey(nameof(Enabletracking), "Enable Tracking (deprecated)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExcludeFromSearch = group.Add(new VocabularyKey(nameof(ExcludeFromSearch), "Exclude From Search", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageURL = group.Add(new VocabularyKey(nameof(ImageURL), "Image URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    IsRoot = group.Add(new VocabularyKey(nameof(IsRoot), "Is Root", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MetaDescription = group.Add(new VocabularyKey(nameof(MetaDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Navigation = group.Add(new VocabularyKey(nameof(Navigation), "Navigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SharedPageConfiguration = group.Add(new VocabularyKey(nameof(SharedPageConfiguration), "Shared Page Configuration", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityForm = group.Add(new VocabularyKey(nameof(EntityForm), "Entity Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityList = group.Add(new VocabularyKey(nameof(EntityList), "Entity List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebForm = group.Add(new VocabularyKey(nameof(WebForm), "Web Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentPolicy = group.Add(new VocabularyKey(nameof(CommentPolicy), "Comment Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnableRatings = group.Add(new VocabularyKey(nameof(EnableRatings), "Enable Ratings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebpageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Copy { get; private set; }
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
        public VocabularyKey Title { get; private set; }
        public VocabularyKey AllowOrigin { get; private set; }
        public VocabularyKey CustomCSS { get; private set; }
        public VocabularyKey CustomJavaScript { get; private set; }
        public VocabularyKey EditorialComments { get; private set; }
        public VocabularyKey Enabletracking { get; private set; }
        public VocabularyKey ExcludeFromSearch { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey ImageURL { get; private set; }
        public VocabularyKey IsRoot { get; private set; }
        public VocabularyKey MetaDescription { get; private set; }
        public VocabularyKey Navigation { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey SharedPageConfiguration { get; private set; }
        public VocabularyKey EntityForm { get; private set; }
        public VocabularyKey EntityList { get; private set; }
        public VocabularyKey WebForm { get; private set; }
        public VocabularyKey CommentPolicy { get; private set; }
        public VocabularyKey EnableRatings { get; private set; }
    }
}