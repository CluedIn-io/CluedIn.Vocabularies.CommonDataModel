using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebinarConfigurationVocabulary : SimpleVocabulary
    {
        public WebinarConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model WebinarConfiguration";
            KeyPrefix = "commonDataModel.webinarconfiguration";
            KeySeparator = ".";
            Grouping = "/WebinarConfiguration";

            AddGroup("Common Data Model WebinarConfiguration Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accessToken = group.Add(new VocabularyKey(nameof(accessToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accessTokenKey = group.Add(new VocabularyKey(nameof(accessTokenKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accessTokenSecret = group.Add(new VocabularyKey(nameof(accessTokenSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
appURL = group.Add(new VocabularyKey(nameof(appURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
authorized = group.Add(new VocabularyKey(nameof(authorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
clientID = group.Add(new VocabularyKey(nameof(clientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastUpdateDateTime = group.Add(new VocabularyKey(nameof(lastUpdateDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
message = group.Add(new VocabularyKey(nameof(message), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
providerServiceStatus = group.Add(new VocabularyKey(nameof(providerServiceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
updateCredentials = group.Add(new VocabularyKey(nameof(updateCredentials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarConfigurationId = group.Add(new VocabularyKey(nameof(webinarConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey accessToken { get; private set; }
public VocabularyKey accessTokenKey { get; private set; }
public VocabularyKey accessTokenSecret { get; private set; }
public VocabularyKey appURL { get; private set; }
public VocabularyKey authorized { get; private set; }
public VocabularyKey clientID { get; private set; }
public VocabularyKey lastUpdateDateTime { get; private set; }
public VocabularyKey message { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey providerServiceStatus { get; private set; }
public VocabularyKey updateCredentials { get; private set; }
public VocabularyKey webinarConfigurationId { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}