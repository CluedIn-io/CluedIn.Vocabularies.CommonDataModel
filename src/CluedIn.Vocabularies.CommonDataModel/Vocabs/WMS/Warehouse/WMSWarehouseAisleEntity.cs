using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSWarehouseAisleEntityVocabulary : SimpleVocabulary
    {
        public WMSWarehouseAisleEntityVocabulary()
        {
            VocabularyName = "Common Data Model WMSWarehouseAisleEntity";
            KeyPrefix = "commonDataModel.wmswarehouseaisleentity";
            KeySeparator = ".";
            Grouping = "/WMSWarehouseAisleEntity";

            AddGroup("Common Data Model WMSWarehouseAisleEntity Details", group =>
            {
                AisleId = group.Add(new VocabularyKey(nameof(AisleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AisleNumber = group.Add(new VocabularyKey(nameof(AisleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AisleName = group.Add(new VocabularyKey(nameof(AisleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualStartingSortOrderCode = group.Add(new VocabularyKey(nameof(ManualStartingSortOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSortOrderCodeAssignedDescending = group.Add(new VocabularyKey(nameof(IsSortOrderCodeAssignedDescending), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AisleId { get; private set; }
        public VocabularyKey AisleNumber { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey AisleName { get; private set; }
        public VocabularyKey ManualStartingSortOrderCode { get; private set; }
        public VocabularyKey IsSortOrderCodeAssignedDescending { get; private set; }


    }
}