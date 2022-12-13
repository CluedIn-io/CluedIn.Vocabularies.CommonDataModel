using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SchedulingParameterVocabulary : SimpleVocabulary
    {
        public SchedulingParameterVocabulary()
        {
            VocabularyName = "Scheduling Parameter";
            KeyPrefix = "commonDataModel.schedulingparameter";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SchedulingParameter;

            AddGroup("SchedulingParameter Details for Scheduling", group =>
            {
                SchedulingParameterId = group.Add(new VocabularyKey(nameof(SchedulingParameterId), "Scheduling Parameter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedSettings = group.Add(new VocabularyKey(nameof(AdvancedSettings), "Advanced Settings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BackgroundJobsConfiguration = group.Add(new VocabularyKey(nameof(BackgroundJobsConfiguration), "Background Jobs Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableOptimizer = group.Add(new VocabularyKey(nameof(EnableOptimizer), "Enable Optimizer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ConnectToMaps = group.Add(new VocabularyKey(nameof(ConnectToMaps), "Connect to Maps", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CustomGeoLatitudeField = group.Add(new VocabularyKey(nameof(CustomGeoLatitudeField), "Custom Geo Latitude Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGeoLocationEntity = group.Add(new VocabularyKey(nameof(CustomGeoLocationEntity), "Custom Geo Location Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGeoLongitudeField = group.Add(new VocabularyKey(nameof(CustomGeoLongitudeField), "Custom Geo Longitude Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGeoResourceField = group.Add(new VocabularyKey(nameof(CustomGeoResourceField), "Custom Geo Resource Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGeoTimestampField = group.Add(new VocabularyKey(nameof(CustomGeoTimestampField), "Custom Geo Timestamp Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRadiusUnit = group.Add(new VocabularyKey(nameof(DefaultRadiusUnit), "Default Radius Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRadiusValue = group.Add(new VocabularyKey(nameof(DefaultRadiusValue), "Default Radius Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DisableSanitizingHTMLTemplates = group.Add(new VocabularyKey(nameof(DisableSanitizingHTMLTemplates), "Disable Sanitizing HTML Templates", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                EnableCustomGeoLocation = group.Add(new VocabularyKey(nameof(EnableCustomGeoLocation), "Enable Custom Geo Location", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                GeoLocationExpiresAfterXMinutes = group.Add(new VocabularyKey(nameof(GeoLocationExpiresAfterXMinutes), "Geo Location Expires After X Minutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                GeoLocationRefreshIntervalSeconds = group.Add(new VocabularyKey(nameof(GeoLocationRefreshIntervalSeconds), "Geo Location Refresh Interval Seconds", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MapApiKey = group.Add(new VocabularyKey(nameof(MapApiKey), "Map Api Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SAAutoFilterServiceTerritory = group.Add(new VocabularyKey(nameof(SAAutoFilterServiceTerritory), "Auto Filter Service Territory", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ScheduleBoardRefreshIntervalSeconds = group.Add(new VocabularyKey(nameof(ScheduleBoardRefreshIntervalSeconds), "The refresh rate of the schedule board.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey AdvancedSettings { get; private set; }
        public VocabularyKey BackgroundJobsConfiguration { get; private set; }
        public VocabularyKey ConnectToMaps { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CustomGeoLatitudeField { get; private set; }
        public VocabularyKey CustomGeoLocationEntity { get; private set; }
        public VocabularyKey CustomGeoLongitudeField { get; private set; }
        public VocabularyKey CustomGeoResourceField { get; private set; }
        public VocabularyKey CustomGeoTimestampField { get; private set; }
        public VocabularyKey DefaultRadiusUnit { get; private set; }
        public VocabularyKey DefaultRadiusValue { get; private set; }
        public VocabularyKey DisableSanitizingHTMLTemplates { get; private set; }
        public VocabularyKey EnableCustomGeoLocation { get; private set; }
        public VocabularyKey EnableOptimizer { get; private set; }
        public VocabularyKey GeoLocationExpiresAfterXMinutes { get; private set; }
        public VocabularyKey GeoLocationRefreshIntervalSeconds { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey MapApiKey { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey SAAutoFilterServiceTerritory { get; private set; }
        public VocabularyKey ScheduleBoardRefreshIntervalSeconds { get; private set; }
        public VocabularyKey SchedulingParameterId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}