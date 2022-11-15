using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerAccrualAdjustmentEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerAccrualAdjustmentEntityVocabulary()
        {
            VocabularyName = "Payroll Worker Accrual Adjustment Entity";
            KeyPrefix = "commonDataModel.payrollworkeraccrualadjustmententity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerAccrualAdjustmentEntity";

            AddGroup("PayrollWorkerAccrualAdjustmentEntity Details", group =>
            {
                AdjustedHours = group.Add(new VocabularyKey(nameof(AdjustedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentType = group.Add(new VocabularyKey(nameof(AdjustmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledAccrual = group.Add(new VocabularyKey(nameof(WorkerEnrolledAccrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledAccrualId = group.Add(new VocabularyKey(nameof(WorkerEnrolledAccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrolledAccrualLegalEntityId = group.Add(new VocabularyKey(nameof(EnrolledAccrualLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AdjustedHours { get; private set; }
        public VocabularyKey AdjustmentType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey WorkerEnrolledAccrual { get; private set; }
        public VocabularyKey WorkerEnrolledAccrualId { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey EnrolledAccrualLegalEntityId { get; private set; }
    }
}