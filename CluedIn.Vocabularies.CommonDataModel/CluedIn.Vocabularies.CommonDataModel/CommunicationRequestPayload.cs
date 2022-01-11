using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestPayloadVocabulary : SimpleVocabulary
    {
        public CommunicationRequestPayloadVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestPayload";
            KeyPrefix = "commonDataModel.communicationrequestpayload";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestPayload";

            AddGroup("Common Data Model CommunicationRequestPayload Details", group =>
            {
                communicationRequestPayloadId = group.Add(new VocabularyKey(nameof(communicationRequestPayloadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
payloadContentReference = group.Add(new VocabularyKey(nameof(payloadContentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
payloadContentString = group.Add(new VocabularyKey(nameof(payloadContentString), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey communicationRequestPayloadId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey payloadContentReference { get; private set; }
public VocabularyKey payloadContentString { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}