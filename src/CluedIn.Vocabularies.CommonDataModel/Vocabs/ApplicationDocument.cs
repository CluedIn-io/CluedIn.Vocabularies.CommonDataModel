using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ApplicationDocumentVocabulary : SimpleVocabulary
    {
        public ApplicationDocumentVocabulary()
        {
            VocabularyName = "Common Data Model ApplicationDocument";
            KeyPrefix = "commonDataModel.applicationdocument";
            KeySeparator = ".";
            Grouping = "/ApplicationDocument";

            AddGroup("Common Data Model ApplicationDocument Details", group =>
            {
                applicationDocumentId = group.Add(new VocabularyKey(nameof(applicationDocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey applicationDocumentId { get; private set; }


    }
}