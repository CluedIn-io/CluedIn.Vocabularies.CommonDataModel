using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementBenefitLineInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementBenefitLineInquiryEntityVocabulary()
        {
            VocabularyName = "Payroll Pay Statement Benefit Line Inquiry Entity";
            KeyPrefix = "commonDataModel.payrollpaystatementbenefitlineinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementBenefitLineInquiryEntity";

            AddGroup("PayrollPayStatementBenefitLineInquiryEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseTimeEarningBaseAmount = group.Add(new VocabularyKey(nameof(BaseTimeEarningBaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseTimeEarningBaseHours = group.Add(new VocabularyKey(nameof(BaseTimeEarningBaseHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumEarningBaseAmount = group.Add(new VocabularyKey(nameof(PremiumEarningBaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumEarningBaseHours = group.Add(new VocabularyKey(nameof(PremiumEarningBaseHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEmployer = group.Add(new VocabularyKey(nameof(IsEmployer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Source = group.Add(new VocabularyKey(nameof(Source), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoice = group.Add(new VocabularyKey(nameof(VendorInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey BaseTimeEarningBaseAmount { get; private set; }
        public VocabularyKey BaseTimeEarningBaseHours { get; private set; }
        public VocabularyKey PremiumEarningBaseAmount { get; private set; }
        public VocabularyKey PremiumEarningBaseHours { get; private set; }
        public VocabularyKey IsEmployer { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey VendorInvoice { get; private set; }
        public VocabularyKey LineNum { get; private set; }
    }
}