using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenIntegrationConfigurationVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenIntegrationConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model LinkedInLeadGenIntegrationConfiguration";
            KeyPrefix = "commonDataModel.linkedinleadgenintegrationconfiguration";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenIntegrationConfiguration";

            AddGroup("Common Data Model LinkedInLeadGenIntegrationConfiguration Details", group =>
            {
                authenticationResource = group.Add(new VocabularyKey(nameof(authenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
authenticationTokenEndpoint = group.Add(new VocabularyKey(nameof(authenticationTokenEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
authenticationType = group.Add(new VocabularyKey(nameof(authenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
clientID = group.Add(new VocabularyKey(nameof(clientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configcacheexpirationdate = group.Add(new VocabularyKey(nameof(configcacheexpirationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
configcacheexpirationperiodinms = group.Add(new VocabularyKey(nameof(configcacheexpirationperiodinms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
discoveryendpointurl = group.Add(new VocabularyKey(nameof(discoveryendpointurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedInConfigurationId = group.Add(new VocabularyKey(nameof(linkedInConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
onMatchingFail = group.Add(new VocabularyKey(nameof(onMatchingFail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
organizationConfig = group.Add(new VocabularyKey(nameof(organizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
redirectURL = group.Add(new VocabularyKey(nameof(redirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
s2sinboundconfigurl = group.Add(new VocabularyKey(nameof(s2sinboundconfigurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
servicePublicId = group.Add(new VocabularyKey(nameof(servicePublicId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey authenticationResource { get; private set; }
public VocabularyKey authenticationTokenEndpoint { get; private set; }
public VocabularyKey authenticationType { get; private set; }
public VocabularyKey clientID { get; private set; }
public VocabularyKey configcacheexpirationdate { get; private set; }
public VocabularyKey configcacheexpirationperiodinms { get; private set; }
public VocabularyKey discoveryendpointurl { get; private set; }
public VocabularyKey linkedInConfigurationId { get; private set; }
public VocabularyKey onMatchingFail { get; private set; }
public VocabularyKey organizationConfig { get; private set; }
public VocabularyKey redirectURL { get; private set; }
public VocabularyKey s2sinboundconfigurl { get; private set; }
public VocabularyKey servicePublicId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}