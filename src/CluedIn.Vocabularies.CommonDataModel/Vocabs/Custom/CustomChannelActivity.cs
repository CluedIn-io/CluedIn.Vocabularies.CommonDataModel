using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomChannelActivityVocabulary : SimpleVocabulary
    {
        public CustomChannelActivityVocabulary()
        {
            VocabularyName = "Common Data Model CustomChannelActivity";
            KeyPrefix = "commonDataModel.customchannelactivity";
            KeySeparator = ".";
            Grouping = "/CustomChannelActivity";

            AddGroup("Common Data Model CustomChannelActivity Details", group =>
            {
                activityID = group.Add(new VocabularyKey(nameof(activityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
customerJourneyId = group.Add(new VocabularyKey(nameof(customerJourneyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
customerjourneycustomchannelactivityId = group.Add(new VocabularyKey(nameof(customerjourneycustomchannelactivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactId = group.Add(new VocabularyKey(nameof(contactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entityID = group.Add(new VocabularyKey(nameof(entityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entityType = group.Add(new VocabularyKey(nameof(entityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey activityID { get; private set; }
public VocabularyKey customerJourneyId { get; private set; }
public VocabularyKey customerjourneycustomchannelactivityId { get; private set; }
public VocabularyKey contactId { get; private set; }
public VocabularyKey entityID { get; private set; }
public VocabularyKey entityType { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}