using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkerEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkerEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Worker Entity";
            KeyPrefix = "commonDataModel.whswarehouseworkerentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkerEntity";

            AddGroup("WHSWarehouseWorkerEntity Details", group =>
            {
                DefaultContainerClosingProfileId = group.Add(new VocabularyKey(nameof(DefaultContainerClosingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultContainerPackingProfileId = group.Add(new VocabularyKey(nameof(DefaultContainerPackingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WarehouseWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerId = group.Add(new VocabularyKey(nameof(WorkerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPackingStationWarehouseId = group.Add(new VocabularyKey(nameof(DefaultPackingStationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPackingStationWarehouseLocationId = group.Add(new VocabularyKey(nameof(DefaultPackingStationWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPackingStationWarehouseSiteId = group.Add(new VocabularyKey(nameof(DefaultPackingStationWarehouseSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultContainerClosingProfileId { get; private set; }
        public VocabularyKey DefaultContainerPackingProfileId { get; private set; }
        public VocabularyKey WarehouseWorkerPersonnelNumber { get; private set; }
        public VocabularyKey WorkerId { get; private set; }
        public VocabularyKey DefaultPackingStationWarehouseId { get; private set; }
        public VocabularyKey DefaultPackingStationWarehouseLocationId { get; private set; }
        public VocabularyKey DefaultPackingStationWarehouseSiteId { get; private set; }
    }
}