using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashStateTransEntityVocabulary : SimpleVocabulary
    {
        public CashStateTransEntityVocabulary()
        {
            VocabularyName = "Cash State Trans Entity";
            KeyPrefix = "commonDataModel.cashstatetransentity";
            KeySeparator = ".";
            Grouping = "/CashStateTransEntity";

            AddGroup("CashStateTransEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyRegistrationNumber = group.Add(new VocabularyKey(nameof(CompanyRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryCode = group.Add(new VocabularyKey(nameof(CountryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Include = group.Add(new VocabularyKey(nameof(Include), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTransactionCode = group.Add(new VocabularyKey(nameof(PaymentTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDirection = group.Add(new VocabularyKey(nameof(PaymentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CompanyRegistrationNumber { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey PaymentTransactionCode { get; private set; }
        public VocabularyKey PaymentDirection { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Voucher { get; private set; }
    }
}