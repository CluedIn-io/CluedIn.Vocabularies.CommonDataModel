using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseAppFieldGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseAppFieldGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseAppFieldGroupEntity";
            KeyPrefix = "commonDataModel.whswarehouseappfieldgroupentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseAppFieldGroupEntity";

            AddGroup("Common Data Model WHSWarehouseAppFieldGroupEntity Details", group =>
            {
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Priority { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}