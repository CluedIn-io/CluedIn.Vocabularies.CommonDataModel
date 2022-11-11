using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollDeductionArrearEntityVocabulary : SimpleVocabulary
    {
        public PayrollDeductionArrearEntityVocabulary()
        {
            VocabularyName = "PayrollDeductionArrearEntity";
            KeyPrefix = "commonDataModel.payrolldeductionarrearentity";
            KeySeparator = ".";
            Grouping = "/PayrollDeductionArrearEntity";

            AddGroup("PayrollDeductionArrearEntity Details", group =>
            {
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullyRecovered = group.Add(new VocabularyKey(nameof(FullyRecovered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey FullyRecovered { get; private set; }
        public VocabularyKey PayStatement { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }


    }
}