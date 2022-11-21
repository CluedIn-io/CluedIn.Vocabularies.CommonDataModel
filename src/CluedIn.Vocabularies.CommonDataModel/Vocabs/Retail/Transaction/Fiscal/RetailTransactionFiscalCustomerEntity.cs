using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionFiscalCustomerEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionFiscalCustomerEntityVocabulary()
        {
            VocabularyName = "Retail Transaction Fiscal Customer Entity";
            KeyPrefix = "commonDataModel.retailtransactionfiscalcustomerentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionFiscalCustomerEntity";

            AddGroup("RetailTransactionFiscalCustomerEntity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Store = group.Add(new VocabularyKey(nameof(Store), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerializedData = group.Add(new VocabularyKey(nameof(SerializedData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplicationCounterFromOrigin = group.Add(new VocabularyKey(nameof(ReplicationCounterFromOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTable_OMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTable_OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnit_PartyNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnit_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey Store { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey SerializedData { get; private set; }
        public VocabularyKey ReplicationCounterFromOrigin { get; private set; }
        public VocabularyKey RetailChannelTable_OMOperatingUnitID { get; private set; }
        public VocabularyKey OMOperatingUnit_PartyNumber { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
    }
}