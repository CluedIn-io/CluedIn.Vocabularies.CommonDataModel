using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSupplementaryProductProductGroupEntityVocabulary : SimpleVocabulary
    {
        public InventSupplementaryProductProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventSupplementaryProductProductGroupEntity";
            KeyPrefix = "commonDataModel.inventsupplementaryproductproductgroupentity";
            KeySeparator = ".";
            Grouping = "/InventSupplementaryProductProductGroupEntity";

            AddGroup("Common Data Model InventSupplementaryProductProductGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}