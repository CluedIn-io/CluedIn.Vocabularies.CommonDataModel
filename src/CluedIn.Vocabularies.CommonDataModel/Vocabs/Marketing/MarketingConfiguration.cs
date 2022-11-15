using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingConfigurationVocabulary : SimpleVocabulary
    {
        public MarketingConfigurationVocabulary()
        {
            VocabularyName = "Marketing Configuration";
            KeyPrefix = "commonDataModel.marketingconfiguration";
            KeySeparator = ".";
            Grouping = "/MarketingConfiguration";

            AddGroup("MarketingConfiguration Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigCacheExpirationDate = group.Add(new VocabularyKey(nameof(ConfigCacheExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigCacheExpirationPeriodInMs = group.Add(new VocabularyKey(nameof(ConfigCacheExpirationPeriodInMs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInstallComplete = group.Add(new VocabularyKey(nameof(IsInstallComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingConfigurationId = group.Add(new VocabularyKey(nameof(MarketingConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Maxretryattempts = group.Add(new VocabularyKey(nameof(Maxretryattempts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Httptimeout = group.Add(new VocabularyKey(nameof(Httptimeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MktSvcDiscoveryEndpointUrl = group.Add(new VocabularyKey(nameof(MktSvcDiscoveryEndpointUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @Default = group.Add(new VocabularyKey(nameof(@Default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationConfig = group.Add(new VocabularyKey(nameof(OrganizationConfig), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TokenAuthenticationResource = group.Add(new VocabularyKey(nameof(TokenAuthenticationResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBasicAuth = group.Add(new VocabularyKey(nameof(UseBasicAuth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMarketingListAvailableInApp = group.Add(new VocabularyKey(nameof(IsMarketingListAvailableInApp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstTimeSetupUrl = group.Add(new VocabularyKey(nameof(FirstTimeSetupUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Setupstatus = group.Add(new VocabularyKey(nameof(Setupstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Isemailtemplatesconsented = group.Add(new VocabularyKey(nameof(Isemailtemplatesconsented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey ConfigCacheExpirationDate { get; private set; }
        public VocabularyKey ConfigCacheExpirationPeriodInMs { get; private set; }
        public VocabularyKey IsInstallComplete { get; private set; }
        public VocabularyKey MarketingConfigurationId { get; private set; }
        public VocabularyKey Maxretryattempts { get; private set; }
        public VocabularyKey Httptimeout { get; private set; }
        public VocabularyKey MktSvcDiscoveryEndpointUrl { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey @Default { get; private set; }
        public VocabularyKey OrganizationConfig { get; private set; }
        public VocabularyKey TokenAuthenticationResource { get; private set; }
        public VocabularyKey UseBasicAuth { get; private set; }
        public VocabularyKey IsMarketingListAvailableInApp { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey FirstTimeSetupUrl { get; private set; }
        public VocabularyKey Setupstatus { get; private set; }
        public VocabularyKey Isemailtemplatesconsented { get; private set; }
    }
}