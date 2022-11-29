using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class KnowledgeArticleVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleVocabulary()
        {
            VocabularyName = "Knowledge Article";
            KeyPrefix = "commonDataModel.knowledgearticle.applicationcommon";
            KeySeparator = ".";
            Grouping = "/KnowledgeArticle";

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
        }

        public VocabularyKey KnowledgearticleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey KeyWords { get; private set; }
        public VocabularyKey PublishOn { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey KnowledgeArticleViews { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MajorVersionNumber { get; private set; }
        public VocabularyKey MinorVersionNumber { get; private set; }
        public VocabularyKey LanguageLocaleId { get; private set; }
        public VocabularyKey ScheduledStatusId { get; private set; }
        public VocabularyKey ExpirationStatusId { get; private set; }
        public VocabularyKey PublishStatusId { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey ReadyForReview { get; private set; }
        public VocabularyKey Review { get; private set; }
        public VocabularyKey UpdateContent { get; private set; }
        public VocabularyKey ExpiredReviewOptions { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey IsRootArticle { get; private set; }
        public VocabularyKey ArticlePublicNumber { get; private set; }
        public VocabularyKey IsLatestVersion { get; private set; }
        public VocabularyKey KnowledgeArticleViewsDate { get; private set; }
        public VocabularyKey KnowledgeArticleViewsState { get; private set; }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey RatingDate { get; private set; }
        public VocabularyKey RatingState { get; private set; }
        public VocabularyKey RatingSum { get; private set; }
        public VocabularyKey RatingCount { get; private set; }
        public VocabularyKey IsInternal { get; private set; }
        public VocabularyKey SetCategoryAssociations { get; private set; }
        public VocabularyKey ExpirationStateId { get; private set; }
    }
}