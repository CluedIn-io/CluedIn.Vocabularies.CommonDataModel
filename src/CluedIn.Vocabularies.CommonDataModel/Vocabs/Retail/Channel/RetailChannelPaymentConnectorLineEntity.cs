using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelPaymentConnectorLineEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelPaymentConnectorLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelPaymentConnectorLineEntity";
            KeyPrefix = "commonDataModel.retailchannelpaymentconnectorlineentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelPaymentConnectorLineEntity";

            AddGroup("Common Data Model RetailChannelPaymentConnectorLineEntity Details", group =>
            {
                OnlineChannel = group.Add(new VocabularyKey(nameof(OnlineChannel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentConnectorName = group.Add(new VocabularyKey(nameof(PaymentConnectorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentConnectorProperties = group.Add(new VocabularyKey(nameof(PaymentConnectorProperties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OnlineChannel { get; private set; }
        public VocabularyKey PaymentConnectorName { get; private set; }
        public VocabularyKey PaymentConnectorProperties { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}