using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocumentRoutingClientAppEntityVocabulary : SimpleVocabulary
    {
        public DocumentRoutingClientAppEntityVocabulary()
        {
            VocabularyName = "Document Routing Client App Entity";
            KeyPrefix = "commonDataModel.documentroutingclientappentity";
            KeySeparator = ".";
            Grouping = "/DocumentRoutingClientAppEntity";

            AddGroup("DocumentRoutingClientAppEntity Details", group =>
            {
                ClientApplicationId = group.Add(new VocabularyKey(nameof(ClientApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientApplicationDescription = group.Add(new VocabularyKey(nameof(ClientApplicationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClientApplicationId { get; private set; }
        public VocabularyKey ClientApplicationDescription { get; private set; }
    }
}