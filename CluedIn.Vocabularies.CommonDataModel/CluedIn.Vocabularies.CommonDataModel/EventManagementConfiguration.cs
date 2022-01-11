using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventManagementConfigurationVocabulary : SimpleVocabulary
    {
        public EventManagementConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model EventManagementConfiguration";
            KeyPrefix = "commonDataModel.eventmanagementconfiguration";
            KeySeparator = ".";
            Grouping = "/EventManagementConfiguration";

            AddGroup("Common Data Model EventManagementConfiguration Details", group =>
            {
                authenticationResource = group.Add(new VocabularyKey(nameof(authenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
authenticationTokenEndpoint = group.Add(new VocabularyKey(nameof(authenticationTokenEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configcachecreatedon = group.Add(new VocabularyKey(nameof(configcachecreatedon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configcacheexpirationdate = group.Add(new VocabularyKey(nameof(configcacheexpirationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configcacheexpirationinsec = group.Add(new VocabularyKey(nameof(configcacheexpirationinsec), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configurationState = group.Add(new VocabularyKey(nameof(configurationState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
discoveryendpointurl = group.Add(new VocabularyKey(nameof(discoveryendpointurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventManagementConfigurationId = group.Add(new VocabularyKey(nameof(eventManagementConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
organizationConfig = group.Add(new VocabularyKey(nameof(organizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey authenticationResource { get; private set; }
public VocabularyKey authenticationTokenEndpoint { get; private set; }
public VocabularyKey configcachecreatedon { get; private set; }
public VocabularyKey configcacheexpirationdate { get; private set; }
public VocabularyKey configcacheexpirationinsec { get; private set; }
public VocabularyKey configurationState { get; private set; }
public VocabularyKey discoveryendpointurl { get; private set; }
public VocabularyKey eventManagementConfigurationId { get; private set; }
public VocabularyKey organizationConfig { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}