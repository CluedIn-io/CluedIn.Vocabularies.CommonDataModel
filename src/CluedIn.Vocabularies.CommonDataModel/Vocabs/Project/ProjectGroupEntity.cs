using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectGroupEntityVocabulary : SimpleVocabulary
    {
        public ProjectGroupEntityVocabulary()
        {
            VocabularyName = "Project Group Entity";
            KeyPrefix = "commonDataModel.projectgroupentity";
            KeySeparator = ".";
            Grouping = "/ProjectGroupEntity";

            AddGroup("ProjectGroupEntity Details", group =>
            {
                AccruedLossCategoryId = group.Add(new VocabularyKey(nameof(AccruedLossCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanVerifyCostAgainstRemainingForecast = group.Add(new VocabularyKey(nameof(CanVerifyCostAgainstRemainingForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueRecognitionAccountingRule = group.Add(new VocabularyKey(nameof(RevenueRecognitionAccountingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostTemplate = group.Add(new VocabularyKey(nameof(CostTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCostsExpense = group.Add(new VocabularyKey(nameof(PostCostsExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenueExpense = group.Add(new VocabularyKey(nameof(AccrueRevenueExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCostsHour = group.Add(new VocabularyKey(nameof(PostCostsHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenueHour = group.Add(new VocabularyKey(nameof(AccrueRevenueHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreForeseeableLosses = group.Add(new VocabularyKey(nameof(AreForeseeableLosses), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccountInvoicing = group.Add(new VocabularyKey(nameof(OnAccountInvoicing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCostsItem = group.Add(new VocabularyKey(nameof(PostCostsItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenueItem = group.Add(new VocabularyKey(nameof(AccrueRevenueItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingSearchPriority = group.Add(new VocabularyKey(nameof(LedgerPostingSearchPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPrinciple = group.Add(new VocabularyKey(nameof(MatchingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodCode = group.Add(new VocabularyKey(nameof(PeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionCategoryId = group.Add(new VocabularyKey(nameof(ProductionCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitCategoryId = group.Add(new VocabularyKey(nameof(ProfitCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectGroup = group.Add(new VocabularyKey(nameof(ProjectGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePropertySearchPriority = group.Add(new VocabularyKey(nameof(LinePropertySearchPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectType = group.Add(new VocabularyKey(nameof(ProjectType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenueFee = group.Add(new VocabularyKey(nameof(AccrueRevenueFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationMethod = group.Add(new VocabularyKey(nameof(CalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesValueCategoryId = group.Add(new VocabularyKey(nameof(SalesValueCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccruedLossCategoryId { get; private set; }
        public VocabularyKey CanVerifyCostAgainstRemainingForecast { get; private set; }
        public VocabularyKey RevenueRecognitionAccountingRule { get; private set; }
        public VocabularyKey CostTemplate { get; private set; }
        public VocabularyKey PostCostsExpense { get; private set; }
        public VocabularyKey AccrueRevenueExpense { get; private set; }
        public VocabularyKey PostCostsHour { get; private set; }
        public VocabularyKey AccrueRevenueHour { get; private set; }
        public VocabularyKey AreForeseeableLosses { get; private set; }
        public VocabularyKey OnAccountInvoicing { get; private set; }
        public VocabularyKey PostCostsItem { get; private set; }
        public VocabularyKey AccrueRevenueItem { get; private set; }
        public VocabularyKey LedgerPostingSearchPriority { get; private set; }
        public VocabularyKey MatchingPrinciple { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodCode { get; private set; }
        public VocabularyKey ProductionCategoryId { get; private set; }
        public VocabularyKey ProfitCategoryId { get; private set; }
        public VocabularyKey ProjectGroup { get; private set; }
        public VocabularyKey LinePropertySearchPriority { get; private set; }
        public VocabularyKey ProjectType { get; private set; }
        public VocabularyKey AccrueRevenueFee { get; private set; }
        public VocabularyKey CalculationMethod { get; private set; }
        public VocabularyKey SalesValueCategoryId { get; private set; }
    }
}