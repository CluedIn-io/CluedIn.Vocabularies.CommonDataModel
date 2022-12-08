using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class KnowledgeArticleCategoryVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleCategoryVocabulary()
        {
            VocabularyName = "Knowledge Article Category";
            KeyPrefix = "commonDataModel.knowledgearticlecategory.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeArticleCategory;

            AddGroup("KnowledgeArticleCategory Details for ApplicationCommon", group =>
            {
			    CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    KnowledgeArticleCategoryId = group.Add(new VocabularyKey(nameof(KnowledgeArticleCategoryId), "Unique identifier of the Category for the knowledge article.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="KnowledgeArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey KnowledgeArticleCategoryId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}