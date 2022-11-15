using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialGroupEntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialGroupEntityVocabulary()
        {
            VocabularyName = "Invent Packing Material Group Entity";
            KeyPrefix = "commonDataModel.inventpackingmaterialgroupentity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialGroupEntity";

            AddGroup("InventPackingMaterialGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}