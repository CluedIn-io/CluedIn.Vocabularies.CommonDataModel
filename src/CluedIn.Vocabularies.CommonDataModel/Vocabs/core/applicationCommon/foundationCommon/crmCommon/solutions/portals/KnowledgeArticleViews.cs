using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class KnowledgeArticleViewsVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleViewsVocabulary()
        {
            VocabularyName = "Knowledge Article Views";
            KeyPrefix = "commonDataModel.knowledgearticleviews.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeArticleViews;

            AddGroup("KnowledgeArticleViews Details for Portals", group =>
            {
			    KnowledgeArticleView = group.Add(new VocabularyKey(nameof(KnowledgeArticleView), "View Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DomainName = group.Add(new VocabularyKey(nameof(DomainName), "Domain Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Referrer = group.Add(new VocabularyKey(nameof(Referrer), "Referrer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
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
            
            #endregion
        }

        public VocabularyKey KnowledgeArticleView { get; private set; }
        public VocabularyKey DomainName { get; private set; }
        public VocabularyKey Referrer { get; private set; }
    }
}