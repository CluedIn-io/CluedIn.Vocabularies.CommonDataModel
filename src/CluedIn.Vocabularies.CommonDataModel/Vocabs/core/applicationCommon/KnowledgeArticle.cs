using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class KnowledgeArticleVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleVocabulary()
        {
            VocabularyName = "Knowledge Article";
            KeyPrefix = "commonDataModel.knowledgearticle";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeArticle;

            AddGroup("KnowledgeArticle Details for ApplicationCommon", group =>
            {
                KnowledgearticleId = group.Add(new VocabularyKey(nameof(KnowledgearticleId), "Knowledge Article", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Content = group.Add(new VocabularyKey(nameof(Content), "Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyWords = group.Add(new VocabularyKey(nameof(KeyWords), "Keywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishOn = group.Add(new VocabularyKey(nameof(PublishOn), "Publish On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnowledgeArticleViews = group.Add(new VocabularyKey(nameof(KnowledgeArticleViews), "Knowledge Article Views", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MajorVersionNumber = group.Add(new VocabularyKey(nameof(MajorVersionNumber), "Major Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MinorVersionNumber = group.Add(new VocabularyKey(nameof(MinorVersionNumber), "Minor Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                LanguageLocaleId = group.Add(new VocabularyKey(nameof(LanguageLocaleId), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStatusId = group.Add(new VocabularyKey(nameof(ScheduledStatusId), "Scheduled Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ExpirationStatusId = group.Add(new VocabularyKey(nameof(ExpirationStatusId), "Expired Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PublishStatusId = group.Add(new VocabularyKey(nameof(PublishStatusId), "Published Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), "Primary Article", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ReadyForReview = group.Add(new VocabularyKey(nameof(ReadyForReview), "Ready For Review", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Review = group.Add(new VocabularyKey(nameof(Review), "Review", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateContent = group.Add(new VocabularyKey(nameof(UpdateContent), "Update Content", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExpiredReviewOptions = group.Add(new VocabularyKey(nameof(ExpiredReviewOptions), "Expired Review Options", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRootArticle = group.Add(new VocabularyKey(nameof(IsRootArticle), "Root Article", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ArticlePublicNumber = group.Add(new VocabularyKey(nameof(ArticlePublicNumber), "Article Public Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLatestVersion = group.Add(new VocabularyKey(nameof(IsLatestVersion), "Is Latest Version", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                KnowledgeArticleViewsDate = group.Add(new VocabularyKey(nameof(KnowledgeArticleViewsDate), "Knowledge Article View(Last Updated Time)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnowledgeArticleViewsState = group.Add(new VocabularyKey(nameof(KnowledgeArticleViewsState), "Knowledge Article View(State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Rating = group.Add(new VocabularyKey(nameof(Rating), "Rating", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RatingDate = group.Add(new VocabularyKey(nameof(RatingDate), "Rating(Last Updated Time)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingState = group.Add(new VocabularyKey(nameof(RatingState), "Rating(State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RatingSum = group.Add(new VocabularyKey(nameof(RatingSum), "Rating(sum)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RatingCount = group.Add(new VocabularyKey(nameof(RatingCount), "Rating(Count)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsInternal = group.Add(new VocabularyKey(nameof(IsInternal), "Internal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SetCategoryAssociations = group.Add(new VocabularyKey(nameof(SetCategoryAssociations), "Set Category Associations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExpirationStateId = group.Add(new VocabularyKey(nameof(ExpirationStateId), "Expiration State Id", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });
            AddGroup("KnowledgeArticle Details for FoundationCommon", group =>
            {
                SetProductAssociations = group.Add(new VocabularyKey(nameof(SetProductAssociations), "Set Product Associations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="PrimaryAuthorId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreviousArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RootArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgeArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PrimaryAuthorId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'ParentArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'PreviousArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'RootArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticleCategory.cdm.json/KnowledgeArticleCategory' with Property 'KnowledgeArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticleViews.cdm.json/KnowledgeArticleViews' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'QueueItem.cdm.json/QueueItem' with Property 'ObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Team.cdm.json/Team' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/AppointmentEMR.cdm.json/AppointmentEMR' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Task.cdm.json/Task' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey ArticlePublicNumber { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey ExpirationStateId { get; private set; }
        public VocabularyKey ExpirationStatusId { get; private set; }
        public VocabularyKey ExpiredReviewOptions { get; private set; }
        public VocabularyKey IsInternal { get; private set; }
        public VocabularyKey IsLatestVersion { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsRootArticle { get; private set; }
        public VocabularyKey KeyWords { get; private set; }
        public VocabularyKey KnowledgearticleId { get; private set; }
        public VocabularyKey KnowledgeArticleViews { get; private set; }
        public VocabularyKey KnowledgeArticleViewsDate { get; private set; }
        public VocabularyKey KnowledgeArticleViewsState { get; private set; }
        public VocabularyKey LanguageLocaleId { get; private set; }
        public VocabularyKey MajorVersionNumber { get; private set; }
        public VocabularyKey MinorVersionNumber { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey PublishOn { get; private set; }
        public VocabularyKey PublishStatusId { get; private set; }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey RatingCount { get; private set; }
        public VocabularyKey RatingDate { get; private set; }
        public VocabularyKey RatingState { get; private set; }
        public VocabularyKey RatingSum { get; private set; }
        public VocabularyKey ReadyForReview { get; private set; }
        public VocabularyKey Review { get; private set; }
        public VocabularyKey ScheduledStatusId { get; private set; }
        public VocabularyKey SetCategoryAssociations { get; private set; }
        public VocabularyKey SetProductAssociations { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey UpdateContent { get; private set; }
    }
}