using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCurrencyParametersV2EntityVocabulary : SimpleVocabulary
    {
        public LedgerCurrencyParametersV2EntityVocabulary()
        {
            VocabularyName = "Ledger Currency Parameters V2 Entity";
            KeyPrefix = "commonDataModel.ledgercurrencyparametersv2entity";
            KeySeparator = ".";
            Grouping = "/LedgerCurrencyParametersV2Entity";

            AddGroup("LedgerCurrencyParametersV2Entity Details", group =>
            {
                CurConvertLossLedgerDimension = group.Add(new VocabularyKey(nameof(CurConvertLossLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurConvertProfitLedgerDimension = group.Add(new VocabularyKey(nameof(CurConvertProfitLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustPostingMode = group.Add(new VocabularyKey(nameof(CustPostingMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustPostingModeTax = group.Add(new VocabularyKey(nameof(CustPostingModeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateLossTaxVend = group.Add(new VocabularyKey(nameof(ExchRateLossTaxVend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateNeg = group.Add(new VocabularyKey(nameof(ExchRateNeg), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateNonrealLossTaxCust = group.Add(new VocabularyKey(nameof(ExchRateNonrealLossTaxCust), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateNonrealProfitTaxCust = group.Add(new VocabularyKey(nameof(ExchRateNonrealProfitTaxCust), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRatePos = group.Add(new VocabularyKey(nameof(ExchRatePos), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchRateProfitTaxVend = group.Add(new VocabularyKey(nameof(ExchRateProfitTaxVend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossCustLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedLossCustLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossEmplLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedLossEmplLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossVendLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedLossVendLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitCustLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedProfitCustLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitEmplLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedProfitEmplLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitVendLedgerDimension = group.Add(new VocabularyKey(nameof(RealizedProfitVendLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableConvertLoss = group.Add(new VocabularyKey(nameof(RTax25ProfitTableConvertLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableConvertProfit = group.Add(new VocabularyKey(nameof(RTax25ProfitTableConvertProfit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLoss = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLossCust = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLossCust), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLossCustPrepayment = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLossCustPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLossEmpl = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLossEmpl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLossVend = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLossVend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableLossVendPrepayment = group.Add(new VocabularyKey(nameof(RTax25ProfitTableLossVendPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfit = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfitCust = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfitCust), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfitCustPrepayment = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfitCustPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfitEmpl = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfitEmpl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfitVend = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfitVend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableProfitVendPrepayment = group.Add(new VocabularyKey(nameof(RTax25ProfitTableProfitVendPrepayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDifference = group.Add(new VocabularyKey(nameof(TaxAmountDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDifferenceLoss = group.Add(new VocabularyKey(nameof(TaxAmountDifferenceLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffLedgerDimension = group.Add(new VocabularyKey(nameof(TaxAmountDiffLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffLossLedgerDimension = group.Add(new VocabularyKey(nameof(TaxAmountDiffLossLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffProfitLedgerDimension = group.Add(new VocabularyKey(nameof(TaxAmountDiffProfitLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossCustLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedLossCustLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossEmplLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedLossEmplLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossVendLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedLossVendLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitCustLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedProfitCustLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitEmplLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedProfitEmplLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitVendLedgerDimension = group.Add(new VocabularyKey(nameof(UnrealizedProfitVendLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendPostingMode = group.Add(new VocabularyKey(nameof(VendPostingMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendPostingModeTax = group.Add(new VocabularyKey(nameof(VendPostingModeTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger_Name = group.Add(new VocabularyKey(nameof(Ledger_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConvertLossExpenseCode = group.Add(new VocabularyKey(nameof(ConvertLossExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConvertProfitIncomeCode = group.Add(new VocabularyKey(nameof(ConvertProfitIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossGeneralExpenseCode = group.Add(new VocabularyKey(nameof(LossGeneralExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossCustExpenseCode = group.Add(new VocabularyKey(nameof(LossCustExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossCustPrepaymentExpenseCode = group.Add(new VocabularyKey(nameof(LossCustPrepaymentExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossEmplExpenseCode = group.Add(new VocabularyKey(nameof(LossEmplExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossVendExpenseCode = group.Add(new VocabularyKey(nameof(LossVendExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossVendPrepaymentExpenseCode = group.Add(new VocabularyKey(nameof(LossVendPrepaymentExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitGeneralIncomeCode = group.Add(new VocabularyKey(nameof(ProfitGeneralIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitCustIncomeCode = group.Add(new VocabularyKey(nameof(ProfitCustIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitCustPrepaymentIncomeCode = group.Add(new VocabularyKey(nameof(ProfitCustPrepaymentIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitEmplIncomeCode = group.Add(new VocabularyKey(nameof(ProfitEmplIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitVendIncomeCode = group.Add(new VocabularyKey(nameof(ProfitVendIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitVendPrepaymentIncomeCode = group.Add(new VocabularyKey(nameof(ProfitVendPrepaymentIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurConvertLossLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CurConvertLossLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurConvertProfitLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CurConvertProfitLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossCustLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedLossCustLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossEmplLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedLossEmplLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLossVendLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedLossVendLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitCustLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedProfitCustLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitEmplLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedProfitEmplLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedProfitVendLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RealizedProfitVendLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxAmountDiffLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffLossLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxAmountDiffLossLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffProfitLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxAmountDiffProfitLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossCustLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedLossCustLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossEmplLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedLossEmplLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLossVendLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedLossVendLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitCustLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedProfitCustLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitEmplLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedProfitEmplLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedProfitVendLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(UnrealizedProfitVendLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CurConvertLossLedgerDimension { get; private set; }
        public VocabularyKey CurConvertProfitLedgerDimension { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustPostingMode { get; private set; }
        public VocabularyKey CustPostingModeTax { get; private set; }
        public VocabularyKey ExchRateLossTaxVend { get; private set; }
        public VocabularyKey ExchRateNeg { get; private set; }
        public VocabularyKey ExchRateNonrealLossTaxCust { get; private set; }
        public VocabularyKey ExchRateNonrealProfitTaxCust { get; private set; }
        public VocabularyKey ExchRatePos { get; private set; }
        public VocabularyKey ExchRateProfitTaxVend { get; private set; }
        public VocabularyKey Ledger { get; private set; }
        public VocabularyKey RealizedLossCustLedgerDimension { get; private set; }
        public VocabularyKey RealizedLossEmplLedgerDimension { get; private set; }
        public VocabularyKey RealizedLossVendLedgerDimension { get; private set; }
        public VocabularyKey RealizedProfitCustLedgerDimension { get; private set; }
        public VocabularyKey RealizedProfitEmplLedgerDimension { get; private set; }
        public VocabularyKey RealizedProfitVendLedgerDimension { get; private set; }
        public VocabularyKey RTax25ProfitTableConvertLoss { get; private set; }
        public VocabularyKey RTax25ProfitTableConvertProfit { get; private set; }
        public VocabularyKey RTax25ProfitTableLoss { get; private set; }
        public VocabularyKey RTax25ProfitTableLossCust { get; private set; }
        public VocabularyKey RTax25ProfitTableLossCustPrepayment { get; private set; }
        public VocabularyKey RTax25ProfitTableLossEmpl { get; private set; }
        public VocabularyKey RTax25ProfitTableLossVend { get; private set; }
        public VocabularyKey RTax25ProfitTableLossVendPrepayment { get; private set; }
        public VocabularyKey RTax25ProfitTableProfit { get; private set; }
        public VocabularyKey RTax25ProfitTableProfitCust { get; private set; }
        public VocabularyKey RTax25ProfitTableProfitCustPrepayment { get; private set; }
        public VocabularyKey RTax25ProfitTableProfitEmpl { get; private set; }
        public VocabularyKey RTax25ProfitTableProfitVend { get; private set; }
        public VocabularyKey RTax25ProfitTableProfitVendPrepayment { get; private set; }
        public VocabularyKey TaxAmountDifference { get; private set; }
        public VocabularyKey TaxAmountDifferenceLoss { get; private set; }
        public VocabularyKey TaxAmountDiffLedgerDimension { get; private set; }
        public VocabularyKey TaxAmountDiffLossLedgerDimension { get; private set; }
        public VocabularyKey TaxAmountDiffProfitLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedLossCustLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedLossEmplLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedLossVendLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedProfitCustLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedProfitEmplLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedProfitVendLedgerDimension { get; private set; }
        public VocabularyKey VendPostingMode { get; private set; }
        public VocabularyKey VendPostingModeTax { get; private set; }
        public VocabularyKey Ledger_Name { get; private set; }
        public VocabularyKey ConvertLossExpenseCode { get; private set; }
        public VocabularyKey ConvertProfitIncomeCode { get; private set; }
        public VocabularyKey LossGeneralExpenseCode { get; private set; }
        public VocabularyKey LossCustExpenseCode { get; private set; }
        public VocabularyKey LossCustPrepaymentExpenseCode { get; private set; }
        public VocabularyKey LossEmplExpenseCode { get; private set; }
        public VocabularyKey LossVendExpenseCode { get; private set; }
        public VocabularyKey LossVendPrepaymentExpenseCode { get; private set; }
        public VocabularyKey ProfitGeneralIncomeCode { get; private set; }
        public VocabularyKey ProfitCustIncomeCode { get; private set; }
        public VocabularyKey ProfitCustPrepaymentIncomeCode { get; private set; }
        public VocabularyKey ProfitEmplIncomeCode { get; private set; }
        public VocabularyKey ProfitVendIncomeCode { get; private set; }
        public VocabularyKey ProfitVendPrepaymentIncomeCode { get; private set; }
        public VocabularyKey CurConvertLossLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CurConvertProfitLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedLossCustLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedLossEmplLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedLossVendLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedProfitCustLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedProfitEmplLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RealizedProfitVendLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TaxAmountDiffLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TaxAmountDiffLossLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TaxAmountDiffProfitLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedLossCustLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedLossEmplLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedLossVendLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedProfitCustLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedProfitEmplLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey UnrealizedProfitVendLedgerDimensionDisplayValue { get; private set; }
    }
}