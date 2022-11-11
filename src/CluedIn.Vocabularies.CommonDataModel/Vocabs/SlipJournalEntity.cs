using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlipJournalEntityVocabulary : SimpleVocabulary
    {
        public SlipJournalEntityVocabulary()
        {
            VocabularyName = "SlipJournalEntity";
            KeyPrefix = "commonDataModel.slipjournalentity";
            KeySeparator = ".";
            Grouping = "/SlipJournalEntity";

            AddGroup("SlipJournalEntity Details", group =>
            {
                ApprovedBy = group.Add(new VocabularyKey(nameof(ApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailLevel = group.Add(new VocabularyKey(nameof(DetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Document = group.Add(new VocabularyKey(nameof(Document), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryExchangeRate = group.Add(new VocabularyKey(nameof(SecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedRate = group.Add(new VocabularyKey(nameof(FixedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivateForUserGroup = group.Add(new VocabularyKey(nameof(PrivateForUserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountsIncludeSalesTax = group.Add(new VocabularyKey(nameof(AmountsIncludeSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinesLimit = group.Add(new VocabularyKey(nameof(LinesLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Log = group.Add(new VocabularyKey(nameof(Log), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimension = group.Add(new VocabularyKey(nameof(OffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterCompanyAccounting = group.Add(new VocabularyKey(nameof(InterCompanyAccounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalJournalNum = group.Add(new VocabularyKey(nameof(OriginalJournalNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedOn = group.Add(new VocabularyKey(nameof(PostedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RejectedBy = group.Add(new VocabularyKey(nameof(RejectedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedAsReadyBy = group.Add(new VocabularyKey(nameof(ReportedAsReadyBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockedBySystem = group.Add(new VocabularyKey(nameof(LockedBySystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityForIntercompanyTaxPosting = group.Add(new VocabularyKey(nameof(LegalEntityForIntercompanyTaxPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberAllocatedAtPosting = group.Add(new VocabularyKey(nameof(NumberAllocatedAtPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowApprovalStatus = group.Add(new VocabularyKey(nameof(WorkflowApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approver_FK_PersonnelNumber = group.Add(new VocabularyKey(nameof(Approver_FK_PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelayTaxCalculation = group.Add(new VocabularyKey(nameof(DelayTaxCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransAccountType = group.Add(new VocabularyKey(nameof(TransAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qty = group.Add(new VocabularyKey(nameof(Qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashCollBagNum_RU = group.Add(new VocabularyKey(nameof(CashCollBagNum_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashCollBankContributor_RU = group.Add(new VocabularyKey(nameof(CashCollBankContributor_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashCollCreditAccountNum_RU = group.Add(new VocabularyKey(nameof(CashCollCreditAccountNum_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashCollDebitAccountNum_RU = group.Add(new VocabularyKey(nameof(CashCollDebitAccountNum_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashCollStoreId_RU = group.Add(new VocabularyKey(nameof(CashCollStoreId_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDocId = group.Add(new VocabularyKey(nameof(CashDocId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashReceiptNumLV = group.Add(new VocabularyKey(nameof(CashReceiptNumLV), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashSourceCode_RU = group.Add(new VocabularyKey(nameof(CashSourceCode_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashSourceDescription_RU = group.Add(new VocabularyKey(nameof(CashSourceDescription_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocType = group.Add(new VocabularyKey(nameof(DocType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeExchAdj_PL = group.Add(new VocabularyKey(nameof(ExcludeExchAdj_PL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LvCashReceiptTable = group.Add(new VocabularyKey(nameof(LvCashReceiptTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualRounding_HU = group.Add(new VocabularyKey(nameof(ManualRounding_HU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOffCashAmount_HU = group.Add(new VocabularyKey(nameof(RoundOffCashAmount_HU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransRegDate_PL = group.Add(new VocabularyKey(nameof(TransRegDate_PL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RCashTransStatus = group.Add(new VocabularyKey(nameof(RCashTransStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRateSecondary = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApprovedBy { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey DetailLevel { get; private set; }
        public VocabularyKey Document { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SecondaryExchangeRate { get; private set; }
        public VocabularyKey FixedRate { get; private set; }
        public VocabularyKey PrivateForUserGroup { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey AmountsIncludeSalesTax { get; private set; }
        public VocabularyKey LinesLimit { get; private set; }
        public VocabularyKey Log { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey OffsetLedgerDimension { get; private set; }
        public VocabularyKey InterCompanyAccounting { get; private set; }
        public VocabularyKey OriginalJournalNum { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey PostedOn { get; private set; }
        public VocabularyKey RejectedBy { get; private set; }
        public VocabularyKey ReportedAsReadyBy { get; private set; }
        public VocabularyKey LockedBySystem { get; private set; }
        public VocabularyKey LegalEntityForIntercompanyTaxPosting { get; private set; }
        public VocabularyKey NumberAllocatedAtPosting { get; private set; }
        public VocabularyKey WorkflowApprovalStatus { get; private set; }
        public VocabularyKey Approver_FK_PersonnelNumber { get; private set; }
        public VocabularyKey OffsetLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DelayTaxCalculation { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey TransAccountType { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey Qty { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CashCollBagNum_RU { get; private set; }
        public VocabularyKey CashCollBankContributor_RU { get; private set; }
        public VocabularyKey CashCollCreditAccountNum_RU { get; private set; }
        public VocabularyKey CashCollDebitAccountNum_RU { get; private set; }
        public VocabularyKey CashCollStoreId_RU { get; private set; }
        public VocabularyKey CashDocId { get; private set; }
        public VocabularyKey CashReceiptNumLV { get; private set; }
        public VocabularyKey CashSourceCode_RU { get; private set; }
        public VocabularyKey CashSourceDescription_RU { get; private set; }
        public VocabularyKey DocType { get; private set; }
        public VocabularyKey ExcludeExchAdj_PL { get; private set; }
        public VocabularyKey LvCashReceiptTable { get; private set; }
        public VocabularyKey ManualRounding_HU { get; private set; }
        public VocabularyKey RoundOffCashAmount_HU { get; private set; }
        public VocabularyKey TransRegDate_PL { get; private set; }
        public VocabularyKey RCashTransStatus { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey ReportingCurrencyExchRateSecondary { get; private set; }


    }
}