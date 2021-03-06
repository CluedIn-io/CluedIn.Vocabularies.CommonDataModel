using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemWorkClassEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemWorkClassEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseMobileDeviceMenuItemWorkClassEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemworkclassentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemWorkClassEntity";

            AddGroup("Common Data Model WHSWarehouseMobileDeviceMenuItemWorkClassEntity Details", group =>
            {
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkClassId = group.Add(new VocabularyKey(nameof(WorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
public VocabularyKey WorkClassId { get; private set; }


    }
}