using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCustomsImportInvoiceNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxCustomsImportInvoiceNumberEntityVocabulary()
        {
            VocabularyName = "Tax Customs Import Invoice Number Entity";
            KeyPrefix = "commonDataModel.taxcustomsimportinvoicenumberentity";
            KeySeparator = ".";
            Grouping = "/TaxCustomsImportInvoiceNumberEntity";

            AddGroup("TaxCustomsImportInvoiceNumberEntity Details", group =>
            {
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImporterInvoiceNumber = group.Add(new VocabularyKey(nameof(ImporterInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Closed { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey ImporterInvoiceNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}