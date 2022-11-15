using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventDestinationWarehouseTransportationTimeEntityVocabulary : SimpleVocabulary
    {
        public InventDestinationWarehouseTransportationTimeEntityVocabulary()
        {
            VocabularyName = "Invent Destination Warehouse Transportation Time Entity";
            KeyPrefix = "commonDataModel.inventdestinationwarehousetransportationtimeentity";
            KeySeparator = ".";
            Grouping = "/InventDestinationWarehouseTransportationTimeEntity";

            AddGroup("InventDestinationWarehouseTransportationTimeEntity Details", group =>
            {
                OriginWarehouseId = group.Add(new VocabularyKey(nameof(OriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationWarehouseId = group.Add(new VocabularyKey(nameof(DestinationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTransportationDays = group.Add(new VocabularyKey(nameof(DefaultTransportationDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OriginWarehouseId { get; private set; }
        public VocabularyKey DestinationWarehouseId { get; private set; }
        public VocabularyKey DefaultTransportationDays { get; private set; }
    }
}