using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocumentRoutingClientAppEntityVocabulary : SimpleVocabulary
    {
        public DocumentRoutingClientAppEntityVocabulary()
        {
            VocabularyName = "Common Data Model DocumentRoutingClientAppEntity";
            KeyPrefix = "commonDataModel.documentroutingclientappentity";
            KeySeparator = ".";
            Grouping = "/DocumentRoutingClientAppEntity";

            AddGroup("Common Data Model DocumentRoutingClientAppEntity Details", group =>
            {
                ClientApplicationId = group.Add(new VocabularyKey(nameof(ClientApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClientApplicationDescription = group.Add(new VocabularyKey(nameof(ClientApplicationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ClientApplicationId { get; private set; }
public VocabularyKey ClientApplicationDescription { get; private set; }


    }
}