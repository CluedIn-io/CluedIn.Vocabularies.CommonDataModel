using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentInvoiceLedgerJournalEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentInvoiceLedgerJournalEntityVocabulary()
        {
            VocabularyName = "Common Data Model PlSADDocumentInvoiceLedgerJournalEntity";
            KeyPrefix = "commonDataModel.plsaddocumentinvoiceledgerjournalentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentInvoiceLedgerJournalEntity";

            AddGroup("Common Data Model PlSADDocumentInvoiceLedgerJournalEntity Details", group =>
            {
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADDate = group.Add(new VocabularyKey(nameof(SADDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADNumber = group.Add(new VocabularyKey(nameof(SADNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey SADDate { get; private set; }
        public VocabularyKey SADNumber { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }


    }
}