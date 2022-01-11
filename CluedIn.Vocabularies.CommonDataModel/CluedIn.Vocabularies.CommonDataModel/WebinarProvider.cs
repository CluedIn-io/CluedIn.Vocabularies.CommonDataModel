using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebinarProviderVocabulary : SimpleVocabulary
    {
        public WebinarProviderVocabulary()
        {
            VocabularyName = "Common Data Model WebinarProvider";
            KeyPrefix = "commonDataModel.webinarprovider";
            KeySeparator = ".";
            Grouping = "/WebinarProvider";

            AddGroup("Common Data Model WebinarProvider Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
baseServiceURL = group.Add(new VocabularyKey(nameof(baseServiceURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
clientID = group.Add(new VocabularyKey(nameof(clientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
clientSecret = group.Add(new VocabularyKey(nameof(clientSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isDefaultProvider = group.Add(new VocabularyKey(nameof(isDefaultProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxDurationInMinutes = group.Add(new VocabularyKey(nameof(maxDurationInMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
privacyPolicy = group.Add(new VocabularyKey(nameof(privacyPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
termsOfService = group.Add(new VocabularyKey(nameof(termsOfService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
updateCredentials = group.Add(new VocabularyKey(nameof(updateCredentials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarProviderId = group.Add(new VocabularyKey(nameof(webinarProviderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
public VocabularyKey baseServiceURL { get; private set; }
public VocabularyKey clientID { get; private set; }
public VocabularyKey clientSecret { get; private set; }
public VocabularyKey isDefaultProvider { get; private set; }
public VocabularyKey maxDurationInMinutes { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey privacyPolicy { get; private set; }
public VocabularyKey termsOfService { get; private set; }
public VocabularyKey updateCredentials { get; private set; }
public VocabularyKey webinarProviderId { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}