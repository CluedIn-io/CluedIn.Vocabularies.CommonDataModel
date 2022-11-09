using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SessionRegistrationVocabulary : SimpleVocabulary
    {
        public SessionRegistrationVocabulary()
        {
            VocabularyName = "Common Data Model SessionRegistration";
            KeyPrefix = "commonDataModel.sessionregistration";
            KeySeparator = ".";
            Grouping = "/SessionRegistration";

            AddGroup("Common Data Model SessionRegistration Details", group =>
            {
                createdFromApi = group.Add(new VocabularyKey(nameof(createdFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isCanceled = group.Add(new VocabularyKey(nameof(isCanceled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publishingState = group.Add(new VocabularyKey(nameof(publishingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationNotificationSeen = group.Add(new VocabularyKey(nameof(registrationNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationOperation = group.Add(new VocabularyKey(nameof(registrationOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationStatus = group.Add(new VocabularyKey(nameof(registrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionRegistrationId = group.Add(new VocabularyKey(nameof(sessionRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
syncedWithProvider = group.Add(new VocabularyKey(nameof(syncedWithProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timesCheckedIn = group.Add(new VocabularyKey(nameof(timesCheckedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarRegistrationID = group.Add(new VocabularyKey(nameof(webinarRegistrationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdFromApi { get; private set; }
public VocabularyKey isCanceled { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey publishingState { get; private set; }
public VocabularyKey registrationNotificationSeen { get; private set; }
public VocabularyKey registrationOperation { get; private set; }
public VocabularyKey registrationStatus { get; private set; }
public VocabularyKey sessionRegistrationId { get; private set; }
public VocabularyKey syncedWithProvider { get; private set; }
public VocabularyKey timesCheckedIn { get; private set; }
public VocabularyKey webinarRegistrationID { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}