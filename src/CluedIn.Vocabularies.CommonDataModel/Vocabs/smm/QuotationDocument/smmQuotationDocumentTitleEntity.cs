using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmQuotationDocumentTitleEntityVocabulary : SimpleVocabulary
    {
        public SmmQuotationDocumentTitleEntityVocabulary()
        {
            VocabularyName = "Smm Quotation Document Title Entity";
            KeyPrefix = "commonDataModel.smmquotationdocumenttitleentity";
            KeySeparator = ".";
            Grouping = "/SmmQuotationDocumentTitleEntity";

            AddGroup("SmmQuotationDocumentTitleEntity Details", group =>
            {
                DocumentTitle = group.Add(new VocabularyKey(nameof(DocumentTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DocumentTitle { get; private set; }
    }
}