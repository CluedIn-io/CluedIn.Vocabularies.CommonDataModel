using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class TransactionOriginVocabulary : SimpleVocabulary
    {
        public TransactionOriginVocabulary()
        {
            VocabularyName = "Transaction Origin";
            KeyPrefix = "commonDataModel.transactionorigin.scheduling";
            KeySeparator = ".";
            Grouping = "/TransactionOrigin";

            AddGroup("TransactionOrigin Details for Scheduling", group =>
            {
			    TransactionOriginId = group.Add(new VocabularyKey(nameof(TransactionOriginId), "Transaction Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Origin = group.Add(new VocabularyKey(nameof(Origin), "Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OriginType = group.Add(new VocabularyKey(nameof(OriginType), "Origin Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction = group.Add(new VocabularyKey(nameof(Transaction), "Transaction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TransactionOriginId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Origin { get; private set; }
        public VocabularyKey OriginType { get; private set; }
        public VocabularyKey Transaction { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
    }
}