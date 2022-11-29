using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class AdVocabulary : SimpleVocabulary
    {
        public AdVocabulary()
        {
            VocabularyName = "Ad";
            KeyPrefix = "commonDataModel.ad.portals";
            KeySeparator = ".";
            Grouping = "/Ad";

            AddGroup("Ad Details for Portals", group =>
            {
			    AdId = group.Add(new VocabularyKey(nameof(AdId), "Ad", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Image = group.Add(new VocabularyKey(nameof(Image), "image URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageAltText = group.Add(new VocabularyKey(nameof(ImageAltText), "Image Alt Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageHeight = group.Add(new VocabularyKey(nameof(ImageHeight), "Image Height", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImageWidth = group.Add(new VocabularyKey(nameof(ImageWidth), "Image Width", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenInNewWindow = group.Add(new VocabularyKey(nameof(OpenInNewWindow), "Open In New Window", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "Redirect URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Copy { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Image { get; private set; }
        public VocabularyKey ImageAltText { get; private set; }
        public VocabularyKey ImageHeight { get; private set; }
        public VocabularyKey ImageWidth { get; private set; }
        public VocabularyKey OpenInNewWindow { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey URL { get; private set; }
    }
}