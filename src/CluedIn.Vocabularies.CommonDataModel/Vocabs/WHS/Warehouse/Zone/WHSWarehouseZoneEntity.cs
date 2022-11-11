using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseZoneEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseZoneEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseZoneEntity";
            KeyPrefix = "commonDataModel.whswarehousezoneentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseZoneEntity";

            AddGroup("WHSWarehouseZoneEntity Details", group =>
            {
                WarehouseZoneGroupId = group.Add(new VocabularyKey(nameof(WarehouseZoneGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZoneId = group.Add(new VocabularyKey(nameof(ZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZoneName = group.Add(new VocabularyKey(nameof(ZoneName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseZoneGroupId { get; private set; }
        public VocabularyKey ZoneId { get; private set; }
        public VocabularyKey ZoneName { get; private set; }


    }
}