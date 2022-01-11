using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReplaceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReplaceVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestReplace";
            KeyPrefix = "commonDataModel.communicationrequestreplace";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReplace";

            AddGroup("Common Data Model CommunicationRequestReplace Details", group =>
            {
                communicationRequestReplaceId = group.Add(new VocabularyKey(nameof(communicationRequestReplaceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey communicationRequestReplaceId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}