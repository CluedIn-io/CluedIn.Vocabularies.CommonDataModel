using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportExtraFieldsEntityVocabulary : SimpleVocabulary
    {
        public TaxReportExtraFieldsEntityVocabulary()
        {
            VocabularyName = "Tax Report Extra Fields Entity";
            KeyPrefix = "commonDataModel.taxreportextrafieldsentity";
            KeySeparator = ".";
            Grouping = "/TaxReportExtraFieldsEntity";

            AddGroup("TaxReportExtraFieldsEntity Details", group =>
            {
                DeferredGSTOnImport = group.Add(new VocabularyKey(nameof(DeferredGSTOnImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredInstalment = group.Add(new VocabularyKey(nameof(DeferredInstalment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATOFringeBenefit = group.Add(new VocabularyKey(nameof(ATOFringeBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FringeCredit = group.Add(new VocabularyKey(nameof(FringeCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedTotalFringeBenefits = group.Add(new VocabularyKey(nameof(EstimatedTotalFringeBenefits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariedFringeBenefitsTax = group.Add(new VocabularyKey(nameof(VariedFringeBenefitsTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FuelTaxCredit = group.Add(new VocabularyKey(nameof(FuelTaxCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FuelTaxCreditOverClaim = group.Add(new VocabularyKey(nameof(FuelTaxCreditOverClaim), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentRate = group.Add(new VocabularyKey(nameof(InstallmentRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaygCredit = group.Add(new VocabularyKey(nameof(PaygCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentIncome = group.Add(new VocabularyKey(nameof(InstallmentIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewVariedInstallmentRate = group.Add(new VocabularyKey(nameof(NewVariedInstallmentRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayroll = group.Add(new VocabularyKey(nameof(TotalPayroll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithheldFromInvestmentWhereNoTFN = group.Add(new VocabularyKey(nameof(WithheldFromInvestmentWhereNoTFN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithheldFromInvoicesWhereNoABN = group.Add(new VocabularyKey(nameof(WithheldFromInvoicesWhereNoABN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaygWithheldSalary = group.Add(new VocabularyKey(nameof(PaygWithheldSalary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentIdentificationNumber = group.Add(new VocabularyKey(nameof(DocumentIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WholesaleCredit = group.Add(new VocabularyKey(nameof(WholesaleCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FringeReasonForVariation = group.Add(new VocabularyKey(nameof(FringeReasonForVariation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PAYGReasonForVariation = group.Add(new VocabularyKey(nameof(PAYGReasonForVariation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DeferredGSTOnImport { get; private set; }
        public VocabularyKey DeferredInstalment { get; private set; }
        public VocabularyKey ATOFringeBenefit { get; private set; }
        public VocabularyKey FringeCredit { get; private set; }
        public VocabularyKey EstimatedTotalFringeBenefits { get; private set; }
        public VocabularyKey VariedFringeBenefitsTax { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey FuelTaxCredit { get; private set; }
        public VocabularyKey FuelTaxCreditOverClaim { get; private set; }
        public VocabularyKey InstallmentRate { get; private set; }
        public VocabularyKey PaygCredit { get; private set; }
        public VocabularyKey InstallmentIncome { get; private set; }
        public VocabularyKey NewVariedInstallmentRate { get; private set; }
        public VocabularyKey TotalPayroll { get; private set; }
        public VocabularyKey WithheldFromInvestmentWhereNoTFN { get; private set; }
        public VocabularyKey WithheldFromInvoicesWhereNoABN { get; private set; }
        public VocabularyKey PaygWithheldSalary { get; private set; }
        public VocabularyKey DocumentIdentificationNumber { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey WholesaleCredit { get; private set; }
        public VocabularyKey FringeReasonForVariation { get; private set; }
        public VocabularyKey PAYGReasonForVariation { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
    }
}