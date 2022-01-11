using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestRecipientVocabulary : SimpleVocabulary
    {
        public CommunicationRequestRecipientVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestRecipient";
            KeyPrefix = "commonDataModel.communicationrequestrecipient";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestRecipient";

            AddGroup("Common Data Model CommunicationRequestRecipient Details", group =>
            {
                communicationRequestRecipientId = group.Add(new VocabularyKey(nameof(communicationRequestRecipientId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recipientType = group.Add(new VocabularyKey(nameof(recipientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey communicationRequestRecipientId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey recipientType { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}