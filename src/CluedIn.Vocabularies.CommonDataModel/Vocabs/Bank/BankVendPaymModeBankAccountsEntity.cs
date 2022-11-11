using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankVendPaymModeBankAccountsEntityVocabulary : SimpleVocabulary
    {
        public BankVendPaymModeBankAccountsEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankVendPaymModeBankAccountsEntity";
            KeyPrefix = "commonDataModel.bankvendpaymmodebankaccountsentity";
            KeySeparator = ".";
            Grouping = "/BankVendPaymModeBankAccountsEntity";

            AddGroup("Common Data Model BankVendPaymModeBankAccountsEntity Details", group =>
            {
                BankAccountID = group.Add(new VocabularyKey(nameof(BankAccountID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymMode = group.Add(new VocabularyKey(nameof(PaymMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountID { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey PaymMode { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}