using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitAccountingRuleEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitAccountingRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBenefitAccountingRuleEntity";
            KeyPrefix = "commonDataModel.payrollbenefitaccountingruleentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitAccountingRuleEntity";

            AddGroup("Common Data Model PayrollBenefitAccountingRuleEntity Details", group =>
            {
                Plan = group.Add(new VocabularyKey(nameof(Plan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollType = group.Add(new VocabularyKey(nameof(PayrollType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Plan { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey PayrollType { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey PlanId { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}