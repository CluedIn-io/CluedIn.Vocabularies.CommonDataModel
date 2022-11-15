using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ApplicationDocumentVocabulary : SimpleVocabulary
    {
        public ApplicationDocumentVocabulary()
        {
            VocabularyName = "Application Document";
            KeyPrefix = "commonDataModel.applicationdocument";
            KeySeparator = ".";
            Grouping = "/ApplicationDocument";

            AddGroup("ApplicationDocument Details", group =>
            {
                ApplicationDocumentId = group.Add(new VocabularyKey(nameof(ApplicationDocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ApplicationDocumentId { get; private set; }
    }
}