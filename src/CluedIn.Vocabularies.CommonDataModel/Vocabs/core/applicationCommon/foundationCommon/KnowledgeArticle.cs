using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class KnowledgeArticleVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleVocabulary()
        {
            VocabularyName = "Knowledge Article";
            KeyPrefix = "commonDataModel.knowledgearticle.foundationcommon";
            KeySeparator = ".";
            Grouping = "/KnowledgeArticle";

            AddGroup("KnowledgeArticle Details for FoundationCommon", group =>
            {
			    SetProductAssociations = group.Add(new VocabularyKey(nameof(SetProductAssociations), "Set Product Associations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SetProductAssociations { get; private set; }
    }
}