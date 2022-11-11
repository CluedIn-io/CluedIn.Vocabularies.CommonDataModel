using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustInvoiceJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public CustInvoiceJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustInvoiceJournalHeaderEntity";
            KeyPrefix = "commonDataModel.custinvoicejournalheaderentity";
            KeySeparator = ".";
            Grouping = "/CustInvoiceJournalHeaderEntity";

            AddGroup("Common Data Model CustInvoiceJournalHeaderEntity Details", group =>
            {
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsPosted { get; private set; }


    }
}