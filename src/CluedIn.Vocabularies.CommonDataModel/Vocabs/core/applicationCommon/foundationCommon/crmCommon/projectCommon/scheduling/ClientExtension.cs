using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class ClientExtensionVocabulary : SimpleVocabulary
    {
        public ClientExtensionVocabulary()
        {
            VocabularyName = "Client Extension";
            KeyPrefix = "commonDataModel.clientextension.scheduling";
            KeySeparator = ".";
            Grouping = "/ClientExtension";

            AddGroup("ClientExtension Details for Scheduling", group =>
            {
			    ClientextensionId = group.Add(new VocabularyKey(nameof(ClientextensionId), "Client Extension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtensionType = group.Add(new VocabularyKey(nameof(ExtensionType), "Extension Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebResource = group.Add(new VocabularyKey(nameof(WebResource), "Web Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClientextensionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ExtensionType { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey WebResource { get; private set; }
    }
}