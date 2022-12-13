using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PageTemplateVocabulary : SimpleVocabulary
    {
        public PageTemplateVocabulary()
        {
            VocabularyName = "Page Template";
            KeyPrefix = "commonDataModel.pagetemplate";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PageTemplate;

            AddGroup("PageTemplate Details for Portals", group =>
            {
                PageTemplateId = group.Add(new VocabularyKey(nameof(PageTemplateId), "Page Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                RewriteURL = group.Add(new VocabularyKey(nameof(RewriteURL), "Rewrite Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseWebsiteHeaderAndFooter = group.Add(new VocabularyKey(nameof(UseWebsiteHeaderAndFooter), "Use Website Header and Footer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
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
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="WebTemplateId"/> to Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="PageTemplateId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'ArchiveTemplateId'
            ///Property <see cref="PageTemplateId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'HomeTemplateId'
            ///Property <see cref="PageTemplateId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'PostTemplateId'
            ///Property <see cref="PageTemplateId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'ForumPageTemplateID'
            ///Property <see cref="PageTemplateId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'ThreadPageTemplateID'
            ///Property <see cref="PageTemplateId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'PageTemplate'
            ///Property <see cref="PageTemplateId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'PageTemplateId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PageTemplateId { get; private set; }
        public VocabularyKey RewriteURL { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UseWebsiteHeaderAndFooter { get; private set; }
    }
}