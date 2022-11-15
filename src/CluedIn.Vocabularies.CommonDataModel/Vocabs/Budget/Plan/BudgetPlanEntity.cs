using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanEntityVocabulary()
        {
            VocabularyName = "Budget Plan Entity";
            KeyPrefix = "commonDataModel.budgetplanentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanEntity";

            AddGroup("BudgetPlanEntity Details", group =>
            {
                BudgetClass = group.Add(new VocabularyKey(nameof(BudgetClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanHeader = group.Add(new VocabularyKey(nameof(BudgetPlanHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanScenario = group.Add(new VocabularyKey(nameof(BudgetPlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimateType = group.Add(new VocabularyKey(nameof(EstimateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNewRequest = group.Add(new VocabularyKey(nameof(IsNewRequest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRecurring = group.Add(new VocabularyKey(nameof(IsRecurring), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineReferenceId = group.Add(new VocabularyKey(nameof(LineReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyAmount = group.Add(new VocabularyKey(nameof(ReportingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionUnitPrice = group.Add(new VocabularyKey(nameof(TransactionUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedAssetId = group.Add(new VocabularyKey(nameof(ProposedAssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedProjectId = group.Add(new VocabularyKey(nameof(ProposedProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataAreaId = group.Add(new VocabularyKey(nameof(SourceDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPosition = group.Add(new VocabularyKey(nameof(ForecastPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetingOrganization = group.Add(new VocabularyKey(nameof(BudgetingOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanPreparer = group.Add(new VocabularyKey(nameof(BudgetPlanPreparer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanPriority = group.Add(new VocabularyKey(nameof(BudgetPlanPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHistorical = group.Add(new VocabularyKey(nameof(IsHistorical), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentBudgetPlanHeader = group.Add(new VocabularyKey(nameof(ParentBudgetPlanHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroup = group.Add(new VocabularyKey(nameof(UserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rank = group.Add(new VocabularyKey(nameof(Rank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanLayout = group.Add(new VocabularyKey(nameof(BudgetPlanLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibilityCenterPartyNumber = group.Add(new VocabularyKey(nameof(ResponsibilityCenterPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stage = group.Add(new VocabularyKey(nameof(Stage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerPersonnelNumber = group.Add(new VocabularyKey(nameof(PreparerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentBudgetPlan = group.Add(new VocabularyKey(nameof(ParentBudgetPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scenario = group.Add(new VocabularyKey(nameof(Scenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedAsset = group.Add(new VocabularyKey(nameof(ProposedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedProject = group.Add(new VocabularyKey(nameof(ProposedProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetingOrganizationName = group.Add(new VocabularyKey(nameof(BudgetingOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelName = group.Add(new VocabularyKey(nameof(PersonnelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountAccountStructure = group.Add(new VocabularyKey(nameof(LedgerAccountAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BudgetClass { get; private set; }
        public VocabularyKey BudgetPlanHeader { get; private set; }
        public VocabularyKey BudgetPlanScenario { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey EstimateType { get; private set; }
        public VocabularyKey IsNewRequest { get; private set; }
        public VocabularyKey IsRecurring { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey LineReferenceId { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey ReportingCurrencyAmount { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey TransactionUnitPrice { get; private set; }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey ProposedAssetId { get; private set; }
        public VocabularyKey ProposedProjectId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey SourceDataAreaId { get; private set; }
        public VocabularyKey ForecastPosition { get; private set; }
        public VocabularyKey BudgetingOrganization { get; private set; }
        public VocabularyKey BudgetPlanningProcess { get; private set; }
        public VocabularyKey BudgetPlanningStage { get; private set; }
        public VocabularyKey BudgetPlanPreparer { get; private set; }
        public VocabularyKey BudgetPlanPriority { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey DocumentStatus { get; private set; }
        public VocabularyKey IsHistorical { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParentBudgetPlanHeader { get; private set; }
        public VocabularyKey UserGroup { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey WorkflowStatus { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey BudgetPlanLayout { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey ResponsibilityCenterPartyNumber { get; private set; }
        public VocabularyKey Process { get; private set; }
        public VocabularyKey Stage { get; private set; }
        public VocabularyKey PreparerPersonnelNumber { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey ParentBudgetPlan { get; private set; }
        public VocabularyKey Layout { get; private set; }
        public VocabularyKey Scenario { get; private set; }
        public VocabularyKey ProposedAsset { get; private set; }
        public VocabularyKey ProposedProject { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey BudgetingOrganizationName { get; private set; }
        public VocabularyKey PersonnelName { get; private set; }
        public VocabularyKey LedgerAccountAccountStructure { get; private set; }
    }
}