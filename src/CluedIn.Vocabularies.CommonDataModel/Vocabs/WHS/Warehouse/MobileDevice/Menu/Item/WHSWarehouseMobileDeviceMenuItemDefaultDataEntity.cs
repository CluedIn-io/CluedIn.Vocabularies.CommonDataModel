using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemDefaultDataEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemDefaultDataEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Mobile Device Menu Item Default Data Entity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemdefaultdataentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemDefaultDataEntity";

            AddGroup("WHSWarehouseMobileDeviceMenuItemDefaultDataEntity Details", group =>
            {
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDataField = group.Add(new VocabularyKey(nameof(DefaultDataField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDataFieldValue = group.Add(new VocabularyKey(nameof(DefaultDataFieldValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
        public VocabularyKey DefaultDataField { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey DefaultDataFieldValue { get; private set; }
    }
}