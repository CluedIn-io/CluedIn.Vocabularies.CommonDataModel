using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventChargeProductGroupEntityVocabulary : SimpleVocabulary
    {
        public InventChargeProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventChargeProductGroupEntity";
            KeyPrefix = "commonDataModel.inventchargeproductgroupentity";
            KeySeparator = ".";
            Grouping = "/InventChargeProductGroupEntity";

            AddGroup("Common Data Model InventChargeProductGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}