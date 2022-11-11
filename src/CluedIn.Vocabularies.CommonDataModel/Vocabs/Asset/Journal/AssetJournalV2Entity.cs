using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetJournalV2EntityVocabulary : SimpleVocabulary
    {
        public AssetJournalV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetJournalV2Entity";
            KeyPrefix = "commonDataModel.assetjournalv2entity";
            KeySeparator = ".";
            Grouping = "/AssetJournalV2Entity";

            AddGroup("Common Data Model AssetJournalV2Entity Details", group =>
            {
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionUnits = group.Add(new VocabularyKey(nameof(ConsumptionUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateSecondary = group.Add(new VocabularyKey(nameof(ExchangeRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmountReportingCurrency = group.Add(new VocabularyKey(nameof(CreditAmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmountReportingCurrency = group.Add(new VocabularyKey(nameof(DebitAmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRateSecondary = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRateSecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BookId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey ConsumptionUnits { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExchangeRateSecondary { get; private set; }
        public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
        public VocabularyKey ChineseVoucherType { get; private set; }
        public VocabularyKey ChineseVoucher { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey CreditAmountReportingCurrency { get; private set; }
        public VocabularyKey DebitAmountReportingCurrency { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey ReportingCurrencyExchRateSecondary { get; private set; }


    }
}