using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Marketing
{
    public class MarketingEmailVocabulary : SimpleVocabulary
    {
        public MarketingEmailVocabulary()
        {
            VocabularyName = "Marketing Email";
            KeyPrefix = "commonDataModel.marketingemail.marketing";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MarketingEmail;

            AddGroup("MarketingEmail Details for Marketing", group =>
            {
			    MarketingEmailId = group.Add(new VocabularyKey(nameof(MarketingEmailId), "Marketing email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AutomaticallyGeneratePlainText = group.Add(new VocabularyKey(nameof(AutomaticallyGeneratePlainText), "Automatically generate plain text", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ClickMap = group.Add(new VocabularyKey(nameof(ClickMap), "Click map", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignerHTML = group.Add(new VocabularyKey(nameof(DesignerHTML), "Designer HTML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailBody = group.Add(new VocabularyKey(nameof(EmailBody), "Email body", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    FromEmail = group.Add(new VocabularyKey(nameof(FromEmail), "Email from address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    FromName = group.Add(new VocabularyKey(nameof(FromName), "Email from name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Istemplategalleryneeded = group.Add(new VocabularyKey(nameof(Istemplategalleryneeded), "Is template gallery needed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LegalDesignation = group.Add(new VocabularyKey(nameof(LegalDesignation), "Legal designation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReplyToEmail = group.Add(new VocabularyKey(nameof(ReplyToEmail), "Reply-to email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), "Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlainText = group.Add(new VocabularyKey(nameof(PlainText), "Plain text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UICEntityID = group.Add(new VocabularyKey(nameof(UICEntityID), "UIC Entity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="FromUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="MarketingEmailId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'SourceEmail'
            ///Property <see cref="MarketingEmailId"/> from Vocab 'GeoPin.cdm.json/GeoPin' with Property 'MarketingEmailGeoPinsId'
            ///Property <see cref="MarketingEmailId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'SourceEmail'
            ///Property <see cref="MarketingEmailId"/> from Vocab 'interactions/EmailOpened.cdm.json/EmailOpened' with Property 'MarketingEmailId'
            #endregion
        }

        public VocabularyKey MarketingEmailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AutomaticallyGeneratePlainText { get; private set; }
        public VocabularyKey ClickMap { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DesignerHTML { get; private set; }
        public VocabularyKey EmailBody { get; private set; }
        public VocabularyKey FromEmail { get; private set; }
        public VocabularyKey FromName { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Istemplategalleryneeded { get; private set; }
        public VocabularyKey LegalDesignation { get; private set; }
        public VocabularyKey ReplyToEmail { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey PlainText { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey UICEntityID { get; private set; }
    }
}