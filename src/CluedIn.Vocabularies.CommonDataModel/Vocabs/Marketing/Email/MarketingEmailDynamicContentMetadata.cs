using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailDynamicContentMetadataVocabulary : SimpleVocabulary
    {
        public MarketingEmailDynamicContentMetadataVocabulary()
        {
            VocabularyName = "Common Data Model MarketingEmailDynamicContentMetadata";
            KeyPrefix = "commonDataModel.marketingemaildynamiccontentmetadata";
            KeySeparator = ".";
            Grouping = "/MarketingEmailDynamicContentMetadata";

            AddGroup("Common Data Model MarketingEmailDynamicContentMetadata Details", group =>
            {
                fields = group.Add(new VocabularyKey(nameof(fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isContextEntity = group.Add(new VocabularyKey(nameof(isContextEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
displayName = group.Add(new VocabularyKey(nameof(displayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
itemType = group.Add(new VocabularyKey(nameof(itemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingEmailDynamicContentMetadataId = group.Add(new VocabularyKey(nameof(marketingEmailDynamicContentMetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
syntax = group.Add(new VocabularyKey(nameof(syntax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey fields { get; private set; }
public VocabularyKey isContextEntity { get; private set; }
public VocabularyKey displayName { get; private set; }
public VocabularyKey itemType { get; private set; }
public VocabularyKey marketingEmailDynamicContentMetadataId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey syntax { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}