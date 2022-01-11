using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxParametersEntityVocabulary : SimpleVocabulary
    {
        public TaxParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxParametersEntity";
            KeyPrefix = "commonDataModel.taxparametersentity";
            KeySeparator = ".";
            Grouping = "/TaxParametersEntity";

            AddGroup("Common Data Model TaxParametersEntity Details", group =>
            {
                CalculationPrinciple = group.Add(new VocabularyKey(nameof(CalculationPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CheckSalesTaxGroupIntersection = group.Add(new VocabularyKey(nameof(CheckSalesTaxGroupIntersection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConditionalTax = group.Add(new VocabularyKey(nameof(ConditionalTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountsIncludeTaxInJournals = group.Add(new VocabularyKey(nameof(AmountsIncludeTaxInJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MandatoryTaxDirection = group.Add(new VocabularyKey(nameof(MandatoryTaxDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoTaxSearch = group.Add(new VocabularyKey(nameof(AutoTaxSearch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxTaxationRules = group.Add(new VocabularyKey(nameof(SalesTaxTaxationRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeAdjustmentOnReport = group.Add(new VocabularyKey(nameof(IncludeAdjustmentOnReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReverseSalesTaxOnCashDiscount = group.Add(new VocabularyKey(nameof(ReverseSalesTaxOnCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCalculationDate = group.Add(new VocabularyKey(nameof(TaxCalculationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesTaxGroup = group.Add(new VocabularyKey(nameof(DefaultSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(DefaultItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductTaxBeforeCashDiscountCalculation = group.Add(new VocabularyKey(nameof(DeductTaxBeforeCashDiscountCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityforIntercompanyTax = group.Add(new VocabularyKey(nameof(LegalEntityforIntercompanyTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AdjustTaxForOverUnderpayment = group.Add(new VocabularyKey(nameof(AdjustTaxForOverUnderpayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPerInvoiceLine = group.Add(new VocabularyKey(nameof(TaxPerInvoiceLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateTaxCode = group.Add(new VocabularyKey(nameof(ValidateTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BASFormatMappingRecId = group.Add(new VocabularyKey(nameof(BASFormatMappingRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BASFormatName = group.Add(new VocabularyKey(nameof(BASFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BASSolutionName = group.Add(new VocabularyKey(nameof(BASSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BASVendorUrl = group.Add(new VocabularyKey(nameof(BASVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsConsumptionTaxReportsEnabled = group.Add(new VocabularyKey(nameof(IsConsumptionTaxReportsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultInvoiceType = group.Add(new VocabularyKey(nameof(DefaultInvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTAuditFileFormatMappingRecId = group.Add(new VocabularyKey(nameof(GSTAuditFileFormatMappingRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTAuditFileFormatName = group.Add(new VocabularyKey(nameof(GSTAuditFileFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTSolutionName = group.Add(new VocabularyKey(nameof(GSTSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTVendorUrl = group.Add(new VocabularyKey(nameof(GSTVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTExemptPrintCode = group.Add(new VocabularyKey(nameof(GSTExemptPrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTGAFVersion = group.Add(new VocabularyKey(nameof(GSTGAFVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTInvoiceFormat = group.Add(new VocabularyKey(nameof(GSTInvoiceFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GSTSummaryDelimiter = group.Add(new VocabularyKey(nameof(GSTSummaryDelimiter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeDelimiterInGSTSummary = group.Add(new VocabularyKey(nameof(IncludeDelimiterInGSTSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeTaxCodeInGSTSummary = group.Add(new VocabularyKey(nameof(IncludeTaxCodeInGSTSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeTaxValueInGSTSummary = group.Add(new VocabularyKey(nameof(IncludeTaxValueInGSTSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseSelfBilledInvoice = group.Add(new VocabularyKey(nameof(UseSelfBilledInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateForSecondTaxRaise = group.Add(new VocabularyKey(nameof(DateForSecondTaxRaise), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankExchangeRate = group.Add(new VocabularyKey(nameof(BankExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxPayableExchangeRateType = group.Add(new VocabularyKey(nameof(SalesTaxPayableExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxPayableExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(SalesTaxPayableExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxReceivableExchangeRateType = group.Add(new VocabularyKey(nameof(SalesTaxReceivableExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxReceivableExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(SalesTaxReceivableExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTaxBranchEnabled = group.Add(new VocabularyKey(nameof(IsTaxBranchEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountIsAppliedInTheInvoice = group.Add(new VocabularyKey(nameof(CashDiscountIsAppliedInTheInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateDifferenceDocumentType = group.Add(new VocabularyKey(nameof(ExchangeRateDifferenceDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncommingVATPayment = group.Add(new VocabularyKey(nameof(IncommingVATPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseVATDueDateInReports = group.Add(new VocabularyKey(nameof(UseVATDueDateInReports), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RestoredVATCalculationMethod = group.Add(new VocabularyKey(nameof(RestoredVATCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RestoredVATGainCalculationMethod = group.Add(new VocabularyKey(nameof(RestoredVATGainCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedOffsetPosting = group.Add(new VocabularyKey(nameof(FixedOffsetPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CalculationPrinciple { get; private set; }
public VocabularyKey CheckSalesTaxGroupIntersection { get; private set; }
public VocabularyKey ConditionalTax { get; private set; }
public VocabularyKey AmountsIncludeTaxInJournals { get; private set; }
public VocabularyKey Key { get; private set; }
public VocabularyKey MandatoryTaxDirection { get; private set; }
public VocabularyKey AutoTaxSearch { get; private set; }
public VocabularyKey SalesTaxTaxationRules { get; private set; }
public VocabularyKey IncludeAdjustmentOnReport { get; private set; }
public VocabularyKey ReverseSalesTaxOnCashDiscount { get; private set; }
public VocabularyKey TaxCalculationDate { get; private set; }
public VocabularyKey DefaultSalesTaxGroup { get; private set; }
public VocabularyKey DefaultItemSalesTaxGroup { get; private set; }
public VocabularyKey DeductTaxBeforeCashDiscountCalculation { get; private set; }
public VocabularyKey LegalEntityforIntercompanyTax { get; private set; }
public VocabularyKey AdjustTaxForOverUnderpayment { get; private set; }
public VocabularyKey TaxPerInvoiceLine { get; private set; }
public VocabularyKey ValidateTaxCode { get; private set; }
public VocabularyKey BASFormatMappingRecId { get; private set; }
public VocabularyKey BASFormatName { get; private set; }
public VocabularyKey BASSolutionName { get; private set; }
public VocabularyKey BASVendorUrl { get; private set; }
public VocabularyKey IsConsumptionTaxReportsEnabled { get; private set; }
public VocabularyKey DefaultInvoiceType { get; private set; }
public VocabularyKey GSTAuditFileFormatMappingRecId { get; private set; }
public VocabularyKey GSTAuditFileFormatName { get; private set; }
public VocabularyKey GSTSolutionName { get; private set; }
public VocabularyKey GSTVendorUrl { get; private set; }
public VocabularyKey GSTExemptPrintCode { get; private set; }
public VocabularyKey GSTGAFVersion { get; private set; }
public VocabularyKey GSTInvoiceFormat { get; private set; }
public VocabularyKey GSTSummaryDelimiter { get; private set; }
public VocabularyKey IncludeDelimiterInGSTSummary { get; private set; }
public VocabularyKey IncludeTaxCodeInGSTSummary { get; private set; }
public VocabularyKey IncludeTaxValueInGSTSummary { get; private set; }
public VocabularyKey UseSelfBilledInvoice { get; private set; }
public VocabularyKey DateForSecondTaxRaise { get; private set; }
public VocabularyKey BankExchangeRate { get; private set; }
public VocabularyKey SalesTaxPayableExchangeRateType { get; private set; }
public VocabularyKey SalesTaxPayableExchangeRateTypeRecId { get; private set; }
public VocabularyKey SalesTaxReceivableExchangeRateType { get; private set; }
public VocabularyKey SalesTaxReceivableExchangeRateTypeRecId { get; private set; }
public VocabularyKey IsTaxBranchEnabled { get; private set; }
public VocabularyKey CashDiscountIsAppliedInTheInvoice { get; private set; }
public VocabularyKey ExchangeRateDifferenceDocumentType { get; private set; }
public VocabularyKey IncommingVATPayment { get; private set; }
public VocabularyKey UseVATDueDateInReports { get; private set; }
public VocabularyKey RestoredVATCalculationMethod { get; private set; }
public VocabularyKey RestoredVATGainCalculationMethod { get; private set; }
public VocabularyKey FixedOffsetPosting { get; private set; }


    }
}