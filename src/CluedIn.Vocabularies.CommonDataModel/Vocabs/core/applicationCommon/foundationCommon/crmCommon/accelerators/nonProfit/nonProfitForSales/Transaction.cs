using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class TransactionVocabulary : SimpleVocabulary
    {
        public TransactionVocabulary()
        {
            VocabularyName = "Transaction";
            KeyPrefix = "commonDataModel.transaction.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Transaction";

            AddGroup("Transaction Details for NonProfitForSales", group =>
            {
			    OriginalTxnAdjustedId = group.Add(new VocabularyKey(nameof(OriginalTxnAdjustedId), "Original Transaction Adjusted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OriginalTxnAdjustedId { get; private set; }
    }
}