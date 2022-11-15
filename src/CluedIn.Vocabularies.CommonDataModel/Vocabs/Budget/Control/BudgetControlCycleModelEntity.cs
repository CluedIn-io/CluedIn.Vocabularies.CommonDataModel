using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlCycleModelEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlCycleModelEntityVocabulary()
        {
            VocabularyName = "Budget Control Cycle Model Entity";
            KeyPrefix = "commonDataModel.budgetcontrolcyclemodelentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlCycleModelEntity";

            AddGroup("BudgetControlCycleModelEntity Details", group =>
            {
                BudgetModelId = group.Add(new VocabularyKey(nameof(BudgetModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlConfiguration = group.Add(new VocabularyKey(nameof(BudgetControlConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCycle = group.Add(new VocabularyKey(nameof(BudgetCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCycleTimeSpanName = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCycleName = group.Add(new VocabularyKey(nameof(BudgetCycleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCycleTimeSpanFiscalCalendarId = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanFiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetModelType = group.Add(new VocabularyKey(nameof(BudgetModelType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetModelSubModelId = group.Add(new VocabularyKey(nameof(BudgetModelSubModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetModelDataAreaId = group.Add(new VocabularyKey(nameof(BudgetModelDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BudgetModelId { get; private set; }
        public VocabularyKey BudgetControlConfiguration { get; private set; }
        public VocabularyKey BudgetCycle { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey BudgetCycleTimeSpanName { get; private set; }
        public VocabularyKey BudgetCycleName { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey BudgetCycleTimeSpanFiscalCalendarId { get; private set; }
        public VocabularyKey BudgetModelType { get; private set; }
        public VocabularyKey BudgetModelSubModelId { get; private set; }
        public VocabularyKey BudgetModelDataAreaId { get; private set; }
    }
}