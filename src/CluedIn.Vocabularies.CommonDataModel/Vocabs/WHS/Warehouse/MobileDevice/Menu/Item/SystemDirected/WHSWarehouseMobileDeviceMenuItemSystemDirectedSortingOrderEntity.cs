using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemSystemDirectedSortingOrderEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemSystemDirectedSortingOrderEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseMobileDeviceMenuItemSystemDirectedSortingOrderEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemsystemdirectedsortingorderentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemSystemDirectedSortingOrderEntity";

            AddGroup("WHSWarehouseMobileDeviceMenuItemSystemDirectedSortingOrderEntity Details", group =>
            {
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingFieldName = group.Add(new VocabularyKey(nameof(SortingFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingOrder = group.Add(new VocabularyKey(nameof(SortingOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey SortingFieldName { get; private set; }
        public VocabularyKey SortingOrder { get; private set; }


    }
}