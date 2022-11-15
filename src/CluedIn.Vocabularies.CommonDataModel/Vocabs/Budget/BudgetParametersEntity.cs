using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetParametersEntityVocabulary : SimpleVocabulary
    {
        public BudgetParametersEntityVocabulary()
        {
            VocabularyName = "Budget Parameters Entity";
            KeyPrefix = "commonDataModel.budgetparametersentity";
            KeySeparator = ".";
            Grouping = "/BudgetParametersEntity";

            AddGroup("BudgetParametersEntity Details", group =>
            {
                AllocationKey = group.Add(new VocabularyKey(nameof(AllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetJournal = group.Add(new VocabularyKey(nameof(BudgetJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckRevenueBudgetForZeroBudgetBalances = group.Add(new VocabularyKey(nameof(CheckRevenueBudgetForZeroBudgetBalances), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCompleteRegisterEntriesOnTransferFromDemandForecast = group.Add(new VocabularyKey(nameof(DoCompleteRegisterEntriesOnTransferFromDemandForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCompleteRegisterEntriesOnTransferFromFixedAssets = group.Add(new VocabularyKey(nameof(DoCompleteRegisterEntriesOnTransferFromFixedAssets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCompleteRegisterEntriesOnTransferFromProject = group.Add(new VocabularyKey(nameof(DoCompleteRegisterEntriesOnTransferFromProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCompleteRegisterEntriesOnTransferFromSupplyForecast = group.Add(new VocabularyKey(nameof(DoCompleteRegisterEntriesOnTransferFromSupplyForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimePeriodForBudgetBalances = group.Add(new VocabularyKey(nameof(TimePeriodForBudgetBalances), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseFrenchPublicSectorAccountingRules = group.Add(new VocabularyKey(nameof(UseFrenchPublicSectorAccountingRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseRulesForBudgetTransfers = group.Add(new VocabularyKey(nameof(UseRulesForBudgetTransfers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseGeneralBudgetReservationPublicSectorAccountingRules = group.Add(new VocabularyKey(nameof(UseGeneralBudgetReservationPublicSectorAccountingRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU = group.Add(new VocabularyKey(nameof(DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AllocationKey { get; private set; }
        public VocabularyKey BudgetJournal { get; private set; }
        public VocabularyKey CheckRevenueBudgetForZeroBudgetBalances { get; private set; }
        public VocabularyKey DoCompleteRegisterEntriesOnTransferFromDemandForecast { get; private set; }
        public VocabularyKey DoCompleteRegisterEntriesOnTransferFromFixedAssets { get; private set; }
        public VocabularyKey DoCompleteRegisterEntriesOnTransferFromProject { get; private set; }
        public VocabularyKey DoCompleteRegisterEntriesOnTransferFromSupplyForecast { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey TimePeriodForBudgetBalances { get; private set; }
        public VocabularyKey UseFrenchPublicSectorAccountingRules { get; private set; }
        public VocabularyKey UseRulesForBudgetTransfers { get; private set; }
        public VocabularyKey UseGeneralBudgetReservationPublicSectorAccountingRules { get; private set; }
        public VocabularyKey DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU { get; private set; }
    }
}