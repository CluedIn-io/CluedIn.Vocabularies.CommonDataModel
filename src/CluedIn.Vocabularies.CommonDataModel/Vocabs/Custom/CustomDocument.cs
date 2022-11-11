using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomDocumentVocabulary : SimpleVocabulary
    {
        public CustomDocumentVocabulary()
        {
            VocabularyName = "Common Data Model CustomDocument";
            KeyPrefix = "commonDataModel.customdocument";
            KeySeparator = ".";
            Grouping = "/CustomDocument";

            AddGroup("Common Data Model CustomDocument Details", group =>
            {
                customDocumentId = group.Add(new VocabularyKey(nameof(customDocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey customDocumentId { get; private set; }


    }
}