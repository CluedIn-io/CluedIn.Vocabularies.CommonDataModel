using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialGroupEntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventPackingMaterialGroupEntity";
            KeyPrefix = "commonDataModel.inventpackingmaterialgroupentity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialGroupEntity";

            AddGroup("Common Data Model InventPackingMaterialGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupName { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}