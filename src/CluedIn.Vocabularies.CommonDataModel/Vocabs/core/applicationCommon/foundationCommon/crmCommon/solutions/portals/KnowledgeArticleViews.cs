using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class KnowledgeArticleViewsVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleViewsVocabulary()
        {
            VocabularyName = "Knowledge Article Views";
            KeyPrefix = "commonDataModel.knowledgearticleviews.portals";
            KeySeparator = ".";
            Grouping = "/KnowledgeArticleViews";

            AddGroup("KnowledgeArticleViews Details for Portals", group =>
            {
			    KnowledgeArticleView = group.Add(new VocabularyKey(nameof(KnowledgeArticleView), "View Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DomainName = group.Add(new VocabularyKey(nameof(DomainName), "Domain Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Referrer = group.Add(new VocabularyKey(nameof(Referrer), "Referrer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey KnowledgeArticleView { get; private set; }
        public VocabularyKey DomainName { get; private set; }
        public VocabularyKey Referrer { get; private set; }
    }
}