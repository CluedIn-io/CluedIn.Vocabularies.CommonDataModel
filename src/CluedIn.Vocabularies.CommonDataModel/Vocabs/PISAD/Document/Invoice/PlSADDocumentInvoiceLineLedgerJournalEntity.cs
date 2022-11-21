using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentInvoiceLineLedgerJournalEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentInvoiceLineLedgerJournalEntityVocabulary()
        {
            VocabularyName = "Pl SAD Document Invoice Line Ledger Journal Entity";
            KeyPrefix = "commonDataModel.plsaddocumentinvoicelineledgerjournalentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentInvoiceLineLedgerJournalEntity";

            AddGroup("PlSADDocumentInvoiceLineLedgerJournalEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADDate = group.Add(new VocabularyKey(nameof(SADDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCommodityCode = group.Add(new VocabularyKey(nameof(ItemCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADNumber = group.Add(new VocabularyKey(nameof(SADNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
        public VocabularyKey SADDate { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ItemCommodityCode { get; private set; }
        public VocabularyKey SADNumber { get; private set; }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey RecordId { get; private set; }
    }
}