using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerInterCompanyAccountEntityVocabulary : SimpleVocabulary
    {
        public LedgerInterCompanyAccountEntityVocabulary()
        {
            VocabularyName = "LedgerInterCompanyAccountEntity";
            KeyPrefix = "commonDataModel.ledgerintercompanyaccountentity";
            KeySeparator = ".";
            Grouping = "/LedgerInterCompanyAccountEntity";

            AddGroup("LedgerInterCompanyAccountEntity Details", group =>
            {
                OriginatingLegalEntityId = group.Add(new VocabularyKey(nameof(OriginatingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationLegalEntityId = group.Add(new VocabularyKey(nameof(DestinationLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCashDiscount = group.Add(new VocabularyKey(nameof(PostCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCurrencyExchangeGainOrLoss = group.Add(new VocabularyKey(nameof(PostCurrencyExchangeGainOrLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostFine = group.Add(new VocabularyKey(nameof(PostFine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostInterest = group.Add(new VocabularyKey(nameof(PostInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Journal = group.Add(new VocabularyKey(nameof(Journal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingCreditAccount = group.Add(new VocabularyKey(nameof(OriginatingCreditAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingDebitAccount = group.Add(new VocabularyKey(nameof(OriginatingDebitAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingCreditAccountDisplayValue = group.Add(new VocabularyKey(nameof(OriginatingCreditAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatingDebitAccountDisplayValue = group.Add(new VocabularyKey(nameof(OriginatingDebitAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCreditAccount = group.Add(new VocabularyKey(nameof(DestinationCreditAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationDebitAccount = group.Add(new VocabularyKey(nameof(DestinationDebitAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCreditAccountDisplayValue = group.Add(new VocabularyKey(nameof(DestinationCreditAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationDebitAccountDisplayValue = group.Add(new VocabularyKey(nameof(DestinationDebitAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentPostFine = group.Add(new VocabularyKey(nameof(VendorPaymentPostFine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentPostFinancialInterest = group.Add(new VocabularyKey(nameof(VendorPaymentPostFinancialInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OriginatingLegalEntityId { get; private set; }
        public VocabularyKey DestinationLegalEntityId { get; private set; }
        public VocabularyKey PostCashDiscount { get; private set; }
        public VocabularyKey PostCurrencyExchangeGainOrLoss { get; private set; }
        public VocabularyKey PostFine { get; private set; }
        public VocabularyKey PostInterest { get; private set; }
        public VocabularyKey Journal { get; private set; }
        public VocabularyKey OriginatingCreditAccount { get; private set; }
        public VocabularyKey OriginatingDebitAccount { get; private set; }
        public VocabularyKey OriginatingCreditAccountDisplayValue { get; private set; }
        public VocabularyKey OriginatingDebitAccountDisplayValue { get; private set; }
        public VocabularyKey DestinationCreditAccount { get; private set; }
        public VocabularyKey DestinationDebitAccount { get; private set; }
        public VocabularyKey DestinationCreditAccountDisplayValue { get; private set; }
        public VocabularyKey DestinationDebitAccountDisplayValue { get; private set; }
        public VocabularyKey VendorPaymentPostFine { get; private set; }
        public VocabularyKey VendorPaymentPostFinancialInterest { get; private set; }


    }
}