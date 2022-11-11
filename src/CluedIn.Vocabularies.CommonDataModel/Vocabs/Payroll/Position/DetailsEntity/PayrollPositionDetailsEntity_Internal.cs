using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPositionDetailsEntity_InternalVocabulary : SimpleVocabulary
    {
        public PayrollPositionDetailsEntity_InternalVocabulary()
        {
            VocabularyName = "PayrollPositionDetailsEntity_Internal";
            KeyPrefix = "commonDataModel.payrollpositiondetailsentity_internal";
            KeySeparator = ".";
            Grouping = "/PayrollPositionDetailsEntity_Internal";

            AddGroup("PayrollPositionDetailsEntity_Internal Details", group =>
            {
                IsSalaryGenerated = group.Add(new VocabularyKey(nameof(IsSalaryGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultEarningCode = group.Add(new VocabularyKey(nameof(DefaultEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceBenefit = group.Add(new VocabularyKey(nameof(InsuranceBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreEarningsGeneratedFromSchedule = group.Add(new VocabularyKey(nameof(AreEarningsGeneratedFromSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycle = group.Add(new VocabularyKey(nameof(PayCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnnualRegularHours = group.Add(new VocabularyKey(nameof(AnnualRegularHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayPeriodOvertimeHours = group.Add(new VocabularyKey(nameof(PayPeriodOvertimeHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Positions = group.Add(new VocabularyKey(nameof(Positions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Schedule = group.Add(new VocabularyKey(nameof(Schedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleLegalEntity = group.Add(new VocabularyKey(nameof(ScheduleLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidByLegalEntity = group.Add(new VocabularyKey(nameof(PaidByLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultEarningCodeId = group.Add(new VocabularyKey(nameof(DefaultEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsSalaryGenerated { get; private set; }
        public VocabularyKey DefaultEarningCode { get; private set; }
        public VocabularyKey InsuranceBenefit { get; private set; }
        public VocabularyKey AreEarningsGeneratedFromSchedule { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey PayCycle { get; private set; }
        public VocabularyKey AnnualRegularHours { get; private set; }
        public VocabularyKey PayPeriodOvertimeHours { get; private set; }
        public VocabularyKey Positions { get; private set; }
        public VocabularyKey Schedule { get; private set; }
        public VocabularyKey ScheduleLegalEntity { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey PaidByLegalEntity { get; private set; }
        public VocabularyKey DefaultEarningCodeId { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }
        public VocabularyKey PositionId { get; private set; }


    }
}