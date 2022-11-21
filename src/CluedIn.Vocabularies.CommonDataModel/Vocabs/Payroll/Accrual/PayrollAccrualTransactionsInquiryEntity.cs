using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollAccrualTransactionsInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollAccrualTransactionsInquiryEntityVocabulary()
        {
            VocabularyName = "Payroll Accrual Transactions Inquiry Entity";
            KeyPrefix = "commonDataModel.payrollaccrualtransactionsinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollAccrualTransactionsInquiryEntity";

            AddGroup("PayrollAccrualTransactionsInquiryEntity Details", group =>
            {
                WorkerName = group.Add(new VocabularyKey(nameof(WorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarryOver = group.Add(new VocabularyKey(nameof(CarryOver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Accrued = group.Add(new VocabularyKey(nameof(Accrued), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Used = group.Add(new VocabularyKey(nameof(Used), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransSource = group.Add(new VocabularyKey(nameof(TransSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedByUserId = group.Add(new VocabularyKey(nameof(CreatedByUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDateTime = group.Add(new VocabularyKey(nameof(CreateDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualTransComments = group.Add(new VocabularyKey(nameof(ManualTransComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WorkerName { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey CarryOver { get; private set; }
        public VocabularyKey Accrued { get; private set; }
        public VocabularyKey Used { get; private set; }
        public VocabularyKey TransSource { get; private set; }
        public VocabularyKey CreatedByUserId { get; private set; }
        public VocabularyKey CreateDateTime { get; private set; }
        public VocabularyKey ManualTransComments { get; private set; }
        public VocabularyKey Accrual { get; private set; }
        public VocabularyKey Worker { get; private set; }
    }
}