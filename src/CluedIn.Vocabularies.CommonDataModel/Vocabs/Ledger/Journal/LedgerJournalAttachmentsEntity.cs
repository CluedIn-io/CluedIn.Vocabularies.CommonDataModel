using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalAttachmentsEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalAttachmentsEntityVocabulary()
        {
            VocabularyName = "LedgerJournalAttachmentsEntity";
            KeyPrefix = "commonDataModel.ledgerjournalattachmentsentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalAttachmentsEntity";

            AddGroup("LedgerJournalAttachmentsEntity Details", group =>
            {
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Restriction = group.Add(new VocabularyKey(nameof(Restriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileContents = group.Add(new VocabularyKey(nameof(FileContents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAttachment = group.Add(new VocabularyKey(nameof(DefaultAttachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey DocumentId { get; private set; }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey Restriction { get; private set; }
        public VocabularyKey FileContents { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FileType { get; private set; }
        public VocabularyKey DefaultAttachment { get; private set; }


    }
}