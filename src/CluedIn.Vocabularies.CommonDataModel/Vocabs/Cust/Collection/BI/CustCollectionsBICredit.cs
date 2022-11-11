using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICreditVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICreditVocabulary()
        {
            VocabularyName = "CustCollectionsBICredit";
            KeyPrefix = "commonDataModel.custcollectionsbicredit";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICredit";

            AddGroup("CustCollectionsBICredit Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyAmount = group.Add(new VocabularyKey(nameof(SystemCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditRemaining = group.Add(new VocabularyKey(nameof(CreditRemaining), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOverCreditLimit = group.Add(new VocabularyKey(nameof(AmountOverCreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyCreditMax = group.Add(new VocabularyKey(nameof(SystemCurrencyCreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey CreditRating { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SystemCurrencyAmount { get; private set; }
        public VocabularyKey CreditRemaining { get; private set; }
        public VocabularyKey AmountOverCreditLimit { get; private set; }
        public VocabularyKey SystemCurrencyCreditMax { get; private set; }


    }
}