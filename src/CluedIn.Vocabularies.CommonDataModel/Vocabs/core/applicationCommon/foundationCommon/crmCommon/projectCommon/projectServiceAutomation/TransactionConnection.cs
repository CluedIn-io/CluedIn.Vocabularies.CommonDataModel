using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class TransactionConnectionVocabulary : SimpleVocabulary
    {
        public TransactionConnectionVocabulary()
        {
            VocabularyName = "Transaction Connection";
            KeyPrefix = "commonDataModel.transactionconnection.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/TransactionConnection";

            AddGroup("TransactionConnection Details for ProjectServiceAutomation", group =>
            {
			    TransactionConnectionId = group.Add(new VocabularyKey(nameof(TransactionConnectionId), "Transaction Connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction1 = group.Add(new VocabularyKey(nameof(Transaction1), "Transaction 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction1Role = group.Add(new VocabularyKey(nameof(Transaction1Role), "Transaction 1 Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction1Type = group.Add(new VocabularyKey(nameof(Transaction1Type), "Transaction 1 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction2 = group.Add(new VocabularyKey(nameof(Transaction2), "Transaction 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction2Role = group.Add(new VocabularyKey(nameof(Transaction2Role), "Transaction 2 Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Transaction2Type = group.Add(new VocabularyKey(nameof(Transaction2Type), "Transaction 2 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TransactionConnectionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Transaction1 { get; private set; }
        public VocabularyKey Transaction1Role { get; private set; }
        public VocabularyKey Transaction1Type { get; private set; }
        public VocabularyKey Transaction2 { get; private set; }
        public VocabularyKey Transaction2Role { get; private set; }
        public VocabularyKey Transaction2Type { get; private set; }
    }
}