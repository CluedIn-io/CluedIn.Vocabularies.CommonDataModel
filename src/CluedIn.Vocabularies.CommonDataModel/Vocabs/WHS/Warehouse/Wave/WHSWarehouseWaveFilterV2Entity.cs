using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveFilterV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveFilterV2EntityVocabulary()
        {
            VocabularyName = "WHSWarehouseWaveFilterV2Entity";
            KeyPrefix = "commonDataModel.whswarehousewavefilterv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveFilterV2Entity";

            AddGroup("WHSWarehouseWaveFilterV2Entity Details", group =>
            {
                WarehouseWaveFilterDescription = group.Add(new VocabularyKey(nameof(WarehouseWaveFilterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWaveFilterCode = group.Add(new VocabularyKey(nameof(WarehouseWaveFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWaveFilterQuery = group.Add(new VocabularyKey(nameof(WarehouseWaveFilterQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseWaveFilterDescription { get; private set; }
        public VocabularyKey WarehouseWaveFilterCode { get; private set; }
        public VocabularyKey WarehouseWaveFilterQuery { get; private set; }


    }
}