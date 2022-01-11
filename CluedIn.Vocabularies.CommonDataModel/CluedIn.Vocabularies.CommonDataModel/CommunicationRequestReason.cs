using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReasonVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestReason";
            KeyPrefix = "commonDataModel.communicationrequestreason";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReason";

            AddGroup("Common Data Model CommunicationRequestReason Details", group =>
            {
                communicationRequestReasonId = group.Add(new VocabularyKey(nameof(communicationRequestReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey communicationRequestReasonId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}