using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPremiumEarningCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollPremiumEarningCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPremiumEarningCodeEntity";
            KeyPrefix = "commonDataModel.payrollpremiumearningcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollPremiumEarningCodeEntity";

            AddGroup("Common Data Model PayrollPremiumEarningCodeEntity Details", group =>
            {
                CalculationFrequency = group.Add(new VocabularyKey(nameof(CalculationFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayoutBasis = group.Add(new VocabularyKey(nameof(PayoutBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumEarningCode = group.Add(new VocabularyKey(nameof(PremiumEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationFrequencyId = group.Add(new VocabularyKey(nameof(CalculationFrequencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleTypeId = group.Add(new VocabularyKey(nameof(PolicyRuleTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyTypeId = group.Add(new VocabularyKey(nameof(PolicyTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CalculationFrequency { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey PayoutBasis { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PremiumEarningCode { get; private set; }
        public VocabularyKey CalculationFrequencyId { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey PolicyRuleTypeId { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey PolicyTypeId { get; private set; }


    }
}