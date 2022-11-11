using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningStatementLineInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningStatementLineInquiryEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEarningStatementLineInquiryEntity";
            KeyPrefix = "commonDataModel.payrollearningstatementlineinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningStatementLineInquiryEntity";

            AddGroup("Common Data Model PayrollEarningStatementLineInquiryEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningDate = group.Add(new VocabularyKey(nameof(EarningDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeDescription = group.Add(new VocabularyKey(nameof(EarningCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnit = group.Add(new VocabularyKey(nameof(QuantityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningRate = group.Add(new VocabularyKey(nameof(EarningRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetroactivePriorRate = group.Add(new VocabularyKey(nameof(RetroactivePriorRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerGLIBenefitId = group.Add(new VocabularyKey(nameof(WorkerGLIBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCompensationBenefitId = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductive = group.Add(new VocabularyKey(nameof(IsProductive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FringeBenefitType = group.Add(new VocabularyKey(nameof(FringeBenefitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumCode = group.Add(new VocabularyKey(nameof(PremiumCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerationSource = group.Add(new VocabularyKey(nameof(GenerationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey EarningDate { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey EarningCodeDescription { get; private set; }
        public VocabularyKey QuantityUnit { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey EarningRate { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey RetroactivePriorRate { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey WorkerGLIBenefitId { get; private set; }
        public VocabularyKey WorkerCompensationBenefitId { get; private set; }
        public VocabularyKey IsProductive { get; private set; }
        public VocabularyKey FringeBenefitType { get; private set; }
        public VocabularyKey PremiumCode { get; private set; }
        public VocabularyKey GenerationSource { get; private set; }


    }
}