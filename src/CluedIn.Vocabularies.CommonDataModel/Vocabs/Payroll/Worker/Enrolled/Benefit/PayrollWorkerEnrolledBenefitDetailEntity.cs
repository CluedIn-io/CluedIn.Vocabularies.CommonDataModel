using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerEnrolledBenefitDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerEnrolledBenefitDetailEntityVocabulary()
        {
            VocabularyName = "Payroll Worker Enrolled Benefit Detail Entity";
            KeyPrefix = "commonDataModel.payrollworkerenrolledbenefitdetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerEnrolledBenefitDetailEntity";

            AddGroup("PayrollWorkerEnrolledBenefitDetailEntity Details", group =>
            {
                CalculationPriorityNumber = group.Add(new VocabularyKey(nameof(CalculationPriorityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionAmountCur = group.Add(new VocabularyKey(nameof(ContributionAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionBasis = group.Add(new VocabularyKey(nameof(ContributionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionRateSource = group.Add(new VocabularyKey(nameof(ContributionRateSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionAmountCur = group.Add(new VocabularyKey(nameof(DeductionAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionBasis = group.Add(new VocabularyKey(nameof(DeductionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionPriorityNumber = group.Add(new VocabularyKey(nameof(DeductionPriorityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionRateSource = group.Add(new VocabularyKey(nameof(DeductionRateSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRetirementCatchUp = group.Add(new VocabularyKey(nameof(IsRetirementCatchUp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideLimit = group.Add(new VocabularyKey(nameof(OverrideLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitDetailValidFrom = group.Add(new VocabularyKey(nameof(BenefitDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitDetailValidTo = group.Add(new VocabularyKey(nameof(BenefitDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledBenefit = group.Add(new VocabularyKey(nameof(WorkerEnrolledBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentStart = group.Add(new VocabularyKey(nameof(EnrollmentStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentEnd = group.Add(new VocabularyKey(nameof(EnrollmentEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendDataAreaId = group.Add(new VocabularyKey(nameof(VendDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAccountNum = group.Add(new VocabularyKey(nameof(VendAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalculationPriorityNumber { get; private set; }
        public VocabularyKey ContributionAmountCur { get; private set; }
        public VocabularyKey ContributionBasis { get; private set; }
        public VocabularyKey ContributionRateSource { get; private set; }
        public VocabularyKey DeductionAmountCur { get; private set; }
        public VocabularyKey DeductionBasis { get; private set; }
        public VocabularyKey DeductionPriorityNumber { get; private set; }
        public VocabularyKey DeductionRateSource { get; private set; }
        public VocabularyKey IsRetirementCatchUp { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey OverrideLimit { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey BenefitDetailValidFrom { get; private set; }
        public VocabularyKey BenefitDetailValidTo { get; private set; }
        public VocabularyKey WorkerEnrolledBenefit { get; private set; }
        public VocabularyKey DataArea { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey EnrollmentStart { get; private set; }
        public VocabularyKey EnrollmentEnd { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey VendDataAreaId { get; private set; }
        public VocabularyKey VendAccountNum { get; private set; }
    }
}