using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankTransactionTypeEntityVocabulary : SimpleVocabulary
    {
        public BankTransactionTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankTransactionTypeEntity";
            KeyPrefix = "commonDataModel.banktransactiontypeentity";
            KeySeparator = ".";
            Grouping = "/BankTransactionTypeEntity";

            AddGroup("Common Data Model BankTransactionTypeEntity Details", group =>
            {
                TransactionTypeId = group.Add(new VocabularyKey(nameof(TransactionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransactionTypeId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }


    }
}