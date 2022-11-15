using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollAccrualPlanRuleEntityVocabulary : SimpleVocabulary
    {
        public PayrollAccrualPlanRuleEntityVocabulary()
        {
            VocabularyName = "Payroll Accrual Plan Rule Entity";
            KeyPrefix = "commonDataModel.payrollaccrualplanruleentity";
            KeySeparator = ".";
            Grouping = "/PayrollAccrualPlanRuleEntity";

            AddGroup("PayrollAccrualPlanRuleEntity Details", group =>
            {
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarryForwardLimit = group.Add(new VocabularyKey(nameof(CarryForwardLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentMonths = group.Add(new VocabularyKey(nameof(EmploymentMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourlyRate = group.Add(new VocabularyKey(nameof(HourlyRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLimit = group.Add(new VocabularyKey(nameof(MaximumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumLimit = group.Add(new VocabularyKey(nameof(MinimumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Accrual { get; private set; }
        public VocabularyKey CarryForwardLimit { get; private set; }
        public VocabularyKey EmploymentMonths { get; private set; }
        public VocabularyKey HourlyRate { get; private set; }
        public VocabularyKey MaximumLimit { get; private set; }
        public VocabularyKey MinimumLimit { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
    }
}