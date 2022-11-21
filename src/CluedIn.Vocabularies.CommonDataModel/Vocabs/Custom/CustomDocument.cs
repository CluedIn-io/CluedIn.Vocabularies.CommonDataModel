using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomDocumentVocabulary : SimpleVocabulary
    {
        public CustomDocumentVocabulary()
        {
            VocabularyName = "Custom Document";
            KeyPrefix = "commonDataModel.customdocument";
            KeySeparator = ".";
            Grouping = "/CustomDocument";

            AddGroup("CustomDocument Details", group =>
            {
                CustomDocumentId = group.Add(new VocabularyKey(nameof(CustomDocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomDocumentId { get; private set; }
    }
}