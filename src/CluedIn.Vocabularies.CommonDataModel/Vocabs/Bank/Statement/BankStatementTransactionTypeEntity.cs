using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementTransactionTypeEntityVocabulary : SimpleVocabulary
    {
        public BankStatementTransactionTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankStatementTransactionTypeEntity";
            KeyPrefix = "commonDataModel.bankstatementtransactiontypeentity";
            KeySeparator = ".";
            Grouping = "/BankStatementTransactionTypeEntity";

            AddGroup("Common Data Model BankStatementTransactionTypeEntity Details", group =>
            {
                BankAccountID = group.Add(new VocabularyKey(nameof(BankAccountID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransType = group.Add(new VocabularyKey(nameof(BankTransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementTransactionCode = group.Add(new VocabularyKey(nameof(StatementTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountID { get; private set; }
        public VocabularyKey BankTransType { get; private set; }
        public VocabularyKey StatementTransactionCode { get; private set; }


    }
}