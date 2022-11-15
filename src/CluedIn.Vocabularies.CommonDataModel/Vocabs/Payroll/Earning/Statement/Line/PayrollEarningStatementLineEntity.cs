using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningStatementLineEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningStatementLineEntityVocabulary()
        {
            VocabularyName = "Payroll Earning Statement Line Entity";
            KeyPrefix = "commonDataModel.payrollearningstatementlineentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningStatementLineEntity";

            AddGroup("PayrollEarningStatementLineEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningsDate = group.Add(new VocabularyKey(nameof(EarningsDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningRate = group.Add(new VocabularyKey(nameof(EarningRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningsStatementHeader = group.Add(new VocabularyKey(nameof(EarningsStatementHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerationSource = group.Add(new VocabularyKey(nameof(GenerationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineModified = group.Add(new VocabularyKey(nameof(LineModified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsManual = group.Add(new VocabularyKey(nameof(IsManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementEarningLine = group.Add(new VocabularyKey(nameof(PayStatementEarningLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLineProperty = group.Add(new VocabularyKey(nameof(ProjectLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCompensationBenefit = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralLiabilityInsurance = group.Add(new VocabularyKey(nameof(GeneralLiabilityInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumCode = group.Add(new VocabularyKey(nameof(PremiumCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalRetroactiveRate = group.Add(new VocabularyKey(nameof(OriginalRetroactiveRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPeriod = group.Add(new VocabularyKey(nameof(WorkPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningsStatementNumber = group.Add(new VocabularyKey(nameof(EarningsStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCompensationBenefitId = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerGeneralLiabilityInsuranceBenefitId = group.Add(new VocabularyKey(nameof(WorkerGeneralLiabilityInsuranceBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegionRecId = group.Add(new VocabularyKey(nameof(WorkerTaxRegionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegionLocationId = group.Add(new VocabularyKey(nameof(WorkerTaxRegionLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingEarningStatementLine = group.Add(new VocabularyKey(nameof(OriginatingEarningStatementLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingEarningsStatementHeader = group.Add(new VocabularyKey(nameof(OriginatingEarningsStatementHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingEarningStatementLineNumber = group.Add(new VocabularyKey(nameof(OriginatingEarningStatementLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingEarningStatementNumber = group.Add(new VocabularyKey(nameof(OriginatingEarningStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumEarningCode = group.Add(new VocabularyKey(nameof(PremiumEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplate = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey EarningsDate { get; private set; }
        public VocabularyKey EarningRate { get; private set; }
        public VocabularyKey EarningsStatementHeader { get; private set; }
        public VocabularyKey GenerationSource { get; private set; }
        public VocabularyKey LineModified { get; private set; }
        public VocabularyKey IsManual { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey PayStatementEarningLine { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey ProjectCategory { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey ProjectLineProperty { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey WorkerCompensationBenefit { get; private set; }
        public VocabularyKey GeneralLiabilityInsurance { get; private set; }
        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey PremiumCode { get; private set; }
        public VocabularyKey OriginalRetroactiveRate { get; private set; }
        public VocabularyKey WorkPeriod { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey EarningsStatementNumber { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey WorkerCompensationBenefitId { get; private set; }
        public VocabularyKey WorkerGeneralLiabilityInsuranceBenefitId { get; private set; }
        public VocabularyKey WorkerTaxRegionRecId { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey WorkerTaxRegionLocationId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey OriginatingEarningStatementLine { get; private set; }
        public VocabularyKey OriginatingEarningsStatementHeader { get; private set; }
        public VocabularyKey OriginatingEarningStatementLineNumber { get; private set; }
        public VocabularyKey OriginatingEarningStatementNumber { get; private set; }
        public VocabularyKey PremiumEarningCode { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey AccountingDistributionTemplate { get; private set; }
    }
}