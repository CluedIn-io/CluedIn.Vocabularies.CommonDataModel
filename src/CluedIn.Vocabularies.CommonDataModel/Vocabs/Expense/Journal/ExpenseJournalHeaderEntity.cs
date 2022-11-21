using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExpenseJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public ExpenseJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Expense Journal Header Entity";
            KeyPrefix = "commonDataModel.expensejournalheaderentity";
            KeySeparator = ".";
            Grouping = "/ExpenseJournalHeaderEntity";

            AddGroup("ExpenseJournalHeaderEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityForIntercompanyTax = group.Add(new VocabularyKey(nameof(LegalEntityForIntercompanyTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReversingEntry = group.Add(new VocabularyKey(nameof(IsReversingEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversingDate = group.Add(new VocabularyKey(nameof(ReversingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedAsReadyBy = group.Add(new VocabularyKey(nameof(ReportedAsReadyBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RejectedBy = group.Add(new VocabularyKey(nameof(RejectedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedBy = group.Add(new VocabularyKey(nameof(ApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey LegalEntityForIntercompanyTax { get; private set; }
        public VocabularyKey IsReversingEntry { get; private set; }
        public VocabularyKey ReversingDate { get; private set; }
        public VocabularyKey ReportedAsReadyBy { get; private set; }
        public VocabularyKey RejectedBy { get; private set; }
        public VocabularyKey ApprovedBy { get; private set; }
    }
}