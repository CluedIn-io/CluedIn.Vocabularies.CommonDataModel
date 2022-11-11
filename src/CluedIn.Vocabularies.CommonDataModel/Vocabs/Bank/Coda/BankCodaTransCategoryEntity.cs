using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaTransCategoryEntityVocabulary : SimpleVocabulary
    {
        public BankCodaTransCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCodaTransCategoryEntity";
            KeyPrefix = "commonDataModel.bankcodatranscategoryentity";
            KeySeparator = ".";
            Grouping = "/BankCodaTransCategoryEntity";

            AddGroup("Common Data Model BankCodaTransCategoryEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction = group.Add(new VocabularyKey(nameof(Transaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionFamily = group.Add(new VocabularyKey(nameof(TransactionFamily), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Transaction { get; private set; }
        public VocabularyKey TransactionCategory { get; private set; }
        public VocabularyKey TransactionFamily { get; private set; }


    }
}