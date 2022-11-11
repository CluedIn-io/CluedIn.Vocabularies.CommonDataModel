using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerGarnishmentRuleEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerGarnishmentRuleEntityVocabulary()
        {
            VocabularyName = "PayrollWorkerGarnishmentRuleEntity";
            KeyPrefix = "commonDataModel.payrollworkergarnishmentruleentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerGarnishmentRuleEntity";

            AddGroup("PayrollWorkerGarnishmentRuleEntity Details", group =>
            {
                GarnishmentTaxLevyType = group.Add(new VocabularyKey(nameof(GarnishmentTaxLevyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitMethod = group.Add(new VocabularyKey(nameof(LimitMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposableIncome = group.Add(new VocabularyKey(nameof(DisposableIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposableIncomeName = group.Add(new VocabularyKey(nameof(DisposableIncomeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposableEarningsPercent = group.Add(new VocabularyKey(nameof(DisposableEarningsPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternateLimit = group.Add(new VocabularyKey(nameof(AlternateLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultipleMethod = group.Add(new VocabularyKey(nameof(MultipleMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposableIncomeExemption = group.Add(new VocabularyKey(nameof(DisposableIncomeExemption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExemptEarningAmount = group.Add(new VocabularyKey(nameof(ExemptEarningAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWage = group.Add(new VocabularyKey(nameof(MinimumWage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWageMultiplier = group.Add(new VocabularyKey(nameof(MinimumWageMultiplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowReduction = group.Add(new VocabularyKey(nameof(AllowReduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GarnishmentTaxLevyType { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey LimitMethod { get; private set; }
        public VocabularyKey DisposableIncome { get; private set; }
        public VocabularyKey DisposableIncomeName { get; private set; }
        public VocabularyKey DisposableEarningsPercent { get; private set; }
        public VocabularyKey AlternateLimit { get; private set; }
        public VocabularyKey MultipleMethod { get; private set; }
        public VocabularyKey DisposableIncomeExemption { get; private set; }
        public VocabularyKey ExemptEarningAmount { get; private set; }
        public VocabularyKey MinimumWage { get; private set; }
        public VocabularyKey MinimumWageMultiplier { get; private set; }
        public VocabularyKey AllowReduction { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}