using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetConsumptionUnitEntityVocabulary : SimpleVocabulary
    {
        public AssetConsumptionUnitEntityVocabulary()
        {
            VocabularyName = "AssetConsumptionUnitEntity";
            KeyPrefix = "commonDataModel.assetconsumptionunitentity";
            KeySeparator = ".";
            Grouping = "/AssetConsumptionUnitEntity";

            AddGroup("AssetConsumptionUnitEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitId = group.Add(new VocabularyKey(nameof(UnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey UnitId { get; private set; }


    }
}