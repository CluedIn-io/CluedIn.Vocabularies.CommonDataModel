using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventChargeProductGroupEntityVocabulary : SimpleVocabulary
    {
        public InventChargeProductGroupEntityVocabulary()
        {
            VocabularyName = "Invent Charge Product Group Entity";
            KeyPrefix = "commonDataModel.inventchargeproductgroupentity";
            KeySeparator = ".";
            Grouping = "/InventChargeProductGroupEntity";

            AddGroup("InventChargeProductGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}