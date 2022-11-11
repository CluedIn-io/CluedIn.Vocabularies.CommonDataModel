using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingConfigurationVocabulary : SimpleVocabulary
    {
        public MarketingConfigurationVocabulary()
        {
            VocabularyName = "MarketingConfiguration";
            KeyPrefix = "commonDataModel.marketingconfiguration";
            KeySeparator = ".";
            Grouping = "/MarketingConfiguration";

            AddGroup("MarketingConfiguration Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                configCacheExpirationDate = group.Add(new VocabularyKey(nameof(configCacheExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                configCacheExpirationPeriodInMs = group.Add(new VocabularyKey(nameof(configCacheExpirationPeriodInMs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isInstallComplete = group.Add(new VocabularyKey(nameof(isInstallComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingConfigurationId = group.Add(new VocabularyKey(nameof(marketingConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                maxretryattempts = group.Add(new VocabularyKey(nameof(maxretryattempts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                httptimeout = group.Add(new VocabularyKey(nameof(httptimeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mktSvcDiscoveryEndpointUrl = group.Add(new VocabularyKey(nameof(mktSvcDiscoveryEndpointUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @default = group.Add(new VocabularyKey(nameof(@default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                organizationConfig = group.Add(new VocabularyKey(nameof(organizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tokenAuthenticationResource = group.Add(new VocabularyKey(nameof(tokenAuthenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                useBasicAuth = group.Add(new VocabularyKey(nameof(useBasicAuth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isMarketingListAvailableInApp = group.Add(new VocabularyKey(nameof(isMarketingListAvailableInApp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                firstTimeSetupUrl = group.Add(new VocabularyKey(nameof(firstTimeSetupUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                setupstatus = group.Add(new VocabularyKey(nameof(setupstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isemailtemplatesconsented = group.Add(new VocabularyKey(nameof(isemailtemplatesconsented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey configCacheExpirationDate { get; private set; }
        public VocabularyKey configCacheExpirationPeriodInMs { get; private set; }
        public VocabularyKey isInstallComplete { get; private set; }
        public VocabularyKey marketingConfigurationId { get; private set; }
        public VocabularyKey maxretryattempts { get; private set; }
        public VocabularyKey httptimeout { get; private set; }
        public VocabularyKey mktSvcDiscoveryEndpointUrl { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey @default { get; private set; }
        public VocabularyKey organizationConfig { get; private set; }
        public VocabularyKey tokenAuthenticationResource { get; private set; }
        public VocabularyKey useBasicAuth { get; private set; }
        public VocabularyKey isMarketingListAvailableInApp { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey firstTimeSetupUrl { get; private set; }
        public VocabularyKey setupstatus { get; private set; }
        public VocabularyKey isemailtemplatesconsented { get; private set; }


    }
}