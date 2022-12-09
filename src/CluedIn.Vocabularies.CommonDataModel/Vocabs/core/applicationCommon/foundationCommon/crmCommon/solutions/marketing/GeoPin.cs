using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class GeoPinVocabulary : SimpleVocabulary
    {
        public GeoPinVocabulary()
        {
            VocabularyName = "Geo Pin";
            KeyPrefix = "commonDataModel.geopin";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.GeoPin;

            AddGroup("GeoPin Details for Marketing", group =>
            {
			    GeopinId = group.Add(new VocabularyKey(nameof(GeopinId), "Geo pin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CampaignGeoPinsId = group.Add(new VocabularyKey(nameof(CampaignGeoPinsId), "Campaign geo pins", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CenterLatitude = group.Add(new VocabularyKey(nameof(CenterLatitude), "Center latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CenterLongitude = group.Add(new VocabularyKey(nameof(CenterLongitude), "Center longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    KPIEmailClickedCount = group.Add(new VocabularyKey(nameof(KPIEmailClickedCount), "KPI email clicked count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    KPIEmailOpenedCount = group.Add(new VocabularyKey(nameof(KPIEmailOpenedCount), "KPI email opened count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    KPIRedirectLinkClickedCount = group.Add(new VocabularyKey(nameof(KPIRedirectLinkClickedCount), "KPI redirect link clicked count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    KPIWebsiteClickedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteClickedCount), "KPI website clicked count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    KPIWebsiteVisitedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteVisitedCount), "KPI website visited count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    KpiFormSubmittedCount = group.Add(new VocabularyKey(nameof(KpiFormSubmittedCount), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    NorthwestLatitude = group.Add(new VocabularyKey(nameof(NorthwestLatitude), "Northwest latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    NorthwestLongitude = group.Add(new VocabularyKey(nameof(NorthwestLongitude), "Northwest longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "Postal code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RedirectURLGeoPinsId = group.Add(new VocabularyKey(nameof(RedirectURLGeoPinsId), "Redirect URL geo pins", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestBuilderService_mktgeopins = group.Add(new VocabularyKey(nameof(RequestBuilderService_mktgeopins), "Marketing interactions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResultParserService_mktgeopins = group.Add(new VocabularyKey(nameof(ResultParserService_mktgeopins), "Marketing interactions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServerIdMarketing = group.Add(new VocabularyKey(nameof(ServerIdMarketing), "serverId_marketing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SoutheastLatitude = group.Add(new VocabularyKey(nameof(SoutheastLatitude), "Southeast latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SoutheastLongitude = group.Add(new VocabularyKey(nameof(SoutheastLongitude), "Southeast longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContactGeoPinsId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerJourney"/> to Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'CustomerJourneyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="MarketingformGeoPinsId"/> to Vocab 'MarketingForm.cdm.json/MarketingForm' with Property 'MarketingFormId'
            ///Property <see cref="LeadGeoPinsId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="MarketingEmailGeoPinsId"/> to Vocab 'MarketingEmail.cdm.json/MarketingEmail' with Property 'MarketingEmailId'
            ///Property <see cref="MarketingPageGeoPinsId"/> to Vocab 'MarketingPage.cdm.json/MarketingPage' with Property 'MarketingPageId'
            ///Property <see cref="WebsiteGeoPinsId"/> to Vocab 'MarketingWebsite.cdm.json/MarketingWebsite' with Property 'WebsiteId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CampaignGeoPinsId { get; private set; }
        public VocabularyKey CenterLatitude { get; private set; }
        public VocabularyKey CenterLongitude { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey GeopinId { get; private set; }
        public VocabularyKey KPIEmailClickedCount { get; private set; }
        public VocabularyKey KPIEmailOpenedCount { get; private set; }
        public VocabularyKey KpiFormSubmittedCount { get; private set; }
        public VocabularyKey KPIRedirectLinkClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteVisitedCount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NorthwestLatitude { get; private set; }
        public VocabularyKey NorthwestLongitude { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey RedirectURLGeoPinsId { get; private set; }
        public VocabularyKey RequestBuilderService_mktgeopins { get; private set; }
        public VocabularyKey ResultParserService_mktgeopins { get; private set; }
        public VocabularyKey ServerIdMarketing { get; private set; }
        public VocabularyKey SoutheastLatitude { get; private set; }
        public VocabularyKey SoutheastLongitude { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}