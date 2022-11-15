using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerEnrolledAccrualEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerEnrolledAccrualEntityVocabulary()
        {
            VocabularyName = "Payroll Worker Enrolled Accrual Entity";
            KeyPrefix = "commonDataModel.payrollworkerenrolledaccrualentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerEnrolledAccrualEntity";

            AddGroup("PayrollWorkerEnrolledAccrualEntity Details", group =>
            {
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualDateBasis = group.Add(new VocabularyKey(nameof(AccrualDateBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualYearStartDate = group.Add(new VocabularyKey(nameof(AccrualYearStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAccrualStopped = group.Add(new VocabularyKey(nameof(IsAccrualStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUsageStopped = group.Add(new VocabularyKey(nameof(IsUsageStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomAccuralDate = group.Add(new VocabularyKey(nameof(CustomAccuralDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Accrual { get; private set; }
        public VocabularyKey AccrualDateBasis { get; private set; }
        public VocabularyKey AccrualYearStartDate { get; private set; }
        public VocabularyKey IsAccrualStopped { get; private set; }
        public VocabularyKey IsUsageStopped { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey CustomAccuralDate { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey AccrualId { get; private set; }
    }
}