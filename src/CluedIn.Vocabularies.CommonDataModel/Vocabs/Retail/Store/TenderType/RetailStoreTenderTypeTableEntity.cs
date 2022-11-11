using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreTenderTypeTableEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreTenderTypeTableEntityVocabulary()
        {
            VocabularyName = "RetailStoreTenderTypeTableEntity";
            KeyPrefix = "commonDataModel.retailstoretendertypetableentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreTenderTypeTableEntity";

            AddGroup("RetailStoreTenderTypeTableEntity Details", group =>
            {
                ChangeTenderId = group.Add(new VocabularyKey(nameof(ChangeTenderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AboveMinimumTenderId = group.Add(new VocabularyKey(nameof(AboveMinimumTenderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountTypeGiftCardCompany = group.Add(new VocabularyKey(nameof(AccountTypeGiftCardCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveAccount = group.Add(new VocabularyKey(nameof(ActiveAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowFloat = group.Add(new VocabularyKey(nameof(AllowFloat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowOvertender = group.Add(new VocabularyKey(nameof(AllowOvertender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowReturnNegative = group.Add(new VocabularyKey(nameof(AllowReturnNegative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowUndertender = group.Add(new VocabularyKey(nameof(AllowUndertender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AskForDate = group.Add(new VocabularyKey(nameof(AskForDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankBagAccountType = group.Add(new VocabularyKey(nameof(BankBagAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankBagLedgerDimension = group.Add(new VocabularyKey(nameof(BankBagLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankBagLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(BankBagLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeLineOnReceipt = group.Add(new VocabularyKey(nameof(ChangeLineOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckPayee = group.Add(new VocabularyKey(nameof(CheckPayee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompressPaymentEntries = group.Add(new VocabularyKey(nameof(CompressPaymentEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingRequired = group.Add(new VocabularyKey(nameof(CountingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiffAccBigDiffLedgerDimension = group.Add(new VocabularyKey(nameof(DiffAccBigDiffLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiffAccBigDiffLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DiffAccBigDiffLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DifferenceAccLedgerDimension = group.Add(new VocabularyKey(nameof(DifferenceAccLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DifferenceAccLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DifferenceAccLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndorseCheck = group.Add(new VocabularyKey(nameof(EndorseCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndorsmentLine1 = group.Add(new VocabularyKey(nameof(EndorsmentLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndorsmentLine2 = group.Add(new VocabularyKey(nameof(EndorsmentLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinterTenderType_BR = group.Add(new VocabularyKey(nameof(FiscalPrinterTenderType_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FrontOfCheck = group.Add(new VocabularyKey(nameof(FrontOfCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Function = group.Add(new VocabularyKey(nameof(Function), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardCompany = group.Add(new VocabularyKey(nameof(GiftCardCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionGiftCardCompany = group.Add(new VocabularyKey(nameof(LedgerDimensionGiftCardCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionGiftCardCompanyDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionGiftCardCompanyDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumInTransaction = group.Add(new VocabularyKey(nameof(LineNumInTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumCountingDifference = group.Add(new VocabularyKey(nameof(MaximumCountingDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAmountAllowed = group.Add(new VocabularyKey(nameof(MaximumAmountAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAmountEntered = group.Add(new VocabularyKey(nameof(MaximumAmountEntered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumOvertenderAmount = group.Add(new VocabularyKey(nameof(MaximumOvertenderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumNormalDifferenceAmount = group.Add(new VocabularyKey(nameof(MaximumNormalDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumRecount = group.Add(new VocabularyKey(nameof(MaximumRecount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAmountAllowed = group.Add(new VocabularyKey(nameof(MinimumAmountAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAmountEntered = group.Add(new VocabularyKey(nameof(MinimumAmountEntered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumChangeAmount = group.Add(new VocabularyKey(nameof(MinimumChangeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiplyInTenderOperations = group.Add(new VocabularyKey(nameof(MultiplyInTenderOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenDrawer = group.Add(new VocabularyKey(nameof(OpenDrawer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayAccountBill = group.Add(new VocabularyKey(nameof(PayAccountBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTerminalId = group.Add(new VocabularyKey(nameof(PaymentTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PosCountEntries = group.Add(new VocabularyKey(nameof(PosCountEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PosOperation = group.Add(new VocabularyKey(nameof(PosOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rounding = group.Add(new VocabularyKey(nameof(Rounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethod = group.Add(new VocabularyKey(nameof(RoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SafeAccLedgerDimension = group.Add(new VocabularyKey(nameof(SafeAccLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SafeAccLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(SafeAccLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SafeAccountType = group.Add(new VocabularyKey(nameof(SafeAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SafeActiveAccount = group.Add(new VocabularyKey(nameof(SafeActiveAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeekAuthorization = group.Add(new VocabularyKey(nameof(SeekAuthorization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SigCapEnabled = group.Add(new VocabularyKey(nameof(SigCapEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SigCapMinAmount = group.Add(new VocabularyKey(nameof(SigCapMinAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlipBackInPrinter = group.Add(new VocabularyKey(nameof(SlipBackInPrinter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlipFrontInPrinter = group.Add(new VocabularyKey(nameof(SlipFrontInPrinter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TakenToBank = group.Add(new VocabularyKey(nameof(TakenToBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TakenToSafe = group.Add(new VocabularyKey(nameof(TakenToSafe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderTypeId = group.Add(new VocabularyKey(nameof(TenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UndertenderAmount = group.Add(new VocabularyKey(nameof(UndertenderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTable_OMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTable_OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnit_PartyNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnit_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardItemId = group.Add(new VocabularyKey(nameof(GiftCardItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorName = group.Add(new VocabularyKey(nameof(ConnectorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideCardInputDetailsInPOS = group.Add(new VocabularyKey(nameof(HideCardInputDetailsInPOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDrawerLimit = group.Add(new VocabularyKey(nameof(CashDrawerLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDrawerLimitEnabled = group.Add(new VocabularyKey(nameof(CashDrawerLimitEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderFlowLedgerDimension = group.Add(new VocabularyKey(nameof(TenderFlowLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderFlowLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TenderFlowLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardCashOutThreshold = group.Add(new VocabularyKey(nameof(GiftCardCashOutThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictReturnsWithoutReceipt = group.Add(new VocabularyKey(nameof(RestrictReturnsWithoutReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChangeTenderId { get; private set; }
        public VocabularyKey AboveMinimumTenderId { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AccountTypeGiftCardCompany { get; private set; }
        public VocabularyKey ActiveAccount { get; private set; }
        public VocabularyKey AllowFloat { get; private set; }
        public VocabularyKey AllowOvertender { get; private set; }
        public VocabularyKey AllowReturnNegative { get; private set; }
        public VocabularyKey AllowUndertender { get; private set; }
        public VocabularyKey AskForDate { get; private set; }
        public VocabularyKey BankBagAccountType { get; private set; }
        public VocabularyKey BankBagLedgerDimension { get; private set; }
        public VocabularyKey BankBagLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ChangeLineOnReceipt { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CheckPayee { get; private set; }
        public VocabularyKey CompressPaymentEntries { get; private set; }
        public VocabularyKey CountingRequired { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey DiffAccBigDiffLedgerDimension { get; private set; }
        public VocabularyKey DiffAccBigDiffLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DifferenceAccLedgerDimension { get; private set; }
        public VocabularyKey DifferenceAccLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey EndorseCheck { get; private set; }
        public VocabularyKey EndorsmentLine1 { get; private set; }
        public VocabularyKey EndorsmentLine2 { get; private set; }
        public VocabularyKey FiscalPrinterTenderType_BR { get; private set; }
        public VocabularyKey FrontOfCheck { get; private set; }
        public VocabularyKey Function { get; private set; }
        public VocabularyKey GiftCardCompany { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey LedgerDimensionGiftCardCompany { get; private set; }
        public VocabularyKey LedgerDimensionGiftCardCompanyDisplayValue { get; private set; }
        public VocabularyKey LineNumInTransaction { get; private set; }
        public VocabularyKey MaximumCountingDifference { get; private set; }
        public VocabularyKey MaximumAmountAllowed { get; private set; }
        public VocabularyKey MaximumAmountEntered { get; private set; }
        public VocabularyKey MaximumOvertenderAmount { get; private set; }
        public VocabularyKey MaximumNormalDifferenceAmount { get; private set; }
        public VocabularyKey MaximumRecount { get; private set; }
        public VocabularyKey MinimumAmountAllowed { get; private set; }
        public VocabularyKey MinimumAmountEntered { get; private set; }
        public VocabularyKey MinimumChangeAmount { get; private set; }
        public VocabularyKey MultiplyInTenderOperations { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OpenDrawer { get; private set; }
        public VocabularyKey PayAccountBill { get; private set; }
        public VocabularyKey PaymentTerminalId { get; private set; }
        public VocabularyKey PosCountEntries { get; private set; }
        public VocabularyKey PosOperation { get; private set; }
        public VocabularyKey Rounding { get; private set; }
        public VocabularyKey RoundingMethod { get; private set; }
        public VocabularyKey SafeAccLedgerDimension { get; private set; }
        public VocabularyKey SafeAccLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey SafeAccountType { get; private set; }
        public VocabularyKey SafeActiveAccount { get; private set; }
        public VocabularyKey SeekAuthorization { get; private set; }
        public VocabularyKey SigCapEnabled { get; private set; }
        public VocabularyKey SigCapMinAmount { get; private set; }
        public VocabularyKey SlipBackInPrinter { get; private set; }
        public VocabularyKey SlipFrontInPrinter { get; private set; }
        public VocabularyKey TakenToBank { get; private set; }
        public VocabularyKey TakenToSafe { get; private set; }
        public VocabularyKey TenderTypeId { get; private set; }
        public VocabularyKey UndertenderAmount { get; private set; }
        public VocabularyKey RetailChannelTable_OMOperatingUnitID { get; private set; }
        public VocabularyKey OMOperatingUnit_PartyNumber { get; private set; }
        public VocabularyKey OMOperatingUnitNumber { get; private set; }
        public VocabularyKey GiftCardItemId { get; private set; }
        public VocabularyKey ConnectorName { get; private set; }
        public VocabularyKey HideCardInputDetailsInPOS { get; private set; }
        public VocabularyKey CashDrawerLimit { get; private set; }
        public VocabularyKey CashDrawerLimitEnabled { get; private set; }
        public VocabularyKey TenderFlowLedgerDimension { get; private set; }
        public VocabularyKey TenderFlowLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey GiftCardCashOutThreshold { get; private set; }
        public VocabularyKey RestrictReturnsWithoutReceipt { get; private set; }


    }
}