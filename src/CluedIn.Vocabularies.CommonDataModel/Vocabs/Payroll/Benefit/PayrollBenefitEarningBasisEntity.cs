using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitEarningBasisEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitEarningBasisEntityVocabulary()
        {
            VocabularyName = "Payroll Benefit Earning Basis Entity";
            KeyPrefix = "commonDataModel.payrollbenefitearningbasisentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitEarningBasisEntity";

            AddGroup("PayrollBenefitEarningBasisEntity Details", group =>
            {
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitOption = group.Add(new VocabularyKey(nameof(BenefitOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlan = group.Add(new VocabularyKey(nameof(BenefitPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitOptionId = group.Add(new VocabularyKey(nameof(BenefitOptionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlanId = group.Add(new VocabularyKey(nameof(BenefitPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey BenefitOption { get; private set; }
        public VocabularyKey BenefitPlan { get; private set; }
        public VocabularyKey Effective { get; private set; }
        public VocabularyKey Expiration { get; private set; }
        public VocabularyKey BenefitOptionId { get; private set; }
        public VocabularyKey BenefitPlanId { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
    }
}