using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitDetailEntityVocabulary()
        {
            VocabularyName = "Payroll Benefit Detail Entity";
            KeyPrefix = "commonDataModel.payrollbenefitdetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitDetailEntity";

            AddGroup("PayrollBenefitDetailEntity Details", group =>
            {
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionCalculationFrequency = group.Add(new VocabularyKey(nameof(ContributionCalculationFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionCalculationRate = group.Add(new VocabularyKey(nameof(ContributionCalculationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionCalculationFrequency = group.Add(new VocabularyKey(nameof(DeductionCalculationFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultContributionAccountingCurrencyAmt = group.Add(new VocabularyKey(nameof(DefaultContributionAccountingCurrencyAmt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultContributionBasis = group.Add(new VocabularyKey(nameof(DefaultContributionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDeductionAccountingCurrencyAmt = group.Add(new VocabularyKey(nameof(DefaultDeductionAccountingCurrencyAmt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDeductionBasis = group.Add(new VocabularyKey(nameof(DefaultDeductionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionCalculationFrequencyId = group.Add(new VocabularyKey(nameof(ContributionCalculationFrequencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionCalculationRateId = group.Add(new VocabularyKey(nameof(ContributionCalculationRateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionCalculationFrequencyId = group.Add(new VocabularyKey(nameof(DeductionCalculationFrequencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey ContributionCalculationFrequency { get; private set; }
        public VocabularyKey ContributionCalculationRate { get; private set; }
        public VocabularyKey DeductionCalculationFrequency { get; private set; }
        public VocabularyKey DefaultContributionAccountingCurrencyAmt { get; private set; }
        public VocabularyKey DefaultContributionBasis { get; private set; }
        public VocabularyKey DefaultDeductionAccountingCurrencyAmt { get; private set; }
        public VocabularyKey DefaultDeductionBasis { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey ContributionCalculationFrequencyId { get; private set; }
        public VocabularyKey ContributionCalculationRateId { get; private set; }
        public VocabularyKey DeductionCalculationFrequencyId { get; private set; }
    }
}