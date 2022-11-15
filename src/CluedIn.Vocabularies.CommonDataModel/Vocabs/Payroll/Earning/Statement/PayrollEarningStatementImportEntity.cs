using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningStatementImportEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningStatementImportEntityVocabulary()
        {
            VocabularyName = "Payroll Earning Statement Import Entity";
            KeyPrefix = "commonDataModel.payrollearningstatementimportentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningStatementImportEntity";

            AddGroup("PayrollEarningStatementImportEntity Details", group =>
            {
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplate = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningsDate = group.Add(new VocabularyKey(nameof(EarningsDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningRate = group.Add(new VocabularyKey(nameof(EarningRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerationSource = group.Add(new VocabularyKey(nameof(GenerationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineModified = group.Add(new VocabularyKey(nameof(LineModified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsManual = group.Add(new VocabularyKey(nameof(IsManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementEarningLine = group.Add(new VocabularyKey(nameof(PayStatementEarningLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Project = group.Add(new VocabularyKey(nameof(Project), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLineProperty = group.Add(new VocabularyKey(nameof(ProjectLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCompensationBenefit = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralLiabilityInsurance = group.Add(new VocabularyKey(nameof(GeneralLiabilityInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPeriod = group.Add(new VocabularyKey(nameof(WorkPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCompensationBenefitId = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerGeneralLiabilityInsuranceBenefitId = group.Add(new VocabularyKey(nameof(WorkerGeneralLiabilityInsuranceBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegion = group.Add(new VocabularyKey(nameof(WorkerTaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey AccountingDistributionTemplate { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey EarningsDate { get; private set; }
        public VocabularyKey EarningRate { get; private set; }
        public VocabularyKey GenerationSource { get; private set; }
        public VocabularyKey LineModified { get; private set; }
        public VocabularyKey IsManual { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey PayStatementEarningLine { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey Project { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectCategory { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ProjectLineProperty { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey WorkerCompensationBenefit { get; private set; }
        public VocabularyKey GeneralLiabilityInsurance { get; private set; }
        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey WorkPeriod { get; private set; }
        public VocabularyKey WorkerCompensationBenefitId { get; private set; }
        public VocabularyKey WorkerGeneralLiabilityInsuranceBenefitId { get; private set; }
        public VocabularyKey WorkerTaxRegion { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
    }
}