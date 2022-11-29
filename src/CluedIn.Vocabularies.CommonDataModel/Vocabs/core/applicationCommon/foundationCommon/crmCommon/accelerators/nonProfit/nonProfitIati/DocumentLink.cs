using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DocumentLinkVocabulary : SimpleVocabulary
    {
        public DocumentLinkVocabulary()
        {
            VocabularyName = "Document Link";
            KeyPrefix = "commonDataModel.documentlink.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DocumentLink";

            AddGroup("DocumentLink Details for NonProfitIati", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentLinkId = group.Add(new VocabularyKey(nameof(DocumentLinkId), "Document Link", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublicationDate = group.Add(new VocabularyKey(nameof(PublicationDate), "Publication Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Url = group.Add(new VocabularyKey(nameof(Url), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentLinkId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PublicationDate { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}