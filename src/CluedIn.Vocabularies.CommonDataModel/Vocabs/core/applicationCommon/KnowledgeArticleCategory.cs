using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class KnowledgeArticleCategoryVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleCategoryVocabulary()
        {
            VocabularyName = "Knowledge Article Category";
            KeyPrefix = "commonDataModel.knowledgearticlecategory.applicationcommon";
            KeySeparator = ".";
            Grouping = "/KnowledgeArticleCategory";

            AddGroup("KnowledgeArticleCategory Details for ApplicationCommon", group =>
            {
			    CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    KnowledgeArticleCategoryId = group.Add(new VocabularyKey(nameof(KnowledgeArticleCategoryId), "Unique identifier of the Category for the knowledge article.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey KnowledgeArticleCategoryId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}