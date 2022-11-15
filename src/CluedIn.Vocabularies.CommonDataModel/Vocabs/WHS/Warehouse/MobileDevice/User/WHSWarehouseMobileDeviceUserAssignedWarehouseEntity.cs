using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceUserAssignedWarehouseEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceUserAssignedWarehouseEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Mobile Device User Assigned Warehouse Entity";
            KeyPrefix = "commonDataModel.whswarehousemobiledeviceuserassignedwarehouseentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceUserAssignedWarehouseEntity";

            AddGroup("WHSWarehouseMobileDeviceUserAssignedWarehouseEntity Details", group =>
            {
                WarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WarehouseMobileDeviceUserId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
    }
}