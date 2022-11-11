using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaTransactionGroupEntityVocabulary : SimpleVocabulary
    {
        public BankCodaTransactionGroupEntityVocabulary()
        {
            VocabularyName = "BankCodaTransactionGroupEntity";
            KeyPrefix = "commonDataModel.bankcodatransactiongroupentity";
            KeySeparator = ".";
            Grouping = "/BankCodaTransactionGroupEntity";

            AddGroup("BankCodaTransactionGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction = group.Add(new VocabularyKey(nameof(Transaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDescription = group.Add(new VocabularyKey(nameof(TransactionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Transaction { get; private set; }
        public VocabularyKey TransactionDescription { get; private set; }
        public VocabularyKey TransactionCategory { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }


    }
}