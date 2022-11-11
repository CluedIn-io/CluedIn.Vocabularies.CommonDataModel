using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankClientOutPaymentLogEntityVocabulary : SimpleVocabulary
    {
        public BankClientOutPaymentLogEntityVocabulary()
        {
            VocabularyName = "BankClientOutPaymentLogEntity";
            KeyPrefix = "commonDataModel.bankclientoutpaymentlogentity";
            KeySeparator = ".";
            Grouping = "/BankClientOutPaymentLogEntity";

            AddGroup("BankClientOutPaymentLogEntity Details", group =>
            {
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Counteragent = group.Add(new VocabularyKey(nameof(Counteragent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentType = group.Add(new VocabularyKey(nameof(DocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateAndTime = group.Add(new VocabularyKey(nameof(DateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderDate = group.Add(new VocabularyKey(nameof(OrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderNumber = group.Add(new VocabularyKey(nameof(OrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentOrderStatus = group.Add(new VocabularyKey(nameof(PaymentOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankCurrencyTransfer = group.Add(new VocabularyKey(nameof(BankCurrencyTransfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentOrderNumber = group.Add(new VocabularyKey(nameof(PaymentOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentOrderDate = group.Add(new VocabularyKey(nameof(PaymentOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Counteragent { get; private set; }
        public VocabularyKey DocumentType { get; private set; }
        public VocabularyKey DateAndTime { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey OrderDate { get; private set; }
        public VocabularyKey OrderNumber { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PaymentOrderStatus { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey BankCurrencyTransfer { get; private set; }
        public VocabularyKey PaymentOrderNumber { get; private set; }
        public VocabularyKey PaymentOrderDate { get; private set; }


    }
}