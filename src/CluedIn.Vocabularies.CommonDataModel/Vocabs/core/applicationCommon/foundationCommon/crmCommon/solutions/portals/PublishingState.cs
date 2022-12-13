using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PublishingStateVocabulary : SimpleVocabulary
    {
        public PublishingStateVocabulary()
        {
            VocabularyName = "Publishing State";
            KeyPrefix = "commonDataModel.publishingstate";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PublishingState;

            AddGroup("PublishingState Details for Portals", group =>
            {
                PublishingStateId = group.Add(new VocabularyKey(nameof(PublishingStateId), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsVisible = group.Add(new VocabularyKey(nameof(IsVisible), "Select whether the publishing state is visible.", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
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
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="PublishingStateId"/> from Vocab 'Ad.cdm.json/Ad' with Property 'PublishingStateId'
            ///Property <see cref="PublishingStateId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'PublishingStateID'
            ///Property <see cref="PublishingStateId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'PublishingStateId'
            ///Property <see cref="PublishingStateId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'PublishingStateId'
            ///Property <see cref="PublishingStateId"/> from Vocab 'WebFile.cdm.json/WebFile' with Property 'PublishingStateId'
            ///Property <see cref="PublishingStateId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'PublishingStateId'
            ///Property <see cref="PublishingStateId"/> from Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'PublishingState'
            #endregion
        }

        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey IsVisible { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PublishingStateId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}