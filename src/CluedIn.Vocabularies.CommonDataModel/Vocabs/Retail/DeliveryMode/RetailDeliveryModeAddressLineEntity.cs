using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDeliveryModeAddressLineEntityVocabulary : SimpleVocabulary
    {
        public RetailDeliveryModeAddressLineEntityVocabulary()
        {
            VocabularyName = "RetailDeliveryModeAddressLineEntity";
            KeyPrefix = "commonDataModel.retaildeliverymodeaddresslineentity";
            KeySeparator = ".";
            Grouping = "/RetailDeliveryModeAddressLineEntity";

            AddGroup("RetailDeliveryModeAddressLineEntity Details", group =>
            {
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryMode = group.Add(new VocabularyKey(nameof(DeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey DeliveryMode { get; private set; }


    }
}