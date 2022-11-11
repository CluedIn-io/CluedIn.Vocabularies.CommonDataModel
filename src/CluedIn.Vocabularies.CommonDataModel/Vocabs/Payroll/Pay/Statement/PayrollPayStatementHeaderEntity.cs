using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementHeaderEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayStatementHeaderEntity";
            KeyPrefix = "commonDataModel.payrollpaystatementheaderentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementHeaderEntity";

            AddGroup("Common Data Model PayrollPayStatementHeaderEntity Details", group =>
            {
                BatchNumber = group.Add(new VocabularyKey(nameof(BatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossPay = group.Add(new VocabularyKey(nameof(GrossPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementReversed = group.Add(new VocabularyKey(nameof(PayStatementReversed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetPay = group.Add(new VocabularyKey(nameof(NetPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDate = group.Add(new VocabularyKey(nameof(PaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentJournal = group.Add(new VocabularyKey(nameof(PaymentJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisbursementFormat = group.Add(new VocabularyKey(nameof(DisbursementFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementStatus = group.Add(new VocabularyKey(nameof(PayStatementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentRunType = group.Add(new VocabularyKey(nameof(PaymentRunType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayPeriod = group.Add(new VocabularyKey(nameof(PayPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatement = group.Add(new VocabularyKey(nameof(ReversedPayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDocument = group.Add(new VocabularyKey(nameof(SourceDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentInvoice = group.Add(new VocabularyKey(nameof(PaymentInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreationType = group.Add(new VocabularyKey(nameof(CreationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatementNumber = group.Add(new VocabularyKey(nameof(ReversedPayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisableAccounting = group.Add(new VocabularyKey(nameof(DisableAccounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchNumber { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey GrossPay { get; private set; }
        public VocabularyKey PayStatementReversed { get; private set; }
        public VocabularyKey NetPay { get; private set; }
        public VocabularyKey PaymentDate { get; private set; }
        public VocabularyKey PaymentJournal { get; private set; }
        public VocabularyKey DisbursementFormat { get; private set; }
        public VocabularyKey PayStatementStatus { get; private set; }
        public VocabularyKey PaymentRunType { get; private set; }
        public VocabularyKey PayPeriod { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey ReversedPayStatement { get; private set; }
        public VocabularyKey SourceDocument { get; private set; }
        public VocabularyKey PaymentInvoice { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey CreationType { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey ReversedPayStatementNumber { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey DisableAccounting { get; private set; }


    }
}