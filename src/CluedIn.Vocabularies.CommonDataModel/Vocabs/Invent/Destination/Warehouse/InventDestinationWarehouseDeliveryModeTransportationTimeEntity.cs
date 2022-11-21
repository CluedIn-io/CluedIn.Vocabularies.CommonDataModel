using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventDestinationWarehouseDeliveryModeTransportationTimeEntityVocabulary : SimpleVocabulary
    {
        public InventDestinationWarehouseDeliveryModeTransportationTimeEntityVocabulary()
        {
            VocabularyName = "Invent Destination Warehouse Delivery Mode Transportation Time Entity";
            KeyPrefix = "commonDataModel.inventdestinationwarehousedeliverymodetransportationtimeentity";
            KeySeparator = ".";
            Grouping = "/InventDestinationWarehouseDeliveryModeTransportationTimeEntity";

            AddGroup("InventDestinationWarehouseDeliveryModeTransportationTimeEntity Details", group =>
            {
                DestinationWarehouseTransportationTimeOriginWarehouseId = group.Add(new VocabularyKey(nameof(DestinationWarehouseTransportationTimeOriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationWarehouseTransportationTimeDestinationWarehouseId = group.Add(new VocabularyKey(nameof(DestinationWarehouseTransportationTimeDestinationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDays = group.Add(new VocabularyKey(nameof(TransportationDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultDeliveryMode = group.Add(new VocabularyKey(nameof(IsDefaultDeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportPointLineRecId = group.Add(new VocabularyKey(nameof(TransportPointLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DestinationWarehouseTransportationTimeOriginWarehouseId { get; private set; }
        public VocabularyKey DestinationWarehouseTransportationTimeDestinationWarehouseId { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey TransportationDays { get; private set; }
        public VocabularyKey IsDefaultDeliveryMode { get; private set; }
        public VocabularyKey TransportPointLineRecId { get; private set; }
    }
}