using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventDestinationAddressTransportationTimeEntityVocabulary : SimpleVocabulary
    {
        public InventDestinationAddressTransportationTimeEntityVocabulary()
        {
            VocabularyName = "InventDestinationAddressTransportationTimeEntity";
            KeyPrefix = "commonDataModel.inventdestinationaddresstransportationtimeentity";
            KeySeparator = ".";
            Grouping = "/InventDestinationAddressTransportationTimeEntity";

            AddGroup("InventDestinationAddressTransportationTimeEntity Details", group =>
            {
                OriginWarehouseId = group.Add(new VocabularyKey(nameof(OriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressStateId = group.Add(new VocabularyKey(nameof(DestinationAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressCountyId = group.Add(new VocabularyKey(nameof(DestinationAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressCity = group.Add(new VocabularyKey(nameof(DestinationAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressZipCode = group.Add(new VocabularyKey(nameof(DestinationAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTransportationDays = group.Add(new VocabularyKey(nameof(DefaultTransportationDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OriginWarehouseId { get; private set; }
        public VocabularyKey DestinationAddressCountryRegionId { get; private set; }
        public VocabularyKey DestinationAddressStateId { get; private set; }
        public VocabularyKey DestinationAddressCountyId { get; private set; }
        public VocabularyKey DestinationAddressCity { get; private set; }
        public VocabularyKey DestinationAddressZipCode { get; private set; }
        public VocabularyKey DefaultTransportationDays { get; private set; }


    }
}