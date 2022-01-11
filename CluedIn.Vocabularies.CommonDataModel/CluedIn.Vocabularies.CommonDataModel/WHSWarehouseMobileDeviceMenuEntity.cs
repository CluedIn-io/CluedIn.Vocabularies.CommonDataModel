using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseMobileDeviceMenuEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuEntity";

            AddGroup("Common Data Model WHSWarehouseMobileDeviceMenuEntity Details", group =>
            {
                MenuName = group.Add(new VocabularyKey(nameof(MenuName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MenuDescription = group.Add(new VocabularyKey(nameof(MenuDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MenuName { get; private set; }
public VocabularyKey MenuDescription { get; private set; }


    }
}