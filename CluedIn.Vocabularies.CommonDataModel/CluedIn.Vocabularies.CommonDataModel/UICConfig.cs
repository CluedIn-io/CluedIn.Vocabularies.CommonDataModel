using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UICConfigVocabulary : SimpleVocabulary
    {
        public UICConfigVocabulary()
        {
            VocabularyName = "Common Data Model UICConfig";
            KeyPrefix = "commonDataModel.uicconfig";
            KeySeparator = ".";
            Grouping = "/UICConfig";

            AddGroup("Common Data Model UICConfig Details", group =>
            {
                eventHubAccessKey = group.Add(new VocabularyKey(nameof(eventHubAccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventHubName = group.Add(new VocabularyKey(nameof(eventHubName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
storageAccountAccessKey = group.Add(new VocabularyKey(nameof(storageAccountAccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
storageAccountName = group.Add(new VocabularyKey(nameof(storageAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UICConfigId = group.Add(new VocabularyKey(nameof(UICConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey eventHubAccessKey { get; private set; }
public VocabularyKey eventHubName { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey storageAccountAccessKey { get; private set; }
public VocabularyKey storageAccountName { get; private set; }
public VocabularyKey UICConfigId { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}