using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingDynamicContentMetadataVocabulary : SimpleVocabulary
    {
        public MarketingDynamicContentMetadataVocabulary()
        {
            VocabularyName = "Common Data Model MarketingDynamicContentMetadata";
            KeyPrefix = "commonDataModel.marketingdynamiccontentmetadata";
            KeySeparator = ".";
            Grouping = "/MarketingDynamicContentMetadata";

            AddGroup("Common Data Model MarketingDynamicContentMetadata Details", group =>
            {
                marketingdynamiccontentmetadataId = group.Add(new VocabularyKey(nameof(marketingdynamiccontentmetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
value = group.Add(new VocabularyKey(nameof(value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey marketingdynamiccontentmetadataId { get; private set; }
public VocabularyKey value { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}