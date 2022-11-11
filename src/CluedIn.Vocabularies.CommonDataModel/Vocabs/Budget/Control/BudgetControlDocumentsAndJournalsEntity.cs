using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlDocumentsAndJournalsEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlDocumentsAndJournalsEntityVocabulary()
        {
            VocabularyName = "BudgetControlDocumentsAndJournalsEntity";
            KeyPrefix = "commonDataModel.budgetcontroldocumentsandjournalsentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlDocumentsAndJournalsEntity";

            AddGroup("BudgetControlDocumentsAndJournalsEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentOrJournal = group.Add(new VocabularyKey(nameof(DocumentOrJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEnabled = group.Add(new VocabularyKey(nameof(IsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoBudgetCheckOnEntry = group.Add(new VocabularyKey(nameof(DoBudgetCheckOnEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey DocumentOrJournal { get; private set; }
        public VocabularyKey IsEnabled { get; private set; }
        public VocabularyKey DoBudgetCheckOnEntry { get; private set; }


    }
}