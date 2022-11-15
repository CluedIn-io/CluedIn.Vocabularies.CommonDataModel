using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerEnrolledBenefitLimitEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerEnrolledBenefitLimitEntityVocabulary()
        {
            VocabularyName = "Payroll Worker Enrolled Benefit Limit Entity";
            KeyPrefix = "commonDataModel.payrollworkerenrolledbenefitlimitentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerEnrolledBenefitLimitEntity";

            AddGroup("PayrollWorkerEnrolledBenefitLimitEntity Details", group =>
            {
                ContributionLimitAmount = group.Add(new VocabularyKey(nameof(ContributionLimitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionLimitEndDate = group.Add(new VocabularyKey(nameof(ContributionLimitEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionLimitPeriod = group.Add(new VocabularyKey(nameof(ContributionLimitPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionLimitPeriodRemaining = group.Add(new VocabularyKey(nameof(ContributionLimitPeriodRemaining), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionLimitAmount = group.Add(new VocabularyKey(nameof(DeductionLimitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionLimitEndDate = group.Add(new VocabularyKey(nameof(DeductionLimitEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionLimitPeriod = group.Add(new VocabularyKey(nameof(DeductionLimitPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionLimitPeriodRemaining = group.Add(new VocabularyKey(nameof(DeductionLimitPeriodRemaining), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledBenefit = group.Add(new VocabularyKey(nameof(WorkerEnrolledBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentStart = group.Add(new VocabularyKey(nameof(EnrollmentStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentEnd = group.Add(new VocabularyKey(nameof(EnrollmentEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrolledBenefitWorker = group.Add(new VocabularyKey(nameof(EnrolledBenefitWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContributionLimitAmount { get; private set; }
        public VocabularyKey ContributionLimitEndDate { get; private set; }
        public VocabularyKey ContributionLimitPeriod { get; private set; }
        public VocabularyKey ContributionLimitPeriodRemaining { get; private set; }
        public VocabularyKey DeductionLimitAmount { get; private set; }
        public VocabularyKey DeductionLimitEndDate { get; private set; }
        public VocabularyKey DeductionLimitPeriod { get; private set; }
        public VocabularyKey DeductionLimitPeriodRemaining { get; private set; }
        public VocabularyKey WorkerEnrolledBenefit { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey EnrollmentStart { get; private set; }
        public VocabularyKey EnrollmentEnd { get; private set; }
        public VocabularyKey EnrolledBenefitWorker { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
    }
}