using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenIntegrationConfigurationVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenIntegrationConfigurationVocabulary()
        {
            VocabularyName = "Linked In Lead Gen Integration Configuration";
            KeyPrefix = "commonDataModel.linkedinleadgenintegrationconfiguration";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenIntegrationConfiguration";

            AddGroup("LinkedInLeadGenIntegrationConfiguration Details", group =>
            {
                AuthenticationResource = group.Add(new VocabularyKey(nameof(AuthenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthenticationTokenEndpoint = group.Add(new VocabularyKey(nameof(AuthenticationTokenEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthenticationType = group.Add(new VocabularyKey(nameof(AuthenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientID = group.Add(new VocabularyKey(nameof(ClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Configcacheexpirationdate = group.Add(new VocabularyKey(nameof(Configcacheexpirationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Configcacheexpirationperiodinms = group.Add(new VocabularyKey(nameof(Configcacheexpirationperiodinms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discoveryendpointurl = group.Add(new VocabularyKey(nameof(Discoveryendpointurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInConfigurationId = group.Add(new VocabularyKey(nameof(LinkedInConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnMatchingFail = group.Add(new VocabularyKey(nameof(OnMatchingFail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationConfig = group.Add(new VocabularyKey(nameof(OrganizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                S2sinboundconfigurl = group.Add(new VocabularyKey(nameof(S2sinboundconfigurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicePublicId = group.Add(new VocabularyKey(nameof(ServicePublicId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AuthenticationResource { get; private set; }
        public VocabularyKey AuthenticationTokenEndpoint { get; private set; }
        public VocabularyKey AuthenticationType { get; private set; }
        public VocabularyKey ClientID { get; private set; }
        public VocabularyKey Configcacheexpirationdate { get; private set; }
        public VocabularyKey Configcacheexpirationperiodinms { get; private set; }
        public VocabularyKey Discoveryendpointurl { get; private set; }
        public VocabularyKey LinkedInConfigurationId { get; private set; }
        public VocabularyKey OnMatchingFail { get; private set; }
        public VocabularyKey OrganizationConfig { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey S2sinboundconfigurl { get; private set; }
        public VocabularyKey ServicePublicId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}