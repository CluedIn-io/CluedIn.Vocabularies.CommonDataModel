using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmKnowledgeArticleEntityVocabulary : SimpleVocabulary
    {
        public smmKnowledgeArticleEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmKnowledgeArticleEntity";
            KeyPrefix = "commonDataModel.smmknowledgearticleentity";
            KeySeparator = ".";
            Grouping = "/smmKnowledgeArticleEntity";

            AddGroup("Common Data Model smmKnowledgeArticleEntity Details", group =>
            {
                ArticleDocument = group.Add(new VocabularyKey(nameof(ArticleDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleItemId = group.Add(new VocabularyKey(nameof(ArticleItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleName = group.Add(new VocabularyKey(nameof(ArticleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleURL = group.Add(new VocabularyKey(nameof(ArticleURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleMemo = group.Add(new VocabularyKey(nameof(ArticleMemo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentArticleItemId = group.Add(new VocabularyKey(nameof(ParentArticleItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleSubject = group.Add(new VocabularyKey(nameof(ArticleSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArticleDocumentType = group.Add(new VocabularyKey(nameof(ArticleDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ArticleDocument { get; private set; }
        public VocabularyKey ArticleItemId { get; private set; }
        public VocabularyKey ArticleName { get; private set; }
        public VocabularyKey ArticleURL { get; private set; }
        public VocabularyKey ArticleMemo { get; private set; }
        public VocabularyKey ParentArticleItemId { get; private set; }
        public VocabularyKey ArticleSubject { get; private set; }
        public VocabularyKey ArticleDocumentType { get; private set; }


    }
}