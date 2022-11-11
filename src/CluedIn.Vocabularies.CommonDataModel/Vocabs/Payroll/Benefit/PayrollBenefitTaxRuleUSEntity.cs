using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitTaxRuleUSEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitTaxRuleUSEntityVocabulary()
        {
            VocabularyName = "PayrollBenefitTaxRuleUSEntity";
            KeyPrefix = "commonDataModel.payrollbenefittaxruleusentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitTaxRuleUSEntity";

            AddGroup("PayrollBenefitTaxRuleUSEntity Details", group =>
            {
                BenefitPlan = group.Add(new VocabularyKey(nameof(BenefitPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomPretaxMethod = group.Add(new VocabularyKey(nameof(CustomPretaxMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromFederalIncomeTax = group.Add(new VocabularyKey(nameof(IsExemptFromFederalIncomeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromFICA = group.Add(new VocabularyKey(nameof(IsExemptFromFICA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromLocalIncomeTax = group.Add(new VocabularyKey(nameof(IsExemptFromLocalIncomeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromMedicare = group.Add(new VocabularyKey(nameof(IsExemptFromMedicare), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromStateDisabilityInsurance = group.Add(new VocabularyKey(nameof(IsExemptFromStateDisabilityInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromStateIncomeTax = group.Add(new VocabularyKey(nameof(IsExemptFromStateIncomeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExemptFromStateUnemployment = group.Add(new VocabularyKey(nameof(IsExemptFromStateUnemployment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreTaxBasis = group.Add(new VocabularyKey(nameof(PreTaxBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlanID = group.Add(new VocabularyKey(nameof(BenefitPlanID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BenefitPlan { get; private set; }
        public VocabularyKey CustomPretaxMethod { get; private set; }
        public VocabularyKey IsExemptFromFederalIncomeTax { get; private set; }
        public VocabularyKey IsExemptFromFICA { get; private set; }
        public VocabularyKey IsExemptFromLocalIncomeTax { get; private set; }
        public VocabularyKey IsExemptFromMedicare { get; private set; }
        public VocabularyKey IsExemptFromStateDisabilityInsurance { get; private set; }
        public VocabularyKey IsExemptFromStateIncomeTax { get; private set; }
        public VocabularyKey IsExemptFromStateUnemployment { get; private set; }
        public VocabularyKey PreTaxBasis { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey BenefitPlanID { get; private set; }
        public VocabularyKey TaxGroupId { get; private set; }


    }
}