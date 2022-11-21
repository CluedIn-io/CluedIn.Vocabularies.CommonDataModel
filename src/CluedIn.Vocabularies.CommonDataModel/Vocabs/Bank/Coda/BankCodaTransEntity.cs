using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaTransEntityVocabulary : SimpleVocabulary
    {
        public BankCodaTransEntityVocabulary()
        {
            VocabularyName = "Bank Coda Trans Entity";
            KeyPrefix = "commonDataModel.bankcodatransentity";
            KeySeparator = ".";
            Grouping = "/BankCodaTransEntity";

            AddGroup("BankCodaTransEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction = group.Add(new VocabularyKey(nameof(Transaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionFamily = group.Add(new VocabularyKey(nameof(TransactionFamily), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Transaction { get; private set; }
        public VocabularyKey TransactionFamily { get; private set; }
    }
}