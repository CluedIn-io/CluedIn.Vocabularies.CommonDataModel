using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaTransactionGroupExportEntityVocabulary : SimpleVocabulary
    {
        public BankCodaTransactionGroupExportEntityVocabulary()
        {
            VocabularyName = "BankCodaTransactionGroupExportEntity";
            KeyPrefix = "commonDataModel.bankcodatransactiongroupexportentity";
            KeySeparator = ".";
            Grouping = "/BankCodaTransactionGroupExportEntity";

            AddGroup("BankCodaTransactionGroupExportEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionGroup = group.Add(new VocabularyKey(nameof(TransactionGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey TransactionGroup { get; private set; }


    }
}