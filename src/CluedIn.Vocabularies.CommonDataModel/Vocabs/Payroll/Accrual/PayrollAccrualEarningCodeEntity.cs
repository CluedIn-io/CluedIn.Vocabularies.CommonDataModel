using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollAccrualEarningCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollAccrualEarningCodeEntityVocabulary()
        {
            VocabularyName = "Payroll Accrual Earning Code Entity";
            KeyPrefix = "commonDataModel.payrollaccrualearningcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollAccrualEarningCodeEntity";

            AddGroup("PayrollAccrualEarningCodeEntity Details", group =>
            {
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Accrual { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
    }
}