using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCurrencyParametersEntityVocabulary : SimpleVocabulary
    {
        public LedgerCurrencyParametersEntityVocabulary()
        {
            VocabularyName = "Ledger Currency Parameters Entity";
            KeyPrefix = "commonDataModel.ledgercurrencyparametersentity";
            KeySeparator = ".";
            Grouping = "/LedgerCurrencyParametersEntity";

            AddGroup("LedgerCurrencyParametersEntity Details", group =>
            {
                ConversionLoss = group.Add(new VocabularyKey(nameof(ConversionLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConversionGain = group.Add(new VocabularyKey(nameof(ConversionGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustPrimaryPostingLedger = group.Add(new VocabularyKey(nameof(CustPrimaryPostingLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTaxPrimaryPostingLedger = group.Add(new VocabularyKey(nameof(CustTaxPrimaryPostingLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRealizedLossSalesTaxes = group.Add(new VocabularyKey(nameof(VendRealizedLossSalesTaxes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedGainSalesTaxes = group.Add(new VocabularyKey(nameof(CustRealizedGainSalesTaxes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedLossSalesTaxes = group.Add(new VocabularyKey(nameof(CustRealizedLossSalesTaxes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRealizedGainSalesTaxes = group.Add(new VocabularyKey(nameof(VendRealizedGainSalesTaxes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLoss = group.Add(new VocabularyKey(nameof(RealizedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount1 = group.Add(new VocabularyKey(nameof(MainAccount1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount2 = group.Add(new VocabularyKey(nameof(MainAccount2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedLoss1 = group.Add(new VocabularyKey(nameof(RealizedLoss1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedGain = group.Add(new VocabularyKey(nameof(RealizedGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount3 = group.Add(new VocabularyKey(nameof(MainAccount3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount4 = group.Add(new VocabularyKey(nameof(MainAccount4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount5 = group.Add(new VocabularyKey(nameof(MainAccount5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedGain1 = group.Add(new VocabularyKey(nameof(RealizedGain1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableConvertLoss = group.Add(new VocabularyKey(nameof(RTax25ProfitTableConvertLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTableConvertProfit = group.Add(new VocabularyKey(nameof(RTax25ProfitTableConvertProfit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode1 = group.Add(new VocabularyKey(nameof(ExpenseCode1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode2 = group.Add(new VocabularyKey(nameof(ExpenseCode2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode3 = group.Add(new VocabularyKey(nameof(ExpenseCode3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode4 = group.Add(new VocabularyKey(nameof(ExpenseCode4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode5 = group.Add(new VocabularyKey(nameof(ExpenseCode5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode = group.Add(new VocabularyKey(nameof(RevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode1 = group.Add(new VocabularyKey(nameof(RevenueCode1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode2 = group.Add(new VocabularyKey(nameof(RevenueCode2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode3 = group.Add(new VocabularyKey(nameof(RevenueCode3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode4 = group.Add(new VocabularyKey(nameof(RevenueCode4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueCode5 = group.Add(new VocabularyKey(nameof(RevenueCode5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountDifferenceInTaxAccounting = group.Add(new VocabularyKey(nameof(AmountDifferenceInTaxAccounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TakeVATIntoAccountForExpenses = group.Add(new VocabularyKey(nameof(TakeVATIntoAccountForExpenses), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerAccount = group.Add(new VocabularyKey(nameof(OffsetLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffLossLedgerDimension = group.Add(new VocabularyKey(nameof(TaxAmountDiffLossLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountDiffProfitLedgerDimension = group.Add(new VocabularyKey(nameof(TaxAmountDiffProfitLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLoss = group.Add(new VocabularyKey(nameof(UnrealizedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount6 = group.Add(new VocabularyKey(nameof(MainAccount6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount7 = group.Add(new VocabularyKey(nameof(MainAccount7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedLoss1 = group.Add(new VocabularyKey(nameof(UnrealizedLoss1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedGain = group.Add(new VocabularyKey(nameof(UnrealizedGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount8 = group.Add(new VocabularyKey(nameof(MainAccount8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount9 = group.Add(new VocabularyKey(nameof(MainAccount9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnrealizedGain1 = group.Add(new VocabularyKey(nameof(UnrealizedGain1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendPrimaryPostingLedger = group.Add(new VocabularyKey(nameof(VendPrimaryPostingLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxPrimaryPostingLedger = group.Add(new VocabularyKey(nameof(VendTaxPrimaryPostingLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger_Name = group.Add(new VocabularyKey(nameof(Ledger_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDimensionConversionExpenseCode = group.Add(new VocabularyKey(nameof(VendTaxDimensionConversionExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDimensionConversionRevenueCode = group.Add(new VocabularyKey(nameof(VendTaxDimensionConversionRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralTaxDimensionExpenseCode = group.Add(new VocabularyKey(nameof(GeneralTaxDimensionExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTaxDimensionExpenseCode = group.Add(new VocabularyKey(nameof(CustTaxDimensionExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTaxDimensionPrepaymentsExpenseCode = group.Add(new VocabularyKey(nameof(CustTaxDimensionPrepaymentsExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplTaxDimensionExpenseCode = group.Add(new VocabularyKey(nameof(EmplTaxDimensionExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDImensionExpenseCode = group.Add(new VocabularyKey(nameof(VendTaxDImensionExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDimensionPrepaymentsExpenseCode = group.Add(new VocabularyKey(nameof(VendTaxDimensionPrepaymentsExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralTaxDimensionRevenueCode = group.Add(new VocabularyKey(nameof(GeneralTaxDimensionRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTaxDimensionRevenueCode = group.Add(new VocabularyKey(nameof(CustTaxDimensionRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTaxDimensionPrepaymentsRevenueCode = group.Add(new VocabularyKey(nameof(CustTaxDimensionPrepaymentsRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplTaxDimensionRevenueCode = group.Add(new VocabularyKey(nameof(EmplTaxDimensionRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDimensionRevenueCode = group.Add(new VocabularyKey(nameof(VendTaxDimensionRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTaxDimensionPrepaymentsRevenueCode = group.Add(new VocabularyKey(nameof(VendTaxDimensionPrepaymentsRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendConversionLoss = group.Add(new VocabularyKey(nameof(VendConversionLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendConversionGain = group.Add(new VocabularyKey(nameof(VendConversionGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedLossMainAccount = group.Add(new VocabularyKey(nameof(CustRealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplRealizedLossMainAccount = group.Add(new VocabularyKey(nameof(EmplRealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedLossTaxPostingAccount = group.Add(new VocabularyKey(nameof(CustRealizedLossTaxPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRelizedLossTaxPostingAccount = group.Add(new VocabularyKey(nameof(VendRelizedLossTaxPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRealizedLossMainAccount = group.Add(new VocabularyKey(nameof(VendRealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedGainMainAccount = group.Add(new VocabularyKey(nameof(CustRealizedGainMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplRealizedGain = group.Add(new VocabularyKey(nameof(EmplRealizedGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRealizedGainTaxPostingAccount = group.Add(new VocabularyKey(nameof(CustRealizedGainTaxPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRelizedGainTaxPostingAccount = group.Add(new VocabularyKey(nameof(VendRelizedGainTaxPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendRealizedGainMainAccount = group.Add(new VocabularyKey(nameof(VendRealizedGainMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustUnrealizedLossMainAccount = group.Add(new VocabularyKey(nameof(CustUnrealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplUnrealizedLossMainAccount = group.Add(new VocabularyKey(nameof(EmplUnrealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendUnrealizedLossMainAccount = group.Add(new VocabularyKey(nameof(VendUnrealizedLossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustUnrealizedGainMainAccount = group.Add(new VocabularyKey(nameof(CustUnrealizedGainMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplUnrealizedGainMainAccount = group.Add(new VocabularyKey(nameof(EmplUnrealizedGainMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendUnrealizedGainMainAccount = group.Add(new VocabularyKey(nameof(VendUnrealizedGainMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConversionLoss { get; private set; }
        public VocabularyKey ConversionGain { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CustPrimaryPostingLedger { get; private set; }
        public VocabularyKey CustTaxPrimaryPostingLedger { get; private set; }
        public VocabularyKey VendRealizedLossSalesTaxes { get; private set; }
        public VocabularyKey CustRealizedGainSalesTaxes { get; private set; }
        public VocabularyKey CustRealizedLossSalesTaxes { get; private set; }
        public VocabularyKey VendRealizedGainSalesTaxes { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey RealizedLoss { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccount1 { get; private set; }
        public VocabularyKey MainAccount2 { get; private set; }
        public VocabularyKey RealizedLoss1 { get; private set; }
        public VocabularyKey RealizedGain { get; private set; }
        public VocabularyKey MainAccount3 { get; private set; }
        public VocabularyKey MainAccount4 { get; private set; }
        public VocabularyKey MainAccount5 { get; private set; }
        public VocabularyKey RealizedGain1 { get; private set; }
        public VocabularyKey RTax25ProfitTableConvertLoss { get; private set; }
        public VocabularyKey RTax25ProfitTableConvertProfit { get; private set; }
        public VocabularyKey ExpenseCode { get; private set; }
        public VocabularyKey ExpenseCode1 { get; private set; }
        public VocabularyKey ExpenseCode2 { get; private set; }
        public VocabularyKey ExpenseCode3 { get; private set; }
        public VocabularyKey ExpenseCode4 { get; private set; }
        public VocabularyKey ExpenseCode5 { get; private set; }
        public VocabularyKey RevenueCode { get; private set; }
        public VocabularyKey RevenueCode1 { get; private set; }
        public VocabularyKey RevenueCode2 { get; private set; }
        public VocabularyKey RevenueCode3 { get; private set; }
        public VocabularyKey RevenueCode4 { get; private set; }
        public VocabularyKey RevenueCode5 { get; private set; }
        public VocabularyKey AmountDifferenceInTaxAccounting { get; private set; }
        public VocabularyKey TakeVATIntoAccountForExpenses { get; private set; }
        public VocabularyKey OffsetLedgerAccount { get; private set; }
        public VocabularyKey TaxAmountDiffLossLedgerDimension { get; private set; }
        public VocabularyKey TaxAmountDiffProfitLedgerDimension { get; private set; }
        public VocabularyKey UnrealizedLoss { get; private set; }
        public VocabularyKey MainAccount6 { get; private set; }
        public VocabularyKey MainAccount7 { get; private set; }
        public VocabularyKey UnrealizedLoss1 { get; private set; }
        public VocabularyKey UnrealizedGain { get; private set; }
        public VocabularyKey MainAccount8 { get; private set; }
        public VocabularyKey MainAccount9 { get; private set; }
        public VocabularyKey UnrealizedGain1 { get; private set; }
        public VocabularyKey VendPrimaryPostingLedger { get; private set; }
        public VocabularyKey VendTaxPrimaryPostingLedger { get; private set; }
        public VocabularyKey Ledger_Name { get; private set; }
        public VocabularyKey VendTaxDimensionConversionExpenseCode { get; private set; }
        public VocabularyKey VendTaxDimensionConversionRevenueCode { get; private set; }
        public VocabularyKey GeneralTaxDimensionExpenseCode { get; private set; }
        public VocabularyKey CustTaxDimensionExpenseCode { get; private set; }
        public VocabularyKey CustTaxDimensionPrepaymentsExpenseCode { get; private set; }
        public VocabularyKey EmplTaxDimensionExpenseCode { get; private set; }
        public VocabularyKey VendTaxDImensionExpenseCode { get; private set; }
        public VocabularyKey VendTaxDimensionPrepaymentsExpenseCode { get; private set; }
        public VocabularyKey GeneralTaxDimensionRevenueCode { get; private set; }
        public VocabularyKey CustTaxDimensionRevenueCode { get; private set; }
        public VocabularyKey CustTaxDimensionPrepaymentsRevenueCode { get; private set; }
        public VocabularyKey EmplTaxDimensionRevenueCode { get; private set; }
        public VocabularyKey VendTaxDimensionRevenueCode { get; private set; }
        public VocabularyKey VendTaxDimensionPrepaymentsRevenueCode { get; private set; }
        public VocabularyKey VendConversionLoss { get; private set; }
        public VocabularyKey VendConversionGain { get; private set; }
        public VocabularyKey CustRealizedLossMainAccount { get; private set; }
        public VocabularyKey EmplRealizedLossMainAccount { get; private set; }
        public VocabularyKey CustRealizedLossTaxPostingAccount { get; private set; }
        public VocabularyKey VendRelizedLossTaxPostingAccount { get; private set; }
        public VocabularyKey VendRealizedLossMainAccount { get; private set; }
        public VocabularyKey CustRealizedGainMainAccount { get; private set; }
        public VocabularyKey EmplRealizedGain { get; private set; }
        public VocabularyKey CustRealizedGainTaxPostingAccount { get; private set; }
        public VocabularyKey VendRelizedGainTaxPostingAccount { get; private set; }
        public VocabularyKey VendRealizedGainMainAccount { get; private set; }
        public VocabularyKey CustUnrealizedLossMainAccount { get; private set; }
        public VocabularyKey EmplUnrealizedLossMainAccount { get; private set; }
        public VocabularyKey VendUnrealizedLossMainAccount { get; private set; }
        public VocabularyKey CustUnrealizedGainMainAccount { get; private set; }
        public VocabularyKey EmplUnrealizedGainMainAccount { get; private set; }
        public VocabularyKey VendUnrealizedGainMainAccount { get; private set; }
    }
}