using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollDeductionArrearRecoveryEntityVocabulary : SimpleVocabulary
    {
        public PayrollDeductionArrearRecoveryEntityVocabulary()
        {
            VocabularyName = "PayrollDeductionArrearRecoveryEntity";
            KeyPrefix = "commonDataModel.payrolldeductionarrearrecoveryentity";
            KeySeparator = ".";
            Grouping = "/PayrollDeductionArrearRecoveryEntity";

            AddGroup("PayrollDeductionArrearRecoveryEntity Details", group =>
            {
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrearsTransaction = group.Add(new VocabularyKey(nameof(ArrearsTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrearsChangeType = group.Add(new VocabularyKey(nameof(ArrearsChangeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoveryCreatedBy = group.Add(new VocabularyKey(nameof(RecoveryCreatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoveryCreatedDateTime = group.Add(new VocabularyKey(nameof(RecoveryCreatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey ArrearsTransaction { get; private set; }
        public VocabularyKey ArrearsChangeType { get; private set; }
        public VocabularyKey PayStatement { get; private set; }
        public VocabularyKey RecoveryCreatedBy { get; private set; }
        public VocabularyKey RecoveryCreatedDateTime { get; private set; }
        public VocabularyKey BenefitId { get; private set; }


    }
}