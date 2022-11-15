using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseQuarantineZoneEntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseQuarantineZoneEntityVocabulary()
        {
            VocabularyName = "Invent Warehouse Quarantine Zone Entity";
            KeyPrefix = "commonDataModel.inventwarehousequarantinezoneentity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseQuarantineZoneEntity";

            AddGroup("InventWarehouseQuarantineZoneEntity Details", group =>
            {
                ZoneDescription = group.Add(new VocabularyKey(nameof(ZoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZoneId = group.Add(new VocabularyKey(nameof(ZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ZoneDescription { get; private set; }
        public VocabularyKey ZoneId { get; private set; }
    }
}