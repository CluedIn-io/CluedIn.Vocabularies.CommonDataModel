using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SubledgerJournalTransferRuleEntityVocabulary : SimpleVocabulary
    {
        public SubledgerJournalTransferRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model SubledgerJournalTransferRuleEntity";
            KeyPrefix = "commonDataModel.subledgerjournaltransferruleentity";
            KeySeparator = ".";
            Grouping = "/SubledgerJournalTransferRuleEntity";

            AddGroup("Common Data Model SubledgerJournalTransferRuleEntity Details", group =>
            {
                SummarizeAccountingEntries = group.Add(new VocabularyKey(nameof(SummarizeAccountingEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotificationGroup = group.Add(new VocabularyKey(nameof(NotificationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDocumentType = group.Add(new VocabularyKey(nameof(SourceDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferMode = group.Add(new VocabularyKey(nameof(TransferMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SummarizeAccountingEntries { get; private set; }
        public VocabularyKey Ledger { get; private set; }
        public VocabularyKey NotificationGroup { get; private set; }
        public VocabularyKey SourceDocumentType { get; private set; }
        public VocabularyKey TransferMode { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }


    }
}