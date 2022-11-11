using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionSafeTenderTransEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionSafeTenderTransEntityVocabulary()
        {
            VocabularyName = "RetailTransactionSafeTenderTransEntity";
            KeyPrefix = "commonDataModel.retailtransactionsafetendertransentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionSafeTenderTransEntity";

            AddGroup("RetailTransactionSafeTenderTransEntity Details", group =>
            {
                AmountCurrency = group.Add(new VocabularyKey(nameof(AmountCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCurrencyPOS = group.Add(new VocabularyKey(nameof(AmountCurrencyPOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMSTPOS = group.Add(new VocabularyKey(nameof(AmountMSTPOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountTendered = group.Add(new VocabularyKey(nameof(AmountTendered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountTenderedPOS = group.Add(new VocabularyKey(nameof(AmountTenderedPOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessDate = group.Add(new VocabularyKey(nameof(BusinessDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardOrAccount = group.Add(new VocabularyKey(nameof(CardOrAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypeId = group.Add(new VocabularyKey(nameof(CardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeLine = group.Add(new VocabularyKey(nameof(ChangeLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Counter = group.Add(new VocabularyKey(nameof(Counter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateMST = group.Add(new VocabularyKey(nameof(ExchangeRateMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManagersKeyLive = group.Add(new VocabularyKey(nameof(ManagersKeyLive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageNumber = group.Add(new VocabularyKey(nameof(MessageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Replicated = group.Add(new VocabularyKey(nameof(Replicated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Shift = group.Add(new VocabularyKey(nameof(Shift), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftDate = group.Add(new VocabularyKey(nameof(ShiftDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Staff = group.Add(new VocabularyKey(nameof(Staff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementCode = group.Add(new VocabularyKey(nameof(StatementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementId = group.Add(new VocabularyKey(nameof(StatementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SafeStatusType = group.Add(new VocabularyKey(nameof(SafeStatusType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderType = group.Add(new VocabularyKey(nameof(TenderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionStatus = group.Add(new VocabularyKey(nameof(TransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTime = group.Add(new VocabularyKey(nameof(TransactionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountCurrency { get; private set; }
        public VocabularyKey AmountCurrencyPOS { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey AmountMSTPOS { get; private set; }
        public VocabularyKey AmountTendered { get; private set; }
        public VocabularyKey AmountTenderedPOS { get; private set; }
        public VocabularyKey BusinessDate { get; private set; }
        public VocabularyKey CardOrAccount { get; private set; }
        public VocabularyKey CardTypeId { get; private set; }
        public VocabularyKey ChangeLine { get; private set; }
        public VocabularyKey Counter { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExchangeRateMST { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ManagersKeyLive { get; private set; }
        public VocabularyKey MessageNumber { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Replicated { get; private set; }
        public VocabularyKey Shift { get; private set; }
        public VocabularyKey ShiftDate { get; private set; }
        public VocabularyKey Staff { get; private set; }
        public VocabularyKey StatementCode { get; private set; }
        public VocabularyKey StatementId { get; private set; }
        public VocabularyKey SafeStatusType { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }
        public VocabularyKey TenderType { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey TransactionStatus { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey TransactionTime { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }


    }
}