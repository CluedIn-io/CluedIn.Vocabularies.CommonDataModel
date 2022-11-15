using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxIntgrExportDocumentConfirmEnityVocabulary : SimpleVocabulary
    {
        public TaxIntgrExportDocumentConfirmEnityVocabulary()
        {
            VocabularyName = "Tax Intgr Export Document Confirm Enity";
            KeyPrefix = "commonDataModel.taxintgrexportdocumentconfirmenity";
            KeySeparator = ".";
            Grouping = "/TaxIntgrExportDocumentConfirmEnity";

            AddGroup("TaxIntgrExportDocumentConfirmEnity Details", group =>
            {
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchName = group.Add(new VocabularyKey(nameof(BatchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExternalInvoiceId { get; private set; }
        public VocabularyKey BatchName { get; private set; }
        public VocabularyKey Position { get; private set; }
    }
}