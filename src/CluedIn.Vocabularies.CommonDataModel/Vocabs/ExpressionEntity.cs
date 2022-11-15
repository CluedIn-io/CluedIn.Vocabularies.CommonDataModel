using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExpressionEntityVocabulary : SimpleVocabulary
    {
        public ExpressionEntityVocabulary()
        {
            VocabularyName = "Expression Entity";
            KeyPrefix = "commonDataModel.expressionentity";
            KeySeparator = ".";
            Grouping = "/ExpressionEntity";

            AddGroup("ExpressionEntity Details", group =>
            {
                ExpressionId = group.Add(new VocabularyKey(nameof(ExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionClassName = group.Add(new VocabularyKey(nameof(ExpressionClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                XPathQuery = group.Add(new VocabularyKey(nameof(XPathQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionDefinition = group.Add(new VocabularyKey(nameof(ExpressionDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExpressionId { get; private set; }
        public VocabularyKey ExpressionClassName { get; private set; }
        public VocabularyKey XPathQuery { get; private set; }
        public VocabularyKey ExpressionDefinition { get; private set; }
    }
}