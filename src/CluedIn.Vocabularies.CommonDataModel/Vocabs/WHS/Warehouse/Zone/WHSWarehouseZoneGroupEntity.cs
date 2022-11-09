using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseZoneGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseZoneGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseZoneGroupEntity";
            KeyPrefix = "commonDataModel.whswarehousezonegroupentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseZoneGroupEntity";

            AddGroup("Common Data Model WHSWarehouseZoneGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}