using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuStructureEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuStructureEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseMobileDeviceMenuStructureEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenustructureentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuStructureEntity";

            AddGroup("Common Data Model WHSWarehouseMobileDeviceMenuStructureEntity Details", group =>
            {
                ParentWarehouseMobileDeviceMenuName = group.Add(new VocabularyKey(nameof(ParentWarehouseMobileDeviceMenuName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseMobileDeviceMenuName = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseMobileDeviceMenuItemName = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ParentWarehouseMobileDeviceMenuName { get; private set; }
public VocabularyKey WarehouseMobileDeviceMenuName { get; private set; }
public VocabularyKey WarehouseMobileDeviceMenuItemName { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }


    }
}