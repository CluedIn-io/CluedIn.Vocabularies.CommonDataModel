using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventDestinationAddressDeliveryModeTransportationTimeEntityVocabulary : SimpleVocabulary
    {
        public InventDestinationAddressDeliveryModeTransportationTimeEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventDestinationAddressDeliveryModeTransportationTimeEntity";
            KeyPrefix = "commonDataModel.inventdestinationaddressdeliverymodetransportationtimeentity";
            KeySeparator = ".";
            Grouping = "/InventDestinationAddressDeliveryModeTransportationTimeEntity";

            AddGroup("Common Data Model InventDestinationAddressDeliveryModeTransportationTimeEntity Details", group =>
            {
                DestinationAddressTransportationTimeOriginWarehouseId = group.Add(new VocabularyKey(nameof(DestinationAddressTransportationTimeOriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationAddressTransportationTimeDestinationAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationAddressTransportationTimeDestinationAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationAddressTransportationTimeDestinationAddressStateId = group.Add(new VocabularyKey(nameof(DestinationAddressTransportationTimeDestinationAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationAddressTransportationTimeDestinationAddressCountyId = group.Add(new VocabularyKey(nameof(DestinationAddressTransportationTimeDestinationAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationAddressTransportationTimeDestinationAddressZipCode = group.Add(new VocabularyKey(nameof(DestinationAddressTransportationTimeDestinationAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationDays = group.Add(new VocabularyKey(nameof(TransportationDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultDeliveryMode = group.Add(new VocabularyKey(nameof(IsDefaultDeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportPointLineRecId = group.Add(new VocabularyKey(nameof(TransportPointLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DestinationAddressTransportationTimeOriginWarehouseId { get; private set; }
public VocabularyKey DestinationAddressTransportationTimeDestinationAddressCountryRegionId { get; private set; }
public VocabularyKey DestinationAddressTransportationTimeDestinationAddressStateId { get; private set; }
public VocabularyKey DestinationAddressTransportationTimeDestinationAddressCountyId { get; private set; }
public VocabularyKey DestinationAddressTransportationTimeDestinationAddressZipCode { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey TransportationDays { get; private set; }
public VocabularyKey IsDefaultDeliveryMode { get; private set; }
public VocabularyKey TransportPointLineRecId { get; private set; }


    }
}