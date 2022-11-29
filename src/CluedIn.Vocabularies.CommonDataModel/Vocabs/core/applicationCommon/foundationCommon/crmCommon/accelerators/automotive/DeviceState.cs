using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceStateVocabulary : SimpleVocabulary
    {
        public DeviceStateVocabulary()
        {
            VocabularyName = "Device State";
            KeyPrefix = "commonDataModel.devicestate.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceState";

            AddGroup("DeviceState Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceStateId = group.Add(new VocabularyKey(nameof(DeviceStateId), "Device State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InventoryStatus = group.Add(new VocabularyKey(nameof(InventoryStatus), "Inventory Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnershipStatus = group.Add(new VocabularyKey(nameof(OwnershipStatus), "Ownership Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnershipType = group.Add(new VocabularyKey(nameof(OwnershipType), "Ownership Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TradeStatus = group.Add(new VocabularyKey(nameof(TradeStatus), "Trade Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceStateId { get; private set; }
        public VocabularyKey InventoryStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnershipStatus { get; private set; }
        public VocabularyKey OwnershipType { get; private set; }
        public VocabularyKey TradeStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}