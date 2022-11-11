using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCodeEntity";
            KeyPrefix = "commonDataModel.taxcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxCodeEntity";

            AddGroup("Common Data Model TaxCodeEntity Details", group =>
            {
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NegativeTax = group.Add(new VocabularyKey(nameof(NegativeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotEUSalesList = group.Add(new VocabularyKey(nameof(NotEUSalesList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTaxCodeId = group.Add(new VocabularyKey(nameof(PaymentTaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCode = group.Add(new VocabularyKey(nameof(PrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxablePurchases = group.Add(new VocabularyKey(nameof(ReportingCodeTaxablePurchases), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxablePurchasesCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxablePurchasesCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableSales = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableSalesCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableSalesCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableImport = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableImportCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableImportCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableImportOffset = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableImportOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxableImportOffsetCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxableImportOffsetCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreePurchase = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreePurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreePurchaseCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreePurchaseCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreeSale = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreeSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreeSaleCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreeSaleCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeSalesTaxReceivable = group.Add(new VocabularyKey(nameof(ReportingCodeSalesTaxReceivable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeSalesTaxReceivableCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeSalesTaxReceivableCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeSalesTaxPayable = group.Add(new VocabularyKey(nameof(ReportingCodeSalesTaxPayable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeSalesTaxPayableCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeSalesTaxPayableCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeUseTax = group.Add(new VocabularyKey(nameof(ReportingCodeUseTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeUseTaxCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeUseTaxCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeUseTaxOffset = group.Add(new VocabularyKey(nameof(ReportingCodeUseTaxOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeUseTaxOffsetCreditNote = group.Add(new VocabularyKey(nameof(ReportingCodeUseTaxOffsetCreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPostingGroupId = group.Add(new VocabularyKey(nameof(TaxPostingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCalculationMethod = group.Add(new VocabularyKey(nameof(TaxCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCountryRegionType = group.Add(new VocabularyKey(nameof(TaxCountryRegionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCurrencyCodeId = group.Add(new VocabularyKey(nameof(TaxCurrencyCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateUnitTaxBeforeSalesTax = group.Add(new VocabularyKey(nameof(CalculateUnitTaxBeforeSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxLimitBase = group.Add(new VocabularyKey(nameof(TaxLimitBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxName = group.Add(new VocabularyKey(nameof(TaxName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxOnTax = group.Add(new VocabularyKey(nameof(TaxOnTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingDutySortCode = group.Add(new VocabularyKey(nameof(PackingDutySortCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingDuty = group.Add(new VocabularyKey(nameof(PackingDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPeriodId = group.Add(new VocabularyKey(nameof(TaxPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRoundOff = group.Add(new VocabularyKey(nameof(TaxRoundOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRoundOffType = group.Add(new VocabularyKey(nameof(TaxRoundOffType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxUnitId = group.Add(new VocabularyKey(nameof(TaxUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCodeType = group.Add(new VocabularyKey(nameof(PrintCodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportLayout = group.Add(new VocabularyKey(nameof(ReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludedTax = group.Add(new VocabularyKey(nameof(IncludedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetainedTax = group.Add(new VocabularyKey(nameof(RetainedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeRecId = group.Add(new VocabularyKey(nameof(TaxationCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalValue = group.Add(new VocabularyKey(nameof(FiscalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxSubstitutionMethod = group.Add(new VocabularyKey(nameof(TaxSubstitutionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilTaxType = group.Add(new VocabularyKey(nameof(BrazilTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiotAddInfo = group.Add(new VocabularyKey(nameof(DiotAddInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MexicoTaxType = group.Add(new VocabularyKey(nameof(MexicoTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxVatReportCategoryRecId = group.Add(new VocabularyKey(nameof(TaxVatReportCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxVatReportCategoryCode = group.Add(new VocabularyKey(nameof(TaxVatReportCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedTax = group.Add(new VocabularyKey(nameof(UnrealizedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SingaporeTaxType = group.Add(new VocabularyKey(nameof(SingaporeTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeBaseIncomingDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeBaseIncomingDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeBaseOutgoingDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeBaseOutgoingDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreeBuyDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreeBuyDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxFreeSalesDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxFreeSalesDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxIncomingDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxIncomingDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCodeTaxOutgoingDebitNote = group.Add(new VocabularyKey(nameof(ReportingCodeTaxOutgoingDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsGST = group.Add(new VocabularyKey(nameof(IsGST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfTax = group.Add(new VocabularyKey(nameof(TypeOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DomesticCustomsPractice = group.Add(new VocabularyKey(nameof(DomesticCustomsPractice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeFromInvoice = group.Add(new VocabularyKey(nameof(ExcludeFromInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxSubstitutionCalculationMethod = group.Add(new VocabularyKey(nameof(TaxSubstitutionCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode = group.Add(new VocabularyKey(nameof(RevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATChargeSource = group.Add(new VocabularyKey(nameof(VATChargeSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JapanTaxType = group.Add(new VocabularyKey(nameof(JapanTaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionQRBill = group.Add(new VocabularyKey(nameof(DescriptionQRBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey NegativeTax { get; private set; }
        public VocabularyKey NotEUSalesList { get; private set; }
        public VocabularyKey PaymentTaxCodeId { get; private set; }
        public VocabularyKey PrintCode { get; private set; }
        public VocabularyKey ReportingCodeTaxablePurchases { get; private set; }
        public VocabularyKey ReportingCodeTaxablePurchasesCreditNote { get; private set; }
        public VocabularyKey ReportingCodeTaxableSales { get; private set; }
        public VocabularyKey ReportingCodeTaxableSalesCreditNote { get; private set; }
        public VocabularyKey ReportingCodeTaxableImport { get; private set; }
        public VocabularyKey ReportingCodeTaxableImportCreditNote { get; private set; }
        public VocabularyKey ReportingCodeTaxableImportOffset { get; private set; }
        public VocabularyKey ReportingCodeTaxableImportOffsetCreditNote { get; private set; }
        public VocabularyKey ReportingCodeTaxFreePurchase { get; private set; }
        public VocabularyKey ReportingCodeTaxFreePurchaseCreditNote { get; private set; }
        public VocabularyKey ReportingCodeTaxFreeSale { get; private set; }
        public VocabularyKey ReportingCodeTaxFreeSaleCreditNote { get; private set; }
        public VocabularyKey ReportingCodeSalesTaxReceivable { get; private set; }
        public VocabularyKey ReportingCodeSalesTaxReceivableCreditNote { get; private set; }
        public VocabularyKey ReportingCodeSalesTaxPayable { get; private set; }
        public VocabularyKey ReportingCodeSalesTaxPayableCreditNote { get; private set; }
        public VocabularyKey ReportingCodeUseTax { get; private set; }
        public VocabularyKey ReportingCodeUseTaxCreditNote { get; private set; }
        public VocabularyKey ReportingCodeUseTaxOffset { get; private set; }
        public VocabularyKey ReportingCodeUseTaxOffsetCreditNote { get; private set; }
        public VocabularyKey TaxPostingGroupId { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey TaxCalculationMethod { get; private set; }
        public VocabularyKey TaxCountryRegionType { get; private set; }
        public VocabularyKey TaxCurrencyCodeId { get; private set; }
        public VocabularyKey CalculateUnitTaxBeforeSalesTax { get; private set; }
        public VocabularyKey TaxLimitBase { get; private set; }
        public VocabularyKey TaxName { get; private set; }
        public VocabularyKey TaxOnTax { get; private set; }
        public VocabularyKey PackingDutySortCode { get; private set; }
        public VocabularyKey PackingDuty { get; private set; }
        public VocabularyKey TaxPeriodId { get; private set; }
        public VocabularyKey TaxRoundOff { get; private set; }
        public VocabularyKey TaxRoundOffType { get; private set; }
        public VocabularyKey TaxUnitId { get; private set; }
        public VocabularyKey PrintCodeType { get; private set; }
        public VocabularyKey ReportLayout { get; private set; }
        public VocabularyKey IncludedTax { get; private set; }
        public VocabularyKey RetainedTax { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
        public VocabularyKey TaxationCodeRecId { get; private set; }
        public VocabularyKey FiscalValue { get; private set; }
        public VocabularyKey TaxSubstitutionMethod { get; private set; }
        public VocabularyKey BrazilTaxType { get; private set; }
        public VocabularyKey DiotAddInfo { get; private set; }
        public VocabularyKey MexicoTaxType { get; private set; }
        public VocabularyKey TaxVatReportCategoryRecId { get; private set; }
        public VocabularyKey TaxVatReportCategoryCode { get; private set; }
        public VocabularyKey UnrealizedTax { get; private set; }
        public VocabularyKey SingaporeTaxType { get; private set; }
        public VocabularyKey ReportingCodeBaseIncomingDebitNote { get; private set; }
        public VocabularyKey ReportingCodeBaseOutgoingDebitNote { get; private set; }
        public VocabularyKey ReportingCodeTaxFreeBuyDebitNote { get; private set; }
        public VocabularyKey ReportingCodeTaxFreeSalesDebitNote { get; private set; }
        public VocabularyKey ReportingCodeTaxIncomingDebitNote { get; private set; }
        public VocabularyKey ReportingCodeTaxOutgoingDebitNote { get; private set; }
        public VocabularyKey IsGST { get; private set; }
        public VocabularyKey TypeOfTax { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey DomesticCustomsPractice { get; private set; }
        public VocabularyKey ExcludeFromInvoice { get; private set; }
        public VocabularyKey TaxSubstitutionCalculationMethod { get; private set; }
        public VocabularyKey RevenueCode { get; private set; }
        public VocabularyKey VATChargeSource { get; private set; }
        public VocabularyKey JapanTaxType { get; private set; }
        public VocabularyKey DescriptionQRBill { get; private set; }


    }
}