using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class WebTemplateVocabulary : SimpleVocabulary
    {
        public WebTemplateVocabulary()
        {
            VocabularyName = "Web Template";
            KeyPrefix = "commonDataModel.webtemplate";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.WebTemplate;

            AddGroup("WebTemplate Details for Portals", group =>
            {
                WebTemplateId = group.Add(new VocabularyKey(nameof(WebTemplateId), "Web Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                MIMEType = group.Add(new VocabularyKey(nameof(MIMEType), "MIME Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="WebTemplateId"/> from Vocab 'Ad.cdm.json/Ad' with Property 'WebTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'AdPlacement.cdm.json/AdPlacement' with Property 'WebTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'PageTemplate.cdm.json/PageTemplate' with Property 'WebTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'Poll.cdm.json/Poll' with Property 'WebTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'PollPlacement.cdm.json/PollPlacement' with Property 'WebTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'Website.cdm.json/Website' with Property 'FooterTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab 'Website.cdm.json/Website' with Property 'HeaderTemplateId'
            ///Property <see cref="WebTemplateId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'WebTemplate'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey MIMEType { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey WebTemplateId { get; private set; }
    }
}