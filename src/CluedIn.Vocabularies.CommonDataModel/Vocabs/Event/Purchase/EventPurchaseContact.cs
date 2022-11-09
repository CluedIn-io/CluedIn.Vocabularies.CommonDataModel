using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseContactVocabulary : SimpleVocabulary
    {
        public EventPurchaseContactVocabulary()
        {
            VocabularyName = "Common Data Model EventPurchaseContact";
            KeyPrefix = "commonDataModel.eventpurchasecontact";
            KeySeparator = ".";
            Grouping = "/EventPurchaseContact";

            AddGroup("Common Data Model EventPurchaseContact Details", group =>
            {
                emailaddress1 = group.Add(new VocabularyKey(nameof(emailaddress1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventPurchaseContactId = group.Add(new VocabularyKey(nameof(eventPurchaseContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
firstName = group.Add(new VocabularyKey(nameof(firstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fullName = group.Add(new VocabularyKey(nameof(fullName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastName = group.Add(new VocabularyKey(nameof(lastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey emailaddress1 { get; private set; }
public VocabularyKey eventPurchaseContactId { get; private set; }
public VocabularyKey firstName { get; private set; }
public VocabularyKey fullName { get; private set; }
public VocabularyKey lastName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}