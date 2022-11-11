using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetRegisterEntryHeaderEntityVocabulary : SimpleVocabulary
    {
        public BudgetRegisterEntryHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetRegisterEntryHeaderEntity";
            KeyPrefix = "commonDataModel.budgetregisterentryheaderentity";
            KeySeparator = ".";
            Grouping = "/BudgetRegisterEntryHeaderEntity";

            AddGroup("Common Data Model BudgetRegisterEntryHeaderEntity Details", group =>
            {
                BudgetCode = group.Add(new VocabularyKey(nameof(BudgetCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetModelId = group.Add(new VocabularyKey(nameof(BudgetModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetTransactionCode = group.Add(new VocabularyKey(nameof(BudgetTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDate = group.Add(new VocabularyKey(nameof(DefaultDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryNumber = group.Add(new VocabularyKey(nameof(EntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneTimeRevision = group.Add(new VocabularyKey(nameof(OneTimeRevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLedgerId = group.Add(new VocabularyKey(nameof(PrimaryLedgerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonTableRef = group.Add(new VocabularyKey(nameof(ReasonTableRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDocument = group.Add(new VocabularyKey(nameof(SourceDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseBudgetTotal = group.Add(new VocabularyKey(nameof(ExpenseBudgetTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueBudgetTotal = group.Add(new VocabularyKey(nameof(RevenueBudgetTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetCode { get; private set; }
        public VocabularyKey BudgetModelId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey BudgetTransactionCode { get; private set; }
        public VocabularyKey BudgetType { get; private set; }
        public VocabularyKey DefaultDate { get; private set; }
        public VocabularyKey EntryNumber { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey OneTimeRevision { get; private set; }
        public VocabularyKey PrimaryLedgerId { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonComment { get; private set; }
        public VocabularyKey ReasonTableRef { get; private set; }
        public VocabularyKey SourceDocument { get; private set; }
        public VocabularyKey WorkflowStatus { get; private set; }
        public VocabularyKey ExpenseBudgetTotal { get; private set; }
        public VocabularyKey RevenueBudgetTotal { get; private set; }


    }
}