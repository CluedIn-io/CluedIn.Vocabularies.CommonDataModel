using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LandingPagesVocabulary : SimpleVocabulary
    {
        public LandingPagesVocabulary()
        {
            VocabularyName = "Landing Pages";
            KeyPrefix = "commonDataModel.landingpages";
            KeySeparator = ".";
            Grouping = "/LandingPages";

            AddGroup("LandingPages Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contactcampaignattribute = group.Add(new VocabularyKey(nameof(Contactcampaignattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactEmailAttribute = group.Add(new VocabularyKey(nameof(ContactEmailAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contactmarketingformattribute = group.Add(new VocabularyKey(nameof(Contactmarketingformattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contactmarketingpageattribute = group.Add(new VocabularyKey(nameof(Contactmarketingpageattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @Default = group.Add(new VocabularyKey(nameof(@Default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keepsuccessfulsubmissions = group.Add(new VocabularyKey(nameof(Keepsuccessfulsubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(Entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allowsubmissiononlyforms = group.Add(new VocabularyKey(nameof(Allowsubmissiononlyforms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsertPrivacyBanner = group.Add(new VocabularyKey(nameof(InsertPrivacyBanner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadCampaignAttribute = group.Add(new VocabularyKey(nameof(LeadCampaignAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadContactAttribute = group.Add(new VocabularyKey(nameof(LeadContactAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadEmailAttribute = group.Add(new VocabularyKey(nameof(LeadEmailAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Leadmarketingformattribute = group.Add(new VocabularyKey(nameof(Leadmarketingformattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Leadmarketingpageattribute = group.Add(new VocabularyKey(nameof(Leadmarketingpageattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingpageconfigurationId = group.Add(new VocabularyKey(nameof(MarketingpageconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyBannerText = group.Add(new VocabularyKey(nameof(PrivacyBannerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyPolicyLinkText = group.Add(new VocabularyKey(nameof(PrivacyPolicyLinkText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyPolicyLinkURL = group.Add(new VocabularyKey(nameof(PrivacyPolicyLinkURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebsitefilterPlaceholder = group.Add(new VocabularyKey(nameof(WebsitefilterPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Websiteid = group.Add(new VocabularyKey(nameof(Websiteid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Websitelanguageid = group.Add(new VocabularyKey(nameof(Websitelanguageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parentwebpageid = group.Add(new VocabularyKey(nameof(Parentwebpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Portalintegrationtype = group.Add(new VocabularyKey(nameof(Portalintegrationtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PortalInstallationStatus = group.Add(new VocabularyKey(nameof(PortalInstallationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationtypeLastrefresh = group.Add(new VocabularyKey(nameof(OrganizationtypeLastrefresh), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Contactcampaignattribute { get; private set; }
        public VocabularyKey ContactEmailAttribute { get; private set; }
        public VocabularyKey Contactmarketingformattribute { get; private set; }
        public VocabularyKey Contactmarketingpageattribute { get; private set; }
        public VocabularyKey @Default { get; private set; }
        public VocabularyKey Keepsuccessfulsubmissions { get; private set; }
        public VocabularyKey Entityupdatebehavioronsubmit { get; private set; }
        public VocabularyKey Allowsubmissiononlyforms { get; private set; }
        public VocabularyKey InsertPrivacyBanner { get; private set; }
        public VocabularyKey LeadCampaignAttribute { get; private set; }
        public VocabularyKey LeadContactAttribute { get; private set; }
        public VocabularyKey LeadEmailAttribute { get; private set; }
        public VocabularyKey Leadmarketingformattribute { get; private set; }
        public VocabularyKey Leadmarketingpageattribute { get; private set; }
        public VocabularyKey MarketingpageconfigurationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrivacyBannerText { get; private set; }
        public VocabularyKey PrivacyPolicyLinkText { get; private set; }
        public VocabularyKey PrivacyPolicyLinkURL { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey WebsitefilterPlaceholder { get; private set; }
        public VocabularyKey Websiteid { get; private set; }
        public VocabularyKey Websitelanguageid { get; private set; }
        public VocabularyKey Parentwebpageid { get; private set; }
        public VocabularyKey Portalintegrationtype { get; private set; }
        public VocabularyKey PortalInstallationStatus { get; private set; }
        public VocabularyKey OrganizationtypeLastrefresh { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
    }
}