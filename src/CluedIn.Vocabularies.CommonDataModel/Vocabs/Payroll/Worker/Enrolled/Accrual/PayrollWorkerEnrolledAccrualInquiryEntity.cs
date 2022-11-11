using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerEnrolledAccrualInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerEnrolledAccrualInquiryEntityVocabulary()
        {
            VocabularyName = "PayrollWorkerEnrolledAccrualInquiryEntity";
            KeyPrefix = "commonDataModel.payrollworkerenrolledaccrualinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerEnrolledAccrualInquiryEntity";

            AddGroup("PayrollWorkerEnrolledAccrualInquiryEntity Details", group =>
            {
                WorkerName = group.Add(new VocabularyKey(nameof(WorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualYearStartDate = group.Add(new VocabularyKey(nameof(AccrualYearStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCarryOver = group.Add(new VocabularyKey(nameof(TotalCarryOver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAccrued = group.Add(new VocabularyKey(nameof(TotalAccrued), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalUsed = group.Add(new VocabularyKey(nameof(TotalUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPendingUsage = group.Add(new VocabularyKey(nameof(TotalPendingUsage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAvailableHours = group.Add(new VocabularyKey(nameof(TotalAvailableHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkerName { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
        public VocabularyKey AccrualYearStartDate { get; private set; }
        public VocabularyKey TotalCarryOver { get; private set; }
        public VocabularyKey TotalAccrued { get; private set; }
        public VocabularyKey TotalUsed { get; private set; }
        public VocabularyKey TotalPendingUsage { get; private set; }
        public VocabularyKey TotalAvailableHours { get; private set; }
        public VocabularyKey Accrual { get; private set; }
        public VocabularyKey Worker { get; private set; }


    }
}