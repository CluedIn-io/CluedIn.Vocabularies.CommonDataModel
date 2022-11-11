using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankPaymentIdEntityVocabulary : SimpleVocabulary
    {
        public BankPaymentIdEntityVocabulary()
        {
            VocabularyName = "BankPaymentIdEntity";
            KeyPrefix = "commonDataModel.bankpaymentidentity";
            KeySeparator = ".";
            Grouping = "/BankPaymentIdEntity";

            AddGroup("BankPaymentIdEntity Details", group =>
            {
                AccountFromPosition = group.Add(new VocabularyKey(nameof(AccountFromPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountToPosition = group.Add(new VocabularyKey(nameof(AccountToPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlankPaymentID = group.Add(new VocabularyKey(nameof(BlankPaymentID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalReferenceFromPosition = group.Add(new VocabularyKey(nameof(ExternalReferenceFromPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalReferenceToPosition = group.Add(new VocabularyKey(nameof(ExternalReferenceToPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceFromPosition = group.Add(new VocabularyKey(nameof(InvoiceFromPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceToPosition = group.Add(new VocabularyKey(nameof(InvoiceToPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentIDLength = group.Add(new VocabularyKey(nameof(PaymentIDLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Modulo = group.Add(new VocabularyKey(nameof(Modulo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentIDType = group.Add(new VocabularyKey(nameof(PaymentIDType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrefixFromPosition = group.Add(new VocabularyKey(nameof(PrefixFromPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrefixTextValue = group.Add(new VocabularyKey(nameof(PrefixTextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrefixToPosition = group.Add(new VocabularyKey(nameof(PrefixToPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrefixValue = group.Add(new VocabularyKey(nameof(PrefixValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuffixFromPosition = group.Add(new VocabularyKey(nameof(SuffixFromPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuffixTextValue = group.Add(new VocabularyKey(nameof(SuffixTextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuffixToPosition = group.Add(new VocabularyKey(nameof(SuffixToPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuffixValue = group.Add(new VocabularyKey(nameof(SuffixValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountFromPosition { get; private set; }
        public VocabularyKey AccountToPosition { get; private set; }
        public VocabularyKey BlankPaymentID { get; private set; }
        public VocabularyKey ExternalReferenceFromPosition { get; private set; }
        public VocabularyKey ExternalReferenceToPosition { get; private set; }
        public VocabularyKey InvoiceFromPosition { get; private set; }
        public VocabularyKey InvoiceToPosition { get; private set; }
        public VocabularyKey PaymentIDLength { get; private set; }
        public VocabularyKey Modulo { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentIDType { get; private set; }
        public VocabularyKey PrefixFromPosition { get; private set; }
        public VocabularyKey PrefixTextValue { get; private set; }
        public VocabularyKey PrefixToPosition { get; private set; }
        public VocabularyKey PrefixValue { get; private set; }
        public VocabularyKey SuffixFromPosition { get; private set; }
        public VocabularyKey SuffixTextValue { get; private set; }
        public VocabularyKey SuffixToPosition { get; private set; }
        public VocabularyKey SuffixValue { get; private set; }


    }
}