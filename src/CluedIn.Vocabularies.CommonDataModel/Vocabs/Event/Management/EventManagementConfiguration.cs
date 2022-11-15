using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventManagementConfigurationVocabulary : SimpleVocabulary
    {
        public EventManagementConfigurationVocabulary()
        {
            VocabularyName = "Event Management Configuration";
            KeyPrefix = "commonDataModel.eventmanagementconfiguration";
            KeySeparator = ".";
            Grouping = "/EventManagementConfiguration";

            AddGroup("EventManagementConfiguration Details", group =>
            {
                AuthenticationResource = group.Add(new VocabularyKey(nameof(AuthenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthenticationTokenEndpoint = group.Add(new VocabularyKey(nameof(AuthenticationTokenEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Configcachecreatedon = group.Add(new VocabularyKey(nameof(Configcachecreatedon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Configcacheexpirationdate = group.Add(new VocabularyKey(nameof(Configcacheexpirationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Configcacheexpirationinsec = group.Add(new VocabularyKey(nameof(Configcacheexpirationinsec), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationState = group.Add(new VocabularyKey(nameof(ConfigurationState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discoveryendpointurl = group.Add(new VocabularyKey(nameof(Discoveryendpointurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventManagementConfigurationId = group.Add(new VocabularyKey(nameof(EventManagementConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationConfig = group.Add(new VocabularyKey(nameof(OrganizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AuthenticationResource { get; private set; }
        public VocabularyKey AuthenticationTokenEndpoint { get; private set; }
        public VocabularyKey Configcachecreatedon { get; private set; }
        public VocabularyKey Configcacheexpirationdate { get; private set; }
        public VocabularyKey Configcacheexpirationinsec { get; private set; }
        public VocabularyKey ConfigurationState { get; private set; }
        public VocabularyKey Discoveryendpointurl { get; private set; }
        public VocabularyKey EventManagementConfigurationId { get; private set; }
        public VocabularyKey OrganizationConfig { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}