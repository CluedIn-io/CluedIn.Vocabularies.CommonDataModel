using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class ArticleVocabulary : SimpleVocabulary
    {
        public ArticleVocabulary()
        {
            VocabularyName = "Article";
            KeyPrefix = "commonDataModel.article.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Article;

            AddGroup("Article Details for Portals", group =>
            {
			    PublishToWeb = group.Add(new VocabularyKey(nameof(PublishToWeb), "Publish to Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AverageRating = group.Add(new VocabularyKey(nameof(AverageRating), "Average Rating", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AverageRatingWholeNumber = group.Add(new VocabularyKey(nameof(AverageRatingWholeNumber), "Average Rating (Whole Number)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Downvotes = group.Add(new VocabularyKey(nameof(Downvotes), "Downvotes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RatingCount = group.Add(new VocabularyKey(nameof(RatingCount), "Rating Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RatingSum = group.Add(new VocabularyKey(nameof(RatingSum), "Rating Sum", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Upvotes = group.Add(new VocabularyKey(nameof(Upvotes), "Upvotes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="KbArticleTemplateId"/> to Vocab '/core/applicationCommon/ArticleTemplate.cdm.json/ArticleTemplate' with Property 'KbArticleTemplateId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="IncidentId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="KbArticleTemplateId"/> from Vocab 'Article.cdm.json/Article' with Property 'KbArticleTemplateId'
            ///Property <see cref="KbArticleId"/> from Vocab 'Case.cdm.json/Case' with Property 'KbArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'CaseDeflection.cdm.json/CaseDeflection' with Property 'KnowledgeArticle'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticleViews.cdm.json/KnowledgeArticleViews' with Property 'KnowledgearticleId'
            #endregion
        }

        public VocabularyKey PublishToWeb { get; private set; }
        public VocabularyKey AverageRating { get; private set; }
        public VocabularyKey AverageRatingWholeNumber { get; private set; }
        public VocabularyKey Downvotes { get; private set; }
        public VocabularyKey RatingCount { get; private set; }
        public VocabularyKey RatingSum { get; private set; }
        public VocabularyKey Upvotes { get; private set; }
    }
}