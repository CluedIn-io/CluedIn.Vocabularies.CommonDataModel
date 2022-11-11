using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ApplicationDocumentVocabulary : SimpleVocabulary
    {
        public ApplicationDocumentVocabulary()
        {
            VocabularyName = "ApplicationDocument";
            KeyPrefix = "commonDataModel.applicationdocument";
            KeySeparator = ".";
            Grouping = "/ApplicationDocument";

            AddGroup("ApplicationDocument Details", group =>
            {
                applicationDocumentId = group.Add(new VocabularyKey(nameof(applicationDocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey applicationDocumentId { get; private set; }


    }
}